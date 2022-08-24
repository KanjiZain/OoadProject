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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.Location = new Point(19,205);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Location = new Point(19, 210);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Location = new Point(172, 206);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Location = new Point(172, 210);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Location = new Point(322, 206);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Location = new Point(322, 210);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.Location = new Point(470, 206);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Location = new Point(470, 210);
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.Location = new Point(632, 206);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Location = new Point(632, 210);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
