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
			var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			Array.Sort(a);

			var ret = 0;
			ret += Math.Abs(a[0] - a[1]);
			ret += Math.Abs(a[1] - a[2]);
			
			Console.WriteLine($"{ret}");

        }
    }
}
