using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paiza_
{

    #region "format"
    static class Class_C_format
    {
        public static void Execute()
        {
            string result = string.Empty;
            var line = System.Console.ReadLine().Trim();


            Console.WriteLine(result);
        }
    }
    #endregion

    #region "問題05"
    static class Class_C_C005
    {
        public static void Execute(string line)
        {

            var N = Int32.Parse(line);
            string[] ip = new string[N];
            for (var i = 0; i < N; ++i)
            {
                ip[i] = System.Console.ReadLine().Trim();
            }

            foreach (string ln in ip)
            {
                string result = "True";
                string[] splt = ln.Split('.');
                try
                {
                    for (int i = 0; i < splt.Count(); ++i)
                    {
                        if (int.Parse(splt[i]) < 0)
                        {
                            result = "False";
                            break;
                        }
                        else if (int.Parse(splt[i]) > 255)
                        {
                            result = "False";
                            break;
                        }
                        else if (i > 4)
                        {
                            result = "False";
                            break;
                        }
                    }
                }
                catch
                {
                    result = "False";
                }

                Console.WriteLine(result);

            }
        }
    }
    #endregion

    #region "問題05_ver2"
    static class Class_C_C005_2
    {
        public static void Execute(string line)
        {
            int 回数 = int.Parse(line);
            List<string> list = new List<string>();

            for (int i = 0; i < 回数; ++i)
            {
                try
                {
                    string[] ip = Console.ReadLine().Trim().Split('.');
                    string result = "True";
                    if (ip.Count() != 4)
                    {
                        result = "False";
                    }
                    foreach (string str in ip)
                    {
                        if (int.Parse(str) > 255 || int.Parse(str) < 0)
                        {
                            result = "False";
                        }
                    }
                    list.Add(result);
                }
                catch
                {
                    list.Add("False");
                }
            }

            foreach (string str in list)
            {
                Console.WriteLine(str);
            }
        }
    }
    #endregion

    #region "C033:野球の審判"
    static class Class_C_C033
    {
        public static void Execute()
        {
            List<string> result = new List<string>();
            var n = int.Parse(System.Console.ReadLine().Trim());

            Queue<string> ストライク判定 = new Queue<string>();
            Queue<string> ボール判定 = new Queue<string>();
            for (int i = 0;i < n; ++i)
            {
                string str = Console.ReadLine().Trim();

                if (str == "strike")
                {
                    if (ストライク判定.Count >= 2)
                    {
                        result.Add("out!");
                        ストライク判定.Enqueue(str);
                    }
                    else
                    {
                        result.Add("strike!");
                        ストライク判定.Enqueue(str);
                    }
                }
                else if (str == "ball")
                {
                    if (ボール判定.Count >= 3)
                    {
                        result.Add("fourball!");
                        ボール判定.Enqueue(str);
                    }
                    else
                    {
                        result.Add("ball!");
                        ボール判定.Enqueue(str);
                    }
                }

            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
    #endregion

    #region "C034:先生の宿題"
    static class Class_C_C034
    {
        public static void Execute()
        {
            var line = System.Console.ReadLine().Trim();    // "a op b = c"
            string a = line.Substring(0, 1);
            string op = line.Substring(2, 1);
            string b = line.Substring(4, 1);
            string c = line.Substring(8, 1);
            int result = 0;
            
            if (c == "x")
            {
                if(op == "+")
                {
                    result = int.Parse(a) + int.Parse(b);
                }
                else
                {
                    result = int.Parse(a) - int.Parse(b);
                }
            }
            else if (a == "x")
            {
                if (op == "+")
                {
                    result = int.Parse(c) - int.Parse(b);
                }
                else
                {
                    result = int.Parse(b) + int.Parse(c);
                }
            }
            else 
            {
                if (op == "+")
                {
                    result = int.Parse(c) - int.Parse(a);
                }
                else
                {
                    result = int.Parse(a) - int.Parse(c);
                }
            }
            
            Console.WriteLine(result.ToString());
        }
    }
    #endregion

    #region "C037:アニメの日時"
    static class Class_C_C037
    {
        public static void Execute()
        {
            string result = string.Empty;
            var line = System.Console.ReadLine().Trim();    //  "MM/dd hh:mm" 
            int 月 = int.Parse(line.Substring(0, 2));
            int 日 = int.Parse(line.Substring(3, 2));
            int 時 = int.Parse(line.Substring(6, 2));
            int 分 = int.Parse(line.Substring(9, 2));

            if (時 / 24 >= 1)
            {
                日 = 日 + (時 / 24);
                時 = 時 % 24;
            }

            result = $"{月:00}/{日:00} {時:00}:{分:00}";
            Console.WriteLine(result);
        }
    }
    #endregion

    #region "C038:お菓子の分配"
    static class Class_C_C038
    {
        public static void Execute()
        {
            //string result = string.Empty;
            var line1 = System.Console.ReadLine().Trim();    // [M N] M:機械の数　N:容器の容量
            List<string> list1 = line1.Split(' ').ToList<string>();
            int m = int.Parse(list1[0]);    // 機械の数
            int n = int.Parse(list1[1]);    // 容器の容量

            List<int> 機械list = new List<int>();
            for ( int i = 0;i < m; ++i)
            {
                機械list.Add(int.Parse(Console.ReadLine()));  // 各機械の梱包容量
            }

            int 容器 = 0;
            int 余り = 0;
            int tmp容器 = 0;
            int tmp余り = 0;
            int result = 0;
            for (int i = 0;i < 機械list.Count(); ++i)
            {
                if (i == 0)
                {
                    容器 = 機械list[i];
                    余り = (n % 機械list[i]);
                    result = 1;
                    continue;
                }
                else
                {
                    tmp容器 = 機械list[i];
                    tmp余り = (n % 機械list[i]);

                }

                if (tmp余り > 余り)
                {
                    continue;
                }
                else
                {
                    if (tmp余り == 余り && tmp容器 <= 容器)
                    {
                        continue;
                    }
                    容器 = tmp容器;
                    余り = tmp余り;
                    result = i + 1;
                }
                
            }
            
            Console.WriteLine(result.ToString());
        }
    }
    #endregion

    #region "C039:古代の数式"
    static class Class_C_C039
    {
        public static void Execute(string line)
        {
            string result = string.Empty;

            List<string> list = line.Trim().Split('+').ToList<string>();
            List<int> 数値list = new List<int>();

            foreach (var item in list)
            {
                int 数値 = 0;
                for (int i = 0;i < item.Length; ++i)
                {
                    switch (item.Substring(i, 1))
                    {
                        case "/":
                            数値 += 1;
                            break;
                        case "<":
                            数値 += 10;
                            break;
                        default:
                            break;
                    }
                }
                数値list.Add(数値);
            }

            result = 数値list.Sum().ToString();

            Console.WriteLine(result);
        }
    }
    #endregion

    #region "C040:【ロジサマコラボ問題】背比べ"
    static class Class_C_C040
    {
        public static void Execute(string line)
        {
            int n = int.Parse(line);
            float max = 200F;
            float min = 100F;

            for (int i = 0; i < n; ++i)
            {
                string str = Console.ReadLine().Trim();
                //if (i == n - 1) { break; } // 最終行の改行は無視
                string[] list = str.Split(' ');

                switch (list[0])
                {
                    case "le":  // 以下
                        if (max > float.Parse(list[1]))
                        {
                            max = float.Parse(list[1]);
                        }
                        break;
                    case "ge":  // 超過
                        if (min < float.Parse(list[1]))
                        {
                            min = float.Parse(list[1]);
                        }
                        break;
                }
            }

            string result = $"{min:0.0} {max:0.0}";

            Console.WriteLine(result);
        }
    }
    #endregion


}
