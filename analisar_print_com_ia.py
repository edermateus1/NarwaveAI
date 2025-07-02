from PIL import Image
import pytesseract
import io
import os
import json
from openai import OpenAI

os.environ["OPENAI_API_KEY"] = os.getenv("OPENAI_API_KEY")
client = OpenAI()

def extrair_erro_com_ia(imagem_bytes):
    imagem = Image.open(io.BytesIO(imagem_bytes))
    texto_extraido = pytesseract.image_to_string(imagem)

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
            "content": """Você é um assistente técnico da Narwal Sistemas, especialista em suporte de sistemas de comércio exterior e logística internacional. Sua missão é auxiliar analistas de suporte N1 e N2 a identificar rapidamente mensagens de erro, interpretar falhas em prints de tela e sugerir ações práticas dentro do contexto do sistema Narwal (como módulos de importação, exportação, semáforos, regras, parametrizações ou integrações com a Receita Federal). Sempre explique de forma clara, objetiva e com foco na realidade do dia a dia de suporte técnico."""
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
