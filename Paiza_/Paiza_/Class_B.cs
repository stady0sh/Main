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
        public static void Execute()
        {
            string line = Console.ReadLine().Trim();
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

    #region "B041:繰り返し模様 "
    static class Class_B_B041
    {
        public static void Execute()
        {
            int k = int.Parse(Console.ReadLine().Trim());
            int n = int.Parse(Console.ReadLine().Trim());
            string result = string.Empty;

            // 図形の取得
            List<string> list = new List<string>();
            for (int i = 0;i < n; ++i)
            {
                list.Add(Console.ReadLine().Trim());
            }

            // 生成
            for (int j = 1;j <= k; ++j)
            {
                int cnt = 0;
                List<string> newList = new List<string>();
                // List = #..
                //        ##.
                //        ###
                foreach (var item in list)
                {
                    // item = #..
                    List<List<string>> tmpList = new List<List<string>>();
                    // tmpListのコンストラクタ
                    for (int q = 0; q < item.Length; ++q)
                    {
                        tmpList.Add(new List<string>());
                    }

                    for (int m = 0;m < item.Length; ++m)
                    {

                        int o = 0;
                        if (item.Substring(m, 1) == ".")
                        {
                            //for (int o = 0 ; o < item.Length; ++o)
                            //{
                            //    tmpList[o].Add(item.Replace('#','.'));
                            //}
                            foreach (var item2 in list)
                            {
                                tmpList[o++].Add(item2.Replace('#', '.'));
                            }
                        }
                        else
                        {
                            //for (int o = 0; o < item.Length; ++o)
                            //{
                            //    tmpList[o].Add(item);
                            //}
                            foreach (var item2 in list)
                            {
                                tmpList[o++].Add(item2);
                            }
                        }
                        
                    }

                    foreach (var item2 in tmpList)
                    {
                        newList.Add(string.Join("", item2));
                    }

                    ++cnt;
                }

                list = newList;
                
            }


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
        }
    }
    #endregion

}
