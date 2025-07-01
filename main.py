# -*- coding: utf-8 -*-
from responder import responder_pergunta

print("Assistente IA Narwal - Suporte Tecnico")
print("-" * 40)

while True:
    pergunta = input("Digite sua pergunta (ou 'sair'): ")
    if pergunta.lower() in ["sair", "exit", "quit"]:
        break
    resposta = responder_pergunta(pergunta)
    print(f"\nResposta da IA:\n{resposta}\n")

input("Pressione Enter para sair...")
