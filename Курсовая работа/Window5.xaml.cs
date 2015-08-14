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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }
        private void ok(object sender, RoutedEventArgs e)
        {
            Cursor = Cursors.Wait;
            if (ComboBox1.Text == "Выберите курс") { Cursor = Cursors.Arrow; MessageBox.Show("Пожалуйста выберите курс!"); }
            else if (ComboBox2.Text == "Выберите неделю") { Cursor = Cursors.Arrow; MessageBox.Show("Пожалуйста выберите неделю!"); }
            else if (TextBox.Text == "" || TextBox.Text[0] != 'h' || TextBox.Text[3] != 'p' || TextBox.Text[11] != 'v' || TextBox.Text[16] != 'u') { Cursor = Cursors.Arrow; MessageBox.Show("Пожалуйста вставьте ссылку или проверьте ее корректность"); }
            else
            {
                try
                {
                    setup fg = new setup();
                    fg.redfile();
                    string otbor = ComboBox1.Text.ToString() + ComboBox2.Text.ToString();
                    switch (otbor)
                    {
                        case "11":
                            fg.writeurl1_1 = TextBox.Text;
                            break;
                        case "12":
                            fg.writeurl1_2 = TextBox.Text;
                            break;
                        case "21":
                            fg.writeurl2_1 = TextBox.Text;
                            break;
                        case "22":
                            fg.writeurl2_2 = TextBox.Text;
                            break;
                        case "31":
                            fg.writeurl3_1 = TextBox.Text;
                            break;
                        case "32":
                            fg.writeurl3_2 = TextBox.Text;
                            break;
                        case "41":
                            fg.writeurl4_1 = TextBox.Text;
                            break;
                        case "42":
                            fg.writeurl4_2 = TextBox.Text;
                            break;
                        case "51":
                            fg.writeurl5_1 = TextBox.Text;
                            break;
                        case "52":
                            fg.writeurl5_2 = TextBox.Text;
                            break;
                    }
                    fg.savesetup();
                    Close();
                    Cursor = Cursors.Arrow;
                    MessageBox.Show("Ссылка успешно добавлена!");
                }
                catch
                {
                    Cursor = Cursors.Arrow;
                    MessageBox.Show("Пожалуйста проверьте правильность введенной вами ссылки и соеденение с интернетом");
                }
            }
        }
    }
}
