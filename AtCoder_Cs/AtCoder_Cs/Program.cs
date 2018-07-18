using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_Cs
{
    public class Program
    {
        private static Int32 ReadInt32()
        {
            return int.Parse(Console.ReadLine());
        }

        public static void Main()
        {
            var m = ReadInt32();

            var ret = 0;

            if (m < 100)
            {
                ret = 0;
            }
            else if (m < 5000)
            {
                ret = m / 1000 * 10;
            }
            else if (m < 30000)
            {

            }
            else if (m < 70000)
            {

            }
            else
            {

            }

            Console.WriteLine($"{ret,00}");

        }
    }
}
