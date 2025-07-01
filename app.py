import streamlit as st
from responder import responder_pergunta, criar_ia_resposta, registrar_feedback, sugerir_script
import os

st.set_page_config(page_title="Narwave AI", layout="centered", page_icon="🐋")

if "historico" not in st.session_state:
    st.session_state["historico"] = []
if "mostrar_opcoes" not in st.session_state:
    st.session_state["mostrar_opcoes"] = False
if "feedbacks_dados" not in st.session_state:
    st.session_state["feedbacks_dados"] = {}

st.markdown('<div class="botao-engrenagem">', unsafe_allow_html=True)
if st.button("⚙️", key="botao_engrenagem"):
    st.session_state["mostrar_opcoes"] = not st.session_state["mostrar_opcoes"]
st.markdown('</div>', unsafe_allow_html=True)

st.markdown("""
    <style>
    div[data-testid="stButton"] button {
        background-color: #262730;
        color: white;
        border: none;
        border-radius: 8px;
        padding: 10px 14px;
        font-size: 18px;
        cursor: pointer;
        box-shadow: 2px 2px 6px rgba(0,0,0,0.4);
    }
    .botao-engrenagem div[data-testid="stButton"] button {
        position: fixed !important;
        bottom: 20px;
        right: 20px;
        z-index: 9999;
    }
    .reprocessar-button {
        position: fixed;
        bottom: 70px;
        right: 20px;
        z-index: 9998;
    }
    </style>
""", unsafe_allow_html=True)

st.title("🐋 Narwave AI")

if st.session_state["mostrar_opcoes"]:
    with st.container():
        st.markdown('<div class="reprocessar-button">', unsafe_allow_html=True)
        if st.button("🔄 Reprocessar base de conhecimento", key="reprocessar"):
            with st.spinner("Reprocessando base..."):
                criar_ia_resposta(reprocessar=True)
                st.success("✅ Base reprocessada com sucesso!")
        st.markdown('</div>', unsafe_allow_html=True)

# Feedback recebido? Trata e re-renderiza
for idx, item in enumerate(st.session_state["historico"]):
    with st.chat_message("user"):
        st.markdown(item["pergunta"])

    with st.chat_message("assistant"):
        st.markdown(item["resposta"])

        if (
            item.get("pdf_path") and os.path.exists(item["pdf_path"]) and
            item.get("fonte_origem") != "faq"
        ):
            with open(item["pdf_path"], "rb") as f:
                st.download_button(
                    "📅 Baixar manual PDF",
                    f,
                    file_name=os.path.basename(item["pdf_path"]),
                    key=f"download_hist_{os.path.basename(item['pdf_path'])}"
                )

        feedback_key = f"feedback_{idx}"
        feedback_dado = st.session_state["feedbacks_dados"].get(feedback_key, False)

        if not feedback_dado:
            col1, col2, _ = st.columns([0.1, 0.1, 0.8])
            with col1:
                if st.button("👍", key=f"like_{idx}", help="Resposta útil"):
                    registrar_feedback(item["pergunta"], item["resposta"], "positivo")
                    st.session_state["feedbacks_dados"][feedback_key] = "positivo"
                    st.rerun()
            with col2:
                if st.button("👎", key=f"dislike_{idx}", help="Resposta não ajudou"):
                    registrar_feedback(item["pergunta"], item["resposta"], "negativo")
                    st.session_state["feedbacks_dados"][feedback_key] = "negativo"
                    st.rerun()
        else:
            tipo = st.session_state["feedbacks_dados"][feedback_key]
            if tipo == "positivo":
                st.success("Obrigado pelo feedback positivo!")
            else:
                st.info("Feedback registrado. Vamos melhorar!")

# Entrada de nova pergunta
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
        fonte_origem = st.session_state.get("fonte_origem")
        if pdf_path and os.path.exists(pdf_path) and fonte_origem != "faq":
            with open(pdf_path, "rb") as f:
                st.download_button(
                    "📅 Baixar manual PDF",
                    f,
                    file_name=os.path.basename(pdf_path),
                    key=f"download_novo_{os.path.basename(pdf_path)}"
                )

    st.session_state["historico"].append({
        "pergunta": pergunta.strip(),
        "resposta": resposta,
        "pdf_path": st.session_state.get("pdf_path"),
        "fonte_origem": st.session_state.get("fonte_origem")
    })
    st.session_state["ultima_pergunta"] = pergunta.strip()
    st.rerun()

# Busca no Azure
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
