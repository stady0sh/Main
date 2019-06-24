using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_Cs
{
	public class ABC081
	{
		public static void Main()
		{
			var lin = Console.ReadLine();
			var cnt = 0;
			for (int i = 0; i <= 2; i++)
			{
				if (lin[i] == '1')
				{
					cnt++;
				}
			}
			Console.WriteLine($"{cnt}");

		}
	}
}
