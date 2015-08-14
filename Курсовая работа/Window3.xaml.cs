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
using System.Net;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Курсовая_работа
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public List<string> ponedelnic1flor = new List<string>();
        nomerakabinetov nomeracabinetov = new nomerakabinetov();
        int nomerfailf = 1;
        string we = "";
        public int not = 1;
        int obrabotkaisklucheni = 0;


        public Excel.Application excelapp;
        public Excel.Workbooks excelappworkbooks;
        public Excel.Workbook excelappworkbook;
        public Excel.Sheets excelsheets;
        public Excel.Worksheet excelworksheet;
        public Excel.Range excelcells;


        public Window3()
        {
            InitializeComponent();
        }

        private async void ok(object sender, RoutedEventArgs e)
        {
            int dostupkobrabotke = 0;
            button1.Visibility = Visibility.Collapsed;
            button2.Visibility = Visibility.Collapsed;
            Label1.Visibility = Visibility.Collapsed;
            bar.Visibility = Visibility.Visible;
            bar1.Visibility = Visibility.Visible;
            Label3.Visibility = Visibility.Visible;
            Label5.Visibility = Visibility.Visible;
            text1.Visibility = Visibility.Visible;
            Label6.Visibility = Visibility.Visible;
            try
            {
                string s = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                this.we = System.IO.Path.Combine(s, @"ProgramData\FreeRooms");
                System.IO.Directory.CreateDirectory(we);
                bar1.Value = 1;
                text1.Text = bar1.Value.ToString();
                Label6.Content = "Создана папка для загрузки";
            }
            catch
            {
                MessageBox.Show("ошибка в создании папки для фаила\n  запустите программу от имени администратора!");
                Label1.Visibility = Visibility.Visible;
                Label3.Visibility = Visibility.Collapsed;
                button1.Visibility = Visibility.Visible;
                button2.Visibility = Visibility.Visible;
                bar.Visibility = Visibility.Collapsed;
                bar1.Visibility = Visibility.Collapsed;
                Label5.Visibility = Visibility.Collapsed;
                text1.Visibility = Visibility.Collapsed;
                Label6.Visibility = Visibility.Collapsed;
                dostupkobrabotke = 1;
            }
            if (dostupkobrabotke == 0)
            {
                int chatch1 = 0;
                var result = await Task<string>.Factory.StartNew(() =>
                {
                    try
                    {

                        WebClient webClient = new WebClient();
                        setup setup = new setup();
                        setup.redfile();
                        switch (setup.colichestvo)
                        {
                            case "0":
                                chatch1 = 1;
                                break;
                            case "2":
                                webClient.DownloadFile(setup.writeurl1_1, System.IO.Path.Combine(we, @"1_1.xls"));
                                webClient.DownloadFile(setup.writeurl1_2, System.IO.Path.Combine(we, @"1_2.xls"));
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"2_1.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"2_1.xls")); }
                                    catch { }
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"2_2.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"2_2.xls")); }
                                    catch { }
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"3_1.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"3_1.xls")); }
                                    catch { }
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"3_2.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"3_2.xls")); }
                                    catch { }
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"4_1.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"4_1.xls")); }
                                    catch { }
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"4_2.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"4_2.xls")); }
                                    catch { }
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"5_1.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"5_1.xls")); }
                                    catch { }
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"5_2.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"5_2.xls")); }
                                    catch { }

                                break;
                            case "4":
                                webClient.DownloadFile(setup.writeurl1_1, System.IO.Path.Combine(we, @"1_1.xls"));
                                webClient.DownloadFile(setup.writeurl1_2, System.IO.Path.Combine(we, @"1_2.xls"));
                                webClient.DownloadFile(setup.writeurl2_1, System.IO.Path.Combine(we, @"2_1.xls"));
                                webClient.DownloadFile(setup.writeurl2_2, System.IO.Path.Combine(we, @"2_2.xls"));
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"3_1.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"3_1.xls")); }
                                    catch { }
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"3_2.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"3_2.xls")); }
                                    catch { }
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"4_1.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"4_1.xls")); }
                                    catch { }
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"4_2.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"4_2.xls")); }
                                    catch { }
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"5_1.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"5_1.xls")); }
                                    catch { }
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"5_2.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"5_2.xls")); }
                                    catch { }
                                break;
                            case "6":
                                webClient.DownloadFile(setup.writeurl1_1, System.IO.Path.Combine(we, @"1_1.xls"));
                                webClient.DownloadFile(setup.writeurl1_2, System.IO.Path.Combine(we, @"1_2.xls"));
                                webClient.DownloadFile(setup.writeurl2_1, System.IO.Path.Combine(we, @"2_1.xls"));
                                webClient.DownloadFile(setup.writeurl2_2, System.IO.Path.Combine(we, @"2_2.xls"));
                                webClient.DownloadFile(setup.writeurl3_1, System.IO.Path.Combine(we, @"3_1.xls"));
                                webClient.DownloadFile(setup.writeurl3_2, System.IO.Path.Combine(we, @"3_2.xls"));
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"4_1.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"4_1.xls")); }
                                    catch { }
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"4_2.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"4_2.xls")); }
                                    catch { }
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"5_1.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"5_1.xls")); }
                                    catch { }
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"5_2.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"5_2.xls")); }
                                    catch { }
                                break;
                            case "8":
                                webClient.DownloadFile(setup.writeurl1_1, System.IO.Path.Combine(we, @"1_1.xls"));
                                webClient.DownloadFile(setup.writeurl1_2, System.IO.Path.Combine(we, @"1_2.xls"));
                                webClient.DownloadFile(setup.writeurl2_1, System.IO.Path.Combine(we, @"2_1.xls"));
                                webClient.DownloadFile(setup.writeurl2_2, System.IO.Path.Combine(we, @"2_2.xls"));
                                webClient.DownloadFile(setup.writeurl3_1, System.IO.Path.Combine(we, @"3_1.xls"));
                                webClient.DownloadFile(setup.writeurl3_2, System.IO.Path.Combine(we, @"3_2.xls"));
                                webClient.DownloadFile(setup.writeurl4_1, System.IO.Path.Combine(we, @"4_1.xls"));
                                webClient.DownloadFile(setup.writeurl4_2, System.IO.Path.Combine(we, @"4_2.xls"));
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"5_1.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"5_1.xls")); }
                                    catch { }
                                if (System.IO.File.Exists(System.IO.Path.Combine(we, @"5_2.xls"))) try { System.IO.File.Delete(System.IO.Path.Combine(we, @"5_2.xls")); }
                                    catch { }
                                break;
                            case "10":
                                webClient.DownloadFile(setup.writeurl1_1, System.IO.Path.Combine(we, @"1_1.xls"));
                                webClient.DownloadFile(setup.writeurl1_2, System.IO.Path.Combine(we, @"1_2.xls"));
                                webClient.DownloadFile(setup.writeurl2_1, System.IO.Path.Combine(we, @"2_1.xls"));
                                webClient.DownloadFile(setup.writeurl2_2, System.IO.Path.Combine(we, @"2_2.xls"));
                                webClient.DownloadFile(setup.writeurl3_1, System.IO.Path.Combine(we, @"3_1.xls"));
                                webClient.DownloadFile(setup.writeurl3_2, System.IO.Path.Combine(we, @"3_2.xls"));
                                webClient.DownloadFile(setup.writeurl4_1, System.IO.Path.Combine(we, @"4_1.xls"));
                                webClient.DownloadFile(setup.writeurl4_2, System.IO.Path.Combine(we, @"4_2.xls"));
                                webClient.DownloadFile(setup.writeurl5_1, System.IO.Path.Combine(we, @"5_1.xls"));
                                webClient.DownloadFile(setup.writeurl5_2, System.IO.Path.Combine(we, @"5_2.xls"));
                                break;
                        }
                    }
                    catch { chatch1 = 1; }
                    return "1";
                });

                if (chatch1 == 1)
                {
                    MessageBox.Show("Ошибка в доступе к серверу: \n a) проверьте подключение к интернету; \n b) запустите программу от имени администратора; \n c) повторите попытку; \n d) если подключение к интернету активно, и вы все равно видите это сообщение то необходимо перезагрузить компьютер.");
                    Label1.Visibility = Visibility.Visible;
                    Label3.Visibility = Visibility.Collapsed;
                    button1.Visibility = Visibility.Visible;
                    button2.Visibility = Visibility.Visible;
                    bar.Visibility = Visibility.Collapsed;
                    bar1.Visibility = Visibility.Collapsed;
                    Label5.Visibility = Visibility.Collapsed;
                    text1.Visibility = Visibility.Collapsed;
                    Label6.Visibility = Visibility.Collapsed;
                    dostupkobrabotke = 1;
                    chatch1 = 0;
                }

                bar1.Value = 10;
                text1.Text = bar1.Value.ToString();
                Label6.Content = "Скачены файлы с сайта ВятГУ, вы можете отключить интернет.";
                if (dostupkobrabotke == 0)
                {
                    otbordata(); 
                    if (obrabotkaisklucheni == 1)
                    {
                        MessageBox.Show("Ошибка в записи в фаил: \n a) проверьте наличие установленного на компьютер Excel; \n  b) перезагрузите компьютер; \n  с) напишите о проблеме разработчику, данные вы найдете в вкладке о программе.");
                        Label1.Visibility = Visibility.Visible;
                        Label3.Visibility = Visibility.Collapsed;
                        button1.Visibility = Visibility.Visible;
                        button2.Visibility = Visibility.Visible;
                        bar.Visibility = Visibility.Collapsed;
                        bar1.Visibility = Visibility.Collapsed;
                        Label5.Visibility = Visibility.Collapsed;
                        text1.Visibility = Visibility.Collapsed;
                        Label6.Visibility = Visibility.Collapsed;
                    }
                }
            }
        }
        private void no(object sender, RoutedEventArgs e)
        {
            Close();
            not = 1;
        }
        private void bazaok(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private async void otbordata()
        {
            string[] vsS = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int a1 = 6;
            int z1 = 0;
            int z2 = 0;
            int z3 = 0;
            string s = "";
            for (int ii = 0; ii < 350; ii++)
            {
                var result = await Task<string>.Factory.StartNew(() =>
           {
               try
               {
                  
                   excelapp = new Excel.Application();
                   try { forotborisfailov(vsS, a1, ref z1, ref z2, ref z3, ref s, @"1_1.xls"); }
                   catch { }
                   try { forotborisfailov(vsS, a1, ref z1, ref z2, ref z3, ref s, @"2_1.xls"); }
                   catch { }
                   try { forotborisfailov(vsS, a1, ref z1, ref z2, ref z3, ref s, @"3_1.xls"); }
                   catch { }
                   try { forotborisfailov(vsS, a1, ref z1, ref z2, ref z3, ref s, @"4_1.xls"); }
                   catch { }
                   try { forotborisfailov(vsS, a1, ref z1, ref z2, ref z3, ref s, @"5_1.xls"); }
                   catch { }
                   List<string> otborVfail = new List<string>();
                   foreach (string ss in nomeracabinetov.OllCabinet)
                   {
                       int r = 0;
                       foreach (string b in ponedelnic1flor)
                       {
                           if (b == ss) { r++; break; }
                       }
                       if (r == 0)
                       {
                           otborVfail.Add(ss);
                       }
                   }

                   string stolb = @"" + nomerfailf.ToString() + ".txt";
                   System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(we, stolb));
                   foreach (string chisla in otborVfail)
                   { sw.WriteLine("{0}", chisla); } 
                   sw.Close();
                   otborVfail.Clear();
                   this.ponedelnic1flor.Clear();
                   this.nomerfailf++;
               }
               catch { this.obrabotkaisklucheni = 1; }
               return "1";
           });
                bar1.Value += 1;
                text1.Text = bar1.Value.ToString();
                Label6.Content = @"" + we + @"\" + (bar1.Value - 10).ToString() + ".txt";
                a1 += 8;
                if (a1 == 342)
                {
                    a1 = 6;
                    break;
                } 
            }
            for (int ii = 0; ii < 350; ii++)
            {
                var result = await Task<string>.Factory.StartNew(() =>
                {
                    try
                    {
                        try { forotborisfailov(vsS, a1, ref z1, ref z2, ref z3, ref s, @"1_2.xls"); }
                        catch { }
                        try { forotborisfailov(vsS, a1, ref z1, ref z2, ref z3, ref s, @"2_2.xls"); }
                        catch { }
                        try { forotborisfailov(vsS, a1, ref z1, ref z2, ref z3, ref s, @"3_2.xls"); }
                        catch { }
                        try { forotborisfailov(vsS, a1, ref z1, ref z2, ref z3, ref s, @"4_2.xls"); }
                        catch { }
                        try { forotborisfailov(vsS, a1, ref z1, ref z2, ref z3, ref s, @"5_2.xls"); }
                        catch { }

                        List<string> otborVfail = new List<string>();
                        foreach (string ss in nomeracabinetov.OllCabinet)
                        {
                            int r = 0;
                            foreach (string b in ponedelnic1flor)
                            {
                                if (b == ss) { r++; break; }
                            }
                            if (r == 0)
                            {
                                otborVfail.Add(ss);
                            }
                        }
                        string stolb = @"" + nomerfailf.ToString() + ".txt";
                        System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(we, stolb));
                        foreach (string chisla in otborVfail)
                        { sw.WriteLine("{0}", chisla); } 
                        sw.Close();
                        otborVfail.Clear();
                        this.ponedelnic1flor.Clear();
                        this.nomerfailf++;
                    }
                    catch { this.obrabotkaisklucheni = 1; }
                    return "1";
                });
                bar1.Value += 1;
                text1.Text = bar1.Value.ToString();
                Label6.Content = @"" + we + @"\" + (bar1.Value - 10).ToString() + ".txt";
                a1 += 8;
                if (a1 == 342) break;
            }
            bar1.Value = 100;
            not = 0;
            Label6.Content = we;
            text1.Text = bar1.Value.ToString();
            Label1.Visibility = Visibility.Collapsed;
            Label3.Visibility = Visibility.Collapsed;
            button1.Visibility = Visibility.Collapsed;
            button2.Visibility = Visibility.Collapsed;
            bar.Visibility = Visibility.Collapsed;
            bar1.Visibility = Visibility.Collapsed;
            Label4.Visibility = Visibility.Visible;
            button4.Visibility = Visibility.Visible;
            Label5.Visibility = Visibility.Collapsed;
            text1.Visibility = Visibility.Collapsed;
            Label6.Visibility = Visibility.Collapsed;

        }

        private void forotborisfailov(string[] vsS, int a1, ref int z1, ref int z2, ref int z3, ref string s, string cilka)
        {
            
            excelapp = new Excel.Application();
            excelappworkbooks = excelapp.Workbooks;
            excelappworkbook = excelapp.Workbooks.Open(System.IO.Path.Combine(we, cilka),
             Type.Missing, Type.Missing, Type.Missing, Type.Missing,
             Type.Missing, Type.Missing, Type.Missing, Type.Missing,
             Type.Missing, Type.Missing, Type.Missing, Type.Missing,
             Type.Missing, Type.Missing);
            excelsheets = excelappworkbook.Worksheets;
            excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);
            for (int i = 0; i < 350; i++)
            {
                if ((z1 < 26) && (z3 == 0)) s = vsS[z1] + a1.ToString();
                else
                {
                    z3++;
                    if (z3 == 1) z1 = 0;
                    s = vsS[z2] + vsS[z1] + a1.ToString();
                    if (z1 == 25) { z2++; z1 = 0; }
                }
                if (s == "IW" + a1.ToString()) break;
                excelcells = excelworksheet.get_Range(s, Type.Missing); 
                string excelnumber = excelcells.Value2;
                if ((excelnumber != null) && (excelnumber != "")) this.ponedelnic1flor.Add(excelnumber);
                z1++;
            }
            z1 = 0;
            z2 = 0;
            z3 = 0;
            excelworksheet = (Excel.Worksheet)excelsheets.get_Item(2);
            for (int i = 0; i < 350; i++)
            {
                if ((z1 < 26) && (z3 == 0)) s = vsS[z1] + a1.ToString();
                else
                {
                    z3++;
                    if (z3 == 1) z1 = 0;
                    s = vsS[z2] + vsS[z1] + a1.ToString();
                    if (z1 == 25) { z2++; z1 = 0; }
                }
                if (s == "IW" + a1.ToString()) break;
                excelcells = excelworksheet.get_Range(s, Type.Missing);
                string excelnumber = excelcells.Value2;
                if ((excelnumber != null) && (excelnumber != "")) this.ponedelnic1flor.Add(excelnumber);
                z1++;
            }
            z1 = 0;
            z2 = 0;
            z3 = 0;
            excelappworkbook.Close();
            excelappworkbooks.Close();
            excelapp.Workbooks.Close();

        }
    }
}