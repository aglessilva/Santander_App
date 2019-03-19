using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombamento.Relatorio.Models
{
    public class Ocorrencia
    {

        public Ocorrencia()
        {
            this.DivergenciasOcorrencia = new HashSet<DivergenciaOcorrencia>();
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

        public virtual ICollection<DivergenciaOcorrencia> DivergenciasOcorrencia { get; set; }


        public static string[] cabecalhoOcorrencia = 
        {
            "CONTRATO MONTREAL ORIGEM"	
            ,"CONTRATO MONTREAL DESTINO"	
            ,"OCORRENCIA ORIGEM"	
            ,"OCORRENCIA DESTINO"	
            ,"TIPO OCORRENCIA ORIGEM"	
            ,"TIPO OCORRENCIA DESTINO"	
            ,"DATA VENCIMENTO ANTERIOR OCORRENCIA ORIGEM"  	
            ,"DATA VENCIMENTO ANTERIOR OCORRENCIA DESTINO"  	
            ,"DATA VENCIMENTO A POSTERIOR OCORRENCIA ORIGEM" 	
            ,"DATA VENCIMENTO A POSTERIOR OCORRENCIA DESTINO" 	
            ,"NOVO DIA DE VENCIMENTO ORIGEM"	
            ,"NOVO DIA DE VENCIMENTO DESTINO"	
            ,"PERCENTUAL TAXA DE JUROS ORIGEM"	
            ,"PERCENTUAL TAXA DE JUROS DESTINO"	
            ,"TIPO DE TAXA DE JUROS ORIGEM"	
            ,"TIPO DE TAXA DE JUROS DESTINO"	
            ,"TIPO PERCENTUAL TAXA DE JUROS ORIGEM"  	
            ,"TIPO PERCENTUAL TAXA DE JUROS DESTINO" 	
            ,"INDICADOR CORRECAO CONTRATO ORIGEM"	
            ,"INDICADOR CORRECAO CONTRATO DESTINO" 	
            ,"PRAZO REMANESCENTE MES ORIGEM"	
            ,"PRAZO REMANESCENTE MES DESTINO"	
            ,"TIPO DE SISTEMA DE AMORTIZACAO ORIGEM" 	
            ,"TIPO DE SISTEMA DE AMORTIZACAO DESTINO" 	
            ,"VALOR SALDO PRINCIPAL ANTERIOR OCORRENCIA ORIGEM" 	
            ,"VALOR SALDO PRINCIPAL ANTERIOR OCORRENCIA DESTINO" 	
            ,"VALOR SALDO PRINCIPAL DATA DA OCORRENCIA ORIGEM" 	
            ,"VALOR SALDO PRINCIPAL DATA DA OCORRENCIA DESTINO" 	
            ,"CODIGO APOLICE CONTRATO ORIGEM"	
            ,"CODIGO APOLICE CONTRATO DESTINO"	
            ,"VALOR TOTAL A PAGAR ORIGEM"	
            ,"VALOR TOTAL A PAGAR DESTINO"	
            ,"VALOR PRINCIPAL A PAGAR ORIGEM" 	
            ,"VALOR PRINCIPAL A PAGAR DESTINO"	
            ,"VALOR TAXA DE ENCARGOS MES A PAGAR ORIGEM" 	
            ,"VALOR TAXA DE ENCARGOS MES A PAGAR DESTINO" 	
            ,"VALOR SEG ENCARGOS MES APG DEVEDOR ORIGEM" 	
            ,"VALOR SEG ENCARGOS MES APG DEVEDOR DESTINO" 	
            ,"VALOR PARCELA VENCIDA A PAGAR ORIGEM" 	
            ,"VALOR PARCELA VENCIDA A PAGAR DESTINO" 	
            ,"VALOR DIFERENCA VALOR A PAGAR ORIGEM" 	
            ,"VALOR DIFERENCA VALOR A PAGAR DESTINO" 	
            ,"VALOR SALDO VENCIDO A INCORPORAR ORIGEM" 	
            ,"VALOR SALDO VENCIDO A INCORPORAR DESTINO" 	
            ,"DATA PAGAMENTO OCORRENCIA ORIGEM"	
            ,"DATA PAGAMENTO OCORRENCIA DESTINO"	
            ,"VALOR PAGAMENTO ORIGEM"    	
            ,"VALOR PAGAMENTO DESTINO"   	
            ,"SITUACAO ANTERIOR ORIGEM"	
            ,"SITUACAO ANTERIOR DESTINO"	
            ,"SITUACAO ATUAL ORIGEM"	
            ,"SITUACAO ATUAL DESTINO"
        };

    }

    public class DivergenciaOcorrencia : IDivergencia
    {
        public int Id { get;set;}
        public int Indice { get; set; }
        public string Contrato { get; set; }
    }

}
