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
using MySql.Data.MySqlClient;


namespace Kyrsov
{
    public partial class avtor : Form
    {
        DataTable database = new DataTable();

        private string commandText = "SELECT * From Employs Where login = @login AND password = @password";
        private string commandText2 = "SELECT * From PostMail Where login = @login AND password = @password";
        private string connectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperatorARM';Integrated Security=True";
        /*private string connectionString = @"Data Source=219_05\SQLEXPRESS;Initial Catalog=IS42P;Integrated Security=True";*/
        public avtor()
        {
            InitializeComponent();
            label2.Visible = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = this.textBox1.Text;
            string password = this.textBox2.Text;
            /*int userRole = GetUserRole(login, password, role);*/
            /*switch (userRole)
            {
                case 1: 
                    FormMain frm1 = new FormMain();
                    this.Hide();
                    frm1.ShowDialog();
                    this.Show();
                    break;

                case 2: 
                    test frm2 = new test();
                    this.Hide();
                    frm2.ShowDialog();
                    this.Show();
                    break;

                default:
                    label2.Visible = true;
                    label2.Text = "Вы ввели неправильный логин или пароль";
                    break;
            }*/

            if (checkBox1.Checked)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand myCommand = conn.CreateCommand();
                myCommand.CommandText = commandText2;
                myCommand.Parameters.Add("@login", SqlDbType.VarChar, 50);
                myCommand.Parameters["@login"].Value = login;
                myCommand.Parameters.Add("@password", SqlDbType.VarChar, 50);
                myCommand.Parameters["@password"].Value = password;

                using (SqlDataReader reader = myCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string fio = reader["fio"].ToString();
                            string address = reader["address"].ToString();

                            MessageBox.Show("Добро пожаловать:" + fio);

                        }
                        FormMain frm = new FormMain();
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        label2.Visible = true;
                        label2.Text = "Вы неправильно ввели логин/пароль";
                    }
                }
                conn.Close();
            }
            else
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand myCommand = conn.CreateCommand();
                myCommand.CommandText = commandText;
                myCommand.Parameters.Add("@login", SqlDbType.VarChar, 50);
                myCommand.Parameters["@login"].Value = login;
                myCommand.Parameters.Add("@password", SqlDbType.VarChar, 50);
                myCommand.Parameters["@password"].Value = password;

                using (SqlDataReader reader = myCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string fio = reader["fio"].ToString();

                            MessageBox.Show(fio);

                        }
                    }
                    else
                    {
                        // Обработка случая, когда данных о пользователе не найдены
                    }
                    if (true)
                    {
                        test frm = new test();
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();

                    }
                    else
                    {
                        label2.Visible = true;
                        label2.Text = "Вы неправильно ввели логин/пароль";
                    }
                }
            }
            this.Close();
        }


        private void avtor_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(10, 18, 80);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        /*private int GetUserRole(string login, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(commandText, conn);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        return Convert.ToInt32(reader["UserRole"]);
                    }
                }
            }

            return 0;
        }*/
    }
}
