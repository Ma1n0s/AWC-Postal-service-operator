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
    public partial class Post : Form
    {
        public string connectionString = @"Data Source=DESKTOP-QNM626B\SQLEXPRESS;Initial Catalog='IS42P';Integrated Security=True";
        Form form;
        public int selected;
        public Post()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*string FIO = textBox5.Text;
            string Weight = textBox4.Text;
            string tip = textBox3.Text;
            string FIO = textBox2.Text;
            int id = textBox1.Text.Length > 0 ? int.Parse(textBox1.Text) : -1;

            if (FIO.Length > 0 || address.Length > 0 || id > 0)
            {
                setTableWithParams(id, FIO, address);
            }
            else
            {
                setTable(-1);
            }*/
        }

        public void setTable(int id)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();


            string sqlExpression = "SELECT * FROM dbo.Correspondence";
            SqlConnection conn = new SqlConnection(connectionString);

            if (id >= 0)
            {
                //sqlExpression = "SELECT Priem.id, Pacient.fio, Vrach.fio, Priem.date, Priem.time FROM Pacient INNER JOIN(Vrach INNER JOIN Priem ON Priem.id_v = Vrach.id) ON Priem.id_p= Pacient.id WHERE Priem.id LIKE @id";
            }


            conn.Open();

            SqlCommand command = new SqlCommand(sqlExpression, conn);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            command.CommandText = sqlExpression;

            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[6]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();
            conn.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        public void setTableWithParams(int id = 0, string FIO = "", string tip = "", string Weight = "", string sum = "")
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string sqlExpression = "SELECT Correspondence.id_Correspondence, Correspondence.id_Employee, Correspondence.id_Insurance, Sender.id_Sender, Sender.FIO, Sender.Address,Correspondence.tip, Correspondence.Weight FROM Correspondence INNER JOIN Sender ON Correspondence.id_Sender = Sender.id_Sender";
            if (id > 0)
            {
                sqlExpression = "SELECT Correspondence.id_Correspondence, Correspondence.id_Employee, Correspondence.id_Insurance, Sender.id_Sender, Sender.FIO, Sender.Address,Correspondence.tip, Correspondence.Weight FROM Correspondence INNER JOIN Sender ON Correspondence.id_Sender = Sender.id_Sender WHERE dbo.Sender.FIO LIKE @FIO AND dbo.Sender.Address LIKE @Address AND dbo.Correspondence.tip LIKE @tip AND dbo.Correspondence.Weight LIKE @Weight AND dbo.Correspondence.id_Correspondence LIKE @id";
            }
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand command = new SqlCommand(sqlExpression, conn);

            command.Parameters.Add("@sum", SqlDbType.VarChar).Value = "%" + sum + "%";
            command.Parameters.Add("@Weights", SqlDbType.VarChar).Value = "%" + Weight + "%";
            command.Parameters.Add("@tip", SqlDbType.VarChar).Value = "%" + tip + "%";
            command.Parameters.Add("@FIO", SqlDbType.VarChar).Value = "%" + FIO + "%";
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            command.CommandText = sqlExpression;

            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[6]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();
            conn.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_the_program newForm = new About_the_program();
            newForm.Show();
        }
    }
}
