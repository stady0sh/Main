using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_Cs
{
	public class ABC86
	{
		public static void ABC86_A()
		{
			var lst = Console.ReadLine().Split(' ');
			var res = int.Parse(lst[0]) * int.Parse(lst[1]);

			var resString = (res % 2 == 0) ? "Even" : "Odd";
			Console.WriteLine($"{resString}");
		}

	}

}
