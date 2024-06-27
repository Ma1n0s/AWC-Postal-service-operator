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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            PasswordMain();
        }
        public void PasswordMain()
        {
            string searchValue = textBox1.Text;
            string query = "SELECT * FROM dbo.Applications WHERE random_password = @searchValue";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchValue", searchValue);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }

            /*this.Close();*/
        }
        string connectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperatorARM';Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                string status = "Клиент забрал";
                string random_password = textBox1.Text;

                string sqlExpression = "UPDATE dbo.Applications SET status = @status WHERE random_password = @random_password";


                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand myCommand = conn.CreateCommand();

                myCommand.CommandText = sqlExpression;
                string queryRandomPassword = "SELECT TOP 1 random_password FROM dbo.Applications WHERE random_password = @random_password";
                SqlCommand cmdRandomPassword = new SqlCommand(queryRandomPassword, conn);
                cmdRandomPassword.Parameters.AddWithValue("@random_password", random_password);
                var afg = cmdRandomPassword.ExecuteNonQuery();
                if (afg != null)
                {
                    /* random_password = afg.ToString();*/

                    myCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
                    myCommand.Parameters.Add("@random_password", SqlDbType.VarChar).Value = random_password;
                    /*myCommand.Parameters.Add("@id", SqlDbType.Int).Value = selected;*/
                    /*            myCommand.Parameters.Add("@id", SqlDbType.Int).Value = id; */

                    myCommand.ExecuteNonQuery();

                    conn.Close();

                    if (String.IsNullOrEmpty(random_password))
                    {
                        MessageBox.Show("Пароль не найден в базе данных");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Выбирите посылку");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вы не дописали данные");
            }
        }

        private void test_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet22.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter.Fill(this.theMailOperatorARMDataSet22.Applications);
            PasswordMain();
        }
    }
}
