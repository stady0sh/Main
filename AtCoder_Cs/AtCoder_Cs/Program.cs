using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_Cs
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Trim().Split(' ');
            int H = int.Parse(line1[0]);
            int W = int.Parse(line1[1]);
            List<string> list = new List<string>();
            for (int i = 0; i < H; ++i)
            {
                list.Add(Console.ReadLine().Trim());
            }

            // 出力
            string 枠 = "#";
            string 外行 = string.Empty;

            for (int i = 0; i < W + 2; ++i)
            {
                外行 += 枠;
            }

            List<string> resultList = new List<string>();
            resultList.Add(外行);
            foreach (var item in list)
            {
                resultList.Add($"{枠}{item}{枠}");
            }
            resultList.Add(外行);
            foreach (var item in resultList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
