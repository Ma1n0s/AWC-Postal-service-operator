using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Word = Microsoft.Office.Interop.Word;

namespace Kyrsov
{
    public partial class MainForm : Form
    {
        public string connectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperator';Integrated Security=True";
        public int selected = -1;
        string FIO = "";
        string Address = "";
        string tip = "";
        string Weight = "";


        public MainForm()
        {
            InitializeComponent();
            setTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void setTableWithParams(int id = 0, string FIO = "", string address = "", string tip = "", string Weight = "")
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();


            string sqlExpression = "SELECT Correspondence.id_Correspondence, Correspondence.id_Employee, Correspondence.id_Insurance, Sender.id_Sender, Sender.FIO, Sender.Address,Correspondence.tip, Correspondence.Weight FROM Correspondence INNER JOIN Sender ON Correspondence.id_Sender= Sender.id_Sender WHERE dbo.Sender.FIO LIKE @FIO AND dbo.Sender.Address LIKE @Address AND dbo.Correspondence.tip LIKE @tip AND dbo.Correspondence.Weight LIKE @Weight";
/*            string sqlExpression = "SELECT rent.id, rent.status, client.fio, client.phone, bike.model, bike.price, rent.date_from, rent.date_to FROM client INNER JOIN(bike INNER JOIN rent ON rent.id_bike = bike.id) ON rent.id_client= client.id WHERE dbo.client.fio LIKE @fio AND dbo.client.phone LIKE @phone";*/
            SqlConnection conn = new SqlConnection(connectionString);

            // WHERE fio LIKE @fio AND model LIKE @model
            /*if (id > 0)
            {
                sqlExpression = "SELECT Correspondence.id_Correspondence, Correspondence.id_Employee, Correspondence.id_Insurance, Sender.id_Sender, Sender.FIO, Sender.Address,Correspondence.tip, Correspondence.Weight FROM Correspondence INNER JOIN Sender ON Correspondence.id_Sender= Sender.id_Sender WHERE dbo.Sender.FIO LIKE @FIO AND dbo.Sender.Address LIKE @Address AND dbo.Correspondence.tip LIKE @tip AND dbo.Correspondence.Weight LIKE @Weight AND dbo.Correspondence.id_Correspondence LIKE @id";
            }*/

            conn.Open();

            SqlCommand command = new SqlCommand(sqlExpression, conn);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@FIO", SqlDbType.VarChar).Value = "%" + FIO + "%";
            command.Parameters.Add("@Address", SqlDbType.VarChar).Value = "%" + address + "%";
            command.Parameters.Add("@tip", SqlDbType.VarChar).Value = "%" + tip + "%";
            command.Parameters.Add("@Weight", SqlDbType.VarChar).Value = "%" + Weight + "%";

            command.CommandText = sqlExpression;

            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[8]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString().Split(' ')[0];
                
            }
            reader.Close();
            conn.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        public void setTable()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();


            string sqlExpression = "";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlCommand command = new SqlCommand(sqlExpression, conn);
            command.CommandText = sqlExpression;

            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[8]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString().Split(' ')[0];
            }
            reader.Close();
            conn.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }

          
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int id = textBox1.Text.Length > 0 ? int.Parse(textBox1.Text) : -1;
            string FIO = textBox2.Text;
            string address = textBox3.Text;
            string tip = textBox4.Text;
            string Weight = textBox5.Text;


            if (FIO.Length > 0 || address.Length > 0 || tip.Length > 0 || Weight.Length > 0 || id > 0)
            {
                setTableWithParams(id, FIO, address, tip, Weight);

            }
            else
            {
                setTable();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (selected > 0)
            {
                string connectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperator';Integrated Security=True";
                string sqlExpression = "Select Correspondence.id_Correspondence, Employee.FIO, Employee.Address, Correspondence.tip, Correspondence.Weight, FROM Correspondence INNER JOIN Employee ON Correspondence.id_Employee = Employee.id_Employee  WHERE Correspondence.id_Correspondence = @id";

                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand myCommand = conn.CreateCommand();
                myCommand.CommandText = sqlExpression;
                myCommand.Parameters.Add("@id", SqlDbType.Int).Value = selected;
                SqlDataReader reader = myCommand.ExecuteReader();

                reader.Read();

                object id = reader.GetValue(0);
                object FIO = reader.GetValue(1);
                object Address = reader.GetValue(2);
                object tip = reader.GetValue(3);
                object Weight = reader.GetValue(4);

                conn.Close();

                var helper = new WordHepler("talon.docx");
                var items = new Dictionary<string, string>
                {
                    { "<id>", id.ToString()},
                    { "<fio>", FIO.ToString()},
                    { "<address>", Address.ToString()},
                    { "<tip>", tip.ToString()},
                    { "<Weight>", Weight.ToString()}
                };

                helper.process(items);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void прокатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            otchet newForm = new otchet();
            newForm.Show();
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*newClient newForm = new newClient();
            newForm.Show();*/
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToShortTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToShortTimeString();
        }

        private void велосипедToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_the_program newForm = new About_the_program();
            newForm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Post newForm = new Post();
            newForm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string id = Convert.ToString(selectedRow.Cells[0].Value);
                if (id != "")
                {
                    selected = int.Parse(id);
                }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            avtor newForm = new avtor();
            newForm.Show();
            this.Close();
        }

        private void инструкцияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("MicrosoftEdge.exe", @"D:\rgИнструкция\index.htm");
        }

        private void видеоИнструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("wmplayer.exe", @"D:\rgВидеоИнструкция.mkv");
        }
    }
}
