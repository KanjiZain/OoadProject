using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows;


namespace OOP_Project
{
    public partial class Form12 : Form
    {
        Timer tim = new Timer();
        TimeSpan t = new TimeSpan(0, 0, 0);
        System.Windows.Forms.OpenFileDialog op = new System.Windows.Forms.OpenFileDialog();
        System.Windows.Media.MediaPlayer sp = new System.Windows.Media.MediaPlayer();
        Uri ur = new Uri(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Quran Audio\108.mp3");

        public Form12()
        {
            InitializeComponent();
            sp.Open(ur);
        }

        private void button116_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button115_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 0, 0);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 3, 800);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 4, 0);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 8, 500);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 8, 600);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 11, 500);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 11, 800);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 16, 900);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }
    }
}
