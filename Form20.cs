using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Form20 : Form
    {
       

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form20()
        {
             con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ooad;Integrated Security=True");

            InitializeComponent();
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
       
        public void button1_Click(object sender, EventArgs e)
        {

          con.Open();

          String query = "insert into Add_Book (Name,Author,Added_By,Added_Date) values (' " + this.textBox1.Text + " ',' " + this.textBox3.Text + " ',' " +this.textBox2.Text+ " ',' " + this.dateTimePicker1.Value.Date +" ') ; insert into Book_Info values (' " + this.textBox1.Text + " ' , 'Available' )";
            cmd = new SqlCommand(query, con);

            try
            {
                dr = cmd.ExecuteReader();
                MessageBox.Show("Book has been Added...!!!!");
            }

            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            con.Close();
        }

        private void Form20_Load(object sender, EventArgs e)
        {

        }
    }
}
