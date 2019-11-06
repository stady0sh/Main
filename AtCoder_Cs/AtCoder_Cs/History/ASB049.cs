using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_Cs
{
    class ASB049
    {

        #region C
        private static string s1 = "dream";
        private static string s2 = "dreamer";
        private static string s3 = "erase";
        private static string s4 = "eraser";

        private static string S { get; set; }

        public static void C()
        {
            S = Console.ReadLine();

            bool ret = NextWith(S.Length);

            string ans = ret ? "YES" : "NO";
            Console.WriteLine($"{ans}");

        }

        private static bool NextWith(int len)
        {

            if (S.Substring(0, len).Length == 0)
            {
                return true;
            }

            if (S.Substring(0, len).EndsWith(s1))
            {
                if (NextWith(len - s1.Length)) return true;
            }
            if (S.Substring(0, len).EndsWith(s2))
            {
                if (NextWith(len - s2.Length)) return true;
            }
            if (S.Substring(0, len).EndsWith(s3))
            {
                if (NextWith(len - s3.Length)) return true;
            }
            if (S.Substring(0, len).EndsWith(s4))
            {
                if (NextWith(len - s4.Length)) return true;
            }

            return false;
        }
        #endregion

    }
}
