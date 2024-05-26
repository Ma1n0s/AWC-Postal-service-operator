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
            float id = float.Parse(textBox4.Text);

            string sqlExpression = "DELETE FROM Employs WHERE [id] = @id";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;
            myCommand.Parameters.Add("@id", SqlDbType.Money).Value = id;

            var lastId = myCommand.ExecuteScalar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fio = textBox1.Text;
            string login = textBox2.Text;
            string password = textBox3.Text;

            string sqlExpression = "UPDATE dbo.Employs (fio, login, password) VALUES (@fio, @login, @password)";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;

            myCommand.Parameters.Add("@fio", SqlDbType.VarChar).Value = fio;
            myCommand.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
            myCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            myCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void CreateColumns()
        {
            /*dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("fio", "фио");
            dataGridView1.Columns.Add("phone", "Телефон");
            dataGridView1.Columns.Add("address", "адрес");
            dataGridView1.Columns.Add("IsNew", string.Empty);*/
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet2.Employs". При необходимости она может быть перемещена или удалена.
            this.employsTableAdapter.Fill(this.theMailOperatorARMDataSet2.Employs);
            LoadData();
            CreateColumns();
            RefreshDataGrid(dataGridView1);

        }

        private void LoadData()
        {

            /*MySqlConnection connection = new MySqlConnection(connectionString);
            connectionString.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM data";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();*/
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string fio = "";
            string login = "";
            string password = "";

            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            string id = Convert.ToString(selectedRow.Cells[0].Value);
            if (id != "")
            {
                selected = int.Parse(id);
                textBox1.Text = fio = Convert.ToString(selectedRow.Cells[2].Value);
                textBox2.Text = login = Convert.ToString(selectedRow.Cells[3].Value);
                textBox3.Text = password = Convert.ToString(selectedRow.Cells[4].Value);
                /*              

                            /*selectRow = e.RowIndex;

                            if(e.RowIndex >= 0) 
                            {
                                DataGridViewRow = dataGridView1.Rows[selectedRow];
                                textBox1
                            }*/
            }
        }
    }
}
