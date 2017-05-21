using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paiza_
{
    #region "format"
    static class Class_ロジサマ_format
    {
        public static void Execute(string line)
        {
            string result = string.Empty;
            
            Console.WriteLine(result);
        }
    }
    #endregion

    #region "復活の呪文　(封印レベルD)"
    static class Class_ロジサマ_1004
    {
        public static void Execute(string line)
        {
            string line2 = Console.ReadLine();

            string result = "NG";

            if (line.Trim() == line2.Trim())
            {
                result = "OK";
            }



            Console.WriteLine(result);
        }
    }
    #endregion

    #region "圧縮　　(封印レベルC)"
    static class Class_ロジサマ_2001
    {
        public static void Execute(string line)
        {
            List<string> result = new List<string>();
            int cnt = 0;
            string tmp = "b";

            for (int i = 0;i < line.Trim().Length; ++i)
            {
                string s = line.Substring(i, 1);
                
                if (tmp == s)
                {
                    cnt += 1;
                }
                else
                {
                    result.Add(cnt.ToString());
                    tmp = s;
                    cnt = 1;
                }


            }

            if (cnt > 0) { result.Add(cnt.ToString()); }
            


            Console.WriteLine(string.Join(" ",result));
        }
    }
    #endregion

    #region "攻撃コマンド　(封印レベルD)"
    static class Class_ロジサマ_3001
    {
        public static void Execute()
        {
            string result = string.Empty;

            int cnt = 0;

            for (int i = 1;i <= 5; ++i)
            {
                string line = Console.ReadLine().Trim();
                if (line == "Attack")
                {
                    cnt += 100;
                }
            }

            result = cnt.ToString();
            Console.WriteLine(result);
        }
    }
    #endregion




}
