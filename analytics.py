import streamlit as st
import pandas as pd
import matplotlib.pyplot as plt
import json
from datetime import datetime, timedelta

st.set_page_config(page_title="Analytics Narwave", layout="centered", page_icon="📊")
st.title("Analytics Narwave")

# Carregamento dos dados
data = []
try:
    with open("feedback_log.jsonl", encoding="utf-8") as f:
        for line in f:
            data.append(json.loads(line))
except FileNotFoundError:
    st.error("Arquivo feedback_log.jsonl não encontrado.")
    st.stop()

if not data:
    st.info("Nenhum feedback registrado ainda.")
    st.stop()

df = pd.DataFrame(data)
df["timestamp"] = pd.to_datetime(df["timestamp"])

# Filtro por período
periodo = st.selectbox("Filtrar por período:", ["Últimos 7 dias", "Últimos 30 dias", "Últimos 90 dias", "Tudo"])
if periodo == "Últimos 7 dias":
    df = df[df["timestamp"] >= datetime.now() - timedelta(days=7)]
elif periodo == "Últimos 30 dias":
    df = df[df["timestamp"] >= datetime.now() - timedelta(days=30)]
elif periodo == "Últimos 90 dias":
    df = df[df["timestamp"] >= datetime.now() - timedelta(days=90)]

# Métricas gerais
positivos = df[df['avaliacao'] == "positivo"].shape[0]
negativos = df[df['avaliacao'] == "negativo"].shape[0]
total = positivos + negativos

st.metric("👍 Feedbacks Positivos", positivos)
st.metric("👎 Feedbacks Negativos", negativos)
st.metric("📈 Total de Feedbacks", total)

# Top 5 perguntas mais frequentes
st.subheader("Top 5 dúvidas mais frequentes")
df["pergunta_normalizada"] = df["pergunta"].str.lower().str.strip()
mais_frequentes = df["pergunta_normalizada"].value_counts().head(5)
st.write(mais_frequentes)

# Gráfico de barras
st.subheader("Distribuição de feedbacks")
feedback_counts = df["avaliacao"].value_counts()
fig, ax = plt.subplots()
feedback_counts.plot(kind="bar", color=["green" if x == "positivo" else "red" for x in feedback_counts.index], ax=ax)
ax.set_ylabel("Quantidade")
ax.set_title("Feedbacks por tipo")
st.pyplot(fig)

# Lista de feedbacks recentes
st.subheader("📋 Últimos feedbacks")
st.dataframe(df.sort_values("timestamp", ascending=False).head(10)[["timestamp", "pergunta", "avaliacao"]])