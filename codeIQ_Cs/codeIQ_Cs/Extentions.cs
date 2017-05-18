using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeIZ_C
{
    static class Extentions
    {
        /// <summary>
        /// Queueに指定のアイテムを追加する
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="q"></param>
        /// <param name="value"></param>
        /// <param name="itemCount"></param>
        /// <returns></returns>
        public static Queue<T> InitItems<T>(this Queue<T> q, T value, int itemCount)
        {
            q.Clear();
            for (int i = 1; i <= itemCount; ++i)
            {
                q.Enqueue(value);
            }
            return q;
        }

    }
}
