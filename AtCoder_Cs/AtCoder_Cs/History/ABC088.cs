using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_Cs
{
    class ABC088
    {
        #region A

        #endregion

        #region B
        public static void B()
        {
            var cnt = int.Parse(Console.ReadLine());
            var lst = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(lst);
            Array.Reverse(lst);

            int A = 0;
            int B = 0;

            for (int i = 0; i <= lst.Count() - 1; i++)
            {
                if (i % 2 == 0)
                {
                    A += lst[i];
                }
                else
                {
                    B += lst[i];
                }
            }

            Console.WriteLine($"{A - B}");
        }

        #endregion

        #region C

        #endregion

        #region D

        #endregion

    }
}
