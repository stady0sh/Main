using System;

namespace codeIZ_C
{
    class プログラミング道場
    {

        public enum 級
        {
            Ｃ級,
            Ｂ級,
            Ａ級
        }

        private 級 _Class;

        public プログラミング道場(級 cls)
        {
            _Class = cls;
        }

        // メイン処理
        public string Execution(string line)
        {
            string res = string.Empty;
            switch (this._Class)
            {
                case 級.Ｂ級:
                    res = B級Process(line);
                    break;
                                            
            }

            return res;
        }

        #region "B級"
        string B級Process(string line)
        {
            string res = line;
            Boolean isNotDel = true;

            do
            {
                isNotDel = Del(res, out res);

            } while (isNotDel);

            return res;
        }

        Boolean Del(string line, out string res)
        {
            int a, b;
            for (int i = 0; i < line.Length - 1; ++i)
            {
                a = int.Parse(line.Substring(i, 1));
                b = int.Parse(line.Substring(i + 1, 1));

                if (a == b + 1 || a == b - 1)
                {
                    line = line.Remove(i, 2);
                    res = line;
                    return true;
                }

            }

            res = line;
            return false;
        }
        #endregion

    }
}
