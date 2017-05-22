using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paiza_
{
    #region "format"
    static class Class_ロジサマ_format
    {
        public static void Execute(string line)
        {
            string result = string.Empty;
            
            Console.WriteLine(result);
        }
    }
    #endregion

    #region "復活の呪文　(封印レベルD)"
    static class Class_ロジサマ_1004
    {
        public static void Execute(string line)
        {
            string line2 = Console.ReadLine();

            string result = "NG";

            if (line.Trim() == line2.Trim())
            {
                result = "OK";
            }



            Console.WriteLine(result);
        }
    }
    #endregion

    #region "圧縮　　(封印レベルC)"
    static class Class_ロジサマ_2001
    {
        public static void Execute(string line)
        {
            List<string> result = new List<string>();
            int cnt = 0;
            string tmp = "b";

            for (int i = 0;i < line.Trim().Length; ++i)
            {
                string s = line.Substring(i, 1);
                
                if (tmp == s)
                {
                    cnt += 1;
                }
                else
                {
                    result.Add(cnt.ToString());
                    tmp = s;
                    cnt = 1;
                }


            }

            if (cnt > 0) { result.Add(cnt.ToString()); }
            


            Console.WriteLine(string.Join(" ",result));
        }
    }
    #endregion

    #region "攻撃コマンド　(封印レベルD)"
    static class Class_ロジサマ_3001
    {
        public static void Execute()
        {
            string result = string.Empty;

            int cnt = 0;

            for (int i = 1;i <= 5; ++i)
            {
                string line = Console.ReadLine().Trim();
                if (line == "Attack")
                {
                    cnt += 100;
                }
            }

            result = cnt.ToString();
            Console.WriteLine(result);
        }
    }
    #endregion

    #region "魔法陣　(封印レベルB)"
    static class Class_ロジサマ_2002
    { 
        public static void Execute()
        {
            int n = int.Parse(Console.ReadLine().Trim());  //ループ回数
            List<List<int>> list = new List<List<int>>();
            for (int i = 0; i < n; ++i)
            {
                List<string> 数値list = Console.ReadLine().Trim().Split(' ').ToList();
                list.Add(new List<int>());
                for (int j = 0;j < n; ++j)
                {
                    list[i].Add(int.Parse(数値list[j])); 
                }
            }

            int max = 0;    // 魔法陣の1行の和を求める
            foreach (var item in list)
            {
                if (item.Sum() > max) { max = item.Sum(); }
            }

            //横の比較（0が１つのもののみ）
            List<List<int>> resultList = new List<List<int>>();
            foreach (var item in list)
            {
                if (item.Where(i2 => i2 == 0).Count() == 1)
                {
                    resultList.Add(new List<int>(Update横List(item,max)));
                }
                else if (item.Where(i2 => i2 == 0).Count() == 0)
                {
                    resultList.Add(new List<int>(item));
                }
                else if (item.Where(i2 => i2 == 0).Count() >= 2)
                {
                    //resultList.Clear();
                    resultList.Add(new List<int>(Update横List0有り(item, max, list)));
                    break;
                }
            }

            //if (resultList.Count() == 0)
            //{
            //    //listの作成
            //    for (int i = 0; i < list.Count(); ++i)
            //    {
            //        resultList.Add(new List<int>());
            //    }

            //    //縦の比較
            //    for (int i = 0;i < list.Count(); ++i)
            //    {
            //        switch (GetCount列の0値(list, i)){
            //            case 0:
            //                var tmpList = Update縦List(list, i, max);
            //                int cnt = 0;
            //                foreach (var item in tmpList)
            //                {
            //                    resultList[cnt++].Add(item);
            //                }
            //                break;
            //            case 1:
            //                //resultList.Add(Update縦List(list, i, max));
            //                var tmpList2 = Update縦List(list, i, max);
            //                int cnt2 = 0;
            //                foreach (var item in tmpList2)
            //                {
            //                    resultList[cnt2++].Add(item);
            //                }
            //                break;
            //            default:
            //                resultList.Clear();
            //                break;

            //        }
            //    }

            //}

            // 結果表示
            foreach(var item in resultList)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }

        static List<int> Update横List(List<int> list, int max)
        {
            List<int> result = new List<int>();
            int x = max - list.Sum();
            foreach (var item in list)
            {
                if (item == 0)
                {
                    result.Add(x);
                }
                else
                {
                    result.Add(item);
                }
            }
            return result;
        }

        static List<int> Update横List0有り(List<int> items, int max, List<List<int>> list)
        {
            List<int> result = new List<int>();
            int x = max - items.Sum();
            int row = 0;
            foreach (var item in items)
            {
                if (item == 0)
                {
                    int 列total = 0;
                    for (int i = 0;i < list.Count(); ++i)
                    {
                        列total += list[i][row];
                    }
                    result.Add(max - 列total);
                }
                else
                {
                    result.Add(item);
                }
                row++;
            }
            return result;
        }

        //static int GetCount列の0値(List<List<int>> list, int n)
        //{
        //    int cnt = 0;
        //    for (int i = 0; i < list.Count(); ++i)
        //    {
        //        if (list[i][n] == 0) { ++cnt; }
        //    }
        //    return cnt;
        //}

        //static List<int> Update縦List(List<List<int>> list, int n ,int max)
        //{
        //    List<int> resultList = new List<int>();
        //    //for (int i = 0; i < list.Count(); ++i)
        //    //{
        //    //    resultList.Add(new List<int>());
        //    //}
        //    for (int i = 0; i < list.Count(); ++i)
        //    {
        //        if (list[i][n] == 0)
        //        {
        //            int sm = 0;
        //            for (int j = 0; j < list.Count(); ++j)
        //            {
        //                sm += list[j][n];
        //            }
        //            resultList.Add(max - sm);

        //        }
        //        else
        //        {
        //            resultList.Add(list[i][n]);
        //        }
        //    }
        //    return resultList;
        //}

    }
    #endregion



}
