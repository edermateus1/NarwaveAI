import sys
import os
sys.path.append(os.path.abspath(os.path.join(os.path.dirname(__file__), '..')))

import streamlit as st
from responder import responder_pergunta, criar_ia_resposta, registrar_feedback, sugerir_script
from analisar_print_com_ia import extrair_erro_com_ia
from dotenv import load_dotenv
import base64

from utils import aplicar_estilo_base


# 1. Carrega variáveis do .env (somente local)
load_dotenv()

# 2. Fallback seguro: tenta usar st.secrets apenas se disponível (no Streamlit Cloud)
try:
    OPENAI_API_KEY = st.secrets["OPENAI_API_KEY"]
    AZURE_OPENAI_API_KEY = st.secrets["AZURE_OPENAI_API_KEY"]
    AZURE_OPENAI_ENDPOINT = st.secrets["AZURE_OPENAI_ENDPOINT"]
    AZURE_OPENAI_DEPLOYMENT = st.secrets["AZURE_OPENAI_DEPLOYMENT"]
except Exception:
    OPENAI_API_KEY = os.getenv("OPENAI_API_KEY", "")
    AZURE_OPENAI_API_KEY = os.getenv("AZURE_OPENAI_API_KEY", "")
    AZURE_OPENAI_ENDPOINT = os.getenv("AZURE_OPENAI_ENDPOINT", "")
    AZURE_OPENAI_DEPLOYMENT = os.getenv("AZURE_OPENAI_DEPLOYMENT", "")

# 3. Injeta no os.environ para bibliotecas que dependem disso (Langchain, OpenAI etc)
os.environ["OPENAI_API_KEY"] = OPENAI_API_KEY
os.environ["AZURE_OPENAI_API_KEY"] = AZURE_OPENAI_API_KEY
os.environ["AZURE_OPENAI_ENDPOINT"] = AZURE_OPENAI_ENDPOINT
os.environ["AZURE_OPENAI_DEPLOYMENT"] = AZURE_OPENAI_DEPLOYMENT

# Configuração da página
st.set_page_config(page_title="Narwave AI", page_icon="🐋", layout="centered")
aplicar_estilo_base()  # <- Aplica CSS + logo centralizada

# Injetar CSS externo
css_path = "styles.css"
if os.path.exists(css_path):
    with open(css_path, encoding="utf-8") as f:
        st.markdown(f"<style>{f.read()}</style>", unsafe_allow_html=True)
else:
    st.warning("Arquivo styles.css não encontrado.")


# Estados da sessão
for key in ["historico", "mostrar_opcoes", "feedbacks_dados", "menu_expandido", "ir_para_template_n2"]:
    if key not in st.session_state:
        st.session_state[key] = False if key != "historico" and key != "feedbacks_dados" else [] if key == "historico" else {}


# Expander para análise de imagem
with st.expander("📸 Analisar print de tela (via IA)", expanded=False):
    if "uploader_key" not in st.session_state:
        st.session_state["uploader_key"] = 0

    imagem = st.file_uploader(
        "Envie um print com erro",
        type=["png", "jpg", "jpeg"],
        key=f"file_uploader_{st.session_state['uploader_key']}"
    )

    if imagem:
        imagem_bytes = imagem.read()
        with st.spinner("Analisando imagem com IA..."):
            resultado = extrair_erro_com_ia(imagem_bytes)

        if resultado:
            st.markdown("### 🧐 Resultado da análise:")
            if resultado["erro_detectado"]:
                st.markdown("#### ⚠️ Erro identificado:")
                st.code(resultado["erro_detectado"])
                st.markdown("**📄 O que isso significa:**")
                st.markdown(resultado["explicacao"])
                st.markdown("**🔧 O que o N1 pode fazer:**")
                st.markdown(resultado["acao_n1"])
            else:
                st.info("Nenhum erro técnico foi detectado na imagem.")

        st.session_state["uploader_key"] += 1

