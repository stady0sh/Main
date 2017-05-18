using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeIZ_C
{
    class Ａランク小銭王子
    {
        static Queue<int> 五百円 = new Queue<int>();
        static Queue<int> 百円 = new Queue<int>();
        static Queue<int> 五十円 = new Queue<int>();
        static Queue<int> 十円 = new Queue<int>();
        static Queue<int> 五円 = new Queue<int>();
        static Queue<int> 一円 = new Queue<int>();
        
        static public string Execution(string line)
        {
            int cnt = 0;

            InitItems<int>(五百円, 500, 1000);
            InitItems<int>(百円, 100, 1000);
            InitItems<int>(五十円, 50, 1000);
            InitItems<int>(十円, 10, 1000);
            InitItems<int>(五円, 5, 1000);
            InitItems<int>(一円, 1, 1000);
            
            // Inputの値の取得
            int n = int.Parse(line);

            cnt = 五百円計算(n);

            return cnt.ToString();

        }

        static int 五百円計算(int price)
        {
            int 額 = 500;
            int cnt = 0;
            //if (price == 0) { return cnt; }
            InitItems<int>(五百円, 額, 1000);

            for (int n = price; n >= 0; n -= 額)
            {
                cnt += 百円計算(n);
                五百円.Dequeue();
                if (五百円.Count == 0) { break; }
            }

            return cnt;
        }

        static int 百円計算(int price)
        {
            int 額 = 100;
            int cnt = 0;
            //if (price == 0) { return cnt; }
            InitItems<int>(百円, 額, 1000);

            for (int n = price; n >= 0; n -= 額)
            {
                cnt += 五十円計算(n);
                百円.Dequeue();
                if (百円.Count == 0) { break; }
            }

            return cnt;
        }

        static int 五十円計算(int price)
        {
            int 額 = 50;
            int cnt = 0;
            //if (price == 0) { return cnt; }
            InitItems<int>(五十円, 額, 1000);

            for (int n = price; n >= 0; n -= 額)
            {
                cnt += 十円計算(n);
                五十円.Dequeue();
                if (五十円.Count == 0) { break; }
            }

            return cnt;
        }

        static int 十円計算(int price)
        {
            int 額 = 10;
            int cnt = 0;
            //if (price == 0) { return cnt; }
            InitItems<int>(十円, 額, 1000);

            for (int n = price; n >= 0; n -= 額)
            {
                cnt += 五円計算(n);
                十円.Dequeue();
                if (十円.Count == 0) { break; }
            }

            return cnt;
        }

        static int 五円計算(int price)
        {
            int 額 = 5;
            int cnt = 0;
            //if (price == 0) { return cnt; }
            //五円.InitItems<int>(額, 1000);
            InitItems<int>(五円, 額, 1000);

            for (int n = price; n >= 0; n -= 額)
            {
                cnt += 一円計算(n);
                五円.Dequeue();
                if (五円.Count == 0) { break; }

            }

            return cnt;
        }

        static int 一円計算(int price)
        {
            //if (price == 0) { return 0; }
            return 1;
        }

        static Queue<T> InitItems<T>(Queue<T> q, T value, int itemCount)
        {
            q.Clear();
            for (int i = 1; i <= itemCount; ++i)
            {
                q.Enqueue(value);
            }
            return q;
        }

    }





}
