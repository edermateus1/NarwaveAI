from PIL import Image, ImageEnhance, ImageFilter
import io
import os
import json
import pytesseract
import openai
from openai import OpenAI
from responder import responder_pergunta
from urllib.parse import quote
import re

openai.api_key = os.getenv("OPENAI_API_KEY")
client = OpenAI()

def limpar_texto_ocr(texto: str) -> str:
    texto = texto.replace("\n", " ").replace("\r", " ")
    texto = re.sub(r"\s{2,}", " ", texto)
    texto = re.sub(r"[^a-zA-Z0-9À-ÿºª.,;:=()/_\- ]", "", texto)
    return texto.strip()

def fallback_json():
    return {
        "erro_detectado": None,
        "rotina": None,
        "explicacao": "Erro ao interpretar resposta da IA.",
        "acao_n1": None,
        "faq_relevante": None,
        "url_busca_azure": None
    }

def analisar_imagem_com_contexto(imagem_bytes, comentario_texto):
    imagem = Image.open(io.BytesIO(imagem_bytes)).convert("L")
    imagem = imagem.filter(ImageFilter.SHARPEN)
    enhancer = ImageEnhance.Contrast(imagem)
    imagem = enhancer.enhance(2.0)

    texto_ocr_raw = pytesseract.image_to_string(imagem, lang="por").strip()
    texto_ocr = limpar_texto_ocr(texto_ocr_raw)
    comentario_texto = comentario_texto.strip() if comentario_texto else "(não informado)"

    prompt = f'''
O analista enviou um print de tela com uma mensagem de erro, além de uma descrição complementar.
Analise o conteúdo da imagem extraída por OCR e considere todos os elementos presentes, inclusive dados como códigos, nomes de sistemas (como Totvs, SEFAZ, Siscomex) e descrições detalhadas que possam aparecer.

🖼️ Mensagem extraída da imagem (OCR):
{texto_ocr}

💬 Comentário do analista:
{comentario_texto}

Tarefa da IA:
1. Identifique o erro principal detectado no print ou comentário.
2. Identifique a possível rotina ou tela do sistema Narwal em que o erro ocorreu.
3. Explique o erro de forma didática e objetiva para o N1.
4. Sugira uma ação prática inicial.

Formato de resposta (JSON):
{{
  "erro_detectado": "...",
  "rotina": "...",
  "explicacao": "...",
  "acao_n1": "..."
}}

Se não houver erro detectado, retorne:
{{
  "erro_detectado": null,
  "rotina": null,
  "explicacao": "Nenhum erro encontrado.",
  "acao_n1": null
}}
'''

    try:
        response = client.chat.completions.create(
            model="gpt-4",
            messages=[
                {
                    "role": "system",
                    "content": (
                        "Você é um assistente técnico da Narwal Sistemas, especialista em suporte de sistemas de comércio exterior e logística internacional. "
                        "Considere que erros geralmente ocorrem em rotinas como emissão de NFe, integração com Siscomex, consultas de cliente, carga de XML, entre outras. "
                        "Se aparecer código de cliente, CNPJ ou nota fiscal, isso pode ajudar a inferir a rotina."
                    )
                },
                {
                    "role": "user",
                    "content": prompt
                }
            ],
            temperature=0.2,
            max_tokens=600
        )

        content = response.choices[0].message.content.strip()
        try:
            resultado = json.loads(content)
        except json.JSONDecodeError:
            match = re.search(r"\{.*\}", content, re.DOTALL)
            if match:
                resultado = json.loads(match.group())
            else:
                return fallback_json()

        for key in ["erro_detectado", "rotina", "explicacao", "acao_n1"]:
            if resultado.get(key) and isinstance(resultado[key], str):
                resultado[key] = resultado[key].replace("<br>", "\n").replace("<strong>", "").replace("</strong>", "").strip()

        if resultado.get("erro_detectado"):
            erro = resultado["erro_detectado"]
            rotina = resultado.get("rotina", "")

            substituicoes = {
                "Object reference not set to an instance of an object": "referência de objeto não definida"
            }
            for padrao, traducao in substituicoes.items():
                if erro.lower() == padrao.lower():
                    erro = traducao

            termos_chave = [erro.lower()]
            if "cliente" in erro.lower() and "não encontrado" in erro.lower():
                termos_chave.append("cadastro de cliente")
            if rotina:
                termos_chave.append(rotina.lower())

            termos_busca = " - ".join(set(termos_chave)).strip()

            resultado["faq_relevante"] = responder_pergunta(termos_busca)

            AZURE_ORG = "NwlSistemas"
            AZURE_PROJECT = "Narwal"
            query = quote(termos_busca)
            resultado["url_busca_azure"] = f"https://dev.azure.com/{AZURE_ORG}/{AZURE_PROJECT}/_search?type=workitem&q={query}"
        else:
            resultado["faq_relevante"] = None
            resultado["url_busca_azure"] = None

        resultado["diagnostico"] = {
            "ocr_raw": texto_ocr_raw,
            "termos_busca": termos_busca if resultado.get("erro_detectado") else None,
            "comentario_usuario": comentario_texto
        }

        return resultado

    except Exception:
        return fallback_json()