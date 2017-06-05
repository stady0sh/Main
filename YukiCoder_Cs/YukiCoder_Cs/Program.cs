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
            int p = 3;
            int 誤差 = 1000000;
            double n = double.Parse(Console.ReadLine());
            double ans = Math.Sqrt(n / p);
            Console.WriteLine(Math.Ceiling(ans / 誤差) * 誤差);
        }
    }
}
