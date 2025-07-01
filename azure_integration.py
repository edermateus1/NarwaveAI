import requests
from requests.auth import HTTPBasicAuth
import os
from dotenv import load_dotenv
import unicodedata
import re

# Carrega variáveis do .env
load_dotenv()

AZURE_ORG = "NwlSistemas"
AZURE_PROJECT = "Narwal"
AZURE_PAT = os.getenv("AZURE_PAT")

def limpar_html(texto):
    return re.sub(r"<[^>]+>", "", texto or "")

def normalizar(texto):
    return unicodedata.normalize("NFKD", texto.lower()).encode("ascii", "ignore").decode("utf-8")

def buscar_work_items(termo_busca, max_resultados=5):
    search_url = f"https://almsearch.dev.azure.com/{AZURE_ORG}/{AZURE_PROJECT}/_apis/search/workitemsearchresults?api-version=7.1-preview.1"
    headers = {
        "Content-Type": "application/json",
        "Accept": "application/json"
    }
    auth = HTTPBasicAuth("", AZURE_PAT)

    def consulta(term):
        payload = {
            "searchText": term,
            "$top": 50
        }
        print(f"🔎 Enviando para Azure: {payload}")
        try:
            resp = requests.post(search_url, json=payload, headers=headers, auth=auth)
            if resp.status_code != 200:
                print(f"❌ Falhou ({resp.status_code}): {resp.text}")
                return []
            data = resp.json()
            resultados = []
            for item in data.get("results", []):
                fields = item.get("fields", {})
                item_id = fields.get("system.id")
                title = fields.get("system.title", "")
                description = limpar_html(fields.get("system.description", ""))
                resultados.append({
                    "id": item_id,
                    "title": title,
                    "description": description,
                    "url": f"https://dev.azure.com/{AZURE_ORG}/{AZURE_PROJECT}/_workitems/edit/{item_id}"
                })
                if len(resultados) >= max_resultados:
                    break
            return resultados
        except Exception as e:
            print("❌ Erro na requisição:", e)
            return []

    # Primeira tentativa com o termo completo
    resultados = consulta(termo_busca)
    if resultados:
        return resultados

    # Fallback com termo reduzido
    palavras = termo_busca.split()
    termo_reduzido = " ".join(palavras[:5]) if len(palavras) > 5 else termo_busca
    print(f"🔁 Tentando com termo reduzido: {termo_reduzido}")
    return consulta(termo_reduzido)
