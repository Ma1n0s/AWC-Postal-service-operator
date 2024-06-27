using Kyrsov.bin;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        string connectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperatorARM';Integrated Security=True";
        public int selected = -1;
        string fio = "";
        string login = "";
        string password = "";
        string role = "";


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fio = textBox1.Text;
            string login = textBox2.Text;
            string password = textBox3.Text;
            string role = listBox1.Text;

            string sqlExpression = "INSERT INTO dbo.Employs (fio, login, password, role) VALUES (@fio, @login, @password, @role)";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;

            myCommand.Parameters.Add("@fio", SqlDbType.VarChar).Value = fio;
            myCommand.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
            myCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            myCommand.Parameters.Add("@role", SqlDbType.VarChar).Value = role;

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
            string sqlCountAdmins = "SELECT COUNT(*) FROM dbo.Employs WHERE role = 'admin'";
            int countAdmins = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand countCommand = new SqlCommand(sqlCountAdmins, conn);
                countAdmins = (int)countCommand.ExecuteScalar();
            }

            if (countAdmins == 1 && role == "admin")
            {
                MessageBox.Show("Вы не можете изменить свою роль, так как вы единственный администратор.");
            }
            else
            {
                string fio = textBox1.Text;
                string login = textBox2.Text;
                string password = textBox3.Text;
                string role = listBox1.Text;

                string sqlExpression = "UPDATE dbo.Employs SET fio = @fio, login = @login, password = @password, role = @role WHERE id = @id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand myCommand = conn.CreateCommand();

                    myCommand.CommandText = sqlExpression;

                    myCommand.Parameters.Add("@fio", SqlDbType.VarChar).Value = fio;
                    myCommand.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    myCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                    myCommand.Parameters.Add("@role", SqlDbType.VarChar).Value = role;
                    myCommand.Parameters.Add("@id", SqlDbType.Int).Value = selected;
                    myCommand.ExecuteNonQuery();
                }
            }
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

            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet1.Employs". При необходимости она может быть перемещена или удалена.
            this.employsTableAdapter.Fill(this.theMailOperatorARMDataSet1.Employs);


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
                    textBox1.Text = fio = Convert.ToString(selectedRow.Cells[1].Value);
                    textBox2.Text = login = Convert.ToString(selectedRow.Cells[2].Value);
                    textBox3.Text = password = Convert.ToString(selectedRow.Cells[3].Value);
                    listBox1.Text = role = Convert.ToString(selectedRow.Cells[4].Value);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet1.Employs". При необходимости она может быть перемещена или удалена.
            this.employsTableAdapter.Fill(this.theMailOperatorARMDataSet1.Employs);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string searchValue = button_search.Text;
            string query = "SELECT * FROM dbo.Employs WHERE id LIKE @searchValue OR fio LIKE @searchValue OR login LIKE @searchValue OR password LIKE @searchValue OR role LIKE @searchValue";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }

        }
    }
}
