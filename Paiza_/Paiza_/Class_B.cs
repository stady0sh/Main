using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paiza_
{
    #region "format"
    static class Class_B_format
    {
        public static void Execute()
        {
            string line = Console.ReadLine().Trim();
            string result = string.Empty;


            Console.WriteLine(result);
        }
    }
    #endregion

    #region "B035:ジョギングランキング"
    static class Class_B_B035
    {
        public static void Execute()
        {
            string line1 = Console.ReadLine().Trim();
            List<string> line1List = line1.Split(' ').ToList();
            int N = int.Parse(line1List[0]);    // 部員の人数
            int M = int.Parse(line1List[1]);    // 今月のジョギング記録の数
            int T = int.Parse(line1List[2]);    // 成績表に表示される上位の人数

            Dictionary<string, int> 先月の記録 = new Dictionary<string, int>();
            Dictionary<string, int> 今月の記録 = new Dictionary<string, int>();
            for (int i = 0;i < N; ++i)
            {
                string[] 先月の記録配列 = Console.ReadLine().Trim().Split(' ');
                先月の記録.Add(先月の記録配列[0], int.Parse(先月の記録配列[1]));
                今月の記録.Add(先月の記録配列[0], 0);
            }

            for (int i = 0; i < M; ++i)
            {
                string[] 今月の記録配列 = Console.ReadLine().Trim().Split(' ');
                今月の記録[今月の記録配列[1]] += int.Parse(今月の記録配列[2]);
            }
            
            var 先月成績list = 先月の記録.OrderByDescending(s => s.Value).ThenBy(s => s.Key).Take(T).Select((c,i) => new { Content = c, Index = i });
            var 成績list = 今月の記録.OrderByDescending(s => s.Value).ThenBy(s => s.Key).Take(T).Select((c, i) => new { Content = c, Index = i });

            foreach (var item in 成績list)
            {
                string result = string.Empty;
                if (先月成績list.Where(s => s.Content.Key == item.Content.Key).Count() == 0)
                {
                    result = "new";
                }
                else if (先月成績list.Where(c => c.Content.Key == item.Content.Key).First().Index > item.Index)
                {
                    result = "up";
                }
                else if (先月成績list.Where(c => c.Content.Key == item.Content.Key).First().Index < item.Index)
                {
                    result = "down";
                }
                else if (先月成績list.Where(c => c.Content.Key == item.Content.Key).First().Index == item.Index)
                {
                    result = "same";
                }

                Console.WriteLine($"{item.Content.Key} {item.Content.Value} {result}");
            }

        }
    }
    #endregion

    #region "B037:【2017年お正月問題】幸運な1年"
    static class Class_B_B037
    {
        public static void Execute()
        {
            Queue<string> 日付 = Init日付(Console.ReadLine().Trim());    // 日付を分解してQueueに格納
            List<int> 乱数A = 分割(Console.ReadLine().Trim());    // 日付を分解してQueueに格納
            List<int> 乱数B = 分割(Console.ReadLine().Trim());    // 日付を分解してQueueに格納
            List<int> 乱数M = 分割(Console.ReadLine().Trim());    // 日付を分解してQueueに格納

            int cnt = 0;
            List<int> 乱数W = new List<int>();
            List<int> 乱数Wtmp = new List<int>();
            for (int i = 0; i < 10000; ++i)
            {
                if (乱数W.Count == 0)
                {
                    乱数W.Add(0);
                    乱数W.Add(0);
                    乱数W.Add(0);
                    乱数W.Add(0);
                }
                Queue<string> 日付a = new Queue<string>(日付);
                cnt = i + 1;
                List<int> カード = new List<int>();
                乱数Wtmp.Clear();
                for (int j = 0; j < 4; ++j)
                {
                    //カード.Add(((乱数A[j] * 乱数W[j] + 乱数B[j]) % 乱数M[j])% 10);    // 乱数からカードを作成
                    var 余り = ((乱数A[j] * 乱数W[j] + 乱数B[j]) % 乱数M[j]);
                    乱数Wtmp.Add(余り);
                    カード.Add(余り % 10);    // 乱数からカードを作成
                }

                List<int> カードa = new List<int>(カード);
                if (カードチェック(日付a, カード))
                {
                    break;
                }

                乱数W.Clear();
                foreach (var item in 乱数Wtmp)
                {
                    乱数W.Add(item);
                }

            }



            Console.WriteLine(cnt.ToString());
        }

        static Queue<string> Init日付(string line)
        {
            Queue<string> result = new Queue<string>();
            string[] s = line.Split(' ');
            foreach (string item in s)
            {
                if (item.Length == 1)
                {
                    result.Enqueue("0");
                    result.Enqueue(item.Substring(0, 1));
                }
                else
                {
                    result.Enqueue(item.Substring(0, 1));
                    result.Enqueue(item.Substring(1, 1));
                }
            }
            return result;
        }

        static List<int> 分割(string line)
        {
            List<int> list = new List<int>();
            List<string> str = line.Split(' ').ToList();
            foreach (var item in str)
            {
                list.Add(int.Parse(item));
            }
            return list;
        }

        static Boolean カードチェック(Queue<string> 日付, List<int> カード)
        {
            while (日付.Count > 0)
            {
                string s = 日付.Dequeue();
                if (カード.Contains(int.Parse(s)))
                {
                    カード.Remove(int.Parse(s));
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
    #endregion

    #region "B040:【キャンペーン問題】たのしい暗号解読"
    static class Class_B_040
    {
        public static void Execute(string line)
        {
            string[] str = line.Split(' ');
            int n = int.Parse(str[0]);  //ループ回数
            Dictionary<string, string> 変換list = Init変換list(new Dictionary<string, string>(), str[1].ToLower());

            List<string> 変換後list = new List<string>();
            List<string> 対象list = new List<string>();
            string 対象列 = Console.ReadLine().ToLower();
            for (int i = 0; i < 対象列.Length; ++i)
            {
                対象list.Add(対象列[i].ToString());
            }

            for (int j = 0;j < n; ++j){
                if (変換後list.Count > 0)
                {
                    対象list = new List<string>(変換後list);
                    変換後list.Clear();
                }

                foreach (string 対象row in 対象list)
                {
                    if (変換list.ContainsKey(対象row))
                    {
                        変換後list.Add(変換list[対象row]);
                    }
                    else
                    {
                        変換後list.Add(対象row);
                    }
                }
            }


            Console.WriteLine(string.Join("", 変換後list));
        }

        public static Dictionary<string, string> Init変換list(Dictionary<string, string> 変換list,string 文字列)
        {
            int i = 0;
            変換list.Add(文字列.Substring(i++,1), "a");
            変換list.Add(文字列.Substring(i++,1), "b");
            変換list.Add(文字列.Substring(i++,1), "c");
            変換list.Add(文字列.Substring(i++,1), "d");
            変換list.Add(文字列.Substring(i++,1), "e");
            変換list.Add(文字列.Substring(i++,1), "f");
            変換list.Add(文字列.Substring(i++,1), "g");
            変換list.Add(文字列.Substring(i++,1), "h");
            変換list.Add(文字列.Substring(i++,1), "i");
            変換list.Add(文字列.Substring(i++,1), "j");
            変換list.Add(文字列.Substring(i++,1), "k");
            変換list.Add(文字列.Substring(i++,1), "l");
            変換list.Add(文字列.Substring(i++,1), "m");
            変換list.Add(文字列.Substring(i++,1), "n");
            変換list.Add(文字列.Substring(i++,1), "o");
            変換list.Add(文字列.Substring(i++,1), "p");
            変換list.Add(文字列.Substring(i++,1), "q");
            変換list.Add(文字列.Substring(i++,1), "r");
            変換list.Add(文字列.Substring(i++,1), "s");
            変換list.Add(文字列.Substring(i++,1), "t");
            変換list.Add(文字列.Substring(i++,1), "u");
            変換list.Add(文字列.Substring(i++,1), "v");
            変換list.Add(文字列.Substring(i++,1), "w");
            変換list.Add(文字列.Substring(i++,1), "x");
            変換list.Add(文字列.Substring(i++,1), "y");
            変換list.Add(文字列.Substring(i++,1), "z");

            return 変換list;
        }
    }
    #endregion

    #region "B041:繰り返し模様 "
    static class Class_B_B041
    {
        public static void Execute()
        {
            int k = int.Parse(Console.ReadLine().Trim());
            int n = int.Parse(Console.ReadLine().Trim());
            string result = string.Empty;

            // 図形の取得
            List<string> list = new List<string>();
            for (int i = 0;i < n; ++i)
            {
                list.Add(Console.ReadLine().Trim());
            }

            // 生成
            for (int j = 1;j <= k; ++j)
            {
                int cnt = 0;
                List<string> newList = new List<string>();
                // List = #..
                //        ##.
                //        ###
                foreach (var item in list)
                {
                    // item = #..
                    List<List<string>> tmpList = new List<List<string>>();
                    // tmpListのコンストラクタ
                    for (int q = 0; q < item.Length; ++q)
                    {
                        tmpList.Add(new List<string>());
                    }

                    for (int m = 0;m < item.Length; ++m)
                    {

                        int o = 0;
                        if (item.Substring(m, 1) == ".")
                        {
                            foreach (var item2 in list)
                            {
                                tmpList[o++].Add(item2.Replace('#', '.'));
                            }
                        }
                        else
                        {
                            foreach (var item2 in list)
                            {
                                tmpList[o++].Add(item2);
                            }
                        }
                        
                    }

                    foreach (var item2 in tmpList)
                    {
                        newList.Add(string.Join("", item2));
                    }

                    ++cnt;
                }

                list = newList;
                
            }


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
        }
    }
    #endregion


}
