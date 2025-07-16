import os
import re
import json

# Caminho do arquivo .cs (ajuste se necessário)
CS_PATH = os.path.join(os.path.dirname(__file__), '../data/seeder/VariavelAmbienteseeder.cs')
# Caminho de saída do JSON
OUT_PATH = os.path.join(os.path.dirname(__file__), '../data/env_vars.json')


def extract_blocks(file_path):
    """
    Lê o .cs e retorna uma lista de blocos de texto completos para cada instância de VariavelAmbiente
    """
    blocks = []
    with open(file_path, encoding='utf-8') as f:
        in_block = False
        block_lines = []
        for line in f:
            if 'new VariavelAmbiente' in line:
                in_block = True
                block_lines = [line]
                continue
            if in_block:
                block_lines.append(line)
                # Fecha o bloco quando encontra '},' ou '}' numa linha só
                if re.match(r"\s*}\s*,?\s*$", line):
                    blocks.append(''.join(block_lines))
                    in_block = False
    return blocks


def extract_fields(block):
    """
    Extrai nome, descrição, tipo e ativo de um bloco de VariavelAmbiente
    Retorna dict ou None se faltar algum campo
    """
    name = desc = tipo = ativo = None
    for line in block.splitlines():
        if 'NomeVariavel' in line:
            m = re.search(r'"([^"]*)"', line)
            if m: name = m.group(1)
        elif 'Descricao' in line:
            m = re.search(r'"([^"]*)"', line)
            if m: desc = m.group(1)
        elif 'TipoVariavel' in line:
            m = re.search(r'TipoVariavel\.([A-Za-z]+)', line)
            if m: tipo = m.group(1)
        elif 'Ativo' in line:
            m = re.search(r'(true|false)', line, re.IGNORECASE)
            if m: ativo = m.group(1).lower() == 'true'
    if None in (name, desc, tipo, ativo):
        return None
    return {
        'name': name,
        'description': desc,
        'type': tipo,
        'active': ativo
    }


def main():
    # Extrai blocos do arquivo .cs
    blocks = extract_blocks(CS_PATH)
    print(f"[INFO] Encontrados {len(blocks)} blocos de VariavelAmbiente")

    records = []
    for block in blocks:
        rec = extract_fields(block)
        if rec:
            records.append(rec)
        else:
            # Exibe primeiras 80 chars do bloco para diagnóstico
            snippet = block.strip().replace('\n', ' ')[:80]
            print(f"[WARN] Falha ao parsear bloco: {snippet}...")

    # Garante que a pasta de saída exista
    os.makedirs(os.path.dirname(OUT_PATH), exist_ok=True)
    # Grava JSON de saída
    with open(OUT_PATH, 'w', encoding='utf-8') as f:
        json.dump(records, f, ensure_ascii=False, indent=2)

    print(f"[OK] Extraídos {len(records)} variáveis para {OUT_PATH}")


if __name__ == '__main__':
    main()
