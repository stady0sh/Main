using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subject._2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            if ( int.TryParse(textBox1.Text.Trim(),out n) == false)
            {
                MessageBox.Show("数値を入力してください。");
                return;
            }

            if ((n < 0 && n > 20) || n % 2 == 0)
            {
                MessageBox.Show("1～20までの奇数を指定してください。");
                return;
            }

            // 点の列数リストの作成
            List<int> list = new List<int>{ n };
            for (int i = n - 2;i > 0;i -= 2)
            {
                list.Insert(0, i);
                list.Add(i);
            }
            
            StringBuilder result = new StringBuilder();
            foreach ( var item in list)
            {
                result.Append(CreateRow(n, item));
            }
            
            FileWriter(result.);
            MessageBox.Show("出力しました。（D:\\図形.txt）");


        }

        private string CreateRow(int 最大列数, int 点の列数)
        {
            int 片側空白列数 = (最大列数 - 点の列数) / 2;
            string result = new string('　', 片側空白列数);
            result += new string('■', 点の列数);
            result += new string('　', 片側空白列数);
            return result;
        }
        
        //private string CreateRow(int 最大列数,int 点の列数)
        //{
        //    int 片側空白列数 = (最大列数 - 点の列数) / 2;
        //    List<string> list = new List<string>();
        //    list.AddRange(AddList(片側空白列数, "　"));
        //    list.AddRange(AddList(点の列数, "■"));
        //    list.AddRange(AddList(片側空白列数, "　"));
        //    return $"{string.Join("", list)}";

        //}

        //private List<string> AddList(int cnt , string value)
        //{
        //    List<string> list = new List<string>();
        //    for (int i = 0; i < cnt; ++i)
        //    {
        //        list.Add(value);
        //    }
        //    return list;
        //}

        static void FileWriter(string line)
        {
            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            StreamWriter writer =
              new StreamWriter(@"D:\図形.txt", false, sjisEnc);
            writer.WriteLine(line);
            writer.Close();
        }

    }
}
