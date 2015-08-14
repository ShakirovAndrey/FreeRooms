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

namespace Курсовая_работа
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void click_button(object sender, RoutedEventArgs e)
        {
            if (newtime.Text == "") MessageBox.Show("Пожалуйста выберите время");
            else if (newweek.Text == "") MessageBox.Show("Пожалуйста выберите неделю");
            else if (newdayofweek.Text == "") MessageBox.Show("Пожалуйста выберите день недели");
            else Close();
        }

        private void click_button1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
