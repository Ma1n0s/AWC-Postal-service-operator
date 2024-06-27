using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Kyrsov
{
    public partial class avtor : Form
    {
        private string connectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperatorARM';Integrated Security=True";
        /*private string connectionString = @"Data Source=219_05\SQLEXPRESS;Initial Catalog=IS42P;Integrated Security=True";*/
        public avtor()
        {
            InitializeComponent();
            label2.Visible = false;
            StartPosition = FormStartPosition.CenterScreen;
        }
        private bool flag = false;
        private void button1_Click(object sender, EventArgs e)
        {
            string login = user.UserName = this.textBox1.Text;
            string password = this.textBox2.Text;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "SELECT * FROM Employs WHERE Login = @login AND Password = @password";
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
                        string role = reader["Role"].ToString();

                        if (role == "admin")
                        {
                            string fio = reader["fio"].ToString();
                            MessageBox.Show("Добро пожаловать, админ " + fio);

                                FormMain frm = new FormMain();
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                        }
                        else if (role == "user")
                        {
                            string fio = reader["fio"].ToString();
                            MessageBox.Show("Добро пожаловать, пользователь " + fio);
                           
                                UsersMail frm = new UsersMail();
                                this.Hide();
                                frm.ShowDialog();
                                this.Show();
                        }
                    }
                    
                }
                else
                {
                    label2.Visible = true;
                    label2.Text = "Вы неправильно ввели логин/пароль";
                }
            }
            conn.Close();
            
        }


        private void avtor_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;

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
            if (!flag)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
            flag = !flag;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if(checkBox1.Checked) 
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else 
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
