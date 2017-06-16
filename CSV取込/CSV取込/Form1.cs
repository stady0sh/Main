using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSV取込
{
    public partial class Form1 : Form
    {
        #region "コンストラクタ"
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region "イベント"
        /// <summary>
        /// "計算"ボタンクリック
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;

            if (System.IO.File.Exists(textBox1.Text.Trim()) == false)
            {
                MessageBox.Show("ファイルが存在しません。");
                return;
            }

            if (textBox1.Text.Trim().EndsWith(".csv") == false)
            {
                MessageBox.Show("CSVファイルを指定してください。");
                return;
            }

            string line;
            using (System.IO.StreamReader sr = new System.IO.StreamReader(textBox1.Text.Trim()))
            {                
                while ((line = sr.ReadLine()) == null)
                {
                    MessageBox.Show("1行以上存在するファイルを選択してください。");
                    return;
                }

                //List<string> list = line.Split(',').Trim().ToList();
                //List<int> result = new List<int>();
                //int tmp = 0;
                //foreach (var item in list)
                //{
                //    tmp = 0;
                //    if (int.TryParse(item, out tmp) == false)
                //    {
                //        MessageBox.Show("ファイルの内容が不正です。");
                //        return;
                //    }
                //    result.Add(tmp);
                //}

            }

            try
            {
                List<int> result = line.Split(',').Select(s => int.Parse(s.Trim())).ToList();
                textBox2.Text += $"{string.Join(" + ", result).Replace("+ -", "- ")}\r\n";
                textBox3.Text = $"{result.Sum():#,##0}";
            }
            catch
            {
                MessageBox.Show("ファイルの内容が不正です。");
            }


        }

        /// <summary>
        /// "ファイル参照"ボタンクリック
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            ofd.FileName = "";
            ofd.InitialDirectory = @"D:\";
            ofd.Filter = "CSVファイル(*.csv)|*.csv";
            ofd.Title = "CSVファイルを選択してください";
            ofd.RestoreDirectory = true;
            //ofd.CheckFileExists = false;
            //ofd.CheckPathExists = false;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }
        #endregion
    }
}
