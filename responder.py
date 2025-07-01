# responder.py
# -*- coding: utf-8 -*-

from langchain_community.embeddings import HuggingFaceEmbeddings
from langchain_community.vectorstores import FAISS
from langchain_openai import ChatOpenAI
from langchain.chains import RetrievalQA
from dotenv import load_dotenv
from load_docs import carregar_documentos, dividir_documentos
import os
import time
import json
import re
from langchain.docstore.document import Document
from datetime import datetime

load_dotenv()

ia = None  # Cache global da IA

def criar_ia_resposta(reprocessar=False):
    global ia

    caminho_index = "faiss_index"
    print("[IA] Iniciando carregamento...")
    inicio = time.time()

    embeddings = HuggingFaceEmbeddings(model_name="sentence-transformers/all-MiniLM-L6-v2")

    if not reprocessar and os.path.exists(caminho_index):
        print("[IA] Carregando índice salvo...")
        vetorstore = FAISS.load_local(
            caminho_index, embeddings, allow_dangerous_deserialization=True
        )
    else:
        print("[IA] Reprocessando documentos...")

        documentos = carregar_documentos(["base_conhecimento/manuais"])
        print(f"[DEBUG] {len(documentos)} documentos carregados.")

        caminho_json = "base_conhecimento/faqs.json"
        if os.path.exists(caminho_json):
            with open(caminho_json, encoding="latin-1") as f:
                faqs = json.load(f)
                for faq in faqs:
                    conteudo = f"Pergunta: {faq['pergunta']}\nCausa: {faq['causa']}\nSolução: {faq['solucao']}"
                    documentos.append(Document(
                        page_content=conteudo,
                        metadata={
                            "source": "faq",
                            "id": str(faq["id"])
                        }
                    ))

        fragmentos = dividir_documentos(documentos)
        print(f"[IA] Fragmentos carregados: {len(fragmentos)}")

        vetorstore = FAISS.from_documents(fragmentos, embeddings)
        vetorstore.save_local(caminho_index)
        print("[IA] Reprocessamento concluído.")

    modelo = ChatOpenAI(
        model_name="gpt-3.5-turbo",
        temperature=0.1,
        max_tokens=500
    )

    chain = RetrievalQA.from_chain_type(
        llm=modelo,
        retriever=vetorstore.as_retriever(
            search_type="similarity",
            search_kwargs={"k": 10}  # Aumentado de 5 para 10
        ),
        return_source_documents=True
    )

    ia = chain
    fim = time.time()
    print(f"[IA] Pronto em {fim - inicio:.2f} segundos.")
    return chain

def sugerir_script(pergunta):
    caminho_scripts = "base_conhecimento/scripts.json"
    if not os.path.exists(caminho_scripts):
        return None

    with open(caminho_scripts, "r", encoding="utf-8") as f:
        scripts = json.load(f)

    pergunta_tokens = set(re.findall(r'\w+', pergunta.lower()))

    for item in scripts:
        for chave in item.get("palavras_chave", []):
            chave_tokens = set(re.findall(r'\w+', chave.lower()))
            if chave_tokens.issubset(pergunta_tokens):
                return item["script"]
    return None

def responder_pergunta(pergunta):
    global ia
    if ia is None:
        ia = criar_ia_resposta()

    # Verifica se a pergunta sugere diretamente que é um comando SQL
    termos_sql = ["sql", "script", "update", "select", "insert", "delete"]
    if any(t in pergunta.lower() for t in termos_sql):
        sugestao = sugerir_script(pergunta)
        if sugestao:
            return f"💡 **Sugestão de script SQL:**\n```sql\n{sugestao.strip()}\n```"

    resposta = ia.invoke(pergunta)
    partes = [resposta["result"]]

    import streamlit as st
    st.session_state["pdf_path"] = None
    st.session_state["fonte_origem"] = None

    fontes = resposta.get("source_documents", [])
    veio_de_faq = False

    if fontes:
        fonte = fontes[0].metadata
        st.session_state["fonte_origem"] = fonte.get("source")

        if fonte.get("source") == "faq" and "id" in fonte:
            veio_de_faq = True
            partes.append(
                f"\n🔗 [Ver chamado no Movidesk](https://narwalsistemas.movidesk.com/Ticket/Edit/{fonte['id']})"
            )
        elif "source" in fonte:
            nome_arquivo = os.path.basename(fonte["source"])
            caminho_local = os.path.join("base_conhecimento", "manuais", nome_arquivo)
            st.session_state["pdf_path"] = caminho_local
            partes.append(f"\n📄 Manual: `{nome_arquivo}`")

    # Se não vier de FAQ, tenta sugerir script complementarmente
    if not veio_de_faq:
        sugestao = sugerir_script(pergunta)
        if sugestao:
            partes.append(f"\n💡 **Sugestão de script SQL:**\n```sql\n{sugestao.strip()}\n```")

    return "\n\n".join(partes)


def registrar_feedback(pergunta, resposta, avaliacao):
    entrada = {
        "pergunta": pergunta,
        "resposta": resposta,
        "avaliacao": avaliacao,
        "timestamp": datetime.now().isoformat()
    }
    with open("feedback_log.jsonl", "a", encoding="utf-8") as f:
        f.write(json.dumps(entrada, ensure_ascii=False) + "\n")
