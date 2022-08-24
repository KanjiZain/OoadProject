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

    public partial class Form10 : Form
    {
        Timer tim = new Timer();
        TimeSpan t = new TimeSpan(0, 0, 0);
        System.Windows.Forms.OpenFileDialog op = new System.Windows.Forms.OpenFileDialog();
        System.Windows.Media.MediaPlayer sp = new System.Windows.Media.MediaPlayer();
        Uri ur = new Uri(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Quran Audio\1.mp3");


        public Form10()
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
            TimeSpan init = new TimeSpan(0, 0, 0, 3, 0);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 6, 300);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 6, 800);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 10, 900);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 11, 0);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 13, 500);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 14, 100);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 17, 350);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 22, 400);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 22, 700);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 22, 800);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 26, 700);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 26, 800);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 29, 500);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 29, 500);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 33, 200);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 33, 300);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 38, 000);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 17, 600);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 22, 200);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }
    }
}
