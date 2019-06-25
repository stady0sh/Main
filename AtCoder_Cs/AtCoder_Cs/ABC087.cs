using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_Cs
{
    class ABC087
    {

        public static void B()
        {
            var c500 = int.Parse(Console.ReadLine());
            var c100 = int.Parse(Console.ReadLine());
            var c50 = int.Parse(Console.ReadLine());
            var sum = int.Parse(Console.ReadLine());

            int sum500 = 0;
            int sum100 = 0;
            int sum50 = 0;

            int cnt = 0;

            for (int i = 0; i <= c500; i++)
            {
                sum500 = 500 * i;

                if (sum500 + sum100 + sum50 == sum)
                {
                    cnt++;
                    continue;
                }

                sum100 = 0;
                for (int j = 0; j <= c100; j++)
                {
                    sum100 = 100 * j;

                    if (sum500 + sum100 + sum50 == sum)
                    {
                        cnt++;
                        continue;
                    }

                    sum50 = 0;
                    for (int k = 0; k <= c50; k++)
                    {
                        sum50 = 50 * k;

                        if (sum500 + sum100 + sum50 == sum)
                        {
                            cnt++;
                            continue;
                        }

                    }
                }
            }

            Console.WriteLine($"{cnt}");
        }

    }
}
