using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Курсовая_работа
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        string numbercursa;
        string numbernedeli;
        int close = 0;
        public Excel.Application excelapp;
        public Excel.Workbooks excelappworkbooks;
        public Excel.Workbook excelappworkbook;
        public Excel.Sheets excelsheets;
        public Excel.Worksheet excelworksheet;
        public Excel.Range excelcells;
        public Window4()
        {
            InitializeComponent();
        }

        private void ok(object sender, RoutedEventArgs e)
        {
            this.close = 0;
            Cursor = Cursors.Wait;
            switch (ComboBox1.Text)
            {
                case "1":
                    this.numbercursa = "1";
                    break;
                case "2":
                    this.numbercursa = "2";
                    break;
                case "3":
                    this.numbercursa = "3";
                    break;
                case "4":
                    this.numbercursa = "4";
                    break;
                case "5":
                    this.numbercursa = "5";
                    break;
                case "Выберите курс":
                    MessageBox.Show("Пожалуйста выберите курс!");
                    this.close = 1;
                    break;
            }
            obrabotkasformi();
            if (close == 0)
            {
                Close();
                otkritie();
            }
            Cursor = Cursors.Arrow;

        }
        private  void obrabotkasformi ()
        {
            switch (ComboBox2.Text)
            {
                case "1":
                    this.numbernedeli = @"" + numbercursa + "_1" + ".xls";
                    break;
                case "2":
                    this.numbernedeli = @"" + numbercursa + "_2" + ".xls";
                    break;
                case "Выберите неделю":
                    MessageBox.Show("Пожалуйста выберите неделю!");
                    this.close = 1;
                    break;
            }
        }
        private void otkritie()
        {
            try
            {
               
                string s = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string we = System.IO.Path.Combine(s, @"ProgramData\FreeRooms");
                System.IO.Directory.CreateDirectory(we);
                excelapp = new Excel.Application();
                excelappworkbooks = excelapp.Workbooks;
                excelappworkbook = excelapp.Workbooks.Open(System.IO.Path.Combine(we, numbernedeli),
                 Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                 Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                 Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                 Type.Missing, Type.Missing);
                excelsheets = excelappworkbook.Worksheets;
                excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);
                excelapp.Visible = true;
            }
            catch { MessageBox.Show("Файл не был найден, обновите базы данных"); }
        }
    }
}
