using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Tombamento.Relatorio.Models
{


    public class Divergencia
    {
        public int TotalErro { get; set; }
        public string Coluna { get; set; }
        public int? TotalContrato { get; set; }
    }


    public class ColunaDivergente
    {
        public int Id { get; set; }
        public int Indice { get; set; }
        public string Contrato { get; set; }
    }

    public class Finaceiro
    {
        public Finaceiro()
        {
            this.DivergenciaFinanceiro = new HashSet<ColunaDivergente>();
        }

        public int Id { get; set; }
        public string C0 { get; set; }
        public string C1 { get; set; }
        public string C2 { get; set; }
        public string C3 { get; set; }
        public string C4 { get; set; }
        public string C5 { get; set; }
        public string C6 { get; set; }
        public string C7 { get; set; }
        public string C8 { get; set; }
        public string C9 { get; set; }
        public string C10 { get; set; }
        public string C11 { get; set; }
        public string C12 { get; set; }
        public string C13 { get; set; }
        public string C14 { get; set; }
        public string C15 { get; set; }
        public string C16 { get; set; }
        public string C17 { get; set; }
        public string C18 { get; set; }
        public string C19 { get; set; }
        public string C20 { get; set; }
        public string C21 { get; set; }
        public string C22 { get; set; }
        public string C23 { get; set; }
        public string C24 { get; set; }
        public string C25 { get; set; }
        public string C26 { get; set; }
        public string C27 { get; set; }
        public string C28 { get; set; }
        public string C29 { get; set; }
        public string C30 { get; set; }
        public string C31 { get; set; }
        public string C32 { get; set; }
        public string C33 { get; set; }
        public string C34 { get; set; }
        public string C35 { get; set; }
        public string C36 { get; set; }
        public string C37 { get; set; }
        public string C38 { get; set; }
        public string C39 { get; set; }
        public string C40 { get; set; }
        public string C41 { get; set; }
        public string C42 { get; set; }
        public string C43 { get; set; }
        public string C44 { get; set; }
        public string C45 { get; set; }
        public string C46 { get; set; }
        public string C47 { get; set; }
        public string C48 { get; set; }
        public string C49 { get; set; }
        public string C50 { get; set; }
        public string C51 { get; set; }
        public string C52 { get; set; }
        public string C53 { get; set; }
        public string C54 { get; set; }
        public string C55 { get; set; }
        public string C56 { get; set; }
        public string C57 { get; set; }
        public string C58 { get; set; }
        public string C59 { get; set; }
        public string C60 { get; set; }
        public string C61 { get; set; }
        public string C62 { get; set; }
        public string C63 { get; set; }
        public string C64 { get; set; }
        public string C65 { get; set; }
        public string C66 { get; set; }
        public string C67 { get; set; }
        public string C68 { get; set; }
        public string C69 { get; set; }
        public string C70 { get; set; }
        public string C71 { get; set; }
        public string C72 { get; set; }
        public string C73 { get; set; }
        public string C74 { get; set; }
        public string C75 { get; set; }
        public string C76 { get; set; }
        public string C77 { get; set; }
        public string C78 { get; set; }
        public string C79 { get; set; }
        public string C80 { get; set; }
        public string C81 { get; set; }
        public string C82 { get; set; }
        public string C83 { get; set; }
        public string C84 { get; set; }
        public string C85 { get; set; }
        public string C86 { get; set; }
        public string C87 { get; set; }
        public string C88 { get; set; }
        public string C89 { get; set; }
        public string C90 { get; set; }
        public string C91 { get; set; }
        public string C92 { get; set; }
        public string C93 { get; set; }
        public string C94 { get; set; }
        public string C95 { get; set; }
        public string C96 { get; set; }
        public string C97 { get; set; }
        public string C98 { get; set; }
        public string C99 { get; set; }
        public string C100 { get; set; }
        public string C101 { get; set; }
        public string C102 { get; set; }
        public string C103 { get; set; }
        public string C104 { get; set; }
        public string C105 { get; set; }
        public string C106 { get; set; }
        public string C107 { get; set; }



        public virtual ICollection<ColunaDivergente> DivergenciaFinanceiro { get; set; }



        public static string[] CabecalhaFin = {
            "CONTRATO MONTREAL ORIGEM"	
            ,"CONTRATO MONTREAL DESTINO"	
            ,"CONTRATO ALTAIR ORIGEM"	
            ,"CONTRATO ALTAIR DESTINO"	
            ,"NOME DA EMPRESA ORIGEM"	
            ,"NOME DA EMPRESA DESTINO"	
            ,"AGENCIA ORIGEM"	
            ,"AGENCIA DESTINO"	
            ,"PRODUTO ORIGEM"	
            ,"PRODUTO DESTINO"	
            ,"NOME PRODUTO ORIGEM"	
            ,"NOME PRODUTO DESTINO"	
            ,"SUB-PRODUTO ORIGEM"	
            ,"SUB-PRODUTO DESTINO"	
            ,"NOME SUB-PRODUTO ORIGEM"	
            ,"NOME SUB-PRODUTO DESTINO"	
            ,"NOME ORIGEM"	
            ,"NOME DESTINO"	
            ,"CPF ORIGEM"	
            ,"CPF DESTINO"	
            ,"DATA NASCIMENTO ORIGEM"	
            ,"DATA NASCIMENTO DESTINO"	
            ,"ENDERECO ORIGEM"	
            ,"ENDERECO DESTINO"	
            ,"TX. CET A.A. ORIGEM"	
            ,"TX. CET A.A. DESTINO"	
            ,"TX. CET MES ORIGEM"	
            ,"TX. CET MES DESTINO"	
            ,"VALOR FINANCIADO (+TAXAS ORIGINACAO) ORIGEM"	
            ,"VALOR FINANCIADO (+TAXAS ORIGINACAO) DESTINO"	
            ,"DATA DO CONTRATO ORIGEM"	
            ,"DATA DO CONTRATO DESTINO"	
            ,"PRAZO TOTAL ORIGEM"	
            ,"PRAZO TOTAL DESTINO"	
            ,"QUANTIDADE PARCELAS PAGAS ORIGEM"	
            ,"QUANTIDADE PARCELAS PAGAS DESTINO"	
            ,"QUANTIDADE PARCELAS EM ABERTO ORIGEM"	
            ,"QUANTIDADE PARCELAS EM ABERTO DESTINO"	
            ,"TAXA JUROS NOMINAL (ANUAL) ORIGEM"	
            ,"TAXA JUROS NOMINAL (ANUAL) DESTINO"	
            ,"TIPO AMORTIZACAO ORIGEM"	
            ,"TIPO AMORTIZACAO DESTINO"	
            ,"PLANO CORRECAO ORIGEM"	
            ,"PLANO CORRACAO DESTINO"	
            ,"INDEXADOR DE CORRECAO ORIGEM"	
            ,"INDEXADOR DE CORRECAO DESTINO"	
            ,"DATA PRIMEIRO VENCIMENTO ORIGEM"	
            ,"DATA PRIMEIRO VENCIMENTO DESTINO"	
            ,"DATA FINAL DO CONTRATO ORIGEM"	
            ,"DATA FINAL DO CONTRATO DESTINO"	
            ,"DATA VENCIMENTO DA PARCELA MAIS ANTIGA EM ABERTO ORIGEM"	
            ,"DATA VENCIMENTO DA PARCELA MAIS ANTIGA EM ABERTO DESTINO"	
            ,"SALDO PRINCIPAL A VENCER ORIGEM"	
            ,"SALDO PRINCIPAL A VENCER DESTINO"	
            ,"ENDERECO DA GARANTIA (ENDERECO COMPLETO) ORIGEM"	
            ,"ENDERECO DA GARANTIA (ENDERECO COMPLETO) DESTINO"	
            ,"DATA DA GARANTIA ORIGEM"	
            ,"DATA DA GARANTIA DESTINO"	
            ,"VALOR DA GARANTIA ORIGEM"	
            ,"VALOR DA GARANTIA DESTINO"	
            ,"PRESTACAO (ULTIMO ANIVERSARIO ANTES TOMBAMENTO) ORIGEM"	
            ,"PRESTACAO (ULTIMO ANIVERSARIO ANTES TOMBAMENTO) DESTINO"	
            ,"SEGURO MIP (ULTIMO ANIVERSARIO ANTES TOMBAMENTO) ORIGEM"	
            ,"SEGURO MIP (ULTIMO ANIVERSARIO ANTES TOMBAMENTO) DESTINO"	
            ,"SEGURO DFI (ULTIMO ANIVERSARIO ANTES TOMBAMENTO) ORIGEM"	
            ,"SEGURO DFI (ULTIMO ANIVERSARIO ANTES TOMBAMENTO) DESTINO"	
            ,"TSA (ULTIMO ANIVERSARIO ANTES TOMBAMENTO) ORIGEM"	
            ,"TSA (ULTIMO ANIVERSARIO ANTES TOMBAMENTO) DESTINO"	
            ,"JUROS MORA (ULTIMO ANIVERSARIO ANTES TOMBAMENTO) ORIGEM"	
            ,"JUROS MORA (ULTIMO ANIVERSARIO ANTES TOMBAMENTO) DESTINO"	
            ,"AMORTIZACAO (ULTIMO ANIVERSARIO ANTES TOMBAMENTO) ORIGEM"	
            ,"AMORTIZACAO (ULTIMO ANIVERSARIO ANTES TOMBAMENTO) DESTINO"	
            ,"SALDO DEVEDOR (ULTIMO ANIVERSARIO ANTES TOMBAMENTO) ORIGEM"	
            ,"SALDO DEVEDOR (ULTIMO ANIVERSARIO ANTES TOMBAMENTO) DESTINO"	
            ,"FGTS DA PRESTACAO (ULTIMO ANIVERSARIO ANTES TOMBAMENTO) ORIGEM"	
            ,"FGTS DA PRESTACAO (ULTIMO ANIVERSARIO ANTES TOMBAMENTO) DESTINO"	
            ,"DATA PAGAMENTO (ULTIMO ANIVERSARIO ANTES TOMBAMENTO) ORIGEM"	
            ,"DATA PAGAMENTO (ULTIMO ANIVERSARIO ANTES TOMBAMENTO) DESTINO"	
            ,"NOME DO CONJUGE ORIGEM"	
            ,"NOME DO CONJUGE DESTINO"	
            ,"CPF DO CONJUGE ORIGEM"	
            ,"CPF DO CONJUGE DESTINO"	
            ,"DATA DE NASCIMENTO DO CONJUGE ORIGEM"	
            ,"DATA DE NASCIMENTO DO CONJUGE DESTINO"	
            ,"PERCENTUAL DE PARTICIPACAO DO CONJUGE ORIGEM"	
            ,"PERCENTUAL DE PARTICIPACAO DO CONJUGE DESTINO"	
            ,"VALOR DA AVALIACAO ORIGINAL DO FINANCIAMENTO ORIGEM"	
            ,"VALOR DA AVALIACAO ORIGINAL DO FINANCIAMENTO DESTINO"	
            ,"VALOR DA AVALIACAO ATUALIZADO ORIGEM"	
            ,"VALOR DA AVALIACAO ATUALIZADO DESTINO"	
            ,"PLANO E SISTEMA DE AMORTIZACAO ORIGEM"	
            ,"PLANO E SISTEMA DE AMORTIZACAO DESTINO"	
            ,"CODIGO DE APOLICE ORIGEM"	
            ,"CODIGO DE APOLICE DESTINO"	
            ,"VALOR DOS PREMIOS DE SEGUROS NA DATA DO TOMBAMENTO ORIGEM"	
            ,"VALOR DOS PREMIOS DE SEGUROS NA DATA DO TOMBAMENTO DESTINO"	
            ,"VALOR DA TSA NA DATA DO TOMBAMENTO ORIGEM"	
            ,"VALOR DA TSA NA DATA DO TOMBAMENTO DESTINO"	
            ,"DATA VENCIMENTO DA PARCELA NA DATA DO TOMBAMENTO ORIGEM"	
            ,"DATA VENCIMENTO DA PARCELA NA DATA DO TOMBAMENTO DESTINO"	
            ,"PRAZO REMANESCENTE NA DATA DO TOMBAMENTO ORIGEM"	
            ,"PRAZO REMANESCENTE NA DATA DO TOMBAMENTO DESTINO"	
            ,"DADOS CADASTRAIS DO CO PARTICIPANTE ORIGEM"	
            ,"DADOS CADASTRAIS DO CO PARTICIPANTE DESTINO"	
            ,"PERCENTUAL DE PARTIUCIPACAO DE SEGUROS DO CO PARTICIPANTE ORIGEM"	
            ,"PERCENTUAL DE PARTIUCIPACAO DE SEGUROS DO CO PARTICIPANTE DESTINO"	
            ,"UTILIZACAO DE FGTS NA PARCELA ( DAMP III ) ORIGEM"	
            ,"UTILIZACAO DE FGTS NA PARCELA ( DAMP III )   DESTINO"	};

    }
   
}
