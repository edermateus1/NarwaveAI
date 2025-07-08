import requests
import os
import urllib.parse
import re
from dotenv import load_dotenv

# Carrega variáveis do .env
load_dotenv()
MOVIDESK_TOKEN = os.getenv("MOVIDESK_TOKEN")

BASE_URL = "https://api.movidesk.com/public/v1/tickets"

def limpar_termo(termo):
    """Limpa e reduz o termo para garantir compatibilidade com o filtro OData."""
    termo = termo.strip().replace("\n", " ")
    termo = re.sub(r"[^a-zA-Z0-9\s\-]", "", termo)  # remove caracteres especiais
    palavras = termo.split()
    return " ".join(palavras[:6])  # limita a 6 palavras

def buscar_tickets_movidesk(termo_busca, max_resultados=5):
    """
    Busca tickets no Movidesk com base nas ações (descrições de interações dos tickets).
    """
    if not MOVIDESK_TOKEN:
        print("❌ Token Movidesk não encontrado.")
        return []

    termo_limpo = limpar_termo(termo_busca)

    filtro = f"actions/any(a: contains(a/description, '{termo_limpo}'))"
    filtro_encoded = urllib.parse.quote(filtro, safe="(),=:' ")

    url = (
        f"{BASE_URL}"
        f"?token={MOVIDESK_TOKEN}"
        f"&$top={max_resultados}"
        f"&$select=id,subject,status,owner"
        f"&$expand=actions"
        f"&$filter={filtro_encoded}"
    )

    try:
        resp = requests.get(url)
        if resp.status_code != 200:
            print(f"❌ Erro Movidesk ({resp.status_code}): {resp.text}")
            return []

        tickets = resp.json()
        resultados = []
        for t in tickets:
            resultados.append({
                "id": t["id"],
                "subject": t.get("subject", "Sem título"),
                "status": t.get("status", "Sem status"),
                "owner": t.get("owner", {}).get("businessName", "Sem responsável"),
                "url": f"https://narwalsistemas.movidesk.com/Ticket/{t['id']}"
            })
        return resultados

    except Exception as e:
        print("❌ Erro na requisição Movidesk:", e)
        return []
