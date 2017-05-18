using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeIZ_C
{
    class 今週のアルゴリズム
    {
        #region "Enum"
        public enum クラス
        {
            異なる整数で作る逆三角形
        }
        #endregion

        #region "メンバ"
        private クラス _Class;
        #endregion

        #region "コンストラクタ"
        public 今週のアルゴリズム(クラス cls)
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
                case クラス.異なる整数で作る逆三角形:
                    res = this.異なる整数で作る逆三角形Prosecc(line);
                    break;

            }

            return res;
        }
        #endregion

        #region "異なる整数で作る逆三角形"
        public string 異なる整数で作る逆三角形Prosecc(string line)
        {
            //int n = int.Parse(line);
            int n = 3;
            int 余力 = 5;
            int[] firstList = new int[n];

            // ループ
            for (int i = 0;i < 3 + 余力; ++i)
            {
                for (int j = 0; j < 3 + 余力; ++j)
                {
                    if (i == j) { continue; }
                    for (int k = 0; k < 3 + 余力; ++k)
                    {
                        if (j == k) { continue; }

                        firstList[0] = i;
                        firstList[1] = j;
                        firstList[2] = k;

                        //int[] newList = new int[]

                        
                    }
                }
            }


            
            return "";
        }

        //public int[] CreateList(int n,int 余力)
        //{

        //}
        #endregion

    }
}
