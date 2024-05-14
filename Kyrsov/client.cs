using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kyrsov
{
    public partial class client : Form
    {
        public string connectionString = @"Data Source=DESKTOP-QNM626B\SQLEXPRESS;Initial Catalog='IS42P';Integrated Security=True";
        Form form;
        public int selected;
        public client()
        {
            InitializeComponent();
            setTable(0);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            /*if (this.form.GetType() == typeof(Form5))
            {
                Form5 form = this.form as Form5;
                form.selectedClient = selected;
                this.Close();
            }*/

            string FIO = textBox3.Text;
            string address = textBox2.Text;
            int id = textBox1.Text.Length > 0 ? int.Parse(textBox1.Text) : -1;

            if (FIO.Length > 0 || address.Length > 0 || id > 0)
            {
                setTableWithParams(id, FIO, address);
            }
            else
            {
                setTable(-1);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            /*setTable(-1);

            if (this.form.GetType() == typeof(Form5))
            {
                button1.Visible = true;
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newClient newForm = new newClient();
            this.Hide();
            newForm.Show();
        }

        public void setTable(int id)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();


            string sqlExpression = "SELECT * FROM dbo.Sender";
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
                data.Add(new string[4]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }
            reader.Close();
            conn.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void setTableWithParams(int id = 0, string FIO = "", string address = "")
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string sqlExpression = "SELECT * FROM dbo.Sender WHERE dbo.Sender.FIO LIKE @FIO AND dbo.Sender.Address LIKE @Address";
            if (id > 0)
            {
                sqlExpression = "SELECT * FROM dbo.Sender WHERE dbo.Sender.FIO LIKE @FIO AND dbo.Sender.Address LIKE @Address AND dbo.Sender.id_Sender LIKE @id";
            }
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand command = new SqlCommand(sqlExpression, conn);

            command.Parameters.Add("@FIO", SqlDbType.VarChar).Value = "%" + FIO + "%";
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = "%" + address + "%";
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            command.CommandText = sqlExpression;

            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }
            reader.Close();
            conn.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FIO = textBox3.Text;
            string address = textBox2.Text;
            int id = textBox1.Text.Length > 0 ? int.Parse(textBox1.Text) : -1;

            if (FIO.Length > 0 || address.Length > 0 || id > 0)
            {
                setTableWithParams(id, FIO, address);
            }
            else
            {
                setTable(-1);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToShortTimeString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sqlExpression = "SELECT * FROM dbo.Sender";
            SqlConnection conn = new SqlConnection(connectionString);
            int id_Sender = int.Parse(this.textBox4.Text);
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-QNM626B\SQLEXPRESS;Initial Catalog='IS42P';Integrated Security=True";
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "DELETE FROM Sender WHERE [id_Sender] = @id_Sender";
            myCommand.Parameters.Add("@id_Sender", SqlDbType.Int, 4);
            myCommand.Parameters["@id_Sender"].Value = id_Sender;
            int UspeshnoeIzmenenie = myCommand.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_the_program newForm = new About_the_program();
            newForm.Show();
        }
    }
}
