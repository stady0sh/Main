using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AtCoder_Cs.Extension;

namespace AtCoder_Cs
{
    public class Program
    {

        public static void Main()
        {
            var l = ReadArrayString();
            var deg = l[0]; // 風向き(0~3600)
            var dis = l[1]; // 風程(0~12000)m

            string dir = muki(int.Parse(deg));

            decimal husoku = Math.Round(decimal.Parse(dis) / 60,1,MidpointRounding.AwayFromZero); // m/s
            Int32 w = huryoku(husoku);
            if (w == 0)
            {
                dir = "C";
            }

            Console.WriteLine($"{dir} {w}");

        }

        public static string muki(int deg )
        {
            var ret = "C";
            if(deg < 112.5)
            {
                ret = "N";
            }
            else if (deg < 337.5)
            {
                ret = "NNE";
            }
            else if (deg < 562.5)
            {
                ret = "NE";
            }
            else if (deg < 787.5)
            {
                ret = "ENE";
            }
            else if (deg < 1012.5)
            {
                ret = "E";
            }
            else if (deg < 1237.5)
            {
                ret = "ESE";
            }
            else if (deg < 1462.5)
            {
                ret = "SE";
            }
            else if (deg < 1687.5)
            {
                ret = "SSE";
            }
            else if (deg < 1912.5)
            {
                ret = "S";
            }
            else if (deg < 2137.5)
            {
                ret = "SSW";
            }
            else if (deg < 2362.5)
            {
                ret = "SW";
            }
            else if (deg < 2587.5)
            {
                ret = "WSW";
            }
            else if (deg < 2812.5)
            {
                ret = "W";
            }
            else if (deg < 3037.5)
            {
                ret = "WNW";
            }
            else if (deg < 3262.5)
            {
                ret = "NW";
            }
            else if (deg < 3487.5)
            {
                ret = "NNW";
            }
            else
            {
                ret = "N";
            }


            return ret;
        }

        public static Int32 huryoku(decimal husoku)
        {
            var ret = 0;
            if (husoku <= 0.2m)
            {
                ret = 0;
            }
            else if (husoku <= 1.5m)
            {
                ret = 1;
            }
            else if (husoku <= 3.3m)
            {
                ret = 2;
            }
            else if (husoku <= 5.4m)
            {
                ret = 3;
            }
            else if (husoku <= 7.9m)
            {
                ret = 4;
            }
            else if (husoku <= 10.7m)
            {
                ret = 5;
            }
            else if (husoku <= 13.8m)
            {
                ret = 6;
            }
            else if (husoku <= 17.1m)
            {
                ret = 7;
            }
            else if (husoku <= 20.7m)
            {
                ret = 8;
            }
            else if (husoku <= 24.4m)
            {
                ret = 9;
            }
            else if (husoku <= 28.4m)
            {
                ret = 10;
            }
            else if (husoku <= 32.6m)
            {
                ret = 11;
            }
            else
            {
                ret = 12;
            }

            return ret;
        }
    }
}

namespace AtCoder_Cs
{
    public static class Extension
    {
        public static Int32 ReadInt32()
        {
            return int.Parse(Console.ReadLine());
        }
        public static Decimal ReadDecimal()
        {
            return Decimal.Parse(Console.ReadLine());
        }

        public static Int32[] ReadArrayInt32()
        {
            return ReadArrayString().Select(int.Parse).ToArray();
        }
        public static string[] ReadArrayString()
        {
            return Console.ReadLine().Trim().Split(' ');
        }
    }
}