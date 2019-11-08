using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_Cs
{
    public class ABC144
    {

        #region A
        public static void A()
        {
            var N = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int ret = -1;
            if (9 >= N[0] && N[0] >= 1 && 9 >= N[1] && N[1] >= 1)
            {
                ret = N[0] * N[1];
            }
            Console.WriteLine($"{ret}");
        }
        #endregion

        #region B
        public static void B()
        {
            var N = int.Parse(Console.ReadLine());
            string ret = "No";

            if (IsHitPattern(N))
            {
                ret = "Yes";
            }
            Console.WriteLine($"{ret}");
        }

        private static bool IsHitPattern(int N)
        {
            var num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var lst = new HashSet<int>();

            foreach (int i in num)
            {
                foreach (int j in num)
                {
                    lst.Add(i * j);
                }

            }

            return lst.Contains(N);
        }
        #endregion

        #region C
        public static void C()
        {
            var N = long.Parse(Console.ReadLine());
            long ret = N;


            for (long i = 1; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    long r = (i - 1) + (N / i) - 1;
                    if (r < ret) { ret = r; }
                    //break;
                }
            }

            Console.WriteLine($"{ret}");
        }
        #endregion

        #region D

        #endregion

    }
}
