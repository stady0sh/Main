using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paiza_
{
    #region "format"
    static class Class_D_format
    {
        public static void Execute()
        {
            string result = string.Empty;


            Console.WriteLine(result);
        }
    }
    #endregion

    #region "D007:N倍の文字列"
    static class Class_D_007
    {
        public static void Execute(string line)
        {
            string result = string.Empty;
            for (int i = 0; i < int.Parse(line); ++i)
            {
                result += "*";

            }

            Console.WriteLine(result);
        }
    }
    #endregion

    #region "D059:トランプ占い"
    static class Class_D_D059
    {
        public static void Execute()
        {
            List<string> card = Console.ReadLine().Trim().Split(' ').ToList();

            if (card.Where(s => s == "J").Count() == 2)
            {
                card[1] = "Q";
            }

            Console.WriteLine(string.Join(" ", card));
        }
    }
    #endregion

    #region "D060:AボタンとBボタン"
    static class Class_D_D060
    {
        public static void Execute()
        {
            int[] line = Console.ReadLine().Trim().Split(' ').Select(s => int.Parse(s)).ToArray();
            
            Console.WriteLine((line[0] - line[1]));
        }
    }
    #endregion

    #region "D061:3倍返し？"
    static class Class_D_D061
    {
        public static void Execute()
        {
            int n = int.Parse(Console.ReadLine());
            int r = 0;

            if (n == 0)
            {
                r = 1;
            }
            else
            {
                r = n * 3;
            }

            Console.WriteLine(r.ToString());
        }
    }
    #endregion

    #region " D062:ひな祭り "
    static class Class_D_D062
    {
        public static void Execute(string line)
        {
            List<string> list = line.Split(' ').ToList<string>();
            List<string> ひな壇 = new List<string>();

            Queue<string> 人形q = Init雛人形リスト();
            foreach (var item in list)
            {
                int n = int.Parse(item);
                string 雛人形列 = string.Empty;

                for (int i = 0;i < n; ++i)
                {
                    雛人形列 = 雛人形列 + 人形q.Dequeue();
                }

                ひな壇.Add(雛人形列);
            }

            foreach (var item in ひな壇)
            {
                Console.WriteLine(item);
            }
        }

        static Queue<string> Init雛人形リスト()
        {
            Queue<string> 人形q = new Queue<string>();
            人形q.Enqueue("A");
            人形q.Enqueue("B");
            人形q.Enqueue("C");
            人形q.Enqueue("D");
            人形q.Enqueue("E");
            人形q.Enqueue("F");
            人形q.Enqueue("G");
            人形q.Enqueue("H");
            人形q.Enqueue("I");
            人形q.Enqueue("J");

            return 人形q;
        } 
    }
    #endregion

    #region "D063:お花見の場所取り 70点"
    static class Class_D_D063
    {
        public static void Execute(string line)
        {
            List<string> list = line.Split(' ').ToList<string>();

            int Me = int.Parse(Console.ReadLine().Trim());

            int cnt = 1;
            foreach(string row in list.OrderBy(n => n))
            {
                if ( int.Parse(row) > Me)
                {
                    break;
                }
                cnt++;
            }

            Console.WriteLine(cnt.ToString());
        }
    }
    #endregion

    #region "D064:嘘つきの日"
    static class Class_D_D064
    {
        public static void Execute(string line)
        {
            string result = string.Empty;


            Console.WriteLine(line.Replace("False", "True"));
        }
    }
    #endregion

    #region "D065:エラーコードの分類"
    static class Class_D_D065
    {
        public static void Execute(string line)
        {
            string result = string.Empty;
            switch (line.Trim().Substring(0, 1))
            {
                case "2":
                    result = "ok";
                    break;
                case "4":
                    result = "error";
                    break;
                default:
                    result = "unknown";
                    break;
            }


            Console.WriteLine(result);
        }
    }
    #endregion

    #region "D067:スイッチのオンオフ"
    static class Class_D_067
    {
        public static void Execute(string line)
        {
            string result = string.Empty;
            int n = int.Parse(line);
            if (n % 2 == 0)
            {
                result = "OFF";
            }
            else
            {
                result = "ON";
            }


            Console.WriteLine(result);
        }
    }
    #endregion

}
