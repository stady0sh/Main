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
        static string s1 = "dream";
        static string s2 = "dreamer";
        static string s3 = "erase";
        static string s4 = "eraser";

        public static void C()
        {
            string S = Console.ReadLine();

            bool ret = NextWith(S);

            string ans = ret ? "YES" : "NO";
            Console.WriteLine($"{ans}");

        }

        private static bool NextWith(string S)
        {

            if (S.Length == 0)
            {
                return true;
            }

            if (S.Length == s1.Length && S.EndsWith(s1))
            {
                if (NextWith(S.Substring(S.Length - s1.Length))) return true;
            }
            if (S.Length == s2.Length && S.EndsWith(s2))
            {
                if (NextWith(S.Substring(S.Length - s2.Length))) return true;
            }
            if (S.Length == s3.Length && S.EndsWith(s3))
            {
                if (NextWith(S.Substring(S.Length - s3.Length))) return true;
            }
            if (S.Length == s4.Length && S.EndsWith(s4))
            {
                if (NextWith(S.Substring(S.Length - s4.Length))) return true;
            }

            return false;
        }
        #endregion

    }
}
