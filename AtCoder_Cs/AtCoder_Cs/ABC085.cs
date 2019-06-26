using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_Cs
{
    class ABC085
    {


        public static void B()
        {
            var N = int.Parse(Console.ReadLine());
            var lst = new HashSet<int>();

            for (int i = 0; i < N; i++)
            {
                lst.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"{lst.Count()}");
        }


    }
}
