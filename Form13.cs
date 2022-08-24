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
    public partial class Form13 : Form
    {
        Timer tim = new Timer();
        TimeSpan t = new TimeSpan(0, 0, 0);
        System.Windows.Forms.OpenFileDialog op = new System.Windows.Forms.OpenFileDialog();
        System.Windows.Media.MediaPlayer sp = new System.Windows.Media.MediaPlayer();
        Uri ur = new Uri(@"C:\Users\Zain Kanji\Desktop\PAF-KIET\Project\Materials\Quran Audio\112.mp3");

        public Form13()
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
            TimeSpan fnit = new TimeSpan(0, 0, 0, 4, 0);
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
            TimeSpan init = new TimeSpan(0, 0, 0, 7, 300);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 9, 300);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 9, 400);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 12, 300);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            TimeSpan init = new TimeSpan(0, 0, 0, 12, 400);
            TimeSpan fnit = new TimeSpan(0, 0, 0, 17, 000);
            sp.Position = init;
            sp.Play();
            while (sp.Position < fnit)
            {

            }
            sp.Stop();
        }
    }
}
