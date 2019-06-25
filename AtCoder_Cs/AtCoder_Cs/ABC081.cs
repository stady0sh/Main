using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_Cs
{
	public class ABC081
	{
		public static void A()
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

        public static void B()
        {
            var n = Console.ReadLine();
            var lst = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int cnt = 0;
            bool isEnd = false;

            do
            {

                for (int i = 0; i < lst.Count(); i++)
                {
                    if (lst[i] % 2 == 0)
                    {
                        lst[i] = lst[i] / 2;
                    }
                    else
                    {
                        isEnd = true;
                    }
                }

                if (!isEnd)
                {
                    cnt++;
                }

            } while (!isEnd);


            Console.WriteLine($"{cnt}");
        }
    }
}