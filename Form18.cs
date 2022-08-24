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
    public partial class Form18 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
       
        public Form18()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ooad;Integrated Security=True");

            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            con.Open();

            string query= "SELECT B_Name FROM Book_Info";
            cmd = new SqlCommand(query,con);
     
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button116_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button115_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form17 form17 = new Form17();
            form17.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            String query = "insert into Issue_Book values (' " + this.comboBox1.SelectedItem + " ' ,' " + this.textBox1.Text + " ',' " + this.textBox3.Text + " ',' " + this.dateTimePicker1.Value.Date + " ',' " + this.dateTimePicker2.Value.Date + " ');  Update Book_Info set B_Status = 'Not  Available' where B_Name = ' " + this.comboBox1.SelectedValue + " ' ki,  ";
            cmd = new SqlCommand(query, con);


            try
            {

                dr = cmd.ExecuteReader();
                MessageBox.Show("Book has been issued...!!!!");
                while (dr.Read())
                {
                  
                }
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            con.Close();

        }
    }
}
