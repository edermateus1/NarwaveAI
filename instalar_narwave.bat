@echo off
setlocal

echo ========================================
echo  NARWAVE AI - INSTALADOR INICIAL
echo ========================================

:: Verifica se Python está no PATH
where python >nul 2>&1
IF %ERRORLEVEL% NEQ 0 (
    echo ERRO: Python não está disponível no PATH.
    echo.
    echo 👉 Passo 1: Instale o Python 3.13.5 com a opção:
    echo     [x] Add Python to PATH
    echo.
    echo Link direto para download:
    echo https://www.python.org/ftp/python/3.13.5/python-3.13.5-amd64.exe
    pause
    exit /b
)

:: Cria ambiente virtual
echo.
echo [1/3] Criando ambiente virtual...
python -m venv .venv

:: Ativa ambiente virtual
call .venv\Scripts\activate.bat

:: Atualiza pip
echo.
echo [2/3] Atualizando pip...
python -m pip install --upgrade pip

:: Instala dependências
echo.
echo [3/3] Instalando dependências do requirements.txt...
pip install -r requirements.txt

echo.
echo ========================================
echo ✅ INSTALAÇÃO CONCLUÍDA!
echo.
echo Para iniciar o Narwave AI:
echo → iniciar_narwave.bat
echo.
echo ========================================
pause
