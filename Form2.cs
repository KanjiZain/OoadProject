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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            this.button7.BackColor = Color.Transparent;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Location = new Point(480, 193);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Location = new Point(480, 199);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.Location = new Point(643, 193);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Location = new Point(643, 199);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Location = new Point(563, 245);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Location = new Point(563, 250);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
        }
    }
}
