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
    public partial class mail : Form
    {
        public mail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tip = textBox1.Text;
            string Destinaon = textBox2.Text;
            var Departure_date = dateTimePicker1;
            var Date_of_receiving = dateTimePicker2;
            string sum = textBox3.Text;
            string Weight = textBox4.Text;
            string Firm = textBox5.Text;


            string connectionString = @"Data Source=DESKTOP-QNM626B\SQLEXPRESS;Initial Catalog='IS42P';Integrated Security=True";
            /* string connectionString = @"Data Source=219_05\SQLEXPRESS;Initial Catalog=IS42P;Integrated Security=True";*/
            string sqlExpression = "INSERT INTO dbo.Correspondence (tip, Destinaon, Departure_date, Date_of_receiving, Weight, sum, Firm) VALUES (@tip, @Destinaon, @Departure_date, @Date_of_receiving, @Weight, @sum, @Firm)";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;

            myCommand.Parameters.Add("@tip", SqlDbType.VarChar).Value = tip;
            myCommand.Parameters.Add("@Destinaon", SqlDbType.VarChar).Value = Destinaon;
            myCommand.Parameters.Add("@Departure_date", SqlDbType.DateTime).Value = Departure_date.Value;
            myCommand.Parameters.Add("@Date_of_receiving", SqlDbType.DateTime).Value = Date_of_receiving.Value;
            myCommand.Parameters.Add("@sum", SqlDbType.VarChar).Value = sum;
            myCommand.Parameters.Add("@Weight", SqlDbType.VarChar).Value = Weight;
            myCommand.Parameters.Add("@Firm", SqlDbType.VarChar).Value = Firm;

            var lastId = myCommand.ExecuteScalar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;

            int id_Correspondence = int.Parse(this.textBox6.Text);
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-QNM626B\SQLEXPRESS;Initial Catalog='IS42P';Integrated Security=True";
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "DELETE FROM Correspondence WHERE [id_Correspondence] = @id_Correspondence";
            myCommand.Parameters.Add("@id_Correspondence", SqlDbType.Int, 4);
            myCommand.Parameters["@id_Correspondence"].Value = id_Correspondence;
            int UspeshnoeIzmenenie = myCommand.ExecuteNonQuery();
        }
    }
}
