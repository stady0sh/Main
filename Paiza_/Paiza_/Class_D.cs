using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paiza_
{
    #region "format"
    static class Class_D_format
    {
        public static void Execute(string line)
        {
            string result = string.Empty;


            Console.WriteLine(result);
        }
    }
    #endregion

    #region "D007:N倍の文字列"
    static class Class_D_007
    {
        public static void Execute(string line)
        {
            string result = string.Empty;
            for (int i = 0; i < int.Parse(line); ++i)
            {
                result += "*";

            }

            Console.WriteLine(result);
        }
    }
    #endregion

    #region "D063:お花見の場所取り 70点"
    static class Class_D_D063
    {
        public static void Execute(string line)
        {
            List<string> list = line.Split(' ').ToList<string>();

            int Me = int.Parse(Console.ReadLine().Trim());

            int cnt = 1;
            foreach(string row in list.OrderBy(n => n))
            {
                if ( int.Parse(row) > Me)
                {
                    break;
                }
                cnt++;
            }

            Console.WriteLine(cnt.ToString());
        }
    }
    #endregion

    #region "D067:スイッチのオンオフ"
    static class Class_D_067
    {
        public static void Execute(string line)
        {
            string result = string.Empty;
            int n = int.Parse(line);
            if (n % 2 == 0)
            {
                result = "OFF";
            }
            else
            {
                result = "ON";
            }


            Console.WriteLine(result);
        }
    }
    #endregion

    #region "D065:エラーコードの分類"
    static class Class_D_D065
    {
        public static void Execute(string line)
        {
            string result = string.Empty;
            switch (line.Trim().Substring(0, 1))
            {
                case "2":
                    result = "ok";
                    break;
                case "4":
                    result = "error";
                    break;
                default:
                    result = "unknown";
                    break;
            }


            Console.WriteLine(result);
        }
    }
    #endregion
}
