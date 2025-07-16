# responder.py
# -*- coding: utf-8 -*-

import os
import time
import json
import re
import unicodedata
from datetime import datetime
from dotenv import load_dotenv
import streamlit as st

from langchain_community.embeddings import HuggingFaceEmbeddings
from langchain_community.vectorstores import FAISS
from langchain_openai import ChatOpenAI
from langchain.chains import RetrievalQA
from langchain.prompts import PromptTemplate
from langchain.schema import SystemMessage, HumanMessage
from langchain.docstore.document import Document as LC_Document

from load_docs import carregar_documentos, dividir_documentos, load_env_vars_index

# Carrega variáveis de ambiente do .env
load_dotenv()

ia = None  # Cache global da IA


def criar_ia_resposta(reprocessar=False):
    global ia
    caminho_index = "faiss_index"
    embeddings = HuggingFaceEmbeddings(model_name="sentence-transformers/all-MiniLM-L6-v2")

    # Carrega índice salvo ou reprocessa manuais/FAQs
    if not reprocessar and os.path.exists(caminho_index):
        vetorstore = FAISS.load_local(
            caminho_index, embeddings, allow_dangerous_deserialization=True
        )
    else:
        documentos = carregar_documentos(["base_conhecimento/manuais"])
        # Carrega FAQs JSON
        faq_path = "base_conhecimento/faqs.json"
        if os.path.exists(faq_path):
            with open(faq_path, encoding="latin-1") as f:
                faqs = json.load(f)
            for faq in faqs:
                conteudo = (
                    f"Pergunta: {faq.get('pergunta','')}\n"
                    f"Causa: {faq.get('causa','')}\n"
                    f"Solução: {faq.get('solucao','')}"
                )
                documentos.append(
                    LC_Document(
                        page_content=conteudo,
                        metadata={"source": "faq", "id": str(faq.get("id", ""))}
                    )
                )
        # Fragmenta e salva o índice
        fragmentos = dividir_documentos(documentos)
        vetorstore = FAISS.from_documents(fragmentos, embeddings)
        vetorstore.save_local(caminho_index)

    # Configura LLM e pipeline QA
    llm = ChatOpenAI(model_name="gpt-4", temperature=0.1, max_tokens=500)
    prompt = PromptTemplate(
        input_variables=["context", "question"],
        template="""
Você é um assistente técnico da Narwal Sistemas.
Use o contexto abaixo para responder de forma clara e objetiva.

{context}

Dúvida/Erro:
{question}
"""
    )
    chain = RetrievalQA.from_chain_type(
        llm=llm,
        retriever=vetorstore.as_retriever(search_type="similarity", search_kwargs={"k":10}),
        chain_type_kwargs={"prompt": prompt},
        return_source_documents=True
    )
    ia = chain
    return chain


def sugerir_script(pergunta):
    path = "base_conhecimento/scripts.json"
    if not os.path.exists(path):
        return None
    with open(path, encoding="utf-8") as f:
        scripts = json.load(f)
    tokens = set(re.findall(r"\w+", pergunta.lower()))
    for item in scripts:
        for chave in item.get("palavras_chave", []):
            chave_tokens = set(re.findall(r"\w+", chave.lower()))
            if chave_tokens.issubset(tokens):
                return item.get("script")
    return None


def responder_pergunta(pergunta):
    global ia
    # Limpa estado para nova pergunta
    st.session_state["pdf_path"] = None
    st.session_state["fonte_origem"] = None

    # Normaliza texto
    tmp = unicodedata.normalize('NFKD', pergunta.lower())
    tmp = ''.join(c for c in tmp if not unicodedata.combining(c))

    # 1) Intercepta consultas sobre variáveis de ambiente
    if 'variavel' in tmp:
        try:
            print(f"[DEBUG] intercept env query: {pergunta}")
            env_idx = load_env_vars_index('data/env_vars.json')
            candidates = env_idx.similarity_search(pergunta, k=20)
            # Monta prompt para LLM filtrar top 5
            vars_list = "\n".join([
                f"- {d.metadata['name']}: {d.page_content}" for d in candidates
            ])
            system = SystemMessage(content=(
    "Você é especialista em variáveis de ambiente. "
    "Dada uma pergunta e uma lista de variáveis (nome e descrição), selecione apenas aquelas cujo significado atenda diretamente à dúvida do usuário. "
    "Liste até 5 variáveis no formato '- **NOME**: descrição'."
))
            human = HumanMessage(content=f"Pergunta: {pergunta}\nVariáveis:\n{vars_list}")
            resp = ChatOpenAI(model_name="gpt-4", temperature=0)([system, human]).content
            # Extrai nomes selecionados
            chosen = re.findall(r"\*\*(.*?)\*\*", resp)
            selected = [d for d in candidates if d.metadata['name'] in chosen]
            if not selected:
                selected = candidates[:5]
            # Formata resposta
            lines = ['🔍 Resultados de variáveis de ambiente relevantes:']
            for d in selected:
                lines.append(f"- **{d.metadata['name']}**: {d.page_content}")
            return "\n".join(lines)
        except Exception as e:
            print(f"[ERROR] env intercept failed: {e}")

    # 2) Sugestão de script SQL
    if any(tok in pergunta.lower() for tok in ["sql","script","update","select","insert","delete"]):
        script = sugerir_script(pergunta)
        if script:
            return f"💡 **Sugestão de script SQL:**\n```sql\n{script.strip()}\n```"

    # 3) Fluxo padrão de QA
    if ia is None:
        ia = criar_ia_resposta()
    result = ia.invoke(pergunta)
    answer = [result.get("result", "")]
    sources = result.get("source_documents", [])

    # 4) Insere link Movidesk ou PDF download button via session_state
    if sources:
        md = sources[0].metadata
        src = md.get("source")
        if src == "faq" and md.get("id"):
            answer.append(f"🔗 [Ver chamado no Movidesk](https://narwalsistemas.movidesk.com/Ticket/Edit/{md['id']})")
            st.session_state["fonte_origem"] = "faq"
        elif src and src not in ("faq", "env_var"):
            pdf_path = md.get("source")
            if os.path.isfile(pdf_path):
                st.session_state["pdf_path"] = pdf_path
                st.session_state["fonte_origem"] = "manual"
                arquivo = os.path.basename(pdf_path)
                answer.append(f"📄 Manual: `{arquivo}`")

    # 5) Sugestão de script SQL extra
    if not any(d.metadata.get("source") == "faq" for d in sources):
        script2 = sugerir_script(pergunta)
        if script2:
            answer.append(f"💡 **Sugestão de script SQL:**\n```sql\n{script2.strip()}\n```")

    return "\n\n".join(answer)


def registrar_feedback(pergunta, resposta, avaliacao):
    entry = {
        "pergunta": pergunta,
        "resposta": resposta,
        "avaliacao": avaliacao,
        "timestamp": datetime.now().isoformat()
    }
    with open("feedback_log.jsonl", "a", encoding="utf-8") as f:
        f.write(json.dumps(entry, ensure_ascii=False) + "\n")
