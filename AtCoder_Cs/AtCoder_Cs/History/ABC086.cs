using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_Cs
{
	public class ABC086
	{
		public static void A()
        {
            var c = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var m = c[0] * c[1];

            string ret = m % 2 == 0 ? "Even" : "Odd";

            Console.WriteLine($"{ret}");
        }

	}

}