# Histórico de mensagens
for idx, item in enumerate(st.session_state["historico"]):
    with st.chat_message("user"):
        st.markdown(item["pergunta"])
    with st.chat_message("assistant"):
        st.markdown(item["resposta"])
        if item.get("pdf_path") and os.path.exists(item["pdf_path"]) and item.get("fonte_origem") != "faq":
            with open(item["pdf_path"], "rb") as f:
                st.download_button("📅 Baixar manual PDF", f, file_name=os.path.basename(item["pdf_path"]), key=f"dl_hist_{idx}")
        feedback_key = f"feedback_{idx}"
        if not st.session_state["feedbacks_dados"].get(feedback_key):
            col1, col2, _ = st.columns([0.1, 0.1, 0.8])
            with col1:
                if st.button("👍", key=f"like_{idx}"):
                    registrar_feedback(item["pergunta"], item["resposta"], "positivo")
                    st.session_state["feedbacks_dados"][feedback_key] = "positivo"
                    st.rerun()
            with col2:
                if st.button("👎", key=f"dislike_{idx}"):
                    registrar_feedback(item["pergunta"], item["resposta"], "negativo")
                    st.session_state["feedbacks_dados"][feedback_key] = "negativo"
                    st.rerun()
        else:
            if st.session_state["feedbacks_dados"][feedback_key] == "positivo":
                st.success("Obrigado pelo feedback positivo!")
            else:
                st.info("Feedback registrado. Vamos melhorar!")

# Nova pergunta
pergunta = st.chat_input("Digite sua dúvida sobre o sistema Narwal...")
if pergunta:
    with st.chat_message("user"):
        st.markdown(pergunta)

    with st.spinner("Consultando base de conhecimento..."):
        resposta = responder_pergunta(pergunta.strip())
        sugestao = sugerir_script(pergunta)

    with st.chat_message("assistant"):
        st.markdown(resposta)
        if sugestao:
            st.markdown(sugestao)
        pdf_path = st.session_state.get("pdf_path")
        if pdf_path and os.path.exists(pdf_path) and st.session_state.get("fonte_origem") != "faq":
            with open(pdf_path, "rb") as f:
                st.download_button("📅 Baixar manual PDF", f, file_name=os.path.basename(pdf_path), key="dl_novo")

    st.session_state["historico"].append({
        "pergunta": pergunta.strip(),
        "resposta": resposta,
        "pdf_path": st.session_state.get("pdf_path"),
        "fonte_origem": st.session_state.get("fonte_origem")
    })
    st.session_state["ultima_pergunta"] = pergunta.strip()

# Integração com Azure DevOps
if st.session_state.get("ultima_pergunta"):
    with st.chat_message("assistant"):
        if st.button("🔎 Buscar no Azure por este erro"):
            with st.spinner("Consultando Azure DevOps..."):
                from azure_integration import buscar_work_items
                resultados = buscar_work_items(st.session_state["ultima_pergunta"])
            if resultados:
                st.markdown("### Resultados encontrados:")
                for item in resultados:
                    st.markdown(f"🔗 [{item['title']}]({item['url']})")
            else:
                st.info("Nenhum card relacionado foi encontrado no Azure.")
# Novo menu lateral com toggle
def alternar_menu():
    st.session_state["menu_expandido"] = not st.session_state["menu_expandido"]

with st.sidebar:
    col1, col2 = st.columns([0.2, 0.8]) if st.session_state.get("menu_expandido", False) else st.columns([1, 0.001])
    with col1:
        st.button("⚙️", key="toggle_menu", on_click=alternar_menu, help="Expandir/recolher menu")

    if st.session_state.get("menu_expandido", False):
        with st.container():
            st.markdown('<div class="menu-lateral-wrapper">', unsafe_allow_html=True)
            st.button("🔄 Reprocessar", key="reprocessar", on_click=lambda: criar_ia_resposta(reprocessar=True))
            st.button("📋 Analisar template N2", on_click=lambda: st.session_state.update({"ir_para_template_n2": True}))
            st.markdown('</div>', unsafe_allow_html=True)

# Redirecionamento
if st.session_state.get("ir_para_template_n2"):
    st.session_state["ir_para_template_n2"] = False  # evita loop de redirecionamento
    st.switch_page("Analisar_Template_N2")  # <- nome visível da página na barra lateral
    st.write(st.runtime.scriptrunner.get_pages(""))
