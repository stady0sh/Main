using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza
{
    class Class_ロジックサマナー
    {
        public static void TEST1(string line)
        {
            Queue<string> q = new Queue<string>();
            Stack<string> s = new Stack<string>();

            int n = int.Parse(line);
            var line2 = Console.ReadLine().Trim();
            for (int i = 0; i < n; ++i)
            {
                string str = line2.Substring(i, 1);
                switch (str)
                {
                    case "R":
                        q.Enqueue((i + 1).ToString());
                        break;
                    case "L":
                        s.Push((i + 1).ToString());
                        break;
                }
            }

            var str1 = string.Join(" ", s);
            var str2 = string.Join(" ", q);
            Console.WriteLine($"{str1} {str2}".Trim());
            
        }

    }
}
