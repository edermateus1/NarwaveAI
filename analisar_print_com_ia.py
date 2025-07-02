from PIL import Image, ImageEnhance, ImageFilter
import io
import os
import json
import pytesseract
import openai
from openai import OpenAI

openai.api_key = os.getenv("OPENAI_API_KEY")
client = OpenAI()

def extrair_erro_com_ia(imagem_bytes):
    imagem = Image.open(io.BytesIO(imagem_bytes)).convert("L")
    imagem = imagem.filter(ImageFilter.SHARPEN)
    enhancer = ImageEnhance.Contrast(imagem)
    imagem = enhancer.enhance(2.0)
    
    texto_extraido = pytesseract.image_to_string(imagem, lang="por")

    prompt = f"""
O seguinte texto foi extraído de um print de tela do sistema Narwal:

\"\"\"
{texto_extraido.strip()}
\"\"\"

Sua tarefa é ajudar um analista de suporte nível 1 (N1) a entender e agir sobre esse erro, considerando o contexto do sistema Narwal.

1. Extraia apenas o trecho de erro relevante, se houver.
2. Explique o erro de forma clara e didática, com linguagem acessível ao N1.
3. Dê uma orientação prática, por exemplo: "Verifique o campo 'Regra' na tela do semáforo" ou "Esse erro geralmente ocorre quando..."

Formato de resposta (em JSON):
{{
  "erro_detectado": "...",
  "explicacao": "...",
  "acao_n1": "..."
}}

Se não houver erro detectado, retorne:
{{
  "erro_detectado": null,
  "explicacao": "Nenhum erro encontrado.",
  "acao_n1": null
}}
"""

    try:
        response = client.chat.completions.create(
            model="gpt-4",
            messages=[
                {
                    "role": "system",
                    "content": """Você é um assistente técnico da Narwal Sistemas, especialista em suporte de sistemas de comércio exterior e logística internacional..."""
                },
                {
                    "role": "user",
                    "content": prompt
                }
            ],
            temperature=0.2,
            max_tokens=500
        )

        content = response.choices[0].message.content.strip()
        resultado = json.loads(content)

        for key in ["erro_detectado", "explicacao", "acao_n1"]:
            if resultado.get(key) and isinstance(resultado[key], str):
                resultado[key] = resultado[key].replace("<br>", "\n").replace("<strong>", "").replace("</strong>", "").strip()

        return resultado

    except Exception:
        return {
            "erro_detectado": None,
            "explicacao": "Erro ao interpretar resposta da IA.",
            "acao_n1": None
        }
