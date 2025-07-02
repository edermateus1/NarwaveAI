from PIL import Image, ImageDraw
import pytesseract
import io
import base64

# Lista de palavras-chave que indicam erro
KEYWORDS = [
    "erro", "exception", "failed", "invalid", "unrecognized",
    "não foi possível", "unterminated", "expected", "path"
]

def analisar_e_destacar_erro(imagem_bytes):
    """
    Recebe uma imagem em bytes, aplica OCR, detecta erros e retorna imagem destacada e texto detectado.
    """
    imagem = Image.open(io.BytesIO(imagem_bytes))
    ocr_data = pytesseract.image_to_data(imagem, output_type=pytesseract.Output.DICT)

    draw = ImageDraw.Draw(imagem)
    erros_detectados = []

    for i, texto in enumerate(ocr_data["text"]):
        texto_lower = texto.lower()
        if any(palavra in texto_lower for palavra in KEYWORDS):
            x, y, w, h = (ocr_data["left"][i], ocr_data["top"][i], ocr_data["width"][i], ocr_data["height"][i])
            draw.rectangle([(x, y), (x + w, y + h)], outline="red", width=3)
            erros_detectados.append(texto)

    # Converter imagem para base64 para exibir no Streamlit
    buffer = io.BytesIO()
    imagem.save(buffer, format="PNG")
    imagem_base64 = base64.b64encode(buffer.getvalue()).decode()

    return erros_detectados, imagem_base64
