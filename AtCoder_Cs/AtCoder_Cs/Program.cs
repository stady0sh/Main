using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder_Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> Group1 = new List<int>() { 1, 3, 5, 7, 8, 10, 12 };
            //List<int> Group2 = new List<int>() { 4, 6, 9, 11 };
            //List<int> Group3 = new List<int>() { 2 };

            //int[] line1 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            //List<int> resultList = new List<int>();
            //foreach ( var item in line1)
            //{
            //    if (Group1.Contains(item))
            //    {
            //        resultList.Add(1);
            //    }
            //    else if (Group2.Contains(item))
            //    {
            //        resultList.Add(2);
            //    }
            //    else if (Group3.Contains(item))
            //    {
            //        resultList.Add(2);
            //    }
            //}
            List<int> Group = new List<int> (){ 0, 1, 3, 1, 2, 1, 2, 1, 1, 2, 1, 2, 1 };
            List<int> line1 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            List<int> resultList = new List<int>();

            foreach ( var item in line1)
            {
                resultList.Add(Group[item]);
            }

            Console.WriteLine((resultList[0] == resultList[1]) ? "Yes" : "No");
            Console.ReadLine();
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] line = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
    //        int N = line[0];
    //        int K = line[1];
    //        List<string> list = new List<string>();
    //        //string[] list = null;
    //        int a = 0;

    //        for (int i = 0; i < N; ++i)
    //        {
    //            string[] line2 = Console.ReadLine().Trim().Split(' ');
    //            for (int j = 0; j < int.Parse(line2[1]); ++j)
    //            {
    //                list.Add(line2[0]);

    //            }
    //        }

    //        //var ans = list.OrderBy(s => s).Select(s => s);
    //        var newList = list.ToArray();
    //        Array.Sort(newList);
    //        int cnt = 1;
    //        string result = string.Empty;
    //        foreach (var item in list)
    //        {
    //            if (cnt == K)
    //            {
    //                result = item.ToString();
    //                break;
    //            }
    //            ++cnt;
    //        }
    //        Console.WriteLine($"{result}");
    //        Console.ReadLine();
    //    }
    //}
}
