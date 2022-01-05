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

namespace WindowsFormsApp2
{
    public partial class CreateAccount : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\radev1924\source\repos\WindowsFormsApp2\WindowsFormsApp2\LoginData.mdf;Integrated Security=True;Connect Timeout=30";
        SqlCommand sqlCmd;
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("please fill the fields");

            }
            else
            {
                using (SqlConnection sqlconn = new SqlConnection(connectionString))
                {
                    sqlconn.Open();
                    //SqlCommand sqlCmd = new SqlCommand("AddUser", sqlconn);
                    //sqlCmd.CommandType = CommandType.StoredProcedure;
                    //sqlCmd.Parameters.AddWithValue("@Username", textBox1.Text.Trim());
                    //sqlCmd.Parameters.AddWithValue("@Password", textBox2.Text.Trim());

                    sqlCmd =new SqlCommand("insert into [Table] values('"+textBox1.Text+"','"+ textBox2.Text+ "')", sqlconn);

                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("registration is succesfull");
                    Clear();
                }
            }
        }

        void Clear()
        {
            textBox1.Text = string.Empty; 
            textBox2.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
