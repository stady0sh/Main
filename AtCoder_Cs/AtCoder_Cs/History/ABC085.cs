using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_Cs
{
    class ABC085
    {


        public static void B()
        {
            var N = int.Parse(Console.ReadLine());
            var lst = new HashSet<int>();

            for (int i = 0; i < N; i++)
            {
                lst.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"{lst.Count()}");
        }

        public static void C()
        {
            int[] inp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = inp[0];
            int Y = inp[1];

            var ansList = new List<string>();

            for (int i = 0; i <= N; i++) // 1000円
            {
                for (int j = 0; j <= N - i; j++) // 5000円
                {
                    //for (int k = 0; k <= N; k++) // 10000円
                    //{
                    //    if ((i * 1000 + j * 5000 + k * 10000 == Y) && (k + j + i == N))
                    //    {
                    //        ansList.Add($"{k} {j} {i}");
                    //        break;
                    //    }
                    //}
                    //if (ansList.Any()) break;
                    int k = (N - i - j);
                    if (i * 1000 + j * 5000 + k * 10000 == Y)
                    {
                        ansList.Add($"{k} {j} {i}");
                        break;
                    }
                }
                if (ansList.Any()) break;
            }

            if (!ansList.Any())
            {
                Console.WriteLine("-1 -1 -1");
            }
            else
            {
                Console.WriteLine(ansList.First());
            }
        }

    }
}
