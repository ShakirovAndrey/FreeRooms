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

namespace Курсовая_работа
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window 
    {
        public int zakrit = 0;
        public Window2()
        {
            InitializeComponent();
            string s = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string we = System.IO.Path.Combine(s, @"ProgramData\FreeRooms");
            System.IO.Directory.CreateDirectory(we);
            DateTime dateBegin = new DateTime(1, 1, 1);
            if (File.Exists(System.IO.Path.Combine(we, @"" + "1" + ".txt")))
            {
                dateBegin = File.GetLastWriteTime(System.IO.Path.Combine(we, @"" + "1" + ".txt"));
                TextBlock.Text = dateBegin.ToLongDateString();
            }
            
            else TextBlock.Text = "обновление не проводилось";
            
        }
        private void obnovlenie(object sender, RoutedEventArgs e)
        {
            Close();
            Window3 df = new Window3();
            df.ShowDialog();
            if (df.not == 0)
            {
                zakrit = 1;
            }
        }

        private void ignor(object sender, RoutedEventArgs e)
        {
            Close();
            zakrit = 1;
        }
    }
}
