using Portal.Domain.Entities;
using Portal.Infra.Data.Base.Contexto;
using Portal.Infra.Data.Base.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using Portal.Domain.Const;
using Enums = Portal.Domain.Services.Helpers.Enums;

namespace Portal.Infra.Data.Base.Migrations.Seeder
{
    public static class VariavelAmbienteSeeder
    {
        public static void Seed(DatabaseContext context)
        {
            try
            {
                var variavelAmbientes = new List<VariavelAmbiente>
                {
                    new VariavelAmbiente
                    {
                        NomeVariavel = "MV_TAMTITIINV",
                        Descricao = "Tamanho do campo Numero do título na tela de Invoice",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 10,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "MV_IMPCUSSD",
                        Descricao = "Ao calcular impostos abrirá o relatorio de custos em dolares",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "MV_TPDESPPROIMP",
                        Descricao = "Retorno do auto complete de Tipo de Despesa na tela de nova despesa",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "Chave",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "MV_PRODPROIMP",
                        Descricao = "Retorno do auto complete de Produto na tela de item processo",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "Chave",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESPPAGAINI",
                        Descricao = "Ao Inserir uma nova despesa, trazer como padrão a informada no parâmetro",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 1,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZARNCM",
                        Descricao = "Ativar o Job que integra/atualiza os Ncm's",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CRIADESPESA",
                        Descricao = "Ativar a criação da despesa da Narwal automaticamente",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TAMCHARCLASS",
                        Descricao = "Quatidade de caracteres máximo para as colunas Classificação entrada e saída",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 3,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PRECLASSIFICA",
                        Descricao = "Obriga pré classificação do processo para geração da nota fiscal.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_EMLSMTP",
                        Descricao = "Host SMTP.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "smtp.site.com.br",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_EMLSMTPPORT",
                        Descricao = "Porta de comunicação SMTP.",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 587,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_EMLEND",
                        Descricao = "E-mail de configuração.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "noreply@site.com.br",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_EMLPAS",
                        Descricao = "Senha do e-mail de configuração.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "noreply",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVFOL",
                        Descricao = "Envia FollowUp.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLEMLFROM",
                        Descricao = "E-mail From para uso no envio de FollowUp.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLEMLBCC",
                        Descricao = "E-mails para uso no envio de FollowUp. Utilizar ';' como separador.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLINTEMLBCC",
                        Descricao = "E-mails para uso no envio de FollowUp Interno. Utilizar ';' como separador.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLCREMLBCC",
                        Descricao = "E-mails para uso no envio de FollowUp de Cotação Rodoviário. Utilizar ';' como separador.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLCMEMLBCC",
                        Descricao = "E-mails para uso no envio de FollowUp de Cotação Maritimo. Utilizar ';' como separador.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLPGEMLBCC",
                        Descricao = "E-mails para uso no envio de FollowUp de Presença de Carga. Utilizar ';' como separador.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_URLEXT",
                        Descricao = "Url de endereço de acesso.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_MANTRANETID",
                        Descricao = "Código de usuário referente ao cadastro do Mantranet",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_MANTRANETSENHA",
                        Descricao = "Senha de usuário referente ao cadastro do Mantranet",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_MANTRANETAVISO",
                        Descricao = "E-mails para recebimento da presença de carga. Utilizar ';' como separador.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ROOTGESTAODOCS",
                        Descricao = "Pasta raiz onde será gravado os arquivos da gestão de documentos.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ROOTGESTAOSISCDOCS",
                        Descricao = "Pasta raiz onde será gravado os arquivos da gestão de documentos SISCOSERV.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ROOTGESTAOPEDCOMPDOCS",
                        Descricao = "Pasta raiz onde será gravado os arquivos da gestão de documentos PEDIDO COMPRA.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ROOTGESTAOPEDVENPDOCS",
                        Descricao = "Pasta raiz onde será gravado os arquivos da gestão de documentos PEDIDO VENDA.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ROOTGESTAOLOGNACDOCS",
                        Descricao = "Pasta raiz onde será gravado os arquivos da gestão de documentos LOGISTICA NACIONAL.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INVOICETITAUT",
                        Descricao = "Faz com que o campo titulo invoice seja preenchido automaticamente ao digitar o número da invoice.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "MV_AUCFIL",
                        Descricao = "Retorno do auto complete da filial",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "Nome",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVFOL_INTERVAL",
                        Descricao = "Intervalo de tempo do Job para enviar os follows",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "* * * * *",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "MV_IMPRASCDI",
                        Descricao = "Após Gerar a DI, Imprimir o Rascunho da declaração de Importação",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZAR_NALADI",
                        Descricao = "Ativar o Job que integra/atualiza os Naladi's",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZAR_NVE",
                        Descricao = "Ativar o Job que integra/atualiza os Nve's",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FECHAFINANC",
                        Descricao = "Ativar integração do Fechamento Financeiro",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLFECFINEMLBCC",
                        Descricao = "E-mails para uso no envio de FollowUp de Fechamento Financeiro. Utilizar ';' como separador.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLBAXNUMEMLOPE",
                        Descricao = "E-mails para envio de FollowUp baixa numerário. Utilizar ';' como separador.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLBAXNUMEMLDES",
                        Descricao = "E-mails para envio de FollowUp baixa numerário p/ despachante próprio. Utilizar ';' como separador.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PREFINPERC",
                        Descricao = "Percentual de margem utilizada no relatório de Previsão Financeira.",
                        Tipo = Enums.TipoVariavel.Double,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 35.00,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FECHAFINANCFORN",
                        Descricao = "Ativar o campo fornecedor no Fechamento Financeiro.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVFOLANEXDOC",
                        Descricao = "Ativar o Envio de follow up ao anexar documentos, por outro usuario.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_MINQTDDOC",
                        Descricao = "Quantidade mínima de documentos no processo de importação para emissão de nota fiscal.",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_EXIBEPRINCING",
                        Descricao = "Exibe coluna princing na tela de Simulação de Importação.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SMTPSSL",
                        Descricao = "Utiliza SSL na conexão de envio de email",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIAPRTOTVS",
                        Descricao = "Envia titulo provisório para Totvs na simulação de importação",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_QTDCHARNF",
                        Descricao = "Quantidade de digitos permitidos no campo NF.",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 6,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_QTDDIAPREV",
                        Descricao = "Quantidade de dias para previsionar frete e outras despesas.",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_AGRDESPPREV",
                        Descricao = "Agrupar as despesas para integração da previsão de despesas.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DOWNAVIO",
                        Descricao = "URL para download do arquivo de integração de navios.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "https://www.mercante.transportes.gov.br/g36127/servlet/download.DownloSvlet?tabela=EMBARC",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_UPNAVPRO",
                        Descricao = "Atualização de Navios dos Processos após integração.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INTSISCARGA",
                        Descricao = "Integração de processos do siscarga.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLDDICI",
                        Descricao = "Pasta de destino extrato DI e CI baixado automaticamente pelo sistema.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SERATUNAV",
                        Descricao = "Autorizar atualização de Navios no Job.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DECCASPRO",
                        Descricao = "Número de casas decimais utilizadas na tela de processo.",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 5,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INTSITDI",
                        Descricao = "Integração de situação DI.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_EMLDESEMT",
                        Descricao = "E-mail para informativo de desembaraço interrompido. Utilizar ';' como separador.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PROPCOMER",
                        Descricao = "Nome do relatório de proposta comercial.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INTMANTRA",
                        Descricao = "Atualiza presença de carga (MANTRA).",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SENIORPREVCODTPTITPAG",
                        Descricao = "Senior -> Código PREVISTO do tipo do título a pagar.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "IA",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SENIORPREVCODFORTITPAG",
                        Descricao = "Senior -> Código PREVISTO do fornecedor do título a pagar.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "41081",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SENIORPREVCODTRANORGTITPAG",
                        Descricao = "Senior -> Código PREVISTO da transação origem do título a pagar.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "90517",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SENIOREFETCODTPTITPAG",
                        Descricao = "Senior -> Código EFETIVO do tipo do título a pagar.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "IA",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SENIOREFETCODFORTITPAG",
                        Descricao = "Senior -> Código EFETIVO do fornecedor do título a pagar.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "41081",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SENIOREFETCODTRANORGTITPAG",
                        Descricao = "Senior -> Código EFETIVO da transação origem do título a pagar.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "90500",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SENIORCODPORTITPAG",
                        Descricao = "Senior -> Código do portador do título a pagar.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "9999",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SENIORCODCARTTITPAG",
                        Descricao = "Senior -> Código da carteira do título a pagar.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "99",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIARIMPOSTOSNOTA",
                        Descricao = "Enviar impostos na nota (caso não será enviado no registro da Di)",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SEQUENCIALPRODUTO",
                        Descricao = "Código para a chave sequencial do produto",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 100,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ROOTGESTAOEXPDOCS",
                        Descricao = "Pasta raiz onde será gravado os arquivos da gestão de documentos (Exportação).",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_BOOKINGSENDERID",
                        Descricao = "SenderID para envio do booking para o inttra.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "NARWAL",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DIASEXPCOTACAO",
                        Descricao = "Dias para expiracao da cotação de frete.",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 1,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INTINTTRA",
                        Descricao = "Habilita integracao INTTRA",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PRODINTTRA",
                        Descricao = "Habilita ambiente produção INTTRA (0 - Homologação 1- Produção)",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PRODNFDESP",
                        Descricao = "Produto a ser enviado ao ERP quando a Nota fiscal de despesa não ratear os produtos",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESNFSEMA",
                        Descricao = "Exibe a coluna de semáforo para Despesas de Nota Fiscal",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARCONTASPAGAR",
                        Descricao = "Ativa o módulo financeiro",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INTSISCOSERV",
                        Descricao = "Ativa integração retorno de lotes SISCOSERV",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_OBRIGADATACOLETA",
                        Descricao = "Obriga a informação da data de coleta quando o incoterm do processo for EXW",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_WAREHOUSEORIGEM",
                        Descricao = "Habilita controle de warehouse na origem",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITARCEST",
                        Descricao = "Habilita controle de Cest",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SELDATAFATURAMENTO",
                        Descricao = "Seleciona a data para faturamento: 0 - DataRegistroDi  1 - DataNotaFiscalEntrega  ",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INTEGRACAODRAWBACK",
                        Descricao = "Integração de Atos concessórios Drawback",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TEMPLDANFE",
                        Descricao = "Caminho armazenamento nota fiscal de saída",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "\\NOTA-SAIDA",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_BLOQUEIARELCUSTO",
                        Descricao = "Bloquear emissão do relatório de Custo conta e ordem e Importação própria",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SCHEMASNFE",
                        Descricao = "Caminho onde está armazenados os schemas da NFe",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = @"",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLDNFEENTRADA",
                        Descricao = "Caminho armazenamento nota fiscal de entrada",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "NOTA-ENTRADA",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLDNFESAIDA",
                        Descricao = "Caminho armazenamento nota fiscal de saída",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "NOTA-SAIDA",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INTEGRASAP",
                        Descricao = "Url integrador SAP",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PORTALAPI",
                        Descricao = "Url Portal.API",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZAPOSNAVIO",
                        Descricao = "Habilita a consulta das posições dos navios",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FILIALWS",
                        Descricao = "Utiliza filial como parâmetro de consulta do Web Service",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INTEGRAFOLLOW",
                        Descricao = "Habilita a integração dos follows dos armadores",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITAFOLLOWRAS",
                        Descricao = "Habilita o envio de follows com informações de RAS e RP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLLOWNOVOPROCESSO",
                        Descricao = "Habilita o envio de follows aos responsaveis quando um novo processo é aberto",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CRIADESSEGURO",
                        Descricao = "Habilita criação automática de despesas: Despesa de Seguro",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CRIADESPFRETE",
                        Descricao = "Habilita criação automática de despesas: Despesa de Frete",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_EXPODESPCRIAFIN",
                        Descricao = "Habilita criação contas a pagar na Previsão de despesa da Exportação",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SELDATAFATURAMENTOEXPO",
                        Descricao = "Seleciona a data para faturamento da exportação: 0 - DataEmbarque 1 - DataEnvioOriginais",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PEDCOMFLUXO",
                        Descricao = "Quantidade de dias para aviso ao fluxo de caixa para o Pedido de compra",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SIMULASAPROD",
                        Descricao = "Ativar pesquisa do produto na simulação de importação",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HONORARIOFCH",
                        Descricao = "Calcular os honorários ao processar os requisitos do processo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PASTAAPROVACOTACAO",
                        Descricao = "Nome da pasta para armazenar o documento de cotação aprovado",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "Frete",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DIASAVISAMANTRA",
                        Descricao = "Quantidade de dias de aviso do vencimendo da senha do mantra",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 5,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_EXIBEPRDANUENTES",
                        Descricao = "Na geração da LI exibe somente produtos anuentes",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INTTRAEXCLUIRARQUIVO",
                        Descricao = "Track&Trace Excluir arquivos ao fim da leitura",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INTTRATRACKTRACE",
                        Descricao = "Realiza a integração do Track & Trace",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLDLI",
                        Descricao = "Pasta de destino extrato LI baixado automaticamente pelo sistema.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SALVALI",
                        Descricao = "Salva extrato da LI quando: 0 - Nunca, 1 - No registro, 2 - No deferimento, 3 - Ambos.",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HEALTHCARE",
                        Descricao = "Habilita abertura de chamados do sistema.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INTEGRACECOMO",
                        Descricao = "Ao integrar o XML da DI a taxa do CE mercante irá integrar como:",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "PP",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_NATUCOMIS",
                        Descricao = "Natureza de operação a ser considerada para calcular a comissão da exportação",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_NATUTXBANC",
                        Descricao = "Natureza de operação a ser considerada para calcular as taxas bancárias da exportação",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TOKENCONSULTANFE",
                        Descricao = "Token para consultar nfe na Roveri.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DEFDATAFIN",
                        Descricao = "Opção padrão da seleção do campo Data base futuro para exportação",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DEFFILTPOS",
                        Descricao = "Opção padrão do campo Posição do processo na tela de filtros do processo",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLLOWMAPA",
                        Descricao = "Habilita criação do follow de mapa na importação.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLLOWLIBERACAOEMBARQUE",
                        Descricao = "Habilita criação do follow de Liberação conhecimento de Embarque.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SISCOMEXATIVARPRODUCAO",
                        Descricao = "Ativar envio da Due para PRODUÇÃO.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARJOBCONSUTADUESISCOMEX",
                        Descricao = "Ativar Job de Consulta DU-E no Siscomex.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVAAUTOSISCARGA",
                        Descricao = "Ativa atualização automatica do processo pelo siscarga.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENCERRAPROCESSO",
                        Descricao = "Encerra processo de importação ao gerar a nota fiscal.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESPFAT",
                        Descricao = "Lista de despesas (Separadas por virgula) que compõe o faturamento.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLLOWLIPRAZO",
                        Descricao = "Dias para envio de aviso de vencimento da licença de importação",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 10,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_AFRMMCE",
                        Descricao = "Considerar a taxa do ce mercante para o calculo da AFRMM",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_UTILIZADTREGISTRO",
                        Descricao = "Utilizada data de registro da DI como base para pesquisa na painel",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SOLCITAMOTIVO",
                        Descricao = "Solicita motivo da alteração do ETD ou ETA na importação e exportação",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_LINKAPINARWAL",
                        Descricao = "Link da API da Narwal",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "https://api.narwalsistemas.com.br",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARJOBNFSE",
                        Descricao = "Ativar Serviço de Atualização/Envio NFSe",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FILTRAPEDCP",
                        Descricao = "Filtrar somente os titulos vinculados a PO Contas a Pagar",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TIMEOUTNOTA",
                        Descricao = "Time Out em Minutos para envio da Nota Fiscal",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 5,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_RECIMPDIVCFOP",
                        Descricao = "Habilita a divisão de notas no recebimento de importacao pelo CFOP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_RECIMPDIVQTD",
                        Descricao = "Habilita a divisão de notas no recebimento de importacao por quantidade",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ADICAOAMOSTRA",
                        Descricao = "Habilita a divisão de adições por amostra na invoice",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ADICAOAEXCECAO",
                        Descricao = "Habilita a divisão de adições por exceção fiscal do item",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_COMPOEDESCRICAOPARADI",
                        Descricao = "Habilita a composição do codigo do produto com a descricao do produto",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIATAXADOCEREAIS",
                        Descricao = "Habilita o envio da taxa do CE mercante sempre em reais para o Siscomex",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_AMBIENTEGATEWAYPRODUCAO",
                        Descricao = "Habilita o ambiente de produção Gateway para NFSe",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_LINKJOBAPI",
                        Descricao = "Link da API JOB da Narwal",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "http://localhost:53903/",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CODDESPCONFECCAOLI",
                        Descricao = "Codigo da despesa para confecção da Li",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "0",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CODDESPANUENCIALI",
                        Descricao = "Codigo da despesa para anuencia da Li",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "0",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_RATEIOPESOINLAND",
                        Descricao = "Tipo de rateio Inland por peso",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_BANDEIRAMARITMODI",
                        Descricao = "Buscar bandeira para DI (0 - Navio, 1 - Armador)",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLDRE",
                        Descricao = "Pasta para salvar os documentos da RE",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_LINKITENSCONTAINER",
                        Descricao = "Habilita o cadastro de container com link aos itens do processo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_RECHACAIMPO",
                        Descricao = "Possibilitar rechaçar um processo de importação",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARNOVORELATORIOCUSTOMERCADO",
                        Descricao = "Habilita o o novo relatório de custo de mercado",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_VALMERC",
                        Descricao = "Controla valor de mercado nos itens do processo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_EXIBIRNOMECNPJCLIENTE",
                        Descricao = "Auto complete Cliente: Exibir o CNPJ junto ao Nome",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_EXIBIRNOMECNPJIMPORTADOR",
                        Descricao = "Auto complete Importador: Exibir o CNPJ junto ao Nome",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CONTROLAMULTALI",
                        Descricao = "Controla o lançamento da multa de li no processo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PERCMULTALI",
                        Descricao = "Percentual da multa de li sobre o valor aduaneiro",
                        Tipo = Enums.TipoVariavel.Double,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 30,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PERCDESCMULTALI",
                        Descricao = "Percentual de desconto sobre a multa de li",
                        Tipo = Enums.TipoVariavel.Double,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 50,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_VALMINMULTALI",
                        Descricao = "Valor mínimo para multa da LI",
                        Tipo = Enums.TipoVariavel.Double,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 500,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_VALMAXMULTALI",
                        Descricao = "Valor maximo para a multa de LI",
                        Tipo = Enums.TipoVariavel.Double,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 5000,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZARATRIBUTONCM",
                        Descricao = "Ativar o Job que integra/atualiza os Atributos dos Ncm's",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PERGUNTASAIRPROCESSO",
                        Descricao = "Botão de fechar ou voltar, perguntar se deseja realmente voltar/sair das telas de processo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_IMPRIMIRPOPORIDIOMA",
                        Descricao = "Ativa tela que solicita o Idioma da PO a ser impressa",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_IMPRIMIRNOVOFECHAMENTOFINANCEIRO",
                        Descricao = "Ativa o novo relatório de fechamento financeiro",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CALCULODESPACHOVALORADUANEIRO",
                        Descricao = "calcula o valor do despacho pelo valor aduaneiro",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DIVIDEFORNE",
                        Descricao = "Divisão da nota fiscal pelo fornecedor do item",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CANCLIINTEGRADA",
                        Descricao = "Cancelar LI no SISCOMEX",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PEDVENDEXP",
                        Descricao = "Utilizar pedido de venda para exportação",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARDEBUG",
                        Descricao = "Ativa gravação do log do item processo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PATHDEBUG",
                        Descricao = "Caminho para gravar o arquivo de log debug",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = @"C:\inetpub\NarwalSistemas\Producao\log",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESPNAOINFODI",
                        Descricao = "Parametro para despesa não Informada na DI",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_UNINFDESP",
                        Descricao = "Parametro para unico item nota fiscal despesa",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APROVAPEDCOMP",
                        Descricao = "Aprovação do Pedido de compra",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = @"",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PREVIAINTEGRADESP",
                        Descricao = "Permitir visualizar e selecionar despesas (Fechamento Financeiro e Numerario) via txt",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = @"",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TIPONFTRANSITO",
                        Descricao = "Tipo padrão para nota de transito 0= Entrada 1=Saída",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = @"",
                        ValorInt = 1,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ZERDESPTRANS",
                        Descricao = "Habilita zerar despesas nota fiscal de transito",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_RELFLWNOVPROC",
                        Descricao = "Relatório para enviar no follow do novo processo",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_RATEIOSEGUROVMCV",
                        Descricao = "Rateia o Seguro pelo VMCV se = 1, VMLE se = 2 e Rateio Padrão se = 0 nos incoterms EXW, FCA, FAS, FOB, CFR, CPT",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CONTROLASAVEADICAO",
                        Descricao = "Marcar linha da grade de Adição da DI quando não salva pela primeira vez",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARNOVORELREGISTRADO",
                        Descricao = "Ativar novo relatório de processos registrados",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CONTROLAMAPA",
                        Descricao = "Ativar Controle de Mapa no processo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HISTADICAO",
                        Descricao = "Ativar Histórico de adição para restaurar dados após cancelamento",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TOLERANCIADIFPESOADICAO",
                        Descricao = "Tolerância da diferença entre o peso liquido e o peso informado das adições",
                        Tipo = Enums.TipoVariavel.Double,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 1,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CRIARNUMERARIODESPESAFOBCIF",
                        Descricao = "Criar as Despesas de FOB e CIF nos numerários.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 1,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_MODALIDADEIMPORTACAO",
                        Descricao = "Sugerir Modalidade Importação. Informe: (I=Impo.Propria) (E= Encomenda) (C=Conta Ordem)",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 1,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PROCESSODESABTHCCEINTEGXMLDI",
                        Descricao = "Desabilita integração das despesas de TAXA CE e THC na integração do XML da DI no processo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESTACARFRETENOTAFISCALENTRADA",
                        Descricao = "Destacar Frete na nota fiscal de entrada para processo CPT",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CRIADESICMS",
                        Descricao = "Habilita criação automática de despesas: Despesa de ICMS",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CRIADESANTIDUMPING",
                        Descricao = "Habilita criação automática de despesas: Despesa de AntiDumping",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PERGUNSALVARASCDI",
                        Descricao = "Habilita a pergunta se deseja salvar o rascunho da DI na gestao de documentos",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CONSUTADIREGISTRADAIMPORTADOR",
                        Descricao = "Consulta DIs Registradas No Siscomex por Importador",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIAFECHAMENTORESULTANTE",
                        Descricao = "Envia fechamento resultante na integração do ERP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ALLOGTRACKTRACE",
                        Descricao = "Realiza a integração do Track & Trace Allog",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_GERARDESPESATAXMOEDA",
                        Descricao = "Obrigar informar taxa da moeda ao gerar arquivo da despesa do despachante",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_BLOQALTITEMPROCESSODI",
                        Descricao = "Bloqueia a alteração dos campos que participam do agrupamento da DI após a mesmo gerada",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TIPOFRETENFENTRADA",
                        Descricao = "Tipo do frete na nota fiscal de entrada",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 1,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "MV_IMPORTAUTOCOMPLETE",
                        Descricao = "Auto Complete Importador Nome, NomeCnpj, NumeroDocumento",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "NomeCnpj",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_OPCOESPADRAOINTEGRARXMLDI",
                        Descricao = "Define quais as opções serão trazidas por padrão na integração do XML da DI",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CARACTERSEPARACAO",
                        Descricao = "Define o caracter de separação do código para descrição na integração de arquivos",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = ";",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_IMPSISCOSERVIMPORTADORPROPRIO",
                        Descricao = "Permite Automatizar o siscoserv para importadores sem cliente e contrato de comissão",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ACEITADIFERECAFRETENEGATIVA",
                        Descricao = "Permite a geração automática da difereça de frete negativa",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARENVIOCARTACAMBIOAUTO",
                        Descricao = "Ativar envio automatico da carta de câmbio",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_NUMPROCESSOABA",
                        Descricao = "Mostra o número do processo na aba quando editando",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CONTROLAULTMADICAO",
                        Descricao = "Destaca na tela a última adição editada",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_VALORINICIALREMOCAODTADTC",
                        Descricao = "Define qual valor inicial do campo Remoção(DTA/DTC) no processo (0- Nâo, 1- Sim, 2- Indefinido)",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARINTEGRACAOSENIOR",
                        Descricao = "Ativar/Desativa integração Senior",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARBAIXAESTORNOTITULOSSENIOR",
                        Descricao = "Ativar a Baixa/Estorno de titulos financeiros quando ERP for Senior",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_OPCAOPAGOPORDESPESA",
                        Descricao = "Opção frete pago por na aba despesas 0-Não informado 1-Despachante 2-Importador 3-Cliente",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_VISUALIZASEMAFOROPEDIDOCOMPRA",
                        Descricao = "Visualizar Semaforo pedido compra!",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DIFICMSPELOVALOR",
                        Descricao = "Calcula o diferimento do ICMS pelo valor do ICMS cheio(quando desmarcado, calcula pela base)",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABFLWRECORRENTE",
                        Descricao = "Habilita a integração dos follows recorrentes",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CAMPOINTRXMLDI",
                        Descricao = "Campo que será utilizado para a associação do produto na integração do XML da DI no processo",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SEPINTRXMLDI",
                        Descricao = "Caracter que separa o valor de associação com o produto na integração do XML da DI no processo",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVTITANTCTOTVS",
                        Descricao = "Habilita/Desabilita o envio de títulos antecipados para o Protheus",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_BLOQUEIATXTDESPESAOUTRAREF",
                        Descricao = "Bloquear arquivo txt despesas em processos diferentes do aquivo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DIASPRAZODEREGISTROSISCOSERV",
                        Descricao = "Dias para o prazo previsto de registro no siscoserv.",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 3,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CONSULTACOMPLETADUE",
                        Descricao = "Consulta completa Due no siscomex.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_VALIDNCMSISCARGREGDI",
                        Descricao = "Valida NCMs dos itens do processo com o siscarga para registro da DI.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUPAISPOSNAVIO",
                        Descricao = "Ativa a atualização do país do navio na busca pela geolocalização.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABPETICAOLI",
                        Descricao = "Habilita/Desabilita relatório de petição da LI.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CRIARDESPESAMARKUP",
                        Descricao = "Cria despesa de markup no calculo do numerário.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_URLJOBMANTRA",
                        Descricao = "URL JOB MANTRA",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZATAXASNCMEXTARIFARIO",
                        Descricao = "Atualiza taxas nas adições conforme extarifário selecionado.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIAXMLDIQUANDO",
                        Descricao = "Envia Xml da DI no momento do desembaraço da DI (0 - Não envia | 1 - Envia no download da CI | 2 - Envia no registro | 3 - Envia nos dois momentos)",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PREPAIDICMS",
                        Descricao = "Habilita/Desabilita o desconto do acrescimo prepaid da base do ICMS",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_NFEENTRPISCONFSAIDA",
                        Descricao = "Hab./Desab. mostrar valores de PIS e COFINS de entrada na informação complementar da NFE de Saida",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVAGERARLIPEDIDOCOMPRA",
                        Descricao = "Hab./Desab. a geração da LI a partir do pedido de compra!",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DIFBRUTOXLIQUIDO",
                        Descricao = "Tolerância de diferença entre o peso liquido e bruto na análise da DI",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_AGRUPARIMPOSTOSDI",
                        Descricao = "Gera um unico titulo par aos impostos da DI",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_URLLINKSISCOMEX",
                        Descricao = "URL API SISCOMEX",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ALTERALEVELLOG",
                        Descricao = "Altera level Log 0 = Trace, 1 = Debug, 2 = Info, 3 =  Warn, 4 = Error, 5 = Fatal, 6 Desabilita",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 4,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INVVLLIQTOTVS",
                        Descricao = "Envia valor liquido na invoice para o TOTVS no momento no envio da Nota fiscal",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SEPARAPARCELATITULO",
                        Descricao = "Utiliza o tipo do título e a função financeira para definir a ordem da parcela no financeiro",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_IMPRIMIRNOVOEXPORTACAOFECHAMENTOFINANCEIRO",
                        Descricao = "Ativa o novo relatório de exportação fechamento financeiro",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FPGNFESAIDASENIOR",
                        Descricao = "Código da Forma de Pagamento da NFe de Saida do Senior",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZARNCMANUENCIA",
                        Descricao = "Ativar o Job que integra/atualiza os Ncm's Anuência",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_VALIDAANUENCIA",
                        Descricao = "Validação anuência Desabilitado = 0, Valida anuência = 1, Não valida anuência = 2",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_NFEENVIARESPTECNICO",
                        Descricao = "Habilita envio do responsável técnico na nfe",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ALIQPISENCOMENDA",
                        Descricao = "Aliquota Padrão do Pis nas operações de encomenda",
                        Tipo = Enums.TipoVariavel.Double,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 1.65,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ALIQCOFINSENCOMENDA",
                        Descricao = "Aliquota Padrão do Cofins nas operações de encomenda",
                        Tipo = Enums.TipoVariavel.Double,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 7.6,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INTEGRPROCIMPODESP",
                        Descricao = "Habilita/desabilita a integração de processo entre importador e despachante",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_IMPOSTOSANTECIPADOS",
                        Descricao = "Habilita (Marcado) regra do pagamento antecipado dos impostos ou habilita (desmarcado) a regra de pagamento pelo tipo de despesa do processo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PROREQCLIENTE",
                        Descricao = "Exibe aba Requisitos do cliente na tela de processos",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_VISUALIZASEMAFOROPEDIDOVENDA",
                        Descricao = "Visualizar Semaforo pedido venda!",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_VARCAMBIALDI",
                        Descricao = "Controla variação cambial somente das invoices com DI registrada",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_EMAILINTEGRACAO",
                        Descricao = "Endereço do e-mail de integração",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "ged.narwalsistemas.com.br",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_EMAILUSUARIO",
                        Descricao = "Usuário do e-mail de integração",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "nwl",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SENIORPEDCOMPRACODTRN",
                        Descricao = "Senior -> Código da transação para envio pedido de compra.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "90410",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_RETORNARDATACONFIRMACAOERP",
                        Descricao = "Retornar a Data Confirmação para ERP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIARNFEERP",
                        Descricao = "Ativa envio Nfe para ERP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLDSIGVIG",
                        Descricao = "Pasta de destino do requerimento SIGVIG baixado automaticamente pelo sistema.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FORNECEDORIMPOSTOSERP",
                        Descricao = "Fornecedor para envio dos impostos ERP.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABCODINTELIGENTE",
                        Descricao = "Habilita a criação de código sequencial inteligente Narwal",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SENIORDECIMAISNAQTDNFE",
                        Descricao = "SENIOR: Informe a quantidade de decimais a enviar na NFE no campo quantidade produto.",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 2,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABEDICAOPEDIDOINTEGRADO",
                        Descricao = "Habilita a edição de pedidos integrados",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CALCULAPESOBRUEXPOITEM",
                        Descricao = "Habilita o cálculo do peso bruto no item da exportação",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABVINCULONFEDUE",
                        Descricao = "Habilita vinculo da NFe exportação com a DUe",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIARPROCESSOERP",
                        Descricao = "Ativa envio processo de importação para ERP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INVTIPOPRODATRIBITEMPROC",
                        Descricao = "Atribui o Tipo do produto da invoice nos itens do processo vinculados",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "MV_FORNECEDORAUTOCOMPLETE",
                        Descricao = "Autocomplete Fornecedor (Chave, Nome, FornecedorIdNome, ChaveNome, NumeroDocumentoNome)",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "Nome",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "MV_FABRICANTEAUTOCOMPLETE",
                        Descricao = "Autocomplete Fabricante (Chave, Nome, FabricanteIdNome, ChaveNome, NumeroDocumentoNome)",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "Nome",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIATUALIZAFORNECEDOR",
                        Descricao = "Permitir que a API aceite atualizar os dados do fornecedor",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIATUALIZAPRODUTO",
                        Descricao = "Permitir que a API aceite atualizar os dados do produto",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIATUALIZAORDEMITEMPEDIDO",
                        Descricao = "Permitir que a API atualize a Ordem do item do pedido de compra/venda",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIATUALIZAIMPORTADOR",
                        Descricao = "Permitir que a API aceite atualizar os dados do importador",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_NAOPERMITESELECDESPQEMITNOTA",
                        Descricao = "Não permite usuário selecionar despesas na tela de nota fiscal despesa que já foram emitido nota",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TITULOENDOSSOPRO",
                        Descricao = "Habilita geração de titulo a receber endosso do processo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_NFEDIVIDEFORNCFOPNCMCENTRO",
                        Descricao = "Habilita a divisão da nfe por fornecedor, CFOP, NCM, centro (desabilita as outras)",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CONSULTANFEREFERENCIADAEXPO",
                        Descricao = "Utiliza consulta de XML de NFe referenciada ao integrar NFe para exportação",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZATITULOSERP",
                        Descricao = "Marca para envio títulos financeiros ao alterar a data do embarque.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CONTBIMPEDIRNOERRO",
                        Descricao = "Impede salvar alterações ao dar erro no processamento da operação contábil e mostra mensagem na tela.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SEPARARCADADESP",
                        Descricao = "Gerar um item nota fiscal despesa para cada despesa",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_OBRIGAFABRICANTEPEDIDOCOMPRAAPI",
                        Descricao = "Obriga informar o fabricante na api do pedido de compra item",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIARPRODUTOPARAERP",
                        Descricao = "Enviar o cadastro de produto para o ERP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZAR_NALADI_NARWALDADOS",
                        Descricao = "Ativar o job que atualiza os dados do naladi pela api narwal dados",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZARNCMANUENCIA_NARWALDADOS",
                        Descricao = "Ativar o job que atualiza os dados do ncm anuencia pela api narwal dados",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZARNCM_NARWALDADOS",
                        Descricao = "Ativar o job que atualiza os dados do ncm pela api narwal dados",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZAR_NVE_NARWALDADOS",
                        Descricao = "Ativar o job que atualiza os dados do nve pela api narwal dados",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZAR_TAXA_MOEDA_NARWALDADOS",
                        Descricao = "Ativar o job que atualiza as taxas das moedas pela api narwal dados",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DRAWBACKMARINHA",
                        Descricao = "Exclui do rateio a desepesa de marinha mercante quando o item tem drawback",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITAFOLLOWUPCLIENTE",
                        Descricao = "Habilita follow-up para o cliente",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVAINTEGRADOCEXPOCLIENTEAPI",
                        Descricao = "Ativa integração de documentos no cadastro do cliente via API",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CMPDINAMICAGRUPADI",
                        Descricao = "Ativa inserção de campos dinâmicos no agrupamento da DI",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVAAPROVATITULOERP",
                        Descricao = "Ativa Aprovação do titulo no ERP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVAPARAMCSTIPIAUTO",
                        Descricao = "Ativa parametrização automática da CST IPI na Nfe",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIATUALIZAARMADOR",
                        Descricao = "Permitir que a API aceite atualizar os dados do Armador",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARENVIOPREVISAOCUSTO",
                        Descricao = "Ativa o envio para ERP da previsão de custo no numerario!",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABDESPAUTODIFNFSE",
                        Descricao = "Habilita geração de despesa automaticamente ao autorizar nota fiscal de serviço",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HONORARIOBASEICMS",
                        Descricao = "Habilita função de somar o valor honorário na base de icms.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SIGVIGDESCRRESUMIDA",
                        Descricao = "Enviar a descrição resumida do produto ao invés da descrição para o SIGVIG",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIOLOTENFE",
                        Descricao = "Habilita o envio em lotes de NFe ao ERP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABPISCOFINSSEMCREDITO",
                        Descricao = "Habilita o envio do Pis Cofins sem direito a credito na nota fiscal",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_IMPRIMIRRELCALCULARIMPOSTOSDEV",
                        Descricao = "Imprimi a nova versão do relatório Calcular Impostos em DevExpress",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_IMPRIMIRRELCALCULARIMPOSTOSDEVPAGINA",
                        Descricao = "Aumenta o tamanho da primeira página no relatório Calcular Impostos em DevExpress",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABPAISTRANSPRODO",
                        Descricao = "Habilita o envio da bandeira do pais na DI de processos rodoviarios",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIANFCOMDESPESA",
                        Descricao = "Habilita o envio da própria NF Despesa sem o título",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIONFENTRADASENIOR",
                        Descricao = "Habilita o envio da invoice como Nf entrada para o Sênior",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVABAIXAPARCNUMERARIO",
                        Descricao = "Habilita a baixa parcial de títulos de numerário",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESPICMSANT",
                        Descricao = "Cria despesa de ICMS antecipado ao Calcular Impostos",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_IDENTIFICAIMPOSTOSDI",
                        Descricao = "Aplica identificação dos impostos da di não agrupados",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARINVERTENUMRECEBERSANKHYA",
                        Descricao = "Se ativado ao enviar um pagar de numerario, vai enviar um receber igual",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVAAUTOENVIOERPPREVISTO",
                        Descricao = "Controla o envio automático dos títulos ao ERP (0 - Não envia automaticamente, 1 - Envia automaticamente, 2 - Pergunta se deseja enviar ao salvar)",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZATITPREVISTOERP",
                        Descricao = "Atualiza a taxa moeda previsão dos titulos ao alterar o cadastro",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PERMITEFORNDIFERETE",
                        Descricao = "Permite a integração do pedido de compra com fornecedores diferentes",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZACAMPOERPAPI",
                        Descricao = "Ativa Atualização do pedido via api, após alterar campos de usuário ERP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIAPEDIDOALTERADOERP",
                        Descricao = "Envia o pedido para o ERP quando alterado",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIADATASALTERADASERP",
                        Descricao = "Envia o pedido para o ERP quando ETA e ETD forem alteradas",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESATIVADELETEADDITEMPEDIDO",
                        Descricao = "Desativa permissão de adicionar e remover item do pedido de compra",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESATIVARECALCULONFEERP",
                        Descricao = "Desativa recalculo da Nfe ao enviar para Senior",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_OBRIGAENVIOINVOICEANTESTITULOS",
                        Descricao = "Obriga enviar invoice antes dos titulos",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_IGNORARERROSENVIOERP",
                        Descricao = "Ignora erros de envio para ERP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_IMPRIMIRELFECHACAMBIODEV",
                        Descricao = "Imprimi a nova versão do relatório Fechamento de Câmbio em DevExpress",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESCRICAODIPEDIDOCOMPRA",
                        Descricao = "Utiliza o campo descricao completa Di ao gerar um processo a partir de um pedido de compra",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_EXPOITEMLME",
                        Descricao = "Ativa o controle de LME para preço da exportação",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_IMPRIMIRRELATORIOFECHAMENTODECAMBIOGERALDEV",
                        Descricao = "Imprimi a nova versão do relatório Fechamento De Cambio em DevExpress",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESATIVAATUALIZABAIXAERP",
                        Descricao = "Desativa atualização do titulo na baixa ERP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLDRECOLHIMENTOICMS",
                        Descricao = "Pasta de destino dos arquivos de Guia de Liberação e GARE.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLDNFEXMLEXPO",
                        Descricao = "Pasta de destino dos arquivos de xml integrados na exportação.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_VOLCONTAINERNOTA",
                        Descricao = "Define Peso bruto, liquido e volume o valor do container para a nota fiscal de exportacao.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZARTITULOSAOTAXA",
                        Descricao = "Atualizar titulos de invoice ao atualizar taxas da DI!",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ROOTGESTAOPARCEIRO",
                        Descricao = "Pasta raiz onde será gravado os arquivos da gestão de documentos PARCEIRO DE NEGÓCIO.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ROOTGESTAOAGENCCOTACAO",
                        Descricao = "Pasta raiz onde será gravado os arquivos da gestão de documentos AGENCIAMENTO COTAÇÃO.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ROOTGESTAOAGENCSOLCOTACAO",
                        Descricao = "Pasta raiz onde será gravado os arquivos da gestão de documentos AGENCIAMENTO SOLICITAÇÃO DE COTAÇÃO.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ROOTGESTAOAGENCPROPOSTA",
                        Descricao = "Pasta raiz onde será gravado os arquivos da gestão de documentos AGENCIAMENTO PROPOSTA.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ROOTGESTAOAGENCIAMENTO",
                        Descricao = "Pasta raiz onde será gravado os arquivos da gestão de documentos AGENCIAMENTO.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_REDUZBASECALCULONFE",
                        Descricao = "Aplica redução na base de calculo indiferente do CST informado",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_URLORIGEM_INTEGRACAOPROCESSO",
                        Descricao = "Url externa da aplicação para usar na integração de processos",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIAAPISANKHYA",
                        Descricao = "Envia para a API do Sankhya ou invés do muro.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABPARCEIRONEGOCIO",
                        Descricao = "Habilita parceiro de negócio",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITAFOLLOWUPRECCORE",
                        Descricao = "Habilita follow-up recorrete para entidades do core",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CALCULAMARKUPENCOMENDA",
                        Descricao = "Habilita o calculo de markup da encomenda",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESATIVARBAIXAESTORNOERP",
                        Descricao = "Desativa a Baixa/Estorno de titulos no ERP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARATEIOSEGUROFRETEINCLUSO",
                        Descricao = "Ativa o calculo do rateio do seguro com o frete incluso",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZARINVOICEPAGARCOMTAXADI",
                        Descricao = "Atualiza a taxa do titulo de invoice com a taxa de registro da DI",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZARPEDIDOVENDAERP",
                        Descricao = "Enviar a atualização do pedido de venda para o ERP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CONSULTARTITULOSERP",
                        Descricao = "Ativa a Consulta de atualização dos titulos do ERP para o Narwal",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_IMPRIMEUNIDADETRIB",
                        Descricao = "Imprime unidade tributária no lugar da unidade comercial na danfe",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVAR_RAZONETE_CRIAR",
                        Descricao = "Tipo de criação de razonete financeiro (0 - Na baixa do título, 1 - Na criação do título, 2 - Razonete operacional)",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 1,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SENIORDECIMAISPREUNINFE",
                        Descricao = "SENIOR: Informe a quantidade de decimais a enviar na NFE no campo preço unitário produto.",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 10,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIASENIORDESPESAFECHADA",
                        Descricao = "SENIOR: Envio da Nota de despesa fechada.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_NOTADESPESANATUREZA",
                        Descricao = "SENIOR: Envio da Nota de despesa controlada pela natureza da operação.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_MANTERORDEMDOARQUIVOASN",
                        Descricao = "Integrar arquivo Invoice mantendo a ordem das linhas do arquivo informado",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_MAXIMOITENSADICAOELI",
                        Descricao = "Número máximo de itens por adição da DI e por LI (Máximo 80)",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 80,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_IMPODESPCRIAFIN",
                        Descricao = "Habilita criação contas a pagar na Previsão de despesa da Importação",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FOLDDOCSDESPESAS",
                        Descricao = "Pasta de destino de documentos anexados às despesas de processo.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "DESPESAS",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ROOTGESTAOFINANCEIRO",
                        Descricao = "Pasta raiz onde será gravado os arquivos da gestão de documentos FINANCEIRO.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "MV_PRODDERAUTO",
                        Descricao = "Retorno do auto complete de Produto Derivação",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "Descricao",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_AGRUPARITEMNFEENVIOSENIOR",
                        Descricao = "Ativar agrupamento de itens da nfe ao enviar para SENIOR",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIASENIORPARCELADESPESA",
                        Descricao = "SENIOR: Envio de parcela da Nota de despesa .",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_BLOQUEARESTOQUENEGATIVO",
                        Descricao = "Bloquear movimentações que deixariam negativas as quantidades em estoque de algum produto",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PROINVCON",
                        Descricao = "Habilita filtro por invoice no lançamento de container do processo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_QUANTITEMDIVNFE",
                        Descricao = "Quantidade de itens utilizados para divisão da NFE",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 30,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TITULOSUBSTITUTO",
                        Descricao = "Substituir do título para o Sênior.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVACAMPOUSUITEM",
                        Descricao = "Ativa envio de campos do usuário do item da ordem de compra Sênior.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ROOTCEMERCANTE",
                        Descricao = "Pasta raiz onde será gravado os arquivos do CE mercante.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABARRASTARARQUIVO",
                        Descricao = "Habilita arrastar arquivos para narwal diretamente.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_COTACAOFRETEDEV",
                        Descricao = "Habilita a impressão da cotação de frete para DevExpress",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PROCEDENCIANOTA",
                        Descricao = "Informa o valor de procedência da nota de entrada Sênior (1 = Normal, 2 = Integração, 3 = Via Pedido, 4 = Automático, 5 = Cardio (Unimed)",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 1,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ROOTGESTAOCONTRATOVENDA",
                        Descricao = "Pasta raiz onde será gravado os arquivos da gestão de documentos CONTRATO VENDA.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIFORMAPAGRECRIARUPDATE",
                        Descricao = "Ativado irá recriar as formas de pagamento a cada atualização do pedido de compra",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZAPEDIDOCOMPRAERPSENIOR",
                        Descricao = "Ativa a atualização do pedido de compra no ERP Sênior.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_NOMEARTITULOSSENIOR",
                        Descricao = "Marque para colocar prefixos/sufixos nos títulos sênior quando forem enviados ao ERP.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PEDVENADDCON",
                        Descricao = "Desabilita no pedido de venda adicionar itens sem contrato de venda",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITAFUNCOESAGENCIAMENTO",
                        Descricao = "Habilita funções disponíveis apenas para rotinas de agenciamento",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITAEXPOCONTAINERPEDIDOVENDA",
                        Descricao = "Habilita utilizar itens do pedido de venda na exportação container",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITAAPROVACAOENVIOERP",
                        Descricao = "Habilita fluxo de aprovação para envio de contas a pagar ao ERP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITAMULTIMOEDANOTADESPESAEXPO",
                        Descricao = "Habilita o uso de multiplas moedas na nota fiscal despesa exportação.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CONTROLAESTOQUEPORPROCESSO",
                        Descricao = "Habilita o controle de custo e quantidade de estoque por processo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PROCESSONOVO",
                        Descricao = "Habilita a rotina nova de processo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FORCAESTADOESTRANGEIRO",
                        Descricao = "Usa 'EX' fixo na tag ufsCic do envio da nota ao sênior.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CUSTOPRODUTOAPICOMVARIACAMBIO",
                        Descricao = "Consulta o custo do produto na API aplicando a variação de câmbio.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARBAIXATITULOPREVISAOAOGERAREFETIVO",
                        Descricao = "Baixa o titulo de previsão ao gerar o efetivo.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARNUMERACAOAUTOMATICACONTASPAGAR",
                        Descricao = "Ativa numeração automatico contas pagar",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_REAGENDARPREVISAODESPESAENVIAUPDATEERP",
                        Descricao = "Reagendar previsão de despesa envia update ao invés de delete ao ERP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INICIOPERIODOFOLLOWUP",
                        Descricao = "Horário de início do período de envio de Follow's",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FIMPERIODOFOLLOWUP",
                        Descricao = "Horário de fim do período de envio de Follow's",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIOFINANCEIROAUTOMATICO",
                        Descricao = "Habilita o envio automático do título gerado a partir das parcelas da invoice ",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIASENIORDATAENTRADANOTADESPESA",
                        Descricao = "Configura o campo base utilizado para envio na entrada na nota tipo 8 no senior (0 - Data Emissão, 1 - Data de envio)",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_MODOCALCULODATAVENCIMENTO",
                        Descricao = "Modo padrão cálculo data de vencimento. (0 = Automático/1 = Manual)",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZAFORMAPAGTOAPI",
                        Descricao = "Permite atualizar a forma de pagamento pela API. Desabilitado quando o ERP é Sênior.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PREFIXOARQUIVOINTTRA",
                        Descricao = "Define o prefixo de filtro dos arquivos do inttra para integração",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "NARWA_IFTSTA_",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITAACCNAPARCELAANTINVOICE",
                        Descricao = "Habilita o adiantamento de contrato de câmbio para abater a parcela antecipada da invoice",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIOASYNCFINANCEIRO",
                        Descricao = "Habilita envio assincrono de titulos financeiros",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABIPDFANEXOFOLLOWREGISTRODESEMBDI",
                        Descricao = "Habilita o anexo do PDF nos Follow's enviados ao registrar ou desembara�ar uma DI",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PERMITELETRAMINUSCULAXMLDI",
                        Descricao = "Permite que o cliente gera a Di com a descrição da mercadoria em minusculo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CALCULASALDOPEDIDOVENDACONTAINER",
                        Descricao = "Faz o cálculo do saldo do pedido de venda pelos itens da expo vinculados em containers",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TENTASUBSTITUICAOTITULOSENIOR",
                        Descricao = "Ao enviar o titulo para o senior, tenta substituir primeiro caso ocorra algum erro continua com a rotina de enviar normalmente",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PERMITEINTEGRARNDJALLES",
                        Descricao = "Permite integrar titulos de nota fiscal despesa",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_UTILIZASEQNUMPARC",
                        Descricao = "Utiliza sequencial para títulos criados a partir de parcelas do numerário",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITAQUANTEMBCONTAINER",
                        Descricao = "Habilita o uso da quantidade de embalagem no container do processo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PROCESSAACCAUTOMATICAMENTE",
                        Descricao = "Processa o adiantamento de contrato de câmbio ao salvar a invoice ou o contrato",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITATOTALABATEADIINVOICE",
                        Descricao = "Habilita abatimento total do valor das parcelas de acordo com valor presente no adiantamento do contrato de câmbio",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITAENVIORATEIONOTAFISCALDESPESA",
                        Descricao = "Quando habilitado, faz rateio da nota fiscal de despesa pela nota importação para envio ao SAP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_UTILIZASEQINVPARC",
                        Descricao = "Utiliza sequencial para títulos criados a partir de parcelas da invoice",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ACCESSKEYNAMESAPB1",
                        Descricao = "Nome da coluna do SAPB1 que contem o id da nota",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESATIVARCANCELAMENTOTITULOS",
                        Descricao = "Desativa o Cancelamento de titulos NO NARWAL, Cancela no ERP e vem para o Narwal",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESATIVARESTORNOSTITULOS",
                        Descricao = "Desativa o Estorno de titulos NO NARWAL, Estorna no ERP e vem para o Narwal",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARRATEIOAREALINHAMATERIAL",
                        Descricao = "Ativa o rateio de titulos por area e linha/material",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESATIVAENVIOAPROVACAOREJEITACAOERP",
                        Descricao = "Ao ativar ele passara por uma validacao se pode enviar ou aprovar no ERP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_UPDSTATUSINTEGRAPEDCOMPAPI",
                        Descricao = "Permite atualização do campo de status da integração para 'Não enviado', no pedido de compra, ao atualizar ele por API",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESABILITACRIACONTAINERINTTRA",
                        Descricao = "Desabilita a criação automática de containers ao realizar a integração de um arquivo inttra",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_MANTERPESOLIQUIDOUNITARIOITEMXMLDI",
                        Descricao = "Mantém o peso líquido unitário informado no item do processo antes da integração do XML da DI",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIATUALIZACLIENTE",
                        Descricao = "Permitir que a API aceite atualizar os dados do cliente",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TOTVSENVIARREFDESPACHANTERECBTOIMPOFILHA",
                        Descricao = "Enviar campo referência despachante na integração de notas filhas do recbto de importação ao Totvs",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SALESPERSONCODESAPB1",
                        Descricao = "Enviar SalesPersonCode PARA SAP B1",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "1",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PESQUISARINVOICESEMVINCULOPROCESSO",
                        Descricao = "Permite pesquisar invoices que não possuam vínculos com processos na tela de Gestão de Câmbio",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITATITULODIFCOMPENSACAO",
                        Descricao = "Habilita a baixa de títulos para contas a receber de compensação sem adiantamento",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_MOEDAAPLICADAPTAXPARATAXADI",
                        Descricao = "Taxa da moeda aplicada da despesa do processo passa a pegar Taxa da DI ao invés da Ptax do dia",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVATAXAFECHAMENTOBAIXAMANUAL",
                        Descricao = "Ativa a taxa de fechamento ao executar uma baixa de título a pagar manual",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVAENVIONUMEXPOPEDVENDAERP",
                        Descricao = "Ativa o envio da numeração de exportações geradas a partir de pedidos de venda para o ERP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_UTILIZAFORMULAPARAMNFETRANSITO",
                        Descricao = "Utiliza formula da parametrzação da NFE no cálculo dos valores totais da nota de trânsito",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVAVARIACAOCAMBIALEXPO",
                        Descricao = "Ativa a variação cambial de exportação",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITASOMATORIOITENSAGENC",
                        Descricao = "Habilita somatório nas grids de itens para o agenciamento",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_UTILIZAPARCPAGAVARCAMB",
                        Descricao = "Utiliza apenas parcelas pagas para cálculo de variação cambial",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PERMITEATUALIZARVALORESCONTRATOCAMBIO",
                        Descricao = "Permite atualizar valores do contrato de cambio",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_LANCAMENTOFINACEIROPORCONTACONTABIL",
                        Descricao = "Habilita o lançamento financeiro para cada conta contábil em Contas a Pagar e Contas a Receber",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVAPARCELASPAGASADIANT",
                        Descricao = "Efetua o pagamento de todas as parcelas antecipadas da invoice, ao realizar adiantamento",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_OBRIGADATAENVIOIMPOSTO",
                        Descricao = "Obriga informar a data de emissão e a data de vencimento para geração dos títulos a partir do envio de impostos da DI",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_NFESAIDAENCOMENDAUNITARIO",
                        Descricao = "Habilita o valor unitario para notas de saída por encomenda",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_MAPEIACAMPOANALISTA",
                        Descricao = "Mapeia o campo analista do pedido para o campo analista do processo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PROJSANKHYAFIXO",
                        Descricao = "Envia código de projeto fixo nas integrações Sankhya",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FECHASEMPARCELA",
                        Descricao = "Considerar fechamento cambio sem vinculo com fechamento financeiro parcela",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESATIVAEMVIOAUTOMATICOERP",
                        Descricao = "Quando marcado ele não enviara titulo para erp ao salvar pedido ou com a integração",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_LORENPEDIDO",
                        Descricao = "Quando ativado filtra apenas pedido de compra vinculado no contas a pagar",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESADOCCLIENTE",
                        Descricao = "Quando habilitado documento nasce desmarcado a visualização do cliente",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITADESPESASTRANSPORTES",
                        Descricao = "Habilita o lançamento de despesas, na aba Transporte, por containers e de serviços que não dependem de containers",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_USARFOMASPAGAMENTOPEDIDONAINVOICE",
                        Descricao = "Usar forma pagamento dos pedidos de compra vinculado ao processo ao gerar invoice",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESABEDITPRECOPRODPC",
                        Descricao = "Desabilita a edição da coluna Preço, em Produtos, dentro de Pedido de compra. Valor será definido pelo ERP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITAFORMULACALCULOSEGURO",
                        Descricao = "Habilita preenchimento automatico do campo Fórmula calculo seguro do processo, de acordo com o que está prenchido no 1° produto do processo.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_UNMEDIMPSENIOR",
                        Descricao = "Utiliza Unidade de Medida do Estoque ou Unidade de Medida do Fornecedor para Pedido de Compra que vem do Senior",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CONSDESCCOMPLETA",
                        Descricao = "Quando flegada vai considerar a descrição completo do produto na index de lote",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIOVENCIMENTOINFERIORHOJE",
                        Descricao = "Permite o envio de títulos com data de vencimento inferior a data atual",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DIFERENCAIMPRETIFICACAO",
                        Descricao = "Efetua o calculo da diferença dos impostos entre um numerário já existente",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_COMECACOMPEDIDODEVENDA",
                        Descricao = "Pesquisa o número do Pedido de Compra com *começa com* ao invés da forma padrão",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_OPCOESPADRAOINTEGRARXMLLI",
                        Descricao = "Define quais as opções serão trazidas por padrão na integração do XML da LI",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_UTILIZAMARINETRAFFICAPI",
                        Descricao = "Habilita o uso do marine traffic para consulta das posições dos navios(UTILIZAR SOMENTE POR MEIO DE AUTORIZACAO)",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ORACLEVERSION12",
                        Descricao = "Quando ativada ao invez de usar Offset ele usara rownum",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_GRAVAVALORCUSTOMEDIOPROD",
                        Descricao = "Permite gravar o Valor do Custo Médio em Previsão de Custo do produto ao usar o botão da previsão de custo em Processo > Numerário",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENCERRAITEMPC",
                        Descricao = "Habilita a opção no usuário para permitir encerramento do item do pedido de compra.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITADESCACRESCIMOPC",
                        Descricao = "Habilita cálculo de preço baseado no preço original, acrescimos e descontos, no item do pedido de compra",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_BLOQUEIAMOEDAPC",
                        Descricao = "Bloqueia a moeda da mercadoria quando o item do processo e o item da invoice tem pedido de compra atrelado",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIORATEIOPRODUTOLOTE",
                        Descricao = "Enviar entrada de titulos em lote com rateios do cadastro de produto invoiceParcela Contas a Pagar Senior",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_EXCLUIOSITENSDOPEDIDODEVENDA",
                        Descricao = "Quando desvinculado um determinado item do processo(expo), todos os itens desse mesmo pedido de venda que estiverem vinculados, também devem ser excluídos.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESABANEXOFOLLOWUPLIDEFERIMENTO",
                        Descricao = "Desabilita o envio de anexo para Follow Up de LI deferida",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESABCALCULOEMBALAGEM",
                        Descricao = "Desabilita o cálculo de Quantidade de Embalagens ao gerar um processo a partir de um pedido de compra",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIOEMAILERROAPI",
                        Descricao = "Enviar e-mail para suporte quando houver algum problema na integração via API",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CONSIDERATOLERANCIAPRODUTO",
                        Descricao = "Considera fazer o cálculo do saldo do Pedido de Compra e de Venda na forma de porcentagem de tolerância sobre o total (O campo Considera Tolerância do Produto tem influência nesta variável)",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_GRAVAPEDCOMPRAITEMFULL",
                        Descricao = "Atualizar itens do pedido de compra sem validar data de encerramento",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESCONSIDERAQUANTPRECO",
                        Descricao = "Ao ativar mesmo que com DI registrada deixara modificar quantidade e preço do item",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TAXCODESAPB1NFFDESPESA",
                        Descricao = "TaxCode referente integração SAP B1 - Nota Fiscal de Despesa",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ADIANTAMENTOFORMAPAGAMENTO",
                        Descricao = "Habilita geração de titulos de previsão do pedido de compra pelas parcelas da forma de pagamento",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CALCULAARMAZENAGEMPROCESSOS",
                        Descricao = "Calcula o custo de armazenagem dos processos em aberto",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CONSIDERADATANFOUFRETENACIONAL",
                        Descricao = "Determina qual data será utilizada entre da nota fiscal ou do frete nacional.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESCONTOFINANCEIROARQUEACAO",
                        Descricao = "Sinaliza que o cliente utiliza desconto financeiro nas invoices em processos com arqueação",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TITULOMANTERHISTORICO",
                        Descricao = "Manter historico padrao de titulos alterados",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESPESAUSAFRETEPREPAID",
                        Descricao = "Gerar despesas de frete com base no frete pre-paid quando o frete estiver zerado",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PERCENTUALAFRMM",
                        Descricao = "Alíquota do AFRMM (Marinha mercante) - (valor em %)",
                        Tipo = Enums.TipoVariavel.Double,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 25,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_IMPORTADORPROPRIOUSACONFIGTIPODESPESA",
                        Descricao = "Sinaliza que o cliente importador próprio, utiliza as configurações de pago por da aba DI/DA no numerário.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TAMANHOLOTESANKHYA",
                        Descricao = "Tamanho máximo de lotes de produtos no Sankhya ",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = @"",
                        ValorInt = 11,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_AZUREADLOGIN",
                        Descricao = "Valor token microsoft no login via AzureAD.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "preferred_username",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESABILITAENVCANCEAUTOMATICENVICANCENFE",
                        Descricao = "Desabilita o envio e cancelamento do titulo ao enviar ou cancelar a nfe",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ESTRUTURADEENVIOTOTVS",
                        Descricao = "TOTVS: Quando habilitado vai enviar pela estrutura 'Https'",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIAOUTROSIMPSANKHYA",
                        Descricao = "SANKHYA: Envia dados do II por itens para tabela TGFIMN, adicionando o valor no Total da nota",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIADADOSFATURASANKHYA",
                        Descricao = "Envia dados da fatura para o Sankhya nos campos Personalizados",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TENANTID",
                        Descricao = "TenantId da base do cliente",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TAXAUTILZACAOMERCANTE",
                        Descricao = "Permite atualizar a taxa de utilização mercante",
                        Tipo = Enums.TipoVariavel.Double,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 21.20,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TEMPOCONTABILIZACAO",
                        Descricao = "Define o tempo em segundo que leva a contabilização para cada nota",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 180,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITAENVIORATEIONOTAFISCALDESPESAVIASAPDIAPI",
                        Descricao = "SAP: Habilita envio de Nota Fiscal de Despesa diretamente via DI-API sem intermedio de parceiros terceiros",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVOPERFINANESPECIFICADASANKHYA",
                        Descricao = "Sankhya: Quando ativo, os campos: CODCTABCOINT, NUMNOTA, DTNEG e DTVENC serão enviados conforme operação financeira",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_OBRIGAPEDIDODECOMPRACONTRATO",
                        Descricao = "Quando ativada o Contrato de cambio obriga informar um pedido.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_USUARIOJOBNOVOCOMEX",
                        Descricao = "Usuário para autenticação do novo Comex",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SENHAJOBNOVOCOMEX",
                        Descricao = "Senha para autenticação do novo Comex",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_NOVOCOMEX",
                        Descricao = "Habilita ou desabilita o uso do Novo Comex",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_URLAPINOVOCOMEX",
                        Descricao = "Url da API do Novo Comex",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_URLUINOVOCOMEX",
                        Descricao = "Url da Interface do Novo Comex",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TENANTNAME",
                        Descricao = "TenantName a ser usado para acessar o Novo Comex",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATTPROCESSOEXPOAUTO",
                        Descricao = "Atualizar o processo de exportação conforme a mudança no pedido de venda.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ADICIONAIINADESPESAADUANEIRASANKHYA",
                        Descricao = "Sankhya - S - Soma o II nas despesas Aduaneiras N - Envia somente o valor de Outros como Despesa Aduaneira",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_RELATORIOCUSTOMIZADOREPXOLD",
                        Descricao = "Permite importar um relatório do formato repx na rotina de gestão de relatórios.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVAPARCELASPAGASADIANTEXPO",
                        Descricao = "Efetua o pagamento de todas as parcelas antecipadas da exportação, ao realizar adiantamento",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_OBSERVACAOINFFISCOSANKHYA",
                        Descricao = "Sankhya - S - Envia Informações Adicionais do Fisco para o Campo Observação. N - Envia informações Complementares (Default)",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TIPOFRETESANKHYA",
                        Descricao = "Sankhya - S - Envia 0 para CIF e 1 FOB - Quando 1, 2, 3, 4 e 9. N - Mantém Padrão",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PESOLIQMANUALSANKHYA",
                        Descricao = "Sankhya - S - Envia a tag PESOLIQUIMANUAL. N - Não envia a Tag",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_MODALIDADEIMPORTACAOSANKHYA",
                        Descricao = "Sankhya - S - Envia a modalidade de importação. N - Mantém padrão (não envia a modalidade de importação)",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITACRIACAOTITULOSEMPEDIDOVENDA",
                        Descricao = "Quando habilitada criará o tilulo mesmo que não há pedido de venda",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_IMPORTADOREDESPACHENTEPARAOPROCESSO",
                        Descricao = "Quando preenchida pega o valor para preencher o importador e despachante na criação do processo(primeiro chave do importado depois despachante separado por virgula)",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_MICROSOFTCLARITYID",
                        Descricao = "Id da configuração do Microsoft Clarity",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIALOTERATEIOSENIORPAGAR",
                        Descricao = "Enviar entrada de titulos em lote utilizando método de rateio - Contas a Pagar Senior",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVAATUALIZACAOFATURAERP",
                        Descricao = "Senior: Quando ativo envia atualização da fatura para o Senior Piccadilly",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CONSIDERASISCOMEXEMB",
                        Descricao = "Quando habilitada considera campo SISCOMEX na embalagem ao invés da Chave quando integra DI",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_UTILIZACALCULOENTRADA",
                        Descricao = "Utiliza base de cálculo da nota fiscal de entrada para a geração da nota fiscal de saída",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INTEGRANFEVIASENIOR",
                        Descricao = "Habilita a integração de xml de Nf-e diretamente do ERP da Senior",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIADUESENIOR",
                        Descricao = "Quando habilitada envia a DU-E para o Senior",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIATAXACONTRATODECAMBIO",
                        Descricao = "Enviar via webservice o valor da taxa da moeda para o ERP - Senior",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIKEYMARINETRAFFIC",
                        Descricao = "Chave da API utilizada para consulta do Marine Traffic",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ALLOGCRITERIA",
                        Descricao = "Allog: Criterio de seleção de processos 1 - Por processo, 2 - Referencia Adquirente(NumeroPO)",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 1,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_URLAPISALESFORCEPENVIAROPOSTA",
                        Descricao = "Url da API Proposta Sales Force",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZAETDETDTXT",
                        Descricao = "Preencher Data ETD e ETA do Processo apos Integrar TXT de arquivos despachante",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 1,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_UTILIZAPTAXCOMPRANFE",
                        Descricao = "Quando ativado considera o valor da TaxaPtaxCompra para emissão de nota fiscal",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 1,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESCONSIDERACSTIPISENIOR",
                        Descricao = "Senior: Quando ativa, ao enviar a nota fiscal ao senior desconsidera CSTIPI",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARMOCKEMDEBUGENVIARCONSULTARLI",
                        Descricao = "Quando ativa não faz consultas diretamente ao siscomex na rotina de LI em modo de DEBUG",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 1,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_VALIDAREGRASDECEXLISUB",
                        Descricao = "Quando ativado valida regras de campos de acordo com Decex",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 1,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIAUNIMEDSENIOR",
                        Descricao = "Quando desativada envia NULO no campo UniMed no XML da Nfe quando o ERP é Senior",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CLIENTECOMPRADOREXPO",
                        Descricao = "Quando ativa preenche automaticamente o campo Comprador quando o campo Cliente for preenchido na aba Dados Cadastrais do Processo de Exportação",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_MANIPULAMOCLI",
                        Descricao = "1 Vai deferir a LI em modo debuger, 2 Cancela Li, outros numeros o status volta aleatorio",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 100,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARMOCKEMDEBUGENVIARREGISTRODI",
                        Descricao = "Quando ativa não registra de fato a DI apenas simula resultados em modo de DEBUG",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 1,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_MANIPULAMOCDI",
                        Descricao = "1 Vai registrar a DI em modo debuger, 2 Cancela DI, outros numeros o status volta aleatorio",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 100,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "MV_TAMTITIOPEPAGIMP",
                        Descricao = "Tamanho do campo Numero do título na tela de Operação de pagamento de importação",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 10,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_OPEPAGIMPTITAUT",
                        Descricao = "Faz com que o campo titulo da tela Operação de pagamento de importação seja preenchido automaticamente ao digitar o número do contrato.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIAPEDEITEMPEDNFE",
                        Descricao = "Habilita envio numero pedido compra e pedido compra item nas tags xPed e nItemPed ao enviar ERP(Senior) ou SEFAZ",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PARAMETRIZAONUMERARIO",
                        Descricao = "Aplica a parametrização da NF-e no calculo do Numerário",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZARATRIBUTOSNCM_NARWALDADOS",
                        Descricao = "Ativar o Job que integra/atualiza os atributos de Ncm's do Narwal Dados",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZAPARAMETRIZACAOCSTIPICSTICMSINTEGRANFE",
                        Descricao = "Atualiza CST ICMS e CST IPI pela parametrização ao integrar NFE de terceiros",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PARAMETRIZADOVLROICVLROICNFE",
                        Descricao = "Retorna tags VlrOic e VlrOic de acordo com o CST de IPI e CST ICMS da parametrizacao da Nota Fiscal.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ROOTGESTAOATOCONCINTEGRADO",
                        Descricao = "Pasta raiz onde será gravado os arquivos da gestão de documentos Ato Conscessório Integrado Suspensão.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ROOTGESTAOATOCONCINTEGRADOISENCAO",
                        Descricao = "Pasta raiz onde será gravado os arquivos da gestão de documentos Ato Conscessório Integrado Isenção.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CANCELAPREVISIONAMENTONOENVIONFE",
                        Descricao = "Realiza a exclusão dos títulos previsto do numerário ao Enviar a nota fiscal para o ERP",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_COFINSMAJORADOSENIOR",
                        Descricao = "Quando ativada não envia a majoração do cofins para o Senior.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_RATEIOPROCESSODEDUCAO",
                        Descricao = "Quando possuir uma DI com dedução de valores,definir se o rateio da dedução será por: Valor = 0, Peso = 1 ou CIF = 2.",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ORDEMRECEBIMENTOADTEXPO",
                        Descricao = "Quando ativa gera a Ordem de Recebimento do tipo adiantamento pela Exportação Parcela",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PERIODOLIMPAARQUIVOSLOG",
                        Descricao = "Período em mês em que deve ocorrer a limpeza dos arquivos de logs",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 1,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DATAETAMARINETRAFFIC",
                        Descricao = "Caso habilitado a data eta do navio vai pegar do campo Reported ETA",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PERMITEALTERARQTDALI",
                        Descricao = "Quando ativa permite alterar a quantidade do Processo, mesmo que já tenha LI vinculada.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITAVERSAOBETA",
                        Descricao = "Quando ativa permite atualizar sistema para versão beta também",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZARTAXAMULTAJUROS",
                        Descricao = "Quando ativa atualiza a Taxa Multa Juros diretamente do banco central",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_VALIDAQTDDISPFORNEC",
                        Descricao = "Quando ativa valida saldo do item pedido pelo saldo quantidade fornecedor",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIAVLROICICMSDIFERIDO",
                        Descricao = "Quando ativa enviará o valor ICMS no campo vlroic para o Senior quando tiver ICMS Diferido/Suspenso",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESEJASAIRLIDI",
                        Descricao = "Ao clicar no voltar da tela de LI e DI, pergunta se deseja realmente voltar/sair da tela. E ao fechar a tela de Li também pergunta.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESOBRIGAFATORCONVERSAO",
                        Descricao = "Quando ativo, desobriga informar o campo de fator de Valor fator de conversão da rotina de Conversão Unidade de Medida.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_EXIBERECEITATRIBUTARIADI",
                        Descricao = "Autocomplete Receita Tributária (Chave, Codigo, Descricao, CodigoDescricao)",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "Codigo",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_VALIDAANUENCIAPC",
                        Descricao = "Quando ativa validará a anuência do item no pedido de compra",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_NAOALTERAITEMINTEGRADI",
                        Descricao = "Não altera itens do processo na integração do xml da DI",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIATUALIZAESTADOFORNECEDOR",
                        Descricao = "Permitir que a API aceite atualizar os dados do Estado do Fornecedor",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_USAUNIDADEDOPCPARAEMISSAONF",
                        Descricao = "Utiliza quantidade e unidade de medida do pedido de compra para gerar nota fiscal",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_VALIDATOTALPEDIDONOCONTRATO",
                        Descricao = "Quando a variável estiver habilitada ao criar um novo contrato como adiantamento valida se o valor do contrato excede o saldo de contratos já vinculados a esse pedido de compra",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_EXLUIPREVDESPIMPNUMERARIO",
                        Descricao = "Quando ativa Excluir titulos previstos de invoice e despesas na geração de parcelas do numerário",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DESATIVAPREFIXOINVCONTASPAGAR",
                        Descricao = "Remover prefixo INV dos titulos de Invoice quando criado no Contas a Pagar",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PERMITEALTERARFRETECOLLECT",
                        Descricao = "Quando ativa permite alterar o valor do frete collect ao integrar arquivo despachante",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_REGRANUMEROPROJETOSANKHYA",
                        Descricao = "Opções de como enviar o código projeto com ERP Sankhya. 0 - Não envia, 1 - Número Processo, 2 - Número Projeto, 3 - Fixo da variável de ambiente NWL_PROJSANKHYAFIXO",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SOBRERESCREVERIMPOSTOSDIRETIFICADAAOINTEGRAR",
                        Descricao = "Sobreescrever os principais impostos de II, IPI, PIS e COFINS da DI ao calcular impostos de uma di Retificada",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_EXLUIPREVDESPNFDESPESA",
                        Descricao = "Quando ativada irá excluir os títulos de numerario quando gerado uma nota fiscal de despesa e o fornecedorId da nota fiscal de despesa for igual ao fornecedorId do Numerario Parcela",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVABAIXAPARCNUMERARIOEXPO",
                        Descricao = "Habilita a baixa parcial de títulos de numerário expo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_VLRFINSOMENTENOTATERCEIROSERPSENIOR",
                        Descricao = "Nfe Sênior, somente envia valor na tag VlrFin se NF-e for emitida por terceiros.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_QTDDEIMALVLRUNITSANKHYA",
                        Descricao = "Quantidade de casas decimais no campo VLRUNIT do sankya",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 6,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_SENIORENVIAORDEMCOMPRAFILHA",
                        Descricao = "Invoice retorna ao ERP com dados para criação de uma Ordem de Compra Filha.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_NATUREZAOPERACAOPADRAO",
                        Descricao = "Preencherá automaticamente a natureza de operação na nota fiscal de despesa conforme código da natureza informado no campo valor",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_QTDDEEMBADOPEDIDOVENDA",
                        Descricao = "Considera a quantidade de embalagem no Processo (expo) conforme informado no Pedido de Venda",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_UTILIZACCT",
                        Descricao = "Habilita a consulta de processos no CCT",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_URLGETCCT",
                        Descricao = "Link da url para fazer a consulta do CCT",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "https://val.portalunico.siscomex.gov.br/ccta/api/ext/conhecimentos",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_URLGETVIAGEMMANIFESTO",
                        Descricao = "Link da url para fazer a consulta de viagem",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "https://val.portalunico.siscomex.gov.br/ccta/api/ext/viagens",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIODADOSIPICMSPORCSTERPSENIOR",
                        Descricao = "Envio de dados IPI/ICMS de acordo com CST de retenção/supensão/deferimento/aliquitazero",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FILTRAPARAMETRIZACAONFINTEGRADO",
                        Descricao = "Quando ativada o campo Parametrização NF Listará somente as do cliente integrado.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIAIMPOSTOSDIDUIMPAUTOMATICAMENTE",
                        Descricao = "Quando ativada ao registrar a DI/DUIMP no SISCOMEX serão criados automaticamente os títulos de impostos e enviados ao ERP.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_URLPOWERBIBECOMEX",
                        Descricao = "Link da url becomex para utilizar o PowerBI",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "https://demo-beconnect-api.becomex.com.br/",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CLIENTIDPOWERBIBECOMEX",
                        Descricao = "ClienteId para utilizar o PowerBI Becomex",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "ext-narwal-dev-svc",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIKEYDARE",
                        Descricao = "Api-Key utilizada para acesso e permissão à API da DARE",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DIASEXPBID",
                        Descricao = "Dias para expiracao do Bid de Fornecedor",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 1,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_USASHIPSTRACKING",
                        Descricao = "Usar integração com ShipsTracking para consultar a posição dos navios do processo. 0 - Nenhum; 1 - ShipsGo; 2 - LogComex",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIKEYSHIPSTRACKING",
                        Descricao = "Token de acesso a API de do site ShipsTracking",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "QafO5tMLV9JrrSk557LWs07WOrFVWYOd2jMIlxz8",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIURLSHIPSTRACKING",
                        Descricao = "Url da API do site ShipsTracking",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "https://api-prd-logmanager.logcomex.io",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVAREGRAIMPOSTO",
                        Descricao = "Habilita os impostos serem calculados conforme regras de impostos cadastradas",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INVOICEEXPO",
                        Descricao = "Habilita criação de Invoice para Exportação",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_FRASESPENDENCIAFRETESICOMEX",
                        Descricao = "Frases de pendência de frete do siscomex (SEPARAR-LAS POR ;)",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "NÃO HÁ PENDÊNCIA.;Não existe histórico de pendência de frete para o ce mercante informado.;",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITAPROCESSAMENTOCONTRATOCOMISSAO",
                        Descricao = "Habilita processamento contrato comissão via expo ou impo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CAMPODESCRICAONOTAFISCAL",
                        Descricao = "Configuração da tag infAdProd e xProd, caso for 1 informa Descrição do produto e Descrição completa da DI, caso for 2 não informa a taf infAdProd e informa a tag xProd com Descrição do produto, caso for 3 não informa tag infAdProd e informa a tag xProd com Descrição completa DI",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 1,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVACONSULTASHIPSTRACKINGAUTOMATICA",
                        Descricao = "Habilita ou desabilta o botão Consulta Ships Tracking no Processo IMPO e EXPO e se a criação do Embarque na Logcomex será automático ou por ação do usuário",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITABLOQUEIOUSUARIO",
                        Descricao = "Habilita bloqueio de usuário quando acessando mesma tela",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITASOFTLOCK",
                        Descricao = "Habilita rotina de comparação ao salvar processo para salvar somente valores alterados para evitar problemas com alteração nos jobs",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATUALIZATTCE",
                        Descricao = "Habilita rotina de atualização dos tratamentos tributários",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ALERTASDUE",
                        Descricao = "Habilita tag para termo de ciência de alerta não impeditivo ao registrar a DU-e",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_GESTAODOCSEXTENSAO",
                        Descricao = "Extensões de arquivos permitidas na gestão de documentos separadas por \";\".",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = ".pdf;.txt;.xlsx;.xls;.csv;.doc;.docx;.jpg;.gif;.png;.xml;.json;",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_INTERVALOJOBATUALIZAPOSICAONAVIOSHIPSGOJOB",
                        Descricao = "Define o intervalo de tempo em que o job AtualizaPosicaoNavioShipsGoJob sera executado.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "0 */12 * * *",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_VERIFICARFALHASPUCOMEX",
                        Descricao = "Define o intervalo de tempo em que o job ProcessaFalhasPucomexRecurringJob sera executado.",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "*/30 * * * *",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARJOBATUALIZAVALORESTOQUEDIARIO",
                        Descricao = "Ativar a execução do job de atualização de valor estoque diário",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITABLOQUEIOUSUARIO",
                        Descricao = "Habilita bloqueio de usuário quando acessando mesma tela",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITASOFTLOCK",
                        Descricao = "Habilita rotina de comparação ao salvar processo para salvar somente valores alterados para evitar problemas com alteração nos jobs",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ALERTASDUE",
                        Descricao = "Habilita tag para termo de ciência de alerta não impeditivo ao registrar a DU-e",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ATIVARJOBGNRERECEITA",
                        Descricao = "Ativar a execução do job de gnre receita",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIATUALIZAFILIAL",
                        Descricao = "Permitir que a API aceite atualizar os dados da filial",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIATUALIZAFABRICANTE",
                        Descricao = "Permitir que a API aceite atualizar os dados do fabricante",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIATUALIZAVENDEDOR",
                        Descricao = "Permitir que a API aceite atualizar os dados do vendedor",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIATUALIZAFORMAPAGAMENTO",
                        Descricao = "Permitir que a API aceite atualizar os dados da forma de pagamento",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIATUALIZAINCOTERM",
                        Descricao = "Permitir que a API aceite atualizar os dados do incoterm",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIATUALIZAMOEDAMERCADORIA",
                        Descricao = "Permitir que a API aceite atualizar os dados da moeda",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIATUALIZAVIATRANSPORTE",
                        Descricao = "Permitir que a API aceite atualizar os dados da via transporte",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIATUALIZAEMBALAGEM",
                        Descricao = "Permitir que a API aceite atualizar os dados da embalagem",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIATUALIZAORIGEMDESTINO",
                        Descricao = "Permitir que a API aceite atualizar os dados da origem e destino",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APIATUALIZAEMBALAGEMDIMENSAO",
                        Descricao = "Permitir que a API aceite atualizar os dados da dimensão da embalagem",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_URLLOGINBECOMEX",
                        Descricao = "URL login becomex",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "https://login.becomex.com.br/",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PREPARACAOLANCAMENTOCR",
                        Descricao = "Envia lancamento de preparacao contas Receber - Senior (S/N)",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PORTACR",
                        Descricao = "Porta Senior para Contas Receber (PORTACR = 0 / PORTACR2 = 1)",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_CONCILIACAOPORWSDL",
                        Descricao = "Utiliza Web Service Sênior para realizar conciliação",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = false
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITADESPESAINTERNACIONAL",
                        Descricao = "Permite informar a taxa de conversão para a moeda desejada nas despesas",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_URLEXTAPI",
                        Descricao = "URL padrão do ambiente próprio de API, exemplo: https://exemploapi.narwalsistemas.com.br",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITAR_DIANA",
                        Descricao = "Habilitar o uso da DIANA",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = null,
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_LIMITE_GERACAO_PLANILHA_DIANA",
                        Descricao = "Limite de itens para ser preenchidos em pela DIANA",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 1500,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_DUIMP_CALCULO_PARALELO_QUANTIA",
                        Descricao = "Número máximo de cálculos paralelos que pode ser feito para calcular os itens da DUIMP",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 50,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIANFAPITOTVS",
                        Descricao = "Quando o ERP for Totvs e essa variavel estiver ativa, ao enviar a nota fiscal ao ERP, ela ficará disponivel na api nfe/consultarpendentes e não irá mais pela Crosscutting",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_ENVIADESPESASADUANEIRASSEMPISECOFINS",
                        Descricao = "Sankhya - S - Envia VLRDESTAQUE sem o Pis e Cofins - N - Envia com o PIS e Cofins no VLRDESTAQUE (Default)",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_GATEWAYSANKHYA",
                        Descricao = "Sankhya com GateWay (S/N)",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_TOKENGATEWAY",
                        Descricao = "Token GateWay do Cliente",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_APPKEYGATEWAY",
                        Descricao = "Token APP Key Gate Way Narwal",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITARIA",
                        Descricao = "Habilitar o uso da IA para geração de invoice",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PERMITEUSARDESPESANOVAMENTE",
                        Descricao = "Permite usar despesa mais de uma vez na nota fiscal de despesa",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = VariavelAmbienteConst.NWL_APIKEYSHIPSGOAIR,
                        Descricao = "Token de acesso a API de do site ShipsGo aéreo",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = VariavelAmbienteConst.NWL_ENVIACAMPOSESPECIFICOSNFEQUALIMPOR,
                        Descricao = "Envia campos especificos para NFE Sankhya Qualimpor",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = VariavelAmbienteConst.NWL_ALIQUOTAMAJORACOFINS,
                        Descricao = "Variável responsável por definir com qual alíquota começará a ser calculada a majoração do COFINS",
                        Tipo = Enums.TipoVariavel.Double,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 10.45,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = VariavelAmbienteConst.NWL_MAJORACAOCOFINS,
                        Descricao = "Variável responsável por definir qual é a alíquota de majoração do COFINS",
                        Tipo = Enums.TipoVariavel.Double,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0.8,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_PERCENTUALPORCENTROCUSTO",
                        Descricao = "Permite inserir mais de um centro de custo por item.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITARATEIOITEM",
                        Descricao =
                            "Habilita a escolha de em quais itens o valor da despesa será rateado, no momento do lançamento da despesa. Variável não deve ser ativa para uso de filiais do Brasil.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = "NWL_HABILITABOARDTELAINICIAL",
                        Descricao = "Habilita a tela inicial com boards do processo.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = VariavelAmbienteConst.NWL_CALCULOCREDITOPRESUMIDO,
                        Descricao = "Fórmula para os campos pCredPresumido e vCredPresumido:  0 = Nenhum;  1 = pCredPresumido: TaxaIcms, vCredPresumido: ValorIcms ;  2 = pCredPresumido: Percentual crédito presumido, vCredPresumido: ValorIcms x Percentual crédito presumido;  3 = pCredPresumido: Diferença entre TaxaIcms e Percentual crédito presumido, vCredPresumido: Diferença entre Icms e Valor crédito presumido.",
                        Tipo = Enums.TipoVariavel.Int,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = VariavelAmbienteConst.NWL_CLIENTEPORTALLOGISTICA,
                        Descricao = "Indica se o cliente utiliza o novo serviço de portal de logística. Essa variável mudará o compartamento da tela de cotação de frete e também do seu atalho na tela de processo",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = VariavelAmbienteConst.NWL_NOVOPORTALLOGISTICAURL,
                        Descricao = "URL base (com https://) para o novo sistema de portal logística. Não possuí barra (/) no final",
                        Tipo = Enums.TipoVariavel.String,
                        ValorChar = null,
                        ValorString = "https://portal-logistica.narwalsistemas.com.br",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = VariavelAmbienteConst.NWL_ADICIONA_DESPESA_BL_IA,
                        Descricao = "Habilita a funcionalidade onde a Inteligência Artificial pode incluir ou modificar as despesas associadas ao processo.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = VariavelAmbienteConst.NWL_HABILITA_CONFIG_PARAMETRIZACAO,
                        Descricao = "Quando ativa considera configurações da Parametrização NF para os cálculos, centralizando as informações de filial e cliente",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = VariavelAmbienteConst.NWL_HABILITAIMPORTARARQPROCESSO,
                        Descricao = "Habilita botão tela de processos para permitir importar arquivos para geração automática de processos.",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = VariavelAmbienteConst.NWL_LPVALTOTALPEDIDOCOMPRA,
                        Descricao = "(Loading Plan) Valor total máximo permitido para geração do processo.",
                        Tipo = Enums.TipoVariavel.Double,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = VariavelAmbienteConst.NWL_LPPERCMAXQTDTOTALPEDIDOCOMPRA,
                        Descricao = "(Loading Plan) Percentual máximo de variação em relação a quantidade do pedido de compra.",
                        Tipo = Enums.TipoVariavel.Double,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = VariavelAmbienteConst.NWL_LPPERCMAXCOMISSAO,
                        Descricao = "(Loading Plan) Percentual máximo de acréscimo de comissão ao preço unitário do pedido.",
                        Tipo = Enums.TipoVariavel.Double,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = VariavelAmbienteConst.NWL_ENVIATGFEST,
                        Descricao = "Ao enviar a NF para o Sankhya, também integra informações na TGFEST - Estoque",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = true,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    },
                    new VariavelAmbiente
                    {
                        NomeVariavel = VariavelAmbienteConst.NWL_VLRFINIGUALVALORLIQSENIOR,
                        Descricao = "Sênior - Valor financeiro igual ao valor Líquido nos itens para integração da nota ?",
                        Tipo = Enums.TipoVariavel.Bool,
                        ValorChar = null,
                        ValorString = "",
                        ValorInt = 0,
                        ValorDouble = 0,
                        ValorBool = false,
                        ValorDateTime = DateTime.MinValue,
                        Ativo = true
                    }
                };

                var nomesExistentes = new HashSet<string>(
                    context.VariavelAmbientes.Select(x => x.NomeVariavel.Trim())
                );

                var novasVariaveis = variavelAmbientes
                    .Where(x => !nomesExistentes.Contains(x.NomeVariavel.Trim()))
                    .ToList();

                if (novasVariaveis.Count > 0)
                {
                    context.VariavelAmbientes.AddRange(novasVariaveis);
                }

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                ex.WriteError("VariavelAmbienteSeeder");
            }
        }
    }
}