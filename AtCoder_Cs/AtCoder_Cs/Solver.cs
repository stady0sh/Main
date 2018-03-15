    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_Cs
{
    class Solver
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                Program.Main();
                sw.Stop();
                Console.WriteLine($"{sw.Elapsed}");
                string line = Console.ReadLine().Trim();
                if (line == "") { return; }
            }
        }
    }
}
