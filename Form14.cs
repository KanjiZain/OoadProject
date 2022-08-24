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
    public partial class Form14 : Form
    {
        Timer tim = new Timer();
        TimeSpan t = new TimeSpan(0, 0, 0);
        System.Windows.Forms.OpenFileDialog op = new System.Windows.Forms.OpenFileDialog();
        System.Windows.Media.MediaPlayer sp = new System.Windows.Media.MediaPlayer();
        Uri ur = new Uri(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Quran Audio\113.mp3");

        public Form14()
        {
            InitializeComponent();
            sp.Open(ur);
        }

        private void button115_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 0, 0);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 3,700);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 4, 200);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 7, 200);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 7, 200);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 9, 950);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 9, 980);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 11, 900);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }


        private void pictureBox10_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 12, 0);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 14, 600);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

      
       

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 14, 800);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 19, 700);
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
            TimeSpan fnit = new TimeSpan(0, 0, 0, 25, 00);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void button116_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
