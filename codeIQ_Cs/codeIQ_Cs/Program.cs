using System;
using System.Collections.Generic;
using System.Linq;

namespace codeIZ_C
{

    class CodeIQSample
    {

        #region "メンバ"
        #endregion
        
        static void Main(string[] args)
        {
            String line;
            for (; (line = Console.ReadLine()) != null;)
            {
                //System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                //sw.Start();
                Console.WriteLine(Prosecc(line.ToUpper()));
                //sw.Stop();
                //Console.WriteLine(sw.Elapsed);
            }
                       
        }

        // メイン処理
        static string Prosecc(string line)
        {
            //プログラミング道場 cls = new プログラミング道場(プログラミング道場.級.Ｂ級);
            実力判定 cls = new 実力判定(実力判定.クラス.Ａランク小銭王子);
            //その他 cls = new その他(その他.クラス.三角形は何通り);
            //鍋谷武典 cls = new 鍋谷武典(鍋谷武典.クラス.正六角形の分割);


            return cls.Execution(line);


            //return Ａランク小銭王子.Execution(line);
            
        }


    }

}
