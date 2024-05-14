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
    public partial class Employee : Form
    {
        public string connectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperator';Integrated Security=True";
        Form form;
        public int selected;
        public Employee()
        {
            InitializeComponent();
            setTable(0);

            /*if (this.form.GetType() == typeof(Form5))
            {
                button2.Visible = true;
            }*/
        }

        public void setTable(int id)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();


            string sqlExpression = "SELECT * FROM dbo.Employee";
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
        public void setTableWithParams(int id = 0, string FIO = "", string Address = "", string Telephone ="")
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string sqlExpression = "SELECT * FROM dbo.Employee WHERE dbo.Employee.FIO LIKE @FIO AND dbo.Employee.Address LIKE @Address AND dbo.Employee.Telephone LIKE @Telephone";
            if (id > 0)
            {
                sqlExpression = "SELECT * FROM dbo.Employee WHERE dbo.Employee.FIO LIKE @FIO AND dbo.Employee.Address LIKE @Address AND dbo.Employee.Telephone LIKE @Telephone AND dbo.Employee.id_Employee LIKE @id";
            }
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand command = new SqlCommand(sqlExpression, conn);

            command.Parameters.Add("@Telephone", SqlDbType.VarChar).Value = Telephone;
            command.Parameters.Add("@FIO", SqlDbType.VarChar).Value = FIO;
            command.Parameters.Add("@Address", SqlDbType.VarChar).Value =Address;
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

        private void button3_Click(object sender, EventArgs e)
        {
            string FIO = textBox2.Text;
            string Address = textBox3.Text;
            string Telephone = textBox4.Text;
            int id = textBox1.Text.Length > 0 ? int.Parse(textBox1.Text) : -1;

            if (Telephone.Length > 0 || Address.Length > 0|| FIO.Length > 0 || id > 0)
            {
                setTableWithParams(id, FIO, Address,Telephone);
            }
            else
            {
                setTable(-1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if (this.form.GetType() == typeof(Form8))
            {
                Form8 form = this.form as Form8;
                form.selectedModel = selected;
                this.Close();
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newEmployee newForm = new newEmployee();
            this.Hide();
            newForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToShortTimeString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
/*            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            string id = Convert.ToString(selectedRow.Cells[0].Value);
            selected = int.Parse(id);*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iS42PDataSet1.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter1.Fill(this.iS42PDataSet1.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "iS42PDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.iS42PDataSet.Employee);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string sqlExpression = "SELECT * FROM dbo.Employee";
            SqlConnection conn = new SqlConnection(connectionString);
            int id_Employee = int.Parse(this.textBox4.Text);
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperator';Integrated Security=True";
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = "DELETE FROM Sender WHERE [id_Employee] = @id_Employee";
            myCommand.Parameters.Add("@id_Employee", SqlDbType.Int, 5);
            myCommand.Parameters["@id_Employee"].Value = id_Employee;
            int UspeshnoeIzmenenie = myCommand.ExecuteNonQuery();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_the_program newForm = new About_the_program();
            newForm.Show();
        }
    }
}
