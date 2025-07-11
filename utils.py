﻿import streamlit as st
import os
import base64
import urllib.parse

def aplicar_estilo_base():
    """Aplica o CSS e exibe o logo no topo da interface."""
    # CSS
    css_path = "styles.css"
    if os.path.exists(css_path):
        with open(css_path, encoding="utf-8") as f:
            st.markdown(f"<style>{f.read()}</style>", unsafe_allow_html=True)
    else:
        st.warning("Arquivo styles.css não encontrado.")

    # Logo
    logo_path = "logo.png"
    if os.path.exists(logo_path):
        with open(logo_path, "rb") as f:
            base64_logo = base64.b64encode(f.read()).decode()
        st.markdown(f"""
            <div class="hero-container">
                <img class="hero-logo" src='data:image/png;base64,{base64_logo}' />
            </div>
        """, unsafe_allow_html=True)

def gerar_url_movidesk(erro: str) -> str:
    """
    Gera uma URL de busca no Movidesk com base na mensagem de erro fornecida.

    Parâmetros:
        erro (str): Texto do erro a ser buscado.

    Retorna:
        str: URL completa para busca no Movidesk.
    """
    termo = urllib.parse.quote(erro)
    return f"https://narwalsistemas.movidesk.com/Ticket?search={termo}"
