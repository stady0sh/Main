using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_Cs
{
    public class Program
    {
        public static void Main()
        {
            var N = long.Parse(Console.ReadLine());
            long ret = N;


            for (long i = 1;i * i <= N;i++)
            {
                if (N % i == 0)
                {
                    long r = (i - 1) + (N / i) - 1;
                    if(r < ret) { ret = r; }
                    //break;
                }
            }

            Console.WriteLine($"{ret}");
        }
    }

}
