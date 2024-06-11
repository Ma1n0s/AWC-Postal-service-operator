using Kyrsov.bin;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kyrsov
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Employee2 : Form
    {
        public Employee2()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase();
        string connectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperatorARM';Integrated Security=True";
        public int selected = -1;
        string fio = "";
        string login = "";
        string password = "";


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fio = textBox1.Text;
            string login = textBox2.Text;
            string password = textBox3.Text;

            string sqlExpression = "INSERT INTO dbo.Employs (fio, login, password) VALUES (@fio, @login, @password)";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;

            myCommand.Parameters.Add("@fio", SqlDbType.VarChar).Value = fio;
            myCommand.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
            myCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            var lastId = myCommand.ExecuteScalar();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Message;
            Message = "Вы хотите удалить эту запись ?";
            if (MessageBox.Show(Message, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            string sqlExpression = "DELETE FROM Employs WHERE [id] = @id";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;
            myCommand.Parameters.Add("@id", SqlDbType.Int).Value = selected;

            var lastId = myCommand.ExecuteScalar();
            /*setTable();*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fio = textBox1.Text;
            string login = textBox2.Text;
            string password = textBox3.Text;

            string sqlExpression = "UPDATE dbo.Employs fio = @fio,login = @login,password = @password WHERE id = @id";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;

            myCommand.Parameters.Add("@fio", SqlDbType.VarChar).Value = fio;
            myCommand.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
            myCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            myCommand.Parameters.Add("@id", SqlDbType.Int).Value = selected;

            myCommand.ExecuteNonQuery();
            conn.Close();
        }


        private void ReadSingRow(DataRow dgw, IDataAdapter record)
        {
           
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Employee2_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string id = Convert.ToString(selectedRow.Cells[0].Value);
                if (id != "")
                {
                    selected = int.Parse(id);
                    textBox1.Text = fio = Convert.ToString(selectedRow.Cells[2].Value);
                    textBox2.Text = login = Convert.ToString(selectedRow.Cells[3].Value);
                    textBox3.Text = password = Convert.ToString(selectedRow.Cells[4].Value);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(51, 51, 76);
        }
    }
}
