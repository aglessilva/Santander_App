using System.Text.RegularExpressions;
using Tombamento.Relatorio.Models;

namespace Tombamento.Relatorio.BLL
{
    public class DTIFinanceiro
    {
        public DTIFinanceiro(){}

        public Finaceiro CriaObjFinanceiro(string[] _linha)
        {
            Finaceiro obj = new Finaceiro()
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
                C52 = _linha[52].Trim(),
                C53 = _linha[53].Trim(),
                C54 = Regex.Replace(_linha[54].Trim(), @"[^A-Za-z0-9$]+", " "),
                C55 = Regex.Replace(_linha[55].Trim(), @"[^A-Za-z0-9$]+", " "),
                C56 = _linha[56].Trim(),
                C57 = _linha[57].Trim(),
                C58 = _linha[58].Trim(),
                C59 = _linha[59].Trim(),
                C60 = _linha[60].Trim(),
                C61 = _linha[61].Trim(),
                C62 = _linha[62].Trim(),
                C63 = _linha[63].Trim(),
                C64 = _linha[64].Trim(),
                C65 = _linha[65].Trim(),
                C66 = _linha[66].Trim(),
                C67 = _linha[67].Trim(),
                C68 = _linha[68].Trim(),
                C69 = _linha[69].Trim(),
                C70 = _linha[70].Trim(),
                C71 = _linha[71].Trim(),
                C72 = _linha[72].Trim(),
                C73 = _linha[73].Trim(),
                C74 = _linha[74].Trim(),
                C75 = _linha[75].Trim(),
                C76 = _linha[76].Trim(),
                C77 = _linha[77].Trim(),
                C78 = _linha[78].Trim(),
                C79 = _linha[79].Trim(),
                C80 = _linha[80].Trim(),
                C81 = _linha[81].Trim(),
                C82 = _linha[82].Trim(),
                C83 = _linha[83].Trim(),
                C84 = _linha[84].Trim(),
                C85 = _linha[85].Trim(),
                C86 = _linha[86].Trim(),
                C87 = _linha[87].Trim(),
                C88 = _linha[88].Trim(),
                C89 = _linha[89].Trim(),
                C90 = _linha[90].Trim(),
                C91 = _linha[91].Trim(),
                C92 = _linha[92].Trim(),
                C93 = _linha[93].Trim(),
                C94 = _linha[94].Trim(),
                C95 = _linha[95].Trim(),
                C96 = _linha[96].Trim(),
                C97 = _linha[97].Trim(),
                C98 = _linha[98].Trim(),
                C99 = _linha[99].Trim(),
                C100 = _linha[100].Trim(),
                C101 = _linha[101].Trim(),
                C102 = Regex.Replace(_linha[102].Trim(), @"[^A-Za-z0-9$]+", " "),
                C103 = Regex.Replace(_linha[103].Trim(), @"[^A-Za-z0-9$]+", " "),
                C104 = _linha[104].Trim(),
                C105 = _linha[105].Trim(),
                C106 = _linha[106].Trim(),
                C107 = _linha[107].Trim(),

            };

            return obj;
        }

        public ColunaDivergente GetErro(int _indice, string _contrato)
        {
            ColunaDivergente obj = new ColunaDivergente()
            {
                Indice = _indice,
                Contrato = Regex.Replace(_contrato.Trim(), @"[^0-9$]", "")
            };
            return obj;
        }
    }
}
