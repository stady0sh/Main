using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza
{
    static class Class_D_6
    {

        #region "問題__"
        public static string 問題__(string line)
        {
            string result = "";

            

            return result;
        }
        #endregion

        #region "問題66"
        public static string 問題66(string line)
        {
            //0:消費スタミナ　1:現在のスタミナ
            String[] str = line.Split(Convert.ToChar(" "));
            string result = "";
            if ( int.Parse(str[0]) <= int.Parse(str[1]))
            {
                result = (int.Parse(str[1]) - int.Parse(str[0])).ToString();
            }
            else
            {
                result = "No";
            }
            return result;
        }
        #endregion

    }
}
