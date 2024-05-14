using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kyrsov
{
    public partial class newEmployee : Form
    {
        public newEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FIO = textBox1.Text;
            string Telephone = textBox2.Text;
            string Address = textBox3.Text;

            string connectionString = @"Data Source=DESKTOP-QNM626B\SQLEXPRESS;Initial Catalog='IS42P';Integrated Security=True";
            string sqlExpression = "INSERT INTO dbo.Employee (FIO, Telephone, Address) VALUES (@FIO, @Telephone, @Address)";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;

            myCommand.Parameters.Add("FIO", SqlDbType.VarChar).Value = FIO;
            myCommand.Parameters.Add("@Telephone", SqlDbType.VarChar).Value = Telephone;
            myCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address;

            var lastId = myCommand.ExecuteScalar();
        }
    }
}
