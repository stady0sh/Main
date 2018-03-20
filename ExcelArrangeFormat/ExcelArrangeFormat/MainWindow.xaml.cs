using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace ExcelArrangeFormat
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.txtResult.Text = "ログが表示されます...";
        }


        private void Form_PreviewDragOver(object sender, DragEventArgs e)
        {
            try
            {
                e.Handled = e.Data.GetDataPresent(DataFormats.FileDrop);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Form_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                e.Effects = DragDropEffects.Copy;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Form_Drop(object sender, DragEventArgs e)
        {
            var files = (String[])e.Data.GetData(DataFormats.FileDrop);

            if (files == null)
                return;

            int cnt = 0;

            // Excelファイル(.xlsx)のみを対象とする
            var xlsFiles = from item in files where item.EndsWith(".xlsx") select item;
            foreach (var file in xlsFiles)
            {
                this.OpenExcel(file);
                cnt++;
            }

            // 結果出力
            this.txtResult.Text = $"{System.DateTime.Now:HH:mm:ss}\t{cnt}件のExcelFileを整形しました。";
        }




        #region OpenExcel
        private void OpenExcel(string file)
        {
            // Open
            IWorkbook wBook;
            using (FileStream rfs = File.OpenRead(file))
            {
                wBook = new XSSFWorkbook(rfs);
            }

            // Action
            int cnt = wBook.NumberOfSheets;
            for (int i = 0; i < cnt; i++)
            {
                ISheet sht = wBook.GetSheetAt(i);

                // シートに対する処理
                this.SheetAction(wBook,sht);

                sht.IsSelected = false;
            }

            // ブックに対する処理
            this.BookAction(wBook);

            // Save
            using (var fs = new FileStream(file, FileMode.Create))
            {
                wBook.Write(fs);
            }
        }
        #endregion

        #region *** SheetAction ***
        private void BookAction(IWorkbook wBook)
        {
            // 1シートをアクティブ化
            this.ActivateTopSheet(wBook);
        }
        
        private void ActivateTopSheet(IWorkbook wBook)
        {
            ISheet sht = wBook.GetSheetAt(0);
            sht.IsSelected = true;
            wBook.SetActiveSheet(0);
        }
        #endregion

        #region *** SheetAction ***
        private void SheetAction(IWorkbook wBook, ISheet sht)
        {
            // A1へフォーカスセット
            if ((bool)this.chkSelectedA1.IsChecked)
                this.Selected_A1(sht);

        }

        private void Selected_A1(ISheet sht)
        {
            sht.SetActiveCell(0, 0);
        }
        #endregion

    }
}
