using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_Cs
{
    public class Program
    {

        private static string s1 = "dream";
        private static string s2 = "dreamer";
        private static string s3 = "erase";
        private static string s4 = "eraser";

        private static string S { get; set; }
        private static Dictionary<int, bool> memo;

        public static void Main()
        {
            S = Console.ReadLine();

            memo = new Dictionary<int, bool>();

            bool ret = NextWith(0);

            string ans = ret ? "YES" : "NO";
            Console.WriteLine($"{ans}");

        }

        private static bool NextWith(int index)
        {

            if (index == S.Length)
            {
                return true;
            }

            if (!memo.ContainsKey(index))
            {
                memo[index] = NextWithCode(index);
            }

            return memo[index];
        }

        private static bool NextWithCode(int index)
        {
            if (S.Substring(index).StartsWith(s1))
            {
                if (NextWith(index + s1.Length)) return true;
            }
            if (S.Substring(index).StartsWith(s2))
            {
                if (NextWith(index + s2.Length)) return true;
            }
            if (S.Substring(index).StartsWith(s3))
            {
                if (NextWith(index + s3.Length)) return true;
            }
            if (S.Substring( index).StartsWith(s4))
            {
                if (NextWith(index + s4.Length)) return true;
            }

            return false;

        }

    }
}
