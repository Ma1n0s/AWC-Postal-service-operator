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
    public partial class Applications : Form
    {
        public Applications()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperatorARM';Integrated Security=True";
        private void Applications_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet3.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter.Fill(this.theMailOperatorARMDataSet3.Applications);
            //TEST PROGRAMM
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float post_office_address = float.Parse(textBox1.Text);
            float fio_sender = float.Parse(textBox2.Text);
            float phone_sender = float.Parse(textBox3.Text);
            float address_sender = float.Parse(textBox4.Text);
            float fio_recipient = float.Parse(textBox5.Text);
            float phone_recipient = float.Parse(textBox2.Text);
            float address_recipient = float.Parse(textBox2.Text);
            float password = float.Parse(textBox2.Text);
            float price = float.Parse(textBox2.Text);
            float status = float.Parse(textBox2.Text);

            string sqlExpression = "INSERT INTO dbo.Employs (fio, login, password) VALUES (@fio, @login, @password)";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;

            myCommand.Parameters.Add("@post_office_address", SqlDbType.Money).Value = post_office_address;
            myCommand.Parameters.Add("@fio_sender", SqlDbType.Money).Value = fio_sender;
            myCommand.Parameters.Add("@phone_sender", SqlDbType.Money).Value = phone_sender;
            myCommand.Parameters.Add("@address_sender", SqlDbType.Money).Value = address_sender;
            myCommand.Parameters.Add("@fio_recipient", SqlDbType.Money).Value = fio_recipient;
            myCommand.Parameters.Add("@phone_recipient", SqlDbType.Money).Value = phone_recipient;
            myCommand.Parameters.Add("@address_recipient", SqlDbType.Money).Value = address_recipient;
            myCommand.Parameters.Add("@password", SqlDbType.Money).Value = password;
            myCommand.Parameters.Add("@price", SqlDbType.Money).Value = price;
            myCommand.Parameters.Add("@status", SqlDbType.Money).Value = status;

            var lastId = myCommand.ExecuteScalar();
        }
    }
}
