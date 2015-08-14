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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        private setup setup = new setup();
        int colcursov;
        public Window6()
        {
            InitializeComponent();
            setup.redfile();
        }

        private void RB1(object sender, RoutedEventArgs e)
        {
            this.colcursov = 2;
            TextBox11.IsEnabled = true;
            TextBox11.Text = setup.writeurl1_1;
            TextBox12.IsEnabled = true;
            TextBox12.Text = setup.writeurl1_2;
            TextBox21.IsEnabled = false;
            TextBox22.IsEnabled = false;
            TextBox31.IsEnabled = false;
            TextBox32.IsEnabled = false;
            TextBox41.IsEnabled = false;
            TextBox42.IsEnabled = false;
            TextBox51.IsEnabled = false;
            TextBox52.IsEnabled = false;
        }

        private void RB2(object sender, RoutedEventArgs e)
        {
            this.colcursov = 4;
            TextBox11.IsEnabled = true;
            TextBox11.Text = setup.writeurl1_1;
            TextBox12.IsEnabled = true;
            TextBox12.Text = setup.writeurl1_2;
            TextBox21.IsEnabled = true;
            TextBox21.Text = setup.writeurl2_1;
            TextBox22.IsEnabled = true;
            TextBox22.Text = setup.writeurl2_2;
            TextBox31.IsEnabled = false;
            TextBox32.IsEnabled = false;
            TextBox41.IsEnabled = false;
            TextBox42.IsEnabled = false;
            TextBox51.IsEnabled = false;
            TextBox52.IsEnabled = false;
        }

        private void RB3(object sender, RoutedEventArgs e)
        {
            this.colcursov = 6;
            TextBox11.IsEnabled = true;
            TextBox11.Text = setup.writeurl1_1;
            TextBox12.IsEnabled = true;
            TextBox12.Text = setup.writeurl1_2;
            TextBox21.IsEnabled = true;
            TextBox21.Text = setup.writeurl2_1;
            TextBox22.IsEnabled = true;
            TextBox22.Text = setup.writeurl2_2;
            TextBox31.IsEnabled = true;
            TextBox31.Text = setup.writeurl3_1;
            TextBox32.IsEnabled = true;
            TextBox32.Text = setup.writeurl3_2;
            TextBox41.IsEnabled = false;
            TextBox42.IsEnabled = false;
            TextBox51.IsEnabled = false;
            TextBox52.IsEnabled = false;
        }

        private void RB4(object sender, RoutedEventArgs e)
        {
            this.colcursov = 8;
            TextBox11.IsEnabled = true;
            TextBox11.Text = setup.writeurl1_1;
            TextBox12.IsEnabled = true;
            TextBox12.Text = setup.writeurl1_2;
            TextBox21.IsEnabled = true;
            TextBox21.Text = setup.writeurl2_1;
            TextBox22.IsEnabled = true;
            TextBox22.Text = setup.writeurl2_2;
            TextBox31.IsEnabled = true;
            TextBox31.Text = setup.writeurl3_1;
            TextBox32.IsEnabled = true;
            TextBox32.Text = setup.writeurl3_2;
            TextBox41.IsEnabled = true;
            TextBox41.Text = setup.writeurl4_1;
            TextBox42.IsEnabled = true;
            TextBox42.Text = setup.writeurl4_2;
            TextBox51.IsEnabled = false;
            TextBox52.IsEnabled = false;
        }

        private void RB5(object sender, RoutedEventArgs e)
        {
            this.colcursov = 10;
            TextBox11.IsEnabled = true;
            TextBox11.Text = setup.writeurl1_1;
            TextBox12.IsEnabled = true;
            TextBox12.Text = setup.writeurl1_2;
            TextBox21.IsEnabled = true;
            TextBox21.Text = setup.writeurl2_1;
            TextBox22.IsEnabled = true;
            TextBox22.Text = setup.writeurl2_2;
            TextBox31.IsEnabled = true;
            TextBox31.Text = setup.writeurl3_1;
            TextBox32.IsEnabled = true;
            TextBox32.Text = setup.writeurl3_2;
            TextBox41.IsEnabled = true;
            TextBox41.Text = setup.writeurl4_1;
            TextBox42.IsEnabled = true;
            TextBox42.Text = setup.writeurl4_2;
            TextBox51.IsEnabled = true;
            TextBox51.Text = setup.writeurl5_1;
            TextBox52.IsEnabled = true;
            TextBox52.Text = setup.writeurl5_2;
        }

        private void ok(object sender, RoutedEventArgs e)
        {
            int i = 10;
            int numbererror = 0; 
            e1.Visibility = Visibility.Collapsed;
            e2.Visibility = Visibility.Collapsed;
            e3.Visibility = Visibility.Collapsed;
            e4.Visibility = Visibility.Collapsed;
            e5.Visibility = Visibility.Collapsed;
            e6.Visibility = Visibility.Collapsed;
            e7.Visibility = Visibility.Collapsed;
            e8.Visibility = Visibility.Collapsed;
            e9.Visibility = Visibility.Collapsed;
            e10.Visibility = Visibility.Collapsed;
            
                switch (colcursov)
                {
                    case 0:
                        MessageBox.Show("Вы не выбрали количество курсов");
                        break;
                    case 2:
try
                        {
                            if (TextBox11.Text == "" || TextBox11.Text[0] != 'h' || TextBox11.Text[3] != 'p' || TextBox11.Text[11] != 'v' || TextBox11.Text[16] != 'u')
                            { e1.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e1.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox12.Text == "" || TextBox12.Text[0] != 'h' || TextBox12.Text[3] != 'p' || TextBox12.Text[11] != 'v' || TextBox12.Text[16] != 'u')
                            { e2.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e2.Visibility = Visibility.Visible; i--;
                        }
                        break;
                    case 4:
                        try
                        {
                            if (TextBox11.Text == "" || TextBox11.Text[0] != 'h' || TextBox11.Text[3] != 'p' || TextBox11.Text[11] != 'v' || TextBox11.Text[16] != 'u')
                            { e1.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e1.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox12.Text == "" || TextBox12.Text[0] != 'h' || TextBox12.Text[3] != 'p' || TextBox12.Text[11] != 'v' || TextBox12.Text[16] != 'u')
                            { e2.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e2.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox21.Text == "" || TextBox21.Text[0] != 'h' || TextBox21.Text[3] != 'p' || TextBox21.Text[11] != 'v' || TextBox21.Text[16] != 'u')
                            { e3.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e3.Visibility = Visibility.Visible; i--; 
                        }
                        try
                        {
                            if (TextBox22.Text == "" || TextBox22.Text[0] != 'h' || TextBox22.Text[3] != 'p' || TextBox22.Text[11] != 'v' || TextBox22.Text[16] != 'u')
                            { e4.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e4.Visibility = Visibility.Visible; i--;
                        }
                        break;
                    case 6:
                        try
                        {
                            if (TextBox11.Text == "" || TextBox11.Text[0] != 'h' || TextBox11.Text[3] != 'p' || TextBox11.Text[11] != 'v' || TextBox11.Text[16] != 'u')
                            { e1.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e1.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox12.Text == "" || TextBox12.Text[0] != 'h' || TextBox12.Text[3] != 'p' || TextBox12.Text[11] != 'v' || TextBox12.Text[16] != 'u')
                            { e2.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e2.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox21.Text == "" || TextBox21.Text[0] != 'h' || TextBox21.Text[3] != 'p' || TextBox21.Text[11] != 'v' || TextBox21.Text[16] != 'u')
                            { e3.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e3.Visibility = Visibility.Visible; i--; 
                        }
                        try
                        {
                            if (TextBox22.Text == "" || TextBox22.Text[0] != 'h' || TextBox22.Text[3] != 'p' || TextBox22.Text[11] != 'v' || TextBox22.Text[16] != 'u')
                            { e4.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e4.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox31.Text == "" || TextBox31.Text[0] != 'h' || TextBox31.Text[3] != 'p' || TextBox31.Text[11] != 'v' || TextBox31.Text[16] != 'u')
                            { e5.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e5.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox32.Text == "" || TextBox32.Text[0] != 'h' || TextBox32.Text[3] != 'p' || TextBox32.Text[11] != 'v' || TextBox32.Text[16] != 'u')
                            { e6.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e6.Visibility = Visibility.Visible; i--;
                        }
                        break;
                    case 8:
                       try
                        {
                            if (TextBox11.Text == "" || TextBox11.Text[0] != 'h' || TextBox11.Text[3] != 'p' || TextBox11.Text[11] != 'v' || TextBox11.Text[16] != 'u')
                            { e1.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e1.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox12.Text == "" || TextBox12.Text[0] != 'h' || TextBox12.Text[3] != 'p' || TextBox12.Text[11] != 'v' || TextBox12.Text[16] != 'u')
                            { e2.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e2.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox21.Text == "" || TextBox21.Text[0] != 'h' || TextBox21.Text[3] != 'p' || TextBox21.Text[11] != 'v' || TextBox21.Text[16] != 'u')
                            { e3.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e3.Visibility = Visibility.Visible; i--; 
                        }
                        try
                        {
                            if (TextBox22.Text == "" || TextBox22.Text[0] != 'h' || TextBox22.Text[3] != 'p' || TextBox22.Text[11] != 'v' || TextBox22.Text[16] != 'u')
                            { e4.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e4.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox31.Text == "" || TextBox31.Text[0] != 'h' || TextBox31.Text[3] != 'p' || TextBox31.Text[11] != 'v' || TextBox31.Text[16] != 'u')
                            { e5.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e5.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox32.Text == "" || TextBox32.Text[0] != 'h' || TextBox32.Text[3] != 'p' || TextBox32.Text[11] != 'v' || TextBox32.Text[16] != 'u')
                            { e6.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e6.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox41.Text == "" || TextBox41.Text[0] != 'h' || TextBox41.Text[3] != 'p' || TextBox41.Text[11] != 'v' || TextBox41.Text[16] != 'u')
                            { e7.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e7.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox42.Text == "" || TextBox42.Text[0] != 'h' || TextBox42.Text[3] != 'p' || TextBox42.Text[11] != 'v' || TextBox42.Text[16] != 'u')
                            { e8.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e8.Visibility = Visibility.Visible; i--;
                        }
                        break;
                    case 10:
                        try
                        {
                            if (TextBox11.Text == "" || TextBox11.Text[0] != 'h' || TextBox11.Text[3] != 'p' || TextBox11.Text[11] != 'v' || TextBox11.Text[16] != 'u')
                            { e1.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e1.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox12.Text == "" || TextBox12.Text[0] != 'h' || TextBox12.Text[3] != 'p' || TextBox12.Text[11] != 'v' || TextBox12.Text[16] != 'u')
                            { e2.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e2.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox21.Text == "" || TextBox21.Text[0] != 'h' || TextBox21.Text[3] != 'p' || TextBox21.Text[11] != 'v' || TextBox21.Text[16] != 'u')
                            { e3.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e3.Visibility = Visibility.Visible; i--; 
                        }
                        try
                        {
                            if (TextBox22.Text == "" || TextBox22.Text[0] != 'h' || TextBox22.Text[3] != 'p' || TextBox22.Text[11] != 'v' || TextBox22.Text[16] != 'u')
                            { e4.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e4.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox31.Text == "" || TextBox31.Text[0] != 'h' || TextBox31.Text[3] != 'p' || TextBox31.Text[11] != 'v' || TextBox31.Text[16] != 'u')
                            { e5.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e5.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox32.Text == "" || TextBox32.Text[0] != 'h' || TextBox32.Text[3] != 'p' || TextBox32.Text[11] != 'v' || TextBox32.Text[16] != 'u')
                            { e6.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e6.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox41.Text == "" || TextBox41.Text[0] != 'h' || TextBox41.Text[3] != 'p' || TextBox41.Text[11] != 'v' || TextBox41.Text[16] != 'u')
                            { e7.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e7.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox42.Text == "" || TextBox42.Text[0] != 'h' || TextBox42.Text[3] != 'p' || TextBox42.Text[11] != 'v' || TextBox42.Text[16] != 'u')
                            { e8.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e8.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox51.Text == "" || TextBox51.Text[0] != 'h' || TextBox51.Text[3] != 'p' || TextBox51.Text[11] != 'v' || TextBox51.Text[16] != 'u')
                            { e9.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e9.Visibility = Visibility.Visible; i--;
                        }
                        try
                        {
                            if (TextBox52.Text == "" || TextBox52.Text[0] != 'h' || TextBox52.Text[3] != 'p' || TextBox52.Text[11] != 'v' || TextBox52.Text[16] != 'u')
                            { e10.Visibility = Visibility.Visible; i--; }
                        }
                        catch
                        {
                            e10.Visibility = Visibility.Visible; i--;
                        }
                        break;
                }
            
            if (i - (10 - colcursov) < colcursov) MessageBox.Show("Пожалуйста вставьте ссылку или проверьте ее корректность");

            if (i - (10 - colcursov) == colcursov && numbererror == 0)
            {
                setup.colichestvo = colcursov.ToString();
                switch (colcursov)
                {
                    case 2:
                        setup.writeurl1_1 = TextBox11.Text;
                        setup.writeurl1_2 = TextBox12.Text;
                        setup.savesetup();
                        Close();
                        MessageBox.Show("Ссылки успешно изменены");
                        break;
                    case 4:
                        setup.writeurl1_1 = TextBox11.Text;
                        setup.writeurl1_2 = TextBox12.Text;
                        setup.writeurl2_1 = TextBox21.Text;
                        setup.writeurl2_2 = TextBox22.Text;
                        setup.savesetup();
                        Close();
                        MessageBox.Show("Ссылки успешно изменены");
                        break;
                    case 6:
                        setup.writeurl1_1 = TextBox11.Text;
                        setup.writeurl1_2 = TextBox12.Text;
                        setup.writeurl2_1 = TextBox21.Text;
                        setup.writeurl2_2 = TextBox22.Text;
                        setup.writeurl3_1 = TextBox31.Text;
                        setup.writeurl3_2 = TextBox32.Text;
                        setup.savesetup();
                        Close();
                        MessageBox.Show("Ссылки успешно изменены");
                        break;
                    case 8:
                        setup.writeurl1_1 = TextBox11.Text;
                        setup.writeurl1_2 = TextBox12.Text;
                        setup.writeurl2_1 = TextBox21.Text;
                        setup.writeurl2_2 = TextBox22.Text;
                        setup.writeurl3_1 = TextBox31.Text;
                        setup.writeurl3_2 = TextBox32.Text;
                        setup.writeurl4_1 = TextBox41.Text;
                        setup.writeurl4_2 = TextBox42.Text;
                        setup.savesetup();
                        Close();
                        MessageBox.Show("Ссылки успешно изменены");
                        break;
                    case 10:
                        setup.writeurl1_1 = TextBox11.Text;
                        setup.writeurl1_2 = TextBox12.Text;
                        setup.writeurl2_1 = TextBox21.Text;
                        setup.writeurl2_2 = TextBox22.Text;
                        setup.writeurl3_1 = TextBox31.Text;
                        setup.writeurl3_2 = TextBox32.Text;
                        setup.writeurl4_1 = TextBox41.Text;
                        setup.writeurl4_2 = TextBox42.Text;
                        setup.writeurl5_1 = TextBox51.Text;
                        setup.writeurl5_2 = TextBox52.Text;
                        setup.savesetup();
                        Close();
                        MessageBox.Show("Ссылки успешно изменены");
                        break;

                }
            }
            numbererror = 0;
        }
    }
}