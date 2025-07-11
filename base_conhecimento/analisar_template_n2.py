﻿import re
from responder import responder_pergunta  # Certifique-se que responder.py está acessível

def analisar_template_n2(texto: str) -> str:
    campos = {
        "categoria": r"Categoria:\s*(.*)",
        "processo": r"N[úu]mero do processo:\s*(.*)",
        "url": r"URL:\s*(.*)",
        "descricao": r"Descri[çc][ãa]o:\s*([\s\S]*?)\n\s*•\s*Est[áa] ocorrendo",
        "todos_os_casos": r"Est[áa] ocorrendo.*?:\s*(.*)",
        "analise": r"An[áa]lise inicial:\s*([\s\S]*?)\n\s*•",
        "impacto": r"Impacto:\s*(.*)",
        "versao": r"Valida[çc][ãa]o na [úu]ltima vers[ãa]o:\s*(.*)",
        "passos": r"4\. Passos para Simula[çc][ãa]o do problema[\s\S]*?Erro Apresentado:\s*([\s\S]*?)\n\n"
    }

    resultado = []

    for campo, padrao in campos.items():
        match = re.search(padrao, texto, re.IGNORECASE)
        if match:
            valor = match.group(1).strip()
            resultado.append(f"**{campo.capitalize().replace('_', ' ')}:** {valor}")

    if not resultado:
        return "⚠️ Não foi possível extrair informações estruturadas do template N2. Verifique o formato."

    resposta = "### 🤖 Análise técnica automatizada\n\n"
    resposta += "\n".join(resultado)

    # 🔍 Diagnóstico por palavras-chave simples
    if 'produtos' in texto.lower() and 'não' in texto.lower():
        resposta += "\n\n🔍 Possível falha no vínculo entre produtos e estrutura de simulação. Revise a aba de parâmetros ou filtros por perfil."
    elif 'despesa' in texto.lower() and 'não puxa' in texto.lower():
        resposta += "\n\n⚙️ Verifique se a despesa está com 'Cálculo despesa' configurado como 'Considera parâmetros'."

    # 🧠 Diagnóstico baseado em IA semântica
    trecho_chave = ""
    for campo in ["descricao", "analise", "impacto"]:
        match = re.search(campos[campo], texto, re.IGNORECASE)
        if match:
            trecho_chave += match.group(1).strip() + "\n"

    if trecho_chave:
        resposta_ia = responder_pergunta(trecho_chave.strip())
        if resposta_ia and "não tenho informações suficientes" not in resposta_ia.lower():
            resposta += f"\n\n📚 **Solução potencial encontrada com base em casos anteriores:**\n\n{resposta_ia}"

    return resposta
