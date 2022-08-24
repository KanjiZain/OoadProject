using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Form15 : Form
    {
        Timer tim = new Timer();
        TimeSpan t = new TimeSpan(0, 0, 0);
        System.Windows.Forms.OpenFileDialog op = new System.Windows.Forms.OpenFileDialog();
        System.Windows.Media.MediaPlayer sp = new System.Windows.Media.MediaPlayer();
        Uri ur = new Uri(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Quran Audio\114.mp3");

        public Form15()
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
            TimeSpan fnit = new TimeSpan(0, 0, 0, 3, 900);
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
            TimeSpan fnit = new TimeSpan(0, 0, 0, 7, 500);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 7, 600);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 9, 700);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 9, 900);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 10, 300);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 10, 500);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 12 ,750);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 13, 100);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 19, 350);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 19, 800);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 20, 300);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 20, 500);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 24, 350);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 24, 700);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 30, 00);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }
    }
}
