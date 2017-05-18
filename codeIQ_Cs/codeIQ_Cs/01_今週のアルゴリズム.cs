using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeIZ_C
{
    class 今週のアルゴリズム_14
    {
        #region "Enum"
        public enum クラス
        {
            素数列から抜き出してつぶやこう,
            異なる整数で作る逆三角形
        }
        #endregion

        #region "メンバ"
        private クラス _Class;
        #endregion

        #region "コンストラクタ"
        public 今週のアルゴリズム_14(クラス cls)
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
                case クラス.素数列から抜き出してつぶやこう:
                    res = this.素数列から抜き出してつぶやこう(line);
                    break;

            }

            return res;
        }
        #endregion

        #region "140 素数列から抜き出してつぶやこう"
        public string 素数列から抜き出してつぶやこう(string line)
        {
            int n = int.Parse(line);
            List<int> 素数list = this.Get素数一覧(n);

            Console.WriteLine(string.Join<int>(" ", 素数list).ToString());

            return "";
        }

        private List<int> Get素数一覧(int max )
        {
            List<int> 素数list = new List<int>();
            for (int i = 1;i <= max; ++i)
            {
                if (Is素数(i)) { 素数list.Add(i); }
            }
            
            return 素数list;
        }

        private Boolean Is素数(int i)
        {
            // 約数が2であるかチェック
            int 約数 = 0;
            for (int j = 1;j <= i; ++j)
            {
                if ( i % j == 0) { 約数++; }
            }
            if (約数 == 2) { return true; }
            return false;
        }
        #endregion

        #region "異なる整数で作る逆三角形"
        public string 異なる整数で作る逆三角形Prosecc(string line)
        {
            int n = int.Parse(line);
            int 最大値 = 10;
            int[] firstList = new int[n];
            
            for (int i = 1;i <= 最大値; ++i)
            {
                firstList = firstList作成(n,i, 最大値);
                if (firstList.Count() > 0) { break; }
            }
                        
            return firstList.OrderBy(s => s).First().ToString();
        }

        private int[] firstList作成(int n,int i,int 最大値)
        {
            int[] list = new int[n - 1];


            return list;
        }
        #endregion

    }

    class 今週のアルゴリズム_13
    {
        #region "Enum"
        public enum クラス
        {
            素数列から抜き出してつぶやこう
        }
        #endregion

        #region "メンバ"
        private クラス _Class;
        #endregion

        #region "コンストラクタ"
        public 今週のアルゴリズム_13(クラス cls)
        {
            this._Class = cls;
        }
        #endregion

        #region "共通メソッド"
        //public string Execution(string line)
        //{
        //    string res = string.Empty;

        //    switch (this._Class)
        //    {
        //        case クラス.異なる整数で作る逆三角形:
        //            res = this.異なる整数で作る逆三角形Prosecc(line);
        //            break;

        //    }

        //    return res;
        //}
        #endregion



    }
}
