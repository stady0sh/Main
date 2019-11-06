using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtCoder_Cs;

namespace LocalTest用
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var sw = new System.Diagnostics.Stopwatch();
                sw.Start();

                AtCoder_Cs.Program.Main();

				sw.Stop();

                Console.WriteLine($"処理時間＝{sw.Elapsed}");

            }

        }
    }
}
