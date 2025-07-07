import streamlit as st
from base_conhecimento.analisar_template_n2 import analisar_template_n2
from utils import aplicar_estilo_base

# Configuração e estilo
st.set_page_config(page_title="Analisar Template N2", page_icon="📋")
aplicar_estilo_base()

# Título
st.title("Analisar (template N2)")

# Campo de entrada
texto = st.text_area("Cole aqui o chamado com template N2 completo:", height=400)

# Botão de análise
if st.button("🚀 Executar análise") and texto:
    with st.spinner("Analisando chamado..."):
        resultado = analisar_template_n2(texto)
        st.markdown(resultado)

# Botão de voltar
if st.button("🏠 Voltar para o assistente"):
    st.switch_page("0_Home")