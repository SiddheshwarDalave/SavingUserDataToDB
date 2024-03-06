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

namespace Siddataabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=Hindavi-Veera\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True;Encrypt=False";

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open();

            string fName = textBox1.Text;
            string lName= textBox2.Text;

            string Query = "INSERT INTO Users (FirstName, LastName) " +
                "VALUES ('" + fName + "' ,'" + lName + "');";

            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("User details saved to Database");



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
