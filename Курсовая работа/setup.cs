using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Курсовая_работа
{
    class setup
    {
        string colichestvosilok;
        string url1_1;
        string url2_1;
        string url3_1;
        string url4_1;
        string url5_1;
        string url1_2;
        string url2_2;
        string url3_2;
        string url4_2;
        string url5_2;

        private setup(string colichestvosilok, string url1_1, string url1_2, string url1_3, string url1_4, string url1_5,
            string url2_1, string url2_2, string url2_3, string url2_4, string url2_5)
        {
            this.colichestvosilok = colichestvosilok;
            this.url1_1 = url1_1;
            this.url2_1 = url1_2;
            this.url3_1 = url1_3;
            this.url4_1 = url1_4;
            this.url5_1 = url1_5;
            this.url1_2 = url2_1;
            this.url2_2 = url2_2;
            this.url3_2 = url2_3;
            this.url4_2 = url2_4;
            this.url5_2 = url2_5;
        }
        public setup() { }


        public void olldsetup()
        {
            this.colichestvosilok = "10";
            this.url1_1 = "http://www.vyatsu.ru/files/schedule/xls/1_1.xls";
            this.url2_1 = "http://www.vyatsu.ru/files/schedule/xls/2_1.xls";
            this.url3_1 = "http://www.vyatsu.ru/files/schedule/xls/3_1.xls";
            this.url4_1 = "http://www.vyatsu.ru/files/schedule/xls/4_1.xls";
            this.url5_1 = "http://www.vyatsu.ru/files/schedule/xls/5_1.xls";
            this.url1_2 = "http://www.vyatsu.ru/files/schedule/xls/1_2.xls";
            this.url2_2 = "http://www.vyatsu.ru/files/schedule/xls/2_2.xls";
            this.url3_2 = "http://www.vyatsu.ru/files/schedule/xls/3_2.xls";
            this.url4_2 = "http://www.vyatsu.ru/files/schedule/xls/4_2.xls";
            this.url5_2 = "http://www.vyatsu.ru/files/schedule/xls/5_2.xls";
        }
        public void savesetup()
        {

            System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine
                (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"ProgramData\FreeRooms", @"" + "setup" + ".stp")); 
            sw.WriteLine(colichestvosilok);
            sw.WriteLine(url1_1);
            sw.WriteLine(url2_1);
            sw.WriteLine(url3_1);
            sw.WriteLine(url4_1);
            sw.WriteLine(url5_1);
            sw.WriteLine(url1_2);
            sw.WriteLine(url2_2);
            sw.WriteLine(url3_2);
            sw.WriteLine(url4_2);
            sw.WriteLine(url5_2);
            sw.Close();
        }
        public string colichestvo { get { return colichestvosilok; } set { this.colichestvosilok = value; } }
        public string writeurl1_1 { get { return url1_1; } set { this.url1_1 = value; } }
        public string writeurl2_1 { get { return url2_1; } set { this.url2_1 = value; } }
        public string writeurl3_1 { get { return url3_1; } set { this.url3_1 = value; } }
        public string writeurl4_1 { get { return url4_1; } set { this.url4_1 = value; } }

        public string writeurl5_1 { get { return url5_1; } set { this.url5_1 = value; } }
        public string writeurl1_2 { get { return url1_2; } set { this.url1_2 = value; } }
        public string writeurl2_2 { get { return url2_2; } set { this.url2_2 = value; } }
        public string writeurl3_2 { get { return url3_2; } set { this.url3_2 = value; } }
        public string writeurl4_2 { get { return url4_2; } set { this.url4_2 = value; } }
        public string writeurl5_2 { get { return url5_2; } set { this.url5_2 = value; } }

        public void redfile()
        {
            try
            {
                System.IO.StreamReader f = new System.IO.StreamReader(System.IO.Path.Combine
                   (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"ProgramData\FreeRooms", @"" + "setup" + ".stp"), System.Text.Encoding.GetEncoding("windows-1251"));
                this.colichestvosilok = f.ReadLine();
                this.url1_1 = f.ReadLine();
                this.url2_1 = f.ReadLine();
                this.url3_1 = f.ReadLine();
                this.url4_1 = f.ReadLine();
                this.url5_1 = f.ReadLine();
                this.url1_2 = f.ReadLine();
                this.url2_2 = f.ReadLine();
                this.url3_2 = f.ReadLine();
                this.url4_2 = f.ReadLine();
                this.url5_2 = f.ReadLine();
                f.Close();
            }
            catch
            {
                olldsetup();
                savesetup();
            }
        }
    }
}
