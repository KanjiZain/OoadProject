using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OOP_Project
{
    public partial class Form17 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;

        public Form17()
        {
            

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ooad;Integrated Security=True");

            InitializeComponent();

        }


        private void button116_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 form16 = new Form16();
            form16.Show();
        }
        
       public void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            Form20 form20 = new Form20();
            form20.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form18 form18 = new Form18();
            form18.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form19 form19 = new Form19();
            form19.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Book_Info where B_Name like ' " + this.textBox1.Text + "%' ";
            sda = new SqlDataAdapter(query, con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT B_Name FROM Book_Info WHERE B_Status = 'Not Available' ";
            sda = new SqlDataAdapter(query, con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
