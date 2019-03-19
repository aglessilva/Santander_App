using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tombamento.Relatorio.Models;

namespace Tombamento.Relatorio.BLL
{
    public class DTIParcela
    {
        public DTIParcela()
        {

        }

        public string[] GetColunms(string linha)
        {
            string[] _linha = linha.Split(';');
            List<string> lst = new List<string>();

            linha = string.Empty;
            Colunas.ColunasParcelas.ForEach(j => {lst.Add(_linha[j].Trim()); });
            return lst.ToArray(); ;
        }

        public DivergenteParcela GetErro(int _indice, string _contrato, string _vencimento, int _countContrato = 0)
        {
            DivergenteParcela obj = new DivergenteParcela()
            {
                Indice = _indice,
                Contrato = Regex.Replace(_contrato.Trim(), @"[^0-9$]", ""),
                Vencimento = _vencimento,
                CountContrato = _countContrato

            };
            return obj;
        }


        public int SaveEntity(List<Parcela> lstParcelas, List<DivergenteParcela> lstDivergencia)
        {
            int ret = 0;
            using (DbCom db = new DbCom())
            {
                lstDivergencia.ForEach(x => {
                    db.DivergenciasParcelas.Add(x);
                });

                lstParcelas.ForEach(p => {
                    db.Parcelas.Add(p);
                });

                ret = db.SaveChanges();
            }

            return ret;
        }

