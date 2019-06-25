using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_Cs
{
    class ABC083
    {

        public static void B()
        {
            var lst = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int res = 0;

            int min = lst[1];
            int max = lst[2];

            for (int i = 0; i <= lst[0]; i++)
            {
                int sum = 0;
                for (int j = 0; j < i.ToString().Length; j++)
                {
                    sum += int.Parse(i.ToString().Substring(j, 1));
                }

                if (max >= sum && sum >= min)
                {
                    res += i;
                }
            }

            Console.WriteLine($"{res}");
        }

    }
}
