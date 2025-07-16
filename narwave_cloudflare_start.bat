@echo off
setlocal

REM >>> Ajuste o caminho do seu cloudflared.exe:
set "CLOUDFLARED_PATH=C:\Program Files (x86)\cloudflared\cloudflared.exe"

REM Verifica existência
if not exist "%CLOUDFLARED_PATH%" (
    echo ERRO: cloudflared nao encontrado em "%CLOUDFLARED_PATH%"
    pause
    exit /b 1
)

echo Iniciando Narwave AI...

REM 1) Inicia Streamlit em nova janela
start "" cmd /k "echo Rodando Streamlit... & streamlit run main.py --server.address=127.0.0.1 --server.port=8501"

REM 2) Aguarda o app subir
timeout /t 5 > nul

echo Iniciando Cloudflare Tunnel...

REM 3) Inicia o tunnel em nova janela sem cmd /k
start "" "%CLOUDFLARED_PATH%" tunnel --url http://localhost:8501

echo Pronto!  
pause
