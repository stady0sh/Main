using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeIZ_C
{
    class その他
    {
        #region "Enum"
        public enum クラス
        {
            Colorize,
                三角形は何通り
        }
        #endregion

        #region "メンバ"
        private クラス _Class;
        #endregion

        #region "コンストラクタ"
        public その他(クラス cls)
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
                case クラス.Colorize:
                    res = this.ColorizeProsecc(line);
                    break;
                case クラス.三角形は何通り:
                    res = this.三角形は何通りProsecc(line);
                    break;

            }

            return res;
        }
        #endregion

        #region "Colorize"
        public string ColorizeProsecc(string line)
        {

            string 赤色 = "=";
            string 黄色s = "[";
            string 黄色e = "]";

            string 検索ワード = line;
            string 検索対象 = Console.ReadLine();   // 検索対象
            int wordCnt = 検索ワード.Length;

            //for (int i = 0; i < 検索対象.Length - wordCnt + 1; ++i)
            //{
            //    if ( 検索対象.Substring(i,1) == " ") { continue; }

            //    if (検索ワード == 検索対象.Substring(i,wordCnt).ToUpper())
            //    {
            //        検索対象 = 検索対象.Insert(i, 赤色);
            //        検索対象 = 検索対象.Insert(i + wordCnt + 赤色.Length, 赤色);

            //        i += 赤色.Length * 2;
            //    }

            //}

            string[] 検索ワードList = 検索対象.Split(null);
            List<string> 結果List = new List<string>();
            foreach (string str in 検索ワードList)
            {
                if (str.ToUpper() == 検索ワード)
                {
                    結果List.Add($"{黄色s}{str}{黄色e}");
                    continue;
                }

                string tmpStr = str;
                for (int i = 0; i < tmpStr.Length - wordCnt + 1; ++i)
                {
                    if (tmpStr.Substring(i, wordCnt).ToUpper() == 検索ワード)
                    {
                        tmpStr = tmpStr.Insert(i, 赤色);
                        tmpStr = tmpStr.Insert(i + wordCnt + 赤色.Length, 赤色);

                        i += 赤色.Length * 2;
                    }
                }
                結果List.Add(tmpStr);
            }

            return string.Join(" ", 結果List);
        }
        #endregion

        #region "三角形は何通り"
        public string 三角形は何通りProsecc(string line)
        {
            int n = int.Parse(line);
            int resCnt = 0;

            for (int i = 1;i < n; ++i)
            {
                for (int j = i; j < n; ++j)
                {
                    for (int k = j; k < n; ++k)
                    {
                        // 




                    }
                }
            }


            return resCnt.ToString();
        }
        #endregion
    }

}
