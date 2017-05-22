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
            ＯはぴったりＸは無し,
            正方形の分割
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
                case クラス.正方形の分割:
                    res = this.正方形の分割Prosecc(line);
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
        
        #region "正方形の分割"
        private string 正方形の分割Prosecc(string line)
        {
            /*
            【概要】
            正方形があります。
            正方形の頂点と、辺の三等分点を全部合わせて「注目Line」と呼びます。
            注目Lineのうちのひとつを別の注目Lineと結んだ線分で、正方形を分割する、という操作を2回行います。
            このとき、出来る図形が何角形になるのかを計算して下さい。

            【入出力】
            入力は
            cj kf
            のようになっています。
            線分を示す文字列が 空白区切りで並んでいます。
            線分を示す文字列は、右図にある端点を示す記号をならべたものです。
            というわけで、cj kfは、右上図の黒い線の部分での分割を意味します。

            出力は、
            3,4,4,4
            のような感じです。
            出来上がる多角形の頂点数を、昇順にコンマ区切りで。
            くれぐれも、昇順にソートすることをお忘れなきよう。
            */
            List<string> 注目Linelist = line.Trim().Split(' ').ToList<string>();
            List<string> 図形list = new List<string>();

            foreach (string 注目Line in 注目Linelist)
            {

            }
            
            return "";
        }

        private List<string> F(string 注目Line , List<string> 図形list)
        {
            List<string> 点list = new List<string>();
            点list.Add(注目Line.Substring(0, 1));
            点list.Add(注目Line.Substring(1, 1));

            // 分割できるかどうかチェック
            // （正方形の直線と、分割ラインが被っており、実質分割の必要が無いかもしれない為）
            if (Is分割(点list)) { return 図形list; }
            



            return 図形list;
        }

        private Boolean Is分割(List<string> 点list)
        {
            List<int> 点数値list = new List<int>();
            List<string> 辺1 = new List<string>() { "A", "B", "C", "D" };
            List<string> 辺2 = new List<string>() { "D", "E", "F", "G" };
            List<string> 辺3 = new List<string>() { "G", "H", "I", "J" };
            List<string> 辺4 = new List<string>() { "J", "K", "L", "A" };

            return ((辺1.Contains(点list[0]) && 辺1.Contains(点list[1])) ||
                    (辺2.Contains(点list[0]) && 辺2.Contains(点list[1])) ||
                    (辺3.Contains(点list[0]) && 辺3.Contains(点list[1])) ||
                    (辺4.Contains(点list[0]) && 辺4.Contains(点list[1]))) ? true : false;
            
        }  
        #endregion

    }
}
