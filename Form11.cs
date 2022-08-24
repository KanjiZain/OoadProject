using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OOP_Project
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            if (urdu_rd_btn.Checked == true)
            {
                Data_con one = new Data_con(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Hadiths\Usool_Kafi.mdb");
                one.user = Search_box.Text;
                one.RunQuerry("Select URDU from Hadiths");
            }
            else if (eng_rd_btn.Checked == true)
            {
                Data_con one = new Data_con(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Hadiths\Usool_Kafi.mdb");
                one.user = Search_box.Text;
                one.RunQuerry("Select ENGLISH from Hadiths");
            }
            else if (urdu_rd_btn.Checked == false && eng_rd_btn.Checked == false)
            {
                MessageBox.Show("Select Language please");
            }
        }



        private void button116_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button115_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sahi_muslim_vol_1_btn_Click(object sender, EventArgs e)
        {
            Filepath obj1 = new Filepath(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Hadiths\books_Saheh%20Al-Muslim_urdu_Saheeh_Muslim_Vol_1.pdf");
        }

        private void sahi_muslim_vol_2_btn_Click(object sender, EventArgs e)
        {
            Filepath obj1 = new Filepath(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Hadiths\books_Saheh%20Al-Muslim_urdu_Saheeh_Muslim_Vol_2.pdf");
        }

        private void sahi_muslim_vol_3_btn_Click(object sender, EventArgs e)
        {
            Filepath obj1 = new Filepath(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Hadiths\books_Saheh%20Al-Muslim_urdu_Saheeh_Muslim_Vol_3.pdf");
        }

        private void sahi_muslim_vol_4_btn_Click(object sender, EventArgs e)
        {
            Filepath obj1 = new Filepath(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Hadiths\books_Saheh%20Al-Muslim_urdu_Saheeh_Muslim_Vol_4.pdf");
        }

        private void sahi_bukhari_vol_1_btn_Click(object sender, EventArgs e)
        {
            Filepath obj1 = new Filepath(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Hadiths\books_Saheh%20Al-Bukhari_urdu_Sahi-Bukhari-Jilad-1.pdf");
        }

        private void sahi_bukhari_vol_2_btn_Click(object sender, EventArgs e)
        {
            Filepath obj1 = new Filepath(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Hadiths\books_Saheh%20Al-Bukhari_urdu_Sahi-Bukhari-Jilad-2.pdf");
        }

        private void sahi_bukhari_vol_3_btn_Click(object sender, EventArgs e)
        {
            Filepath obj1 = new Filepath(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Hadiths\books_Saheh%20Al-Bukhari_urdu_Sahi-Bukhari-Jilad-3.pdf");
        }

        private void sahi_bukhari_vol_4_btn_Click(object sender, EventArgs e)
        {
            Filepath obj1 = new Filepath(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Hadiths\books_Saheh%20Al-Bukhari_urdu_Sahi-Bukhari-Jilad-4.pdf");
        }

        private void Manla_yudhr_fahi_vol_1_btn_Click(object sender, EventArgs e)
        {
            Filepath obj1 = new Filepath(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Hadiths\ManLaYadharulFaqih1of4.pdf");

        }

        private void Manla_yudhr_fahi_vol_2_btn_Click(object sender, EventArgs e)
        {
            Filepath obj1 = new Filepath(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Hadiths\ManLaYadharulFaqih2of4.pdf");

        }

        private void Manla_yudhr_fahi_vol_3_btn_Click(object sender, EventArgs e)
        {
            Filepath obj1 = new Filepath(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Hadiths\ManLaYadharulFaqih3of4.pdf");

        }

        private void Manla_yudhr_fahi_vol_4_btn_Click(object sender, EventArgs e)
        {
            Filepath obj1 = new Filepath(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Hadiths\ManLaYadharulFaqih4of4.pdf");

        }

        private void eng_rd_btn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Filepath obj1 = new Filepath(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Hadiths\Asool-e-Kafi Vol 1.pdf");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Filepath obj1 = new Filepath(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Hadiths\Asool-e-Kafi Vol 2.pdf");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Filepath obj1 = new Filepath(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Hadiths\Assol-e-Kafi Vol 3.pdf");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Filepath obj1 = new Filepath(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Hadiths\Assol-e-Kafi Vol 4.pdf");
        }
    }

    public class Data_con
    {
        public OleDbConnection Con;
        public string[] s = new string[500];
        public string user;
        public Data_con(string connectionString)
        {
            this.Con = new OleDbConnection(connectionString);


        }

        public void RunQuerry(string query)
        {
            OleDbCommand Command = new OleDbCommand(query, Con);
            Con.Open();

            OleDbDataReader reader = Command.ExecuteReader();


            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    s[i] = reader[i].ToString();
                    if (s[i].Contains(user) == true)
                    {
                        MessageBox.Show(s[i]);
                    }
                }
                Console.WriteLine();
            }



            reader.Close();
            Command.Dispose();
            Con.Close();



        }

    }
}
