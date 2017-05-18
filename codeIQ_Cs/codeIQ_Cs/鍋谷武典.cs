using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeIZ_C
{
    class 鍋谷武典
    {

        #region "Enum"
        public enum クラス
        {
            正六角形の分割,
            ＯはぴったりＸは無し
        }
        #endregion

        #region "プロパティ"
        private クラス _クラス;
        #endregion

        #region "コンストラクタ"
        public 鍋谷武典(クラス cls)
        {
            this._クラス = cls;
        }
        #endregion

        #region "メイン処理"
        public string Execution(string line)
        {
            string res = string.Empty;

            switch (this._クラス)
            {
                case クラス.正六角形の分割:
                    res = this.正六角形の分割Prosecc(line);
                    break;
                case クラス.ＯはぴったりＸは無し:
                    res = this.ＯはぴったりＸは無しProsecc(line);
                    break;
                default:
                    res = string.Empty;
                    break;
                    
            }

            return res;
        }
        #endregion

        #region "正六角形の分割Prosecc"
        private string 正六角形の分割Prosecc(string line)
        {
            List<string> res = new List<string>();
            string 二進数 = Int64.Parse(Convert.ToString(Int32.Parse(line), 2)).ToString("000000000000");

            Boolean isFirst = true;
            int first頂点 = 0;
            int 頂点 = 0;
            int 直線判定Cnt = 1;
            int first直線判定Cnt = 0;

            //For i As Integer = 11 To 0 Step - 1
            for (int i = 11; i >= 0; --i)
            {
                string str = 二進数.Substring(i, 1);
                if (str == "1")
                {
                    if (直線判定Cnt != 6)
                    {
                        頂点 += 1;
                    }

                    if (isFirst == false)
                    {
                        res.Add((頂点 + 1).ToString());
                        頂点 = 1;
                        直線判定Cnt = 1;
                    }
                    else
                    {
                        first頂点 = 頂点;
                        頂点 = 1;
                        first直線判定Cnt = 直線判定Cnt - 1;
                        直線判定Cnt = 1;
                        isFirst = false;

                    }

                }
                else
                {
                    直線判定Cnt += 1;
                    if (i % 2 == 1)
                    {
                        頂点 += 1;
                    }
                }

            }

            if (first直線判定Cnt + 直線判定Cnt == 6)
            {
                res.Add((頂点 + first頂点).ToString());
            }
            else
            {
                res.Add((頂点 + first頂点 + 1).ToString());
            }

            return string.Join(",", res.OrderBy(s => s));
        }

        #endregion

        #region "ＯはぴったりＸは無し"
        private string _o = "o";
        private string _x = "x";
        private string ＯはぴったりＸは無しProsecc(string line)
        {
            string res = string.Empty;
            // 入力情報
            string[] str = line.Split(Convert.ToChar(" ")); //0:n、1:○の座標、2:×の座標
            int n = int.Parse(str[0]);
            List<string> Ｏ座標 = str[1].Split(Convert.ToChar(",")).ToList<string>();
            List<string> Ｘ座標 = str[2].Split(Convert.ToChar(",")).ToList<string>();

            // 座標をボードに格納　（26x26マス）
            string[,] board = new string[25,25];

            foreach(string o座標 in Ｏ座標)
            {
                board = this.Set座標(o座標, this._o, board);
            }
            foreach (string x座標 in Ｘ座標)
            {
                board = this.Set座標(x座標, this._x, board);
            }

            // 座標(0,0)から、有効最大矩形の大きさをListに格納する。
            List<string> 有効リスト = new List<string>();
            int tmpX, tmpY;
            for (int x = 0; x <= 25; ++x)
            {
                for (int y = 0; y <= 25; ++y)
                {
                    if (board[x,y] == _x)
                    {
                        continue;
                    }

                    tmpX = x;
                    tmpY = y;

                    // X列で、次に×がくる列数を算出する
                    while (tmpX <= 25)
                    {
                        if (board[tmpX + 1,tmpY] == _x)
                        {
                            break;
                        }

                        tmpX += 1;
                    }
                    

                }

            }


            // List（降順）から、×を含まないか検査



            return res;
        }

        private string[,] Set座標(string 座標, string 記号,string[,] board)
        {
            int x = Convert.ToInt32(System.Text.Encoding.ASCII.GetBytes((座標.Substring(0, 1))).ToString(),16) - 65;   // 大文字　A = 65
            int y = Convert.ToInt32(System.Text.Encoding.ASCII.GetBytes((座標.Substring(1, 1))).ToString(), 16) - 97;  // 小文字　a = 97

            board[x, y] = 記号;

            return board;
        }
        #endregion


    }
}
