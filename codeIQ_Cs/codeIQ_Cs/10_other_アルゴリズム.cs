using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeIZ_C
{
    class other_アルゴリズム
    {

        #region "Enum"
        public enum クラス
        {
            アルゴ１,
            アルゴ２
        }
        #endregion

        #region "プロパティ"
        private クラス _クラス;
        #endregion

        #region "コンストラクタ"
        public other_アルゴリズム(クラス cls)
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
                case クラス.アルゴ１:
                    res = this.アルゴ１(line);
                    break;
                case クラス.アルゴ２:
                    res = this.アルゴ２(line);
                        break;
                default:
                    res = string.Empty;
                    break;
            }

            return res;
        }
        #endregion

        #region "アルゴ１"
        private String アルゴ１(string line)
        {
            string res = string.Empty;


            return res;
        }
        #endregion
        
        #region "アルゴ２"
        /// <summary>
        /// 1～Nまでの二乗和を求める
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private String アルゴ２(string line)
        {
            int n = int.Parse(line);
            int result = 0;
            for (int i = 1; i <= n; ++i)
            {
                result += i * i;
            }
            
            return result.ToString();
        }
        #endregion

        #region "アルゴ２"
        private String アルゴ３(string line)
        {
            int n = int.Parse(line);
            int result = 0;
            for (int i = 1; i <= n; ++i)
            {
                result += i * i;
            }

            return result.ToString();
        }
        #endregion

    }
}
