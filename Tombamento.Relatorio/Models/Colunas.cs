using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombamento.Relatorio.Models
{
    public class Colunas
    {
        public Colunas()
        {

        }

        public static List<int> excecao = new List<int>() { 7, 8, 10, 11, 14, 15, 24, 25, 26, 27 };
        public static List<int> exc = new List<int>() { 54, 55, 102, 1, 03 };
        public static List<int> ColunasItem = new List<int>() { 0, 1, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 31, 33, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 59, 61, 64, 65, 66, 67, 69, 71, 75, 77, 81, 83, 87, 89, 93, 95, 99, 101, 105, 107, 111, 113, 117, 119, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 133, 135, 139, 141, 144, 145, 146, 147, 148, 149, 153, 155, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167 };
        public static List<int> ColunasItemOcorrencia = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 26, 28, 32, 34, 37, 38, 40, 42, 46, 48, 52, 54, 58, 60, 64, 66, 70, 72, 76, 78, 81, 82, 84, 86, 89, 90, 91, 92 };
        public static List<int> ColunasParcelas = new List<int>() { 0, 1, 2, 3, 4, 5, 7, 9, 13, 15, 19, 21, 25, 27, 31, 33, 37, 39, 43, 45, 48, 49, 52, 54, 58, 60, 64, 66, 70, 72, 76, 78, 81, 82, 83, 84, 85, 86, 87, 88, 90, 92, 96, 98, 101, 102, 105, 107, 110, 111, 114, 116, 119, 120, 121, 122, 123, 124, 126, 127 };


        public static List<KeyValuePair<string, string>> PreencherPlanoCorrecaoIndexador()
        {
            var list = new List<KeyValuePair<string, string>>();
            list.Add(new KeyValuePair<string, string>("PCM", "P"));
            list.Add(new KeyValuePair<string, string>("PCR", "R"));
            list.Add(new KeyValuePair<string, string>("PES", "E"));
            list.Add(new KeyValuePair<string, string>("PREF", "PREF"));
            list.Add(new KeyValuePair<string, string>("IOF", "IOF"));
            list.Add(new KeyValuePair<string, string>("1", "CDI"));
            list.Add(new KeyValuePair<string, string>("2", "TR"));
            list.Add(new KeyValuePair<string, string>("7", "IGPM"));
            list.Add(new KeyValuePair<string, string>("8", "IGPM"));
            list.Add(new KeyValuePair<string, string>("9", "INCC"));
            list.Add(new KeyValuePair<string, string>("10", "INCC"));
            list.Add(new KeyValuePair<string, string>("POUP", "TR"));
            return list;
        }

    }
}
