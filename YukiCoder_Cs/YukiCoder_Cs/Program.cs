using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YukiCoder_Cs
{
    class Program
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] list = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            
            string ans = "possible";
            if (list.Sum()% 2 != 0)
            {
                ans = "impossible";
            }
            else
            {
                int a = 0;
                int b = 0;

                for (int i = 0;i < N; ++i)
                {
                    for (int j = 0; j < N; ++j)
                    {

                    }

                }
                Array.Sort(list);
                Array.Reverse(list);
                foreach (var item in list)
                {
                    if (a > b)
                    {
                        b += item;
                    }
                    else
                    {
                        a += item;
                    }
                }

                if (a != b || list.Contains(Math.Abs(a - b) * 2) == false)
                {
                    ans = "impossible";
                }
            }
            Console.WriteLine(ans);
        }
    }
}
