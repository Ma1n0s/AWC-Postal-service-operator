using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kyrsov
{
    public partial class newClient : Form
    {
        public newClient()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=DESKTOP-QNM626B\SQLEXPRESS;Initial Catalog='IS42P';Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            string FIO = textBox1.Text;
            string Telephone = textBox2.Text;
            string Address = textBox3.Text;

            
            string sqlExpression = "INSERT INTO dbo.Sender (FIO, Telephone, Address) VALUES (@FIO, @Telephone, @Address)";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;

            myCommand.Parameters.Add("FIO", SqlDbType.VarChar).Value = FIO;
            myCommand.Parameters.Add("@Telephone", SqlDbType.VarChar).Value = Telephone;
            myCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address;

            var lastId = myCommand.ExecuteScalar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}
