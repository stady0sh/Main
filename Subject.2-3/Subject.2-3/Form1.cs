using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subject._2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region "コンストラクタ"
        private void Form1_Load(object sender, EventArgs e)
        {
            txt年.Text = DateTime.Now.Year.ToString();
            txt月.Text = DateTime.Now.Month.ToString();
        }
        #endregion

        #region "イベント"
        private void button1_Click(object sender, EventArgs e)
        {
            int 年;
            int 月;
            if(int.TryParse(txt年.Text, out 年) == false)
            {
                MessageBox.Show("年は数値を入力してください。");
                return;
            }
            if (int.TryParse(txt月.Text, out 月) == false)
            {
                MessageBox.Show("月は数値を入力してください。");
                return;
            }

            DateTime dtStart = new DateTime(年, 月, 1);
            DateTime dtEnd = new DateTime(年, 月+1, 1).AddDays(-1);

            for (int i = 1;i <= dtEnd.Day; ++i)
            {

            }

            var a = 7 - (dtStart.DayOfWeek - DayOfWeek.Sunday);


            var weekNo = new DateTime(年, 月, 1).DayOfWeek;
            List<List<string>> Calendar = new List<List<string>>();

            for (int i = 0;i < 7; ++i)
            {
                Calendar.Add(new List<string>());
                if (a <= i)
                {
                    Calendar[0].Add($"{i:00}");
                }
                else
                {
                    Calendar[0].Add($"  ");
                }
            }

            // 日付をクリア
            for (int i = 0; i <= 5; ++i)
            {
                for (int j = 0; j <= 5; ++j)
                {

                }
            }

            //int w = 0; // 週
            //int dw = dt.DayOfWeek; // 曜日 ( 0 〜 6 )
            //int d = 1; // 日
            //int days = Date.DaysInMonth(dt.Year, dt.Month);
            //do
            //{

            //} while (d <= days);


        }   
        #endregion  

    }
}
