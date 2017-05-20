using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paiza_
{
    #region "format"
    static class Class_B_format
    {
        public static void Execute(string line)
        {
            string result = string.Empty;


            Console.WriteLine(result);
        }
    }
    #endregion


    #region "B040:【キャンペーン問題】たのしい暗号解読"
    static class Class_B_040
    {
        public static void Execute(string line)
        {
            string[] str = line.Split(' ');
            int n = int.Parse(str[0]);  //ループ回数
            Dictionary<string, string> 変換list = Init変換list(new Dictionary<string, string>(), str[1].ToLower());

            List<string> 変換後list = new List<string>();
            List<string> 対象list = new List<string>();
            string 対象列 = Console.ReadLine().ToLower();
            for (int i = 0; i < 対象列.Length; ++i)
            {
                対象list.Add(対象列[i].ToString());
            }

            for (int j = 0;j < n; ++j){
                if (変換後list.Count > 0)
                {
                    対象list = new List<string>(変換後list);
                    変換後list.Clear();
                }

                foreach (string 対象row in 対象list)
                {
                    if (変換list.ContainsKey(対象row))
                    {
                        変換後list.Add(変換list[対象row]);
                    }
                    else
                    {
                        変換後list.Add(対象row);
                    }
                }
            }


            Console.WriteLine(string.Join("", 変換後list));
        }

        public static Dictionary<string, string> Init変換list(Dictionary<string, string> 変換list,string 文字列)
        {
            int i = 0;
            変換list.Add(文字列.Substring(i++,1), "a");
            変換list.Add(文字列.Substring(i++,1), "b");
            変換list.Add(文字列.Substring(i++,1), "c");
            変換list.Add(文字列.Substring(i++,1), "d");
            変換list.Add(文字列.Substring(i++,1), "e");
            変換list.Add(文字列.Substring(i++,1), "f");
            変換list.Add(文字列.Substring(i++,1), "g");
            変換list.Add(文字列.Substring(i++,1), "h");
            変換list.Add(文字列.Substring(i++,1), "i");
            変換list.Add(文字列.Substring(i++,1), "j");
            変換list.Add(文字列.Substring(i++,1), "k");
            変換list.Add(文字列.Substring(i++,1), "l");
            変換list.Add(文字列.Substring(i++,1), "m");
            変換list.Add(文字列.Substring(i++,1), "n");
            変換list.Add(文字列.Substring(i++,1), "o");
            変換list.Add(文字列.Substring(i++,1), "p");
            変換list.Add(文字列.Substring(i++,1), "q");
            変換list.Add(文字列.Substring(i++,1), "r");
            変換list.Add(文字列.Substring(i++,1), "s");
            変換list.Add(文字列.Substring(i++,1), "t");
            変換list.Add(文字列.Substring(i++,1), "u");
            変換list.Add(文字列.Substring(i++,1), "v");
            変換list.Add(文字列.Substring(i++,1), "w");
            変換list.Add(文字列.Substring(i++,1), "x");
            変換list.Add(文字列.Substring(i++,1), "y");
            変換list.Add(文字列.Substring(i++,1), "z");

            return 変換list;
        }
    }
    #endregion
    
}
