using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeIZ_C
{
    class 実力判定
    {

        #region "Enum"
        public enum クラス
        {
            Ｃランク,
            Ｂランク,
            Ａランク,
            Ａランク小銭王子,
            Ｓランク
        }
        #endregion

        #region "メンバ"
        private クラス _Class;
        #endregion

        #region "コンストラクタ"
        public 実力判定(クラス cls)
        {
            this._Class = cls;
        }
        #endregion

        #region "共通メソッド"
        public string Execution(string line)
        {
            string res = string.Empty;

            switch (this._Class)
            {
                case クラス.Ｃランク:
                    res = this.ＣランクProsecc(line);
                    break;
                case クラス.Ａランク:
                    //res = this.ＡランクProsecc(line);
                    res = this.ＡランクProsecc4(line);
                    break;
                case クラス.Ｂランク:
                    //res = this.ＡランクProsecc(line);
                    res = this.ＢランクProsecc(line);
                    break;
                case クラス.Ａランク小銭王子:
                    res = this.Ａランク小銭王子Prosecc(line);
                    break;
                default:
                    break;

            }
            
            return res;
        }
        #endregion
        
        public string ＣランクProsecc(string line)
        {
            int len = int.Parse(line);

            string str = Console.ReadLine();
            string[] list = str.Split(null);

            for (int i = 0;i < len; i++)
            {
                for (int j = i + 1;j < len; j++)
                {
                    if ((int.Parse(list[i]) + int.Parse(list[j])) == 256)
                    {
                        return "yes";
                    }
                }
            }

            return "no";
        }

        public string ＢランクProsecc(string line)
        {
            string[] str = line.Split(Convert.ToChar(" "));

            int cnt = 0;
            for (int i = 0;i <= int.Parse(str[0]); ++i)
            {
                string num = Convert.ToString(i, 2);
                List<String> list = new List<String>();
                for (int j = 0;j < num.Length; ++j)
                {
                    list.Add(num.Substring(j, 1));
                }

                if (list.Where(s => s == "1").Count() == int.Parse(str[1]))
                {
                    cnt += 1;
                }

            }

            return cnt.ToString();
        }

        public string ＡランクProsecc(string line)
        {
            int max = 1000000;
            int n = int.Parse(line);
            int cnt = 0;
            
            for (int i = (n / 2); i < max; ++i)
            {
                int total = i + (i + 1);
                if (total % n == 0)
                {
                    cnt += 1;
                }
            }

            return cnt.ToString();
        }
        
        public string ＡランクProsecc2(string line)
        {
            int n = int.Parse(line);
            int cnt = 0;
            

            int total = (n / 2);
            if (total % 2 == 0)
            {
                total -= 1;
            }
            while (total < 1999999)
            {
                //int total = i + (i + 1);
                //if (total % n == 0)
                if (total % n == 0)
                {
                    cnt += 1;
                }

                total += 2;
            }

            return cnt.ToString();
        }

        public string ＡランクProsecc3(string line)
        {
            int n = int.Parse(line);
            int cnt = 0;

            int i = n;
            while (i < 1999999)
            {
                if (i % 2 == 1)
                {
                    cnt += 1;
                }

                i = i + n;
            }
            
            return cnt.ToString();
        }

        public string ＡランクProsecc4(string line)
        {
            int max = 1999999;
            int n = int.Parse(line);
            int cnt = 0;

            if (n % 2 == 0)
            {
                cnt = 0;
            }
            else
            {
                cnt = ((max / n) + 1) / 2;
            }
            
            return cnt.ToString();
        }

        #region "Ａランク小銭王子Prosecc"
        Queue<int> 五百円 = new Queue<int>();
        Queue<int> 百円 = new Queue<int>();
        Queue<int> 五十円 = new Queue<int>();
        Queue<int> 十円 = new Queue<int>();
        Queue<int> 五円 = new Queue<int>();
        Queue<int> 一円 = new Queue<int>();
        private string Ａランク小銭王子Prosecc(string line)
        {
            int cnt = 0;
            
            五百円.InitItems<int>(500,1000);
            百円.InitItems<int>(100, 1000);
            五十円.InitItems<int>(50, 1000);
            十円.InitItems<int>(10, 1000);
            五円.InitItems<int>(5, 1000);
            一円.InitItems<int>(1, 1000);


            // Inputの値の取得
            int n = int.Parse(line);

            cnt = this.五百円計算(n);

            return cnt.ToString();

        }

        public int 五百円計算(int price)
        {
            int 額 = 500;
            int cnt = 0;
            //if (price == 0) { return cnt; }
            五百円.InitItems<int>(額, 1000);

            for (int n = price; n >= 0; n -= 額)
            {
                cnt += 百円計算(n);
                五百円.Dequeue();
                if (五百円.Count == 0) { break; }
            }

            return cnt;
        }

        public int 百円計算(int price)
        {
            int 額 = 100;
            int cnt = 0;
            //if (price == 0) { return cnt; }
            百円.InitItems<int>(額, 1000);

            for (int n = price; n >= 0; n -= 額)
            {
                cnt += 五十円計算(n);
                百円.Dequeue();
                if (百円.Count == 0) { break; }
            }

            return cnt;
        }

        public int 五十円計算(int price)
        {
            int 額 = 50;
            int cnt = 0;
            //if (price == 0) { return cnt; }
            五十円.InitItems<int>(額, 1000);

            for (int n = price; n >= 0; n -= 額)
            {
                cnt += 十円計算(n);
                五十円.Dequeue();
                if (五十円.Count == 0) { break; }
            }

            return cnt;
        }

        public int 十円計算(int price)
        {
            int 額 = 10;
            int cnt = 0;
            //if (price == 0) { return cnt; }
            十円.InitItems<int>(額, 1000);

            for (int n = price; n >= 0; n -= 額)
            {
                cnt += 五円計算(n);
                十円.Dequeue();
                if (十円.Count == 0) { break; }
            }

            return cnt;
        }

        public int 五円計算(int price)
        {
            int 額 = 5;
            int cnt = 0;
            //if (price == 0) { return cnt; }
            五円.InitItems<int>(額, 1000);

            for (int n = price; n >= 0; n -= 額)
            {
                cnt += 一円計算(n);
                五円.Dequeue();
                if (五円.Count == 0) { break; }

            }

            return cnt;
        }

        public int 一円計算(int price)
        {
            //if (price == 0) { return 0; }
            return 1;
        }
        #endregion

    }
}
