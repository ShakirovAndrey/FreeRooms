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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Курсовая_работа
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string week;
        public string time;
        public string dayofweek;
        string s; 
        public MainWindow()
        {
            InitializeComponent();
            this.s = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string we = System.IO.Path.Combine(s, @"ProgramData\FreeRooms");
            System.IO.Directory.CreateDirectory(we);
            DateTime dateBegin = new DateTime(1, 1, 1);
            if (File.Exists(System.IO.Path.Combine(s, @"ProgramData\FreeRooms", @"" + "1" + ".txt")))
                dateBegin = File.GetLastWriteTime(System.IO.Path.Combine(s, @"ProgramData\FreeRooms", @"" + "1" + ".txt"));
            DateTime dateEnd = dateBegin.AddDays(14);
            DateTime today = DateTime.Now;
            if (today >= dateBegin && today < dateEnd)
            {
                showdialogwithchoisdate();
                if ((time == "") || (week == "") || (dayofweek == "")) Close();
                otbordata();
            }
            else 
            {
                Window2 dff = new Window2();
                dff.ShowDialog();
                if (dff.zakrit == 1)
                {
                    showdialogwithchoisdate();
                    if ((time == "") || (week == "") || (dayofweek == "")) Close();
                    otbordata();
                }
                else
                {
                    _1flor.Text = "Базы данных не были обновлены!";    
                    _1flor.Foreground = Brushes.Red;
                }
                
            }
            
        }
        private void new_date_Click(object sender, RoutedEventArgs e)
        {
            showdialogwithchoisdate();
            otbordata();
        }

        public void showdialogwithchoisdate()
        {
            Window1 df = new Window1();
            df.ShowDialog();
            this.week = df.newweek.Text;
            this.dayofweek = df.newdayofweek.Text;
            this.time = df.newtime.Text;
            weekDayTime.Text = week + " " + dayofweek + " " + time;  
        }
        private void otbordata()
        {
            if (week == "первая неделя")
            {
                if (dayofweek == "пн")
                {
                    if (time == "08:20-09:50") vivodisfaila(1);
                    if (time == "10:00-11:30") vivodisfaila(2);
                    if (time == "11:45-13:15") vivodisfaila(3);
                    if (time == "14:00-15:30") vivodisfaila(4);
                    if (time == "15:45-17:15") vivodisfaila(5);
                    if (time == "17:20-18:50") vivodisfaila(6);
                    if (time == "18:50-20:25") vivodisfaila(7);
                }
                if (dayofweek == "вт")
                {
                    if (time == "08:20-09:50") vivodisfaila(8);
                    if (time == "10:00-11:30") vivodisfaila(9);
                    if (time == "11:45-13:15") vivodisfaila(10);
                    if (time == "14:00-15:30") vivodisfaila(11);
                    if (time == "15:45-17:15") vivodisfaila(12);
                    if (time == "17:20-18:50") vivodisfaila(13);
                    if (time == "18:50-20:25") vivodisfaila(14);
                }
                if (dayofweek == "ср")
                {
                    if (time == "08:20-09:50") vivodisfaila(15);
                    if (time == "10:00-11:30") vivodisfaila(16);
                    if (time == "11:45-13:15") vivodisfaila(17);
                    if (time == "14:00-15:30") vivodisfaila(18);
                    if (time == "15:45-17:15") vivodisfaila(19);
                    if (time == "17:20-18:50") vivodisfaila(20);
                    if (time == "18:50-20:25") vivodisfaila(21);
                }
                if (dayofweek == "чт")
                {
                    if (time == "08:20-09:50") vivodisfaila(22);
                    if (time == "10:00-11:30") vivodisfaila(23);
                    if (time == "11:45-13:15") vivodisfaila(24);
                    if (time == "14:00-15:30") vivodisfaila(25);
                    if (time == "15:45-17:15") vivodisfaila(26);
                    if (time == "17:20-18:50") vivodisfaila(27);
                    if (time == "18:50-20:25") vivodisfaila(28);
                }
                if (dayofweek == "пт")
                {
                    if (time == "08:20-09:50") vivodisfaila(29);
                    if (time == "10:00-11:30") vivodisfaila(30);
                    if (time == "11:45-13:15") vivodisfaila(31);
                    if (time == "14:00-15:30") vivodisfaila(32);
                    if (time == "15:45-17:15") vivodisfaila(33);
                    if (time == "17:20-18:50") vivodisfaila(34);
                    if (time == "18:50-20:25") vivodisfaila(35);
                }
                if (dayofweek == "сб")
                {
                    if (time == "08:20-09:50") vivodisfaila(36);
                    if (time == "10:00-11:30") vivodisfaila(37);
                    if (time == "11:45-13:15") vivodisfaila(38);
                    if (time == "14:00-15:30") vivodisfaila(39);
                    if (time == "15:45-17:15") vivodisfaila(40);
                    if (time == "17:20-18:50") vivodisfaila(41);
                    if (time == "18:50-20:25") vivodisfaila(42);
                }
            }
            if (week == "вторая неделя")
            {
                if (dayofweek == "пн")
                {
                    if (time == "08:20-09:50") vivodisfaila(43);
                    if (time == "10:00-11:30") vivodisfaila(44);
                    if (time == "11:45-13:15") vivodisfaila(45);
                    if (time == "14:00-15:30") vivodisfaila(46);
                    if (time == "15:45-17:15") vivodisfaila(47);
                    if (time == "17:20-18:50") vivodisfaila(48);
                    if (time == "18:50-20:25") vivodisfaila(49);
                }
                if (dayofweek == "вт")
                {
                    if (time == "08:20-09:50") vivodisfaila(50);
                    if (time == "10:00-11:30") vivodisfaila(51);
                    if (time == "11:45-13:15") vivodisfaila(52);
                    if (time == "14:00-15:30") vivodisfaila(53);
                    if (time == "15:45-17:15") vivodisfaila(54);
                    if (time == "17:20-18:50") vivodisfaila(55);
                    if (time == "18:50-20:25") vivodisfaila(56);
                }
                if (dayofweek == "ср")
                {
                    if (time == "08:20-09:50") vivodisfaila(57);
                    if (time == "10:00-11:30") vivodisfaila(58);
                    if (time == "11:45-13:15") vivodisfaila(59);
                    if (time == "14:00-15:30") vivodisfaila(60);
                    if (time == "15:45-17:15") vivodisfaila(61);
                    if (time == "17:20-18:50") vivodisfaila(62);
                    if (time == "18:50-20:25") vivodisfaila(63);
                }
                if (dayofweek == "чт")
                {
                    if (time == "08:20-09:50") vivodisfaila(64);
                    if (time == "10:00-11:30") vivodisfaila(65);
                    if (time == "11:45-13:15") vivodisfaila(66);
                    if (time == "14:00-15:30") vivodisfaila(67);
                    if (time == "15:45-17:15") vivodisfaila(68);
                    if (time == "17:20-18:50") vivodisfaila(69);
                    if (time == "18:50-20:25") vivodisfaila(70);
                }
                if (dayofweek == "пт")
                {
                    if (time == "08:20-09:50") vivodisfaila(71);
                    if (time == "10:00-11:30") vivodisfaila(72);
                    if (time == "11:45-13:15") vivodisfaila(73);
                    if (time == "14:00-15:30") vivodisfaila(74);
                    if (time == "15:45-17:15") vivodisfaila(75);
                    if (time == "17:20-18:50") vivodisfaila(76);
                    if (time == "18:50-20:25") vivodisfaila(77);
                }
                if (dayofweek == "сб")
                {
                    if (time == "08:20-09:50") vivodisfaila(78);
                    if (time == "10:00-11:30") vivodisfaila(79);
                    if (time == "11:45-13:15") vivodisfaila(80);
                    if (time == "14:00-15:30") vivodisfaila(81);
                    if (time == "15:45-17:15") vivodisfaila(82);
                    if (time == "17:20-18:50") vivodisfaila(83);
                    if (time == "18:50-20:25") vivodisfaila(84);
                }
            }
        }
        private void vivodisfaila(int number)
        {
            try
            {
                _1flor.Text = null;
                System.IO.StreamReader f = new System.IO.StreamReader(System.IO.Path.Combine(s, @"ProgramData\FreeRooms", @"" + number.ToString() + ".txt"),
                    System.Text.Encoding.GetEncoding("windows-1251"));
                bool i = true;
                while (i == true)
                {
                    string NomerCabinetaFail = f.ReadLine();
                    if ((NomerCabinetaFail != null) && (NomerCabinetaFail != ""))
                    {
                        _1flor.Text += NomerCabinetaFail;
                        _1flor.Text += "; ";
                    }
                    else i = false;
                }
                f.Close();
                this._1flor.Foreground = Brushes.Black;
            }
            catch
            {
                _1flor.Text = "Для работы с программой обновите базы данных.";
                this._1flor.Foreground = Brushes.Red;
            }
        }
        private void vixodisprogi(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void oProgramme(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("разработчик - Шакиров Андрей Альбертович \nпрограмма - Свободные кабинеты 5 корпуса ВятГУ \nверсия - 1.01");
        }

        private void obnovlenieBazExselfast(object sender, RoutedEventArgs e)
        {
            Window3 ds = new Window3();
            ds.ShowDialog();
            if (ds.not == 0)
            {
                _1flor.Text = "Базы данных программы успешно обновлены!  Выберите дату.";
                _1flor.Foreground = Brushes.Black;
                showdialogwithchoisdate();
                otbordata();
            }
            else
            {
                _1flor.Text = "Базы данных не были обновлены!";
                _1flor.Foreground = Brushes.Red;
            }
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Window4 g = new Window4();
            g.ShowDialog();
        }

        private void sbrossetup(object sender, RoutedEventArgs e)
        {
            setup df = new setup();
            df.olldsetup();
            df.savesetup();
            MessageBox.Show("Настройки успешно востановлены!");
        }

        private void silka1(object sender, RoutedEventArgs e)
        {
            Window5 fg = new Window5();
            fg.ShowDialog();
        }


        private void ssilkaoll(object sender, RoutedEventArgs e)
        {
            Window6 fg = new Window6();
            fg.ShowDialog();
        }
    }
}