        public Parcela CriaObjetoParcela(string[] _linha)
        {
            Parcela obj = new Parcela()
            {
                C0 = Regex.Replace(_linha[0].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C1 = Regex.Replace(_linha[1].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C2 = Regex.Replace(_linha[2].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C3 = Regex.Replace(_linha[3].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C4 = Regex.Replace(_linha[4].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C5 = Regex.Replace(_linha[5].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C6 = Regex.Replace(_linha[6].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C7 = Regex.Replace(_linha[7].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C8 = Regex.Replace(_linha[8].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C9 = Regex.Replace(_linha[9].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C10 = Regex.Replace(_linha[10].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C11 = Regex.Replace(_linha[11].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C12 = Regex.Replace(_linha[12].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C13 = Regex.Replace(_linha[13].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C14 = Regex.Replace(_linha[14].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C15 = Regex.Replace(_linha[15].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C16 = Regex.Replace(_linha[16].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C17 = Regex.Replace(_linha[17].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C18 = Regex.Replace(_linha[18].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C19 = Regex.Replace(_linha[19].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C20 = Regex.Replace(_linha[20].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C21 = Regex.Replace(_linha[21].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C22 = Regex.Replace(_linha[22].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C23 = Regex.Replace(_linha[23].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C24 = Regex.Replace(_linha[24].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C25 = Regex.Replace(_linha[25].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C26 = Regex.Replace(_linha[26].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C27 = Regex.Replace(_linha[27].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C28 = Regex.Replace(_linha[28].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C29 = Regex.Replace(_linha[29].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C30 = Regex.Replace(_linha[30].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C31 = Regex.Replace(_linha[31].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C32 = Regex.Replace(_linha[32].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C33 = Regex.Replace(_linha[33].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C34 = Regex.Replace(_linha[34].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C35 = Regex.Replace(_linha[35].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C36 = Regex.Replace(_linha[36].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C37 = Regex.Replace(_linha[37].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C38 = Regex.Replace(_linha[38].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C39 = Regex.Replace(_linha[39].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C40 = Regex.Replace(_linha[40].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C41 = Regex.Replace(_linha[41].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C42 = Regex.Replace(_linha[42].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C43 = Regex.Replace(_linha[43].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C44 = Regex.Replace(_linha[44].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C45 = Regex.Replace(_linha[45].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C46 = Regex.Replace(_linha[46].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C47 = Regex.Replace(_linha[47].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C48 = Regex.Replace(_linha[48].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C49 = Regex.Replace(_linha[49].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C50 = Regex.Replace(_linha[50].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C51 = Regex.Replace(_linha[51].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C52 = Regex.Replace(_linha[52].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C53 = Regex.Replace(_linha[53].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C54 = Regex.Replace(_linha[54].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C55 = Regex.Replace(_linha[55].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C56 = Regex.Replace(_linha[56].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C57 = Regex.Replace(_linha[57].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C58 = Regex.Replace(_linha[58].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
                C59 = Regex.Replace(_linha[59].Trim(), @"[^A-Za-z0-9$]+", " ").Trim(),
            };

            return obj;
        }

        public  DataTable Filter(List<Parcela> lstParcelas)
        {
            DataTable tabelaContrato = new DataTable();

            for (int i = 0; i < Parcela.CabecalhoParcelas.Count(); i++)
            {
                tabelaContrato.Columns.Add("C"+i.ToString(), typeof(string));
            }

            Parcela obj = CriaObjetoParcela(Parcela.CabecalhoParcelas);
            lstParcelas.Insert(0, obj);

            DataRow dr = null;

            lstParcelas.ForEach(x => {

                dr = tabelaContrato.NewRow();
                dr["C0"] = x.C0;
                dr["C1"] = x.C1;
                dr["C2"] = x.C2;
                dr["C3"] = x.C3;
                dr["C4"] = x.C4;
                dr["C5"] = x.C5;
                dr["C6"] = x.C6;
                dr["C7"] = x.C7;
                dr["C8"] = x.C8;
                dr["C9"] = x.C9;
                dr["C10"] = x.C10;
                dr["C11"] = x.C11;
                dr["C12"] = x.C12;
                dr["C13"] = x.C13;
                dr["C14"] = x.C14;
                dr["C15"] = x.C15;
                dr["C16"] = x.C16;
                dr["C17"] = x.C17;
                dr["C18"] = x.C18;
                dr["C19"] = x.C19;
                dr["C20"] = x.C20;
                dr["C21"] = x.C21;
                dr["C22"] = x.C22;
                dr["C23"] = x.C23;
                dr["C24"] = x.C24;
                dr["C25"] = x.C25;
                dr["C26"] = x.C26;
                dr["C27"] = x.C27;
                dr["C28"] = x.C28;
                dr["C29"] = x.C29;
                dr["C30"] = x.C30;
                dr["C31"] = x.C31;
                dr["C32"] = x.C32;
                dr["C33"] = x.C33;
                dr["C34"] = x.C34;
                dr["C35"] = x.C35;
                dr["C36"] = x.C36;
                dr["C37"] = x.C37;
                dr["C38"] = x.C38;
                dr["C39"] = x.C39;
                dr["C40"] = x.C40;
                dr["C41"] = x.C41;
                dr["C42"] = x.C42;
                dr["C43"] = x.C43;
                dr["C44"] = x.C44;
                dr["C45"] = x.C45;
                dr["C46"] = x.C46;
                dr["C47"] = x.C47;
                dr["C48"] = x.C48;
                dr["C49"] = x.C49;
                dr["C50"] = x.C50;
                dr["C51"] = x.C51;
                dr["C52"] = x.C52;
                dr["C53"] = x.C53;
                dr["C54"] = x.C54;
                dr["C55"] = x.C55;
                dr["C56"] = x.C56;
                dr["C57"] = x.C57;
                dr["C58"] = x.C58;
                dr["C59"] = x.C59;
              
               tabelaContrato.Rows.Add(dr);
            });


            return tabelaContrato;
        }


        public List<Parcela> GetTop100(int _indice)
        {
            List<Parcela> lstParcela = new List<Parcela>();
            using (DbCom db = new DbCom())
            {

                lstParcela = (from c in db.Parcelas
                              join pv in db.DivergenciasParcelas
                              on new { Contrato =  c.C0, Vencimento = c.C2 }
                              equals new { Contrato =  pv.Contrato, Vencimento = pv.Vencimento }
                              where pv.Indice == _indice && pv.CountContrato == 1
                              select c).Take(100).ToList();
                return lstParcela; 
            }

        }


        
        
    }
}
