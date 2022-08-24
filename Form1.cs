using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Location = new Point(368, 245);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Location = new Point(368, 252);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form16 form16 = new Form16();
            form16.Show();
            
        }

        private void button116_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
