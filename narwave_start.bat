@echo off
echo Iniciando Narwave AI...

REM Caminho completo para o ngrok (ajuste se necessário)
set NGROK_PATH=C:\ngrok\ngrok.exe

REM Ative o ambiente virtual se necessário:
REM call venv\Scripts\activate

REM Inicia o Streamlit em uma janela separada
start cmd /k "streamlit run main.py --server.address=127.0.0.1 --server.port=8501"

REM Espera o Streamlit iniciar
timeout /t 5

REM Inicia o ngrok em outra janela
start cmd /k "%NGROK_PATH% http 8501"

echo Narwave AI está rodando. Acesse a URL pública exibida na janela do ngrok.
pause
