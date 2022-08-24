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
    public partial class Form16: Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
      
        public Form16()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ooad;Integrated Security=True");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        public void button1_Click(object sender, EventArgs e)
        {
           

            string user = textBox1.Text;
            string pass = textBox2.Text;
           
          
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Admin_Login where username='" + user+ "' AND password='" + pass + "'";
            dr = cmd.ExecuteReader();
           
            if (dr.Read())
            {
              

               
               
                Form17 form17 = new Form17();
                this.Hide();
                form17.Show();
                

                
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();

            


        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
