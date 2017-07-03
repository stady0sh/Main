using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doukaku.Org
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleCalender calender = new ConsoleCalender();
            calender.PrintYearCalender(2014);

            // calender.PrintYearCalender(2014,11);  2014/11だけ表示 こんな呼び出し方もできる。
            Console.ReadLine();
        }
    }
}

namespace Doukaku.Org
{

    // CalenderMakerCoreを利用して、カレンダーを作成する。
    // このクラスは、表示に専念
    class ConsoleCalender
    {
        public void PrintYearCalender(int year)
        {
            for (int m = 1; m <= 12; m++)
            {
                PrintMonthCalender(year, m);
                Console.WriteLine();
            }
        }

        public void PrintMonthCalender(int year, int month)
        {
            foreach (var item in GetMonthCalender(year, month))
            {
                Console.WriteLine(item);
            }
        }

        IEnumerable<string> GetMonthCalender(int year, int month)
        {
            List<string> lines = new List<string>();
            yield return string.Format("      {0}年{1}月", year, month);
            yield return " 日 月 火 水 木 金 土";
            var seq = CalenderMakerCore.GetMonthCalender(year, month);
            var q = seq.Select(w => w.Aggregate("", (line, d) => line += String.Format("{0,3:#}", d)));
            foreach (var s in q)
                yield return s;
        }
    }
}

namespace Doukaku.Org
{
    // カレンダーを作成する部分を、CalenderMakerCoreとして独立させている。
    public static class CalenderMakerCore
    {
        // IEnumerable<int[]>を返すメソッドで、int[]には日曜日から始まる１週間分の
        // 日にちが入っています。0 は、日付の無い箇所（空白表示）を示している。
        // それが、一ヶ月分のカレンダー上の行数分返されます。
        public static IEnumerable<int[]> GetMonthCalender(int year, int month)
        {
            List<int> oneWeek = new List<int>();
            DateTime dt = new DateTime(year, month, 1);
            // 空白の箇所（日付の無い箇所）は、0 で示す
            for (int i = 0; i < (int)dt.DayOfWeek; i++)
                oneWeek.Add(0);
            for (; dt.Month == month; dt = dt.AddDays(1))
            {
                oneWeek.Add(dt.Day);
                if (dt.DayOfWeek == DayOfWeek.Saturday)
                {
                    yield return oneWeek.ToArray();
                    oneWeek.Clear();
                }
            }
            if (oneWeek.Count != 0)
                yield return oneWeek.ToArray();
        }
    }
}