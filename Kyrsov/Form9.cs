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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tip = textBox1.Text;
            string pynct = textBox2.Text;
            var data = textBox3.Text;
            var data1 = textBox4.Text;

            string connectionString = @"DESKTOP-QNM626B\SQLEXPRESS;Initial Catalog=IS42P;Integrated Security=True";
            /* string connectionString = @"Data Source=219_05\SQLEXPRESS;Initial Catalog=IS42P;Integrated Security=True";*/
            string sqlExpression = "INSERT INTO dbo.Корреспонденция (Тип, Пункт_назначения, Дата_отправления, Дата_получения) VALUES (@Тип, @Пункт_назначения, @Дата_отправления, @Дата_получения)";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;

            myCommand.Parameters.Add("@Тип", SqlDbType.VarChar).Value = tip;
            myCommand.Parameters.Add("@Пункт_назначения", SqlDbType.VarChar).Value = pynct;
            myCommand.Parameters.Add("@Дата_отправления", SqlDbType.DateTime).Value = data;
            myCommand.Parameters.Add("@Дата_получения", SqlDbType.DateTime).Value = data1;

            var lastId = myCommand.ExecuteScalar();
        }
    }
}
