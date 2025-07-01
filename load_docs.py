# -*- coding: utf-8 -*-
# load_docs.py

import os
import json
import re
import fitz  # PyMuPDF
from PIL import Image
import pytesseract
import io

from langchain_community.document_loaders import (
    PyMuPDFLoader,
    UnstructuredWordDocumentLoader,
    TextLoader
)
from langchain.text_splitter import RecursiveCharacterTextSplitter
from langchain_core.documents import Document

# (Opcional) Configure manualmente o caminho do Tesseract se necessário
# pytesseract.pytesseract.tesseract_cmd = r"C:\Program Files\Tesseract-OCR\tesseract.exe"

def carregar_documentos(caminhos):
    documentos = []

    for caminho in list(caminhos):
        print(f"[DEBUG] Verificando caminho: {caminho}")
        if os.path.isdir(caminho):
            for root, _, files in os.walk(caminho):
                for arquivo in files:
                    caminho_arquivo = os.path.join(root, arquivo)
                    if any(part.startswith('$') for part in caminho_arquivo.split(os.sep)):
                        print(f"[IGNORADO] Arquivo do sistema/lixeira: {caminho_arquivo}")
                        continue
                    documentos.extend(carregar_arquivo(caminho_arquivo))
        elif os.path.isfile(caminho):
            documentos.extend(carregar_arquivo(caminho))

    print(f"[DEBUG] Total de documentos carregados: {len(documentos)}")
    return documentos

def carregar_arquivo(caminho):
    print(f"[DEBUG] Tentando carregar: {caminho}")
    documentos = []

    try:
        if caminho.endswith(".pdf"):
            documentos = carregar_pdf_com_ocr(caminho)
        elif caminho.endswith(".docx"):
            loader = UnstructuredWordDocumentLoader(caminho)
            documentos = loader.load()
        elif caminho.endswith(".txt"):
            loader = TextLoader(caminho, encoding="utf-8")
            documentos = loader.load()
        elif caminho.endswith(".json"):
            with open(caminho, "r", encoding="latin-1") as f:
                faqs = json.load(f)
                for item in faqs:
                    conteudo = f"Pergunta: {item['pergunta']}\nCausa: {item.get('causa', '')}\nSolução: {item.get('solucao', '')}"
                    doc = Document(page_content=conteudo, metadata={"source": "faq"})
                    documentos.append(doc)
    except Exception as e:
        print(f"[ERRO] Falha ao carregar '{caminho}': {e}")

    return documentos

def carregar_pdf_com_ocr(caminho_pdf):
    try:
        loader = PyMuPDFLoader(caminho_pdf)
        docs = loader.load()
        if docs and any(doc.page_content.strip() for doc in docs):
            return docs

        print(f"[OCR] Iniciando OCR para: {caminho_pdf}")
        texto_ocr = []
        with fitz.open(caminho_pdf) as doc:
            for pagina in doc:
                pix = pagina.get_pixmap(dpi=300)
                imagem = Image.open(io.BytesIO(pix.tobytes("png")))
                texto = pytesseract.image_to_string(imagem, lang="por")
                texto_ocr.append(texto)

        conteudo = "\n\n".join(texto_ocr).strip()
        if conteudo:
            return [Document(page_content=conteudo, metadata={"source": caminho_pdf})]
        else:
            print(f"[OCR] Nenhum texto detectado via OCR em: {caminho_pdf}")
            return []
    except Exception as e:
        print(f"[ERRO] Falha no OCR de '{caminho_pdf}': {e}")
        return []

def dividir_documentos(docs):
    splitter = RecursiveCharacterTextSplitter(
        chunk_size=1000,
        chunk_overlap=100
    )
    return splitter.split_documents(docs)
