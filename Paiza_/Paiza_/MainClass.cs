using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Solution
//{
//    class Solution
//    {
//        static void Main(string[] args)
//        {
//            var line1 = System.Console.ReadLine().Trim();
//            var N = Int32.Parse(line1);
//            for (var i = 0; i < N; i++)
//            {
//                string[] stArrayData = System.Console.ReadLine().Trim().Split(',');
//                System.Console.WriteLine("hello = {0} , world = {1}", stArrayData[0], stArrayData[1]);
//            }
//        }
//    }
//} 

namespace Paiza_
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var line = System.Console.ReadLine().Trim();
            Class_B_040.Execute(line);

            Console.ReadLine();
        }
    }
}
