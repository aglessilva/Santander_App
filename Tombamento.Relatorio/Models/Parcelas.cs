using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombamento.Relatorio.Models
{
    public class Parcela
    {
        public Parcela()
        {
            this.DivergenciaParcela = new HashSet<DivergenteParcela>();
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

        public virtual ICollection<DivergenteParcela> DivergenciaParcela { get; set; }


        public static string[] CabecalhoParcelas = 
        {
            "CONTRATO MONTREAL ORIGEM"
            ,"CONTRATO MONTREAL DESTINO"
            ,"DATA AMORTIZACAO PARCELA ORIGEM"
            ,"DATA AMORTIZACAO PARCELA DESTINO"
            ,"NUMERO PARCELA ORIGEM"
            ,"NUMERO PARCELA DESTINO"
            ,"VALOR AMORTIZACAO PARCELA CORRENTE ORIGEM"
            ,"VALOR AMORTIZACAO PARCELA CORRENTE DESTINO"
            ,"VALOR JUROS PARCELA CORRENTE ORIGEM"
            ,"VALOR JUROS PARCELA CORRENTE DESTINO"
            ,"VALOR MIP PARCELA CORRENTE ORIGEM"
            ,"VALOR MIP PARCELA CORRENTE DESTINO"
            ,"VALOR DFI PARCELA CORRENTE ORIGEM"
            ,"VALOR DFI PARCELA CORRENTE DESTINO"
            ,"VALOR IOF SEGURO ORIGEM"
            ,"VALOR IOF SEGURO DESTINO"
            ,"VALOR TARIFA PARCELA CORRENTE ORIGEM"
            ,"VALOR TARIFA PARCELA CORRENTE DESTINO"
            ,"VALOR ABATIMENTO FGTS DAMPIII ORIGEM"
            ,"VALOR ABATIMENTO FGTS DAMPIII DESTINO"
            ,"FATOR CORRECAO MONETARIA PARCELA ORIGEM"
            ,"FATOR CORRECAO MONETARIA PARCELA DESTINO"
            ,"VALOR CORRECAO MONETARIA E ENCARGOS ORIGEM"
            ,"VALOR CORRECAO MONETARIA E ENCARGOS DESTINO"
            ,"VALOR JUROS REMUN ORIGEM"
            ,"VALOR JUROS REMUN DESTINO"
            ,"VALOR JUROS MORA ORIGEM"
            ,"VALOR JUROS MORA DESTINO"
            ,"VALOR CORRECAO MONETARIA DE ATRASO ORIGEM"
            ,"VALOR CORRECAO MONETARIA DE ATRASO DESTINO"
            ,"VALOR DIFERENCA PAGAMENTO ANTERIOR CORRIGIDO ORIGEM"
            ,"VALOR DIFERENCA PAGAMENTO ANTERIOR CORRIGIDO DESTINO"
            ,"CODIGO NOSSO NUMERO BOLETO ORIGEM"
            ,"CODIGO NOSSO NUMERO BOLETO DESTINO"
            ,"INDICADOR PARCELA PAGA ORIGEM"
            ,"INDICADOR PARCELA PAGA DESTINO"
            ,"DATA MOV PAGAMENTO ORIGEM"
            ,"DATA MOV PAGAMENTO DESTINO"
            ,"FORMA DE LIQUIDACAO ORIGEM"
            ,"FORMA DE LIQUIDACAO DESTINO"
            ,"VALOR PAGO ORIGEM"
            ,"VALOR PAGO DESTINO"
            ,"VALOR DESCONTO ORIGEM"
            ,"VALOR DESCONTO DESTINO"
            ,"VALOR DIFERENCA PAGA CARREG ORIGEM"
            ,"VALOR DIFERENCA PAGA CARREG DESTINO"
            ,"VALOR PRI SALDO DEVEDOR MES ORIGEM"
            ,"VALOR PRI SALDO DEVEDOR MES DESTINO"
            ,"VALOR JUROS SALDO DEVEDOR MES ORIGEM"
            ,"VALOR JUROS SALDO DEVEDOR MES DESTINO" 
            ,"VALOR CORRECAO MONETARIA SALDO DEVEDOR MES ORIGEM"
            ,"VALOR CORRECAO MONETARIA SALDO DEVEDOR MES DESTINO"
            ,"INDICADOR PARCELA EMITIDA ORIGEM"
            ,"INDICADOR PARCELA EMITIDA DESTINO"
            ,"TIPO SISTEMA AMORTIZACAO ORIGEM"
            ,"TIPO SISTEMA AMORTIZACAO DESTINO"
            ,"PERC TAXA JUROS NOMINAL ORIGEM"
            ,"PERC TAXA JUROS NOMINAL DESTINO"
            ,"INDICADOR INCORPORADORA ORIGEM"
            ,"INDICADOR INCORPORADORA DESTINO"

        };
    }


    public class DivergenteParcela 
    {
        public int Id { get; set; }
        public int Indice { get; set; }
        public string Contrato { get; set; }
        public string Vencimento { get; set; }
        public int CountContrato { get; set; }
    }
}
