using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza
{
    class Class_C_1
    {

        #region "問題__"
        public static string 問題__(string line)
        {
            string result = "";




            return result;
        }
        #endregion

        #region "問題05"
        public static void 問題05(string line)
        {
            
            var N = Int32.Parse(line);
            string[] ip = new string[N];
            for (var i = 0; i < N; ++i)
            {
              ip[i] = System.Console.ReadLine().Trim();
            }

            foreach ( string ln in ip)
            {
                string result = "True";
                string[] splt = ln.Split('.');
                try
                {
                    for (int i = 0; i < splt.Count(); ++i)
                    {
                        if (int.Parse(splt[i]) < 0)
                        {
                            result = "False";
                            break;
                        }
                        else if (int.Parse(splt[i]) > 255)
                        {
                            result = "False";
                            break;
                        }
                        else if (i > 4)
                        {
                            result = "False";
                            break;
                        }
                    }
                }
                catch
                {
                    result = "False";
                }

                Console.WriteLine(result);

            }
            //Console.ReadLine();
        }
        #endregion

        #region "問題05_ver2"
        public static void 問題05_ver2(string line)
        {
            int 回数 = int.Parse(line);
            List<string> list= new List<string>();

            for (int i = 0; i < 回数; ++i)
            {
                try
                {
                    string[] ip = Console.ReadLine().Trim().Split('.');
                    string result = "True";
                    if (ip.Count() != 4)
                    {
                        result = "False";
                    }
                    foreach (string str in ip)
                    {
                        if (int.Parse(str) > 255 || int.Parse(str) < 0)
                        {
                            result = "False";
                        }
                    }
                    list.Add(result);
                }
                catch
                {
                    list.Add("False");
                }
            }

            foreach(string str in list)
            {
                Console.WriteLine(str);
            }
        }
        #endregion


    }

    class Class_C_4
    {

        #region "問題__"
        public static string 問題__(string line)
        {
            string result = "";




            return result;
        }
        #endregion

        #region "問題40"
        /// <summary>
        ///  C040:【ロジサマコラボ問題】背比べ
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public static string 問題40(string line)
        {
            int n = int.Parse(line);
            float max = 200F;
            float min = 100F;

            for (int i = 0;i < n; ++i)
            {
                string str = Console.ReadLine().Trim();
                //if (i == n - 1) { break; } // 最終行の改行は無視
                string[] list = str.Split(' ');

                switch (list[0])
                {
                    case "le":  // 以下
                        if (max > float.Parse(list[1]))
                        {
                            max = float.Parse(list[1]);
                        }
                        break;
                    case "ge":  // 超過
                        if (min < float.Parse(list[1]))
                        {
                            min = float.Parse(list[1]);
                        }
                        break;
                }
                            }
            
            string result = $"{min:0.0} {max:0.0}";
            
            return result;
        }
        #endregion

    }
}
