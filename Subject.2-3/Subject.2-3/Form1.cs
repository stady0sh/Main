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
            txt結果.Text = string.Empty;
        }
        #endregion

        #region "イベント"
        private void button1_Click(object sender, EventArgs e)
        {
            txt結果.Text = string.Empty;
            int 年;
            int 月;
            if(int.TryParse(txt年.Text, out 年) == false)
            {
                MessageBox.Show("年は1900～2100までの値を入力してください。");
                return;
            }
            else if (年 > 2100 || 1900 > 年)
            {
                MessageBox.Show("年は1900～2100までの値を入力してください。");
                return;
            }   
            if (int.TryParse(txt月.Text, out 月) == false)
            {
                MessageBox.Show("月は1～12までの値を入力してください。");
                return;
            }
            else if (月 > 12 || 1 > 月)
            {
                MessageBox.Show("月は1～12までの値を入力してください。");
                return;
            }

            DateTime dtStart = new DateTime(年, 月, 1);
            DateTime dtEnd = new DateTime(年, 月, 1).AddMonths(1).AddDays(-1);
            
            var weekNo = (int)dtStart.DayOfWeek;
            List<List<string>> Calendar = new List<List<string>>();
            Calendar.Add(new List<string>());

            int i = 0;
            for (i = 0;i < weekNo; ++i)
            {
                Calendar[0].Add("  ");
            }

            for (int d = 1;d <= dtEnd.Day; ++d)
            {
                if (Calendar[Calendar.Count() - 1].Count() == 7)
                {
                    Calendar.Add(new List<string>());
                }
                Calendar[Calendar.Count() - 1].Add(d.ToString().PadLeft(2,' '));
            }
            
            foreach( var item in Calendar)
            {
                txt結果.Text += string.Join(" ", item) + "\r\n";
            }

        }   
        #endregion  

    }
}
