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
        /*string sqlExpression = "INSERT INTO dbo.Employee (FIO, Telephone, Address) VALUES (@FIO, @Telephone, @Address)";*/


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float fio = float.Parse(textBox2.Text);
            float login = float.Parse(textBox2.Text);
            float password= float.Parse(textBox2.Text);

            string sqlExpression = "INSERT INTO dbo.Employs (fio, login, password) VALUES (@fio, @login, @password)";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;

            myCommand.Parameters.Add("@fio", SqlDbType.Money).Value = fio;
            myCommand.Parameters.Add("@login", SqlDbType.Money).Value = login;
            myCommand.Parameters.Add("@password", SqlDbType.Money).Value = password;

            var lastId = myCommand.ExecuteScalar();

            this.Close();

            /*string FIO = textBox1.Text;
            string Telephone = textBox2.Text;
            string Address = textBox3.Text;

            string connectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperator';Integrated Security=True";
            string sqlExpression = "INSERT INTO dbo.Employee (FIO, Telephone, Address) VALUES (@FIO, @Telephone, @Address)";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;

            myCommand.Parameters.Add("FIO", SqlDbType.VarChar).Value = FIO;
            myCommand.Parameters.Add("@Telephone", SqlDbType.VarChar).Value = Telephone;
            myCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = Address;

            var lastId = myCommand.ExecuteScalar();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Message;
            Message = "Вы хотите удалить эту запись ?";
            if (MessageBox.Show(Message, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

            float fio = float.Parse(textBox2.Text);
            float login = float.Parse(textBox2.Text);
            float password = float.Parse(textBox2.Text);

            string sqlExpression = "DELETE FROM dbo.Employs (fio, login, password) VALUES (@fio, @login, @password)\"";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand myCommand = conn.CreateCommand())
                {
                    myCommand.CommandText = sqlExpression;

                    myCommand.Parameters.Add("@fio", SqlDbType.Money).Value = fio;
                    myCommand.Parameters.Add("@login", SqlDbType.Money).Value = login;
                    myCommand.Parameters.Add("@password", SqlDbType.Money).Value = password;

                    myCommand.ExecuteNonQuery();


                    /*string sql = "delete from Employee where id_Employee =" + id_Employee;*//*
                    myCommand.CommandText = "DELETE FROM Sender WHERE [id_Employee] = @id_Employee";
                    id = dataGridView1.Rows[0].Cells["id_Employee"].ToString();*/
                }
            }
            dataGridView1.Rows.RemoveAt(selectedRowIndex);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

            string fio = dataGridView1.Rows[selectedRowIndex].Cells["fioColumn"].Value.ToString();
            float phone = float.Parse(dataGridView1.Rows[selectedRowIndex].Cells["phoneColumn"].Value.ToString());
            float address = float.Parse(dataGridView1.Rows[selectedRowIndex].Cells["addressColumn"].Value.ToString());

            string sqlExpression = "Update FROM ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand myCommand = conn.CreateCommand())
                {
                    myCommand.CommandText = sqlExpression;

                    myCommand.Parameters.Add("@fio", SqlDbType.VarChar).Value = fio;
                    myCommand.Parameters.Add("@phone", SqlDbType.Money).Value = phone;
                    myCommand.Parameters.Add("@address", SqlDbType.Money).Value = address;

                    myCommand.ExecuteNonQuery();


                    *//*string sql = "delete from Employee where id_Employee =" + id_Employee;*//*
                    myCommand.CommandText = "DELETE FROM Sender WHERE [id_Employee] = @id_Employee";
                    id = dataGridView1.Rows[0].Cells["id_Employee"].ToString();*//*
                }
            }*/
            float fio = float.Parse(textBox2.Text);
            float login = float.Parse(textBox2.Text);
            float password = float.Parse(textBox2.Text);

            string sqlExpression = "UPDATE dbo.Employs (fio, login, password) VALUES (@fio, @login, @password)";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;

            myCommand.Parameters.Add("@fio", SqlDbType.Money).Value = fio;
            myCommand.Parameters.Add("@login", SqlDbType.Money).Value = login;
            myCommand.Parameters.Add("@password", SqlDbType.Money).Value = password;

            var lastId = myCommand.ExecuteScalar();

            this.Close();

           /* dataGridView1.Rows.RemoveAt(selectedRowIndex);*/
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
            /*dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3));*/
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            /*dgw.Rows.Clear();

            string queryString = $"select * from Employs";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingRow(dgw, reader);
            }
            reader.Close();*/
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
            /*selectRow = e.RowIndex;

            if(e.RowIndex >= 0) 
            {
                DataGridViewRow = dataGridView1.Rows[selectedRow];
                textBox1
            }*/
        }
    }
}
