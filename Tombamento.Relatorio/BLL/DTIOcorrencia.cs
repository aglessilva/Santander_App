using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using Tombamento.Relatorio.Models;

namespace Tombamento.Relatorio.BLL
{
    public class DTIOcorrencia
    {

        public Ocorrencia CriaObjOcorrencia(string[] _linha)
        {
            Ocorrencia obj = new Ocorrencia()
            {
                C0 = _linha[0].Trim(),
                C1 = _linha[1].Trim(),
                C2 = _linha[2].Trim(),
                C3 = _linha[3].Trim(),
                C4 = _linha[4].Trim(),
                C5 = _linha[5].Trim(),
                C6 = _linha[6].Trim(),
                C7 = _linha[7].Trim(),
                C8 = _linha[8].Trim(),
                C9 = _linha[9].Trim(),
                C10 = _linha[10].Trim(),
                C11 = _linha[11].Trim(),
                C12 = _linha[12].Trim(),
                C13 = _linha[13].Trim(),
                C14 = _linha[14].Trim(),
                C15 = _linha[15].Trim(),
                C16 = _linha[16].Trim(),
                C17 = _linha[17].Trim(),
                C18 = _linha[18].Trim(),
                C19 = _linha[19].Trim(),
                C20 = _linha[20].Trim(),
                C21 = _linha[21].Trim(),
                C22 = _linha[22].Trim(),
                C23 = _linha[23].Trim(),
                C24 = _linha[24].Trim(),
                C25 = _linha[25].Trim(),
                C26 = _linha[26].Trim(),
                C27 = _linha[27].Trim(),
                C28 = _linha[28].Trim(),
                C29 = _linha[29].Trim(),
                C30 = _linha[30].Trim(),
                C31 = _linha[31].Trim(),
                C32 = _linha[32].Trim(),
                C33 = _linha[33].Trim(),
                C34 = _linha[34].Trim(),
                C35 = _linha[35].Trim(),
                C36 = _linha[36].Trim(),
                C37 = _linha[37].Trim(),
                C38 = _linha[38].Trim(),
                C39 = _linha[39].Trim(),
                C40 = _linha[40].Trim(),
                C41 = _linha[41].Trim(),
                C42 = _linha[42].Trim(),
                C43 = _linha[43].Trim(),
                C44 = _linha[44].Trim(),
                C45 = _linha[45].Trim(),
                C46 = _linha[46].Trim(),
                C47 = _linha[47].Trim(),
                C48 = _linha[48].Trim(),
                C49 = _linha[49].Trim(),
                C50 = _linha[50].Trim(),
                C51 = _linha[51].Trim(),
            };

            return obj;
        }


        public DivergenciaOcorrencia GetErro(int _indice, string _contrato)
        {
            DivergenciaOcorrencia obj = new DivergenciaOcorrencia()
            {
                Indice = _indice,
                Contrato = Regex.Replace(_contrato.Trim(), @"[^0-9$]", "")
            };
            return obj;
        }




        public DataTable  Filter(List<Ocorrencia> _lst, int _coluna)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("C0");
            dt.Columns.Add("C1");
            dt.Columns.Add("C2");
            dt.Columns.Add("C3");
            dt.Columns.Add("C4");
            dt.Columns.Add("C5");
            dt.Columns.Add("C6");
            dt.Columns.Add("C7");
            dt.Columns.Add("C8");
            dt.Columns.Add("C9");
            dt.Columns.Add("C10");
            dt.Columns.Add("C11");
            dt.Columns.Add("C12");
            dt.Columns.Add("C13");
            dt.Columns.Add("C14");
            dt.Columns.Add("C15");
            dt.Columns.Add("C16");
            dt.Columns.Add("C17");
            dt.Columns.Add("C18");
            dt.Columns.Add("C19");
            dt.Columns.Add("C20");
            dt.Columns.Add("C21");
            dt.Columns.Add("C22");
            dt.Columns.Add("C23");
            dt.Columns.Add("C24");
            dt.Columns.Add("C25");
            dt.Columns.Add("C26");
            dt.Columns.Add("C27");
            dt.Columns.Add("C28");
            dt.Columns.Add("C29");
            dt.Columns.Add("C30");
            dt.Columns.Add("C31");
            dt.Columns.Add("C32");
            dt.Columns.Add("C33");
            dt.Columns.Add("C34");
            dt.Columns.Add("C35");
            dt.Columns.Add("C36");
            dt.Columns.Add("C37");
            dt.Columns.Add("C38");
            dt.Columns.Add("C39");
            dt.Columns.Add("C40");
            dt.Columns.Add("C41");
            dt.Columns.Add("C42");
            dt.Columns.Add("C43");
            dt.Columns.Add("C44");
            dt.Columns.Add("C45");
            dt.Columns.Add("C46");
            dt.Columns.Add("C47");
            dt.Columns.Add("C48");
            dt.Columns.Add("C49");
            dt.Columns.Add("C50");
            dt.Columns.Add("C51");


            DataRow dr = null;

            foreach (Ocorrencia x in _lst)
            {
                dr = dt.NewRow();
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

                if (_coluna == 19)
                {
                    KeyValuePair<string, string> item = Colunas.PreencherPlanoCorrecaoIndexador().Find(k => k.Key == dr[18].ToString().Trim());
                    if (!dr[19].ToString().Trim().Equals(item.Value))
                        dt.Rows.Add(dr);

                    continue;
                }
                if (!dr[(_coluna - 1)].ToString().Equals(dr[_coluna].ToString()))
                    dt.Rows.Add(dr);
            }

            return dt;
        }
    }
}
