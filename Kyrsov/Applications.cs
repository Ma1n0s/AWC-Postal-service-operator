using Microsoft.Office.Interop.Excel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Kyrsov.bin;
using Google.Protobuf.WellKnownTypes;

namespace Kyrsov
{
    public partial class Applications : Form
    {
        public Applications()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperatorARM';Integrated Security=True";

        public int selected = -1;
        string status = "";
        string type_of_departure = "";
        string post_office_address = "";
        string fio_sender = "";
        string phone_sender = "";
        string address_sender = "";
        string fio_recipient = "";
        string phone_recipient = "";
        string address_recipient = "";
        string size = "";
        string parcel_contents = "";
        string price = "";
        string weight = "";
        string random_password = "";
       /* string datetime = "";*/
        private void Applications_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet16.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter9.Fill(this.theMailOperatorARMDataSet16.Applications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet15.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter8.Fill(this.theMailOperatorARMDataSet15.Applications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet14.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter7.Fill(this.theMailOperatorARMDataSet14.Applications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet13.PostMail". При необходимости она может быть перемещена или удалена.
            this.postMailTableAdapter.Fill(this.theMailOperatorARMDataSet13.PostMail);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet11.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter6.Fill(this.theMailOperatorARMDataSet11.Applications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet9.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter5.Fill(this.theMailOperatorARMDataSet9.Applications);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string post_office_address = comboBox1.Text;
            string fio_sender = textBox2.Text;
            string phone_sender = textBox3.Text;
            string address_sender = textBox4.Text;
            string fio_recipient = textBox5.Text;
            string phone_recipient = textBox6.Text;
            string address_recipient = textBox7.Text;
            string size = textBox8.Text;
            string weight = textBox9.Text;
            string parcel_contents = textBox13.Text;
            double price = Convert.ToDouble(textBox10.Text);
            string status = comboBox2.Text;
            string type_of_departure = comboBox3.Text;


            string sqlExpression = "INSERT INTO dbo.Applications (post_office_address,fio_sender,phone_sender,address_sender," +
                "fio_recipient,phone_recipient,address_recipient,size,weight,parcel_contents,price,status,type_of_departure) VALUES (@post_office_address,@fio_sender,@phone_sender," +
                "@address_sender,@fio_recipient,@phone_recipient,@address_recipient,@size,@weight,@parcel_contents,@price,@status,@type_of_departure)";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;

            myCommand.Parameters.Add("@post_office_address", SqlDbType.VarChar).Value = post_office_address;
            myCommand.Parameters.Add("@fio_sender", SqlDbType.VarChar).Value = fio_sender;
            myCommand.Parameters.Add("@phone_sender", SqlDbType.VarChar).Value = phone_sender;
            myCommand.Parameters.Add("@address_sender", SqlDbType.VarChar).Value = address_sender;
            myCommand.Parameters.Add("@fio_recipient", SqlDbType.VarChar).Value = fio_recipient;
            myCommand.Parameters.Add("@phone_recipient", SqlDbType.VarChar).Value = phone_recipient;
            myCommand.Parameters.Add("@address_recipient", SqlDbType.VarChar).Value = address_recipient;
            myCommand.Parameters.Add("@size", SqlDbType.VarChar).Value = size;
            myCommand.Parameters.Add("@weight", SqlDbType.VarChar).Value = weight;
            myCommand.Parameters.Add("@parcel_contents", SqlDbType.VarChar).Value = parcel_contents;
            myCommand.Parameters.Add("@price", SqlDbType.Money).Value = price;
            myCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
            myCommand.Parameters.Add("@type_of_departure", SqlDbType.VarChar).Value = type_of_departure;

            var lastId = myCommand.ExecuteScalar();
            /*setTable();*/
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string sqlExpression = "DELETE FROM Applications WHERE id = @id";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;
            myCommand.Parameters.Add("@id", SqlDbType.Int).Value = selected;

            var lastId = myCommand.ExecuteScalar();
            /*setTable();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string post_office_address = comboBox1.Text;
            string fio_sender = textBox2.Text;
            string phone_sender = textBox3.Text;
            string address_sender = textBox4.Text;
            string fio_recipient = textBox5.Text;
            string phone_recipient = textBox6.Text;
            string address_recipient = textBox7.Text;
            string size = textBox8.Text;
            string weight = textBox9.Text;
            string parcel_contents = textBox13.Text;
            /*float password = float.Parse(textBox8.Text);*/
            double price = Convert.ToDouble(textBox10.Text);
            string status = comboBox2.Text;
            string type_of_departure = comboBox3.Text;

            string sqlExpression = "UPDATE dbo.Applications SET post_office_address = @post_office_address, fio_sender = @fio_sender, " +
            "phone_sender = @phone_sender, address_sender = @address_sender, fio_recipient = @fio_recipient, " +
            "phone_recipient = @phone_recipient, address_recipient = @address_recipient, size = @size, weight = @weight, " +
            "parcel_contents = @parcel_contents, price = @price, status = @status , type_of_departure = @type_of_departure WHERE id = @id";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;

            myCommand.Parameters.Add("@post_office_address", SqlDbType.VarChar).Value = post_office_address;
            myCommand.Parameters.Add("@fio_sender", SqlDbType.VarChar).Value = fio_sender;
            myCommand.Parameters.Add("@phone_sender", SqlDbType.VarChar).Value = phone_sender;
            myCommand.Parameters.Add("@address_sender", SqlDbType.VarChar).Value = address_sender;
            myCommand.Parameters.Add("@fio_recipient", SqlDbType.VarChar).Value = fio_recipient;
            myCommand.Parameters.Add("@phone_recipient", SqlDbType.VarChar).Value = phone_recipient;
            myCommand.Parameters.Add("@address_recipient", SqlDbType.VarChar).Value = address_recipient;
            myCommand.Parameters.Add("@size", SqlDbType.VarChar).Value = size;
            myCommand.Parameters.Add("@weight", SqlDbType.VarChar).Value = weight;
            myCommand.Parameters.Add("@parcel_contents", SqlDbType.VarChar).Value = parcel_contents;
            myCommand.Parameters.Add("@price", SqlDbType.Money).Value = price;
            myCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
            myCommand.Parameters.Add("@type_of_departure", SqlDbType.VarChar).Value = type_of_departure;
            myCommand.Parameters.Add("@id", SqlDbType.Int).Value = selected;
/*            myCommand.Parameters.Add("@id", SqlDbType.Int).Value = id; // Предполагается, что у вас есть переменная id, которая хранит идентификатор записи*/

            myCommand.ExecuteNonQuery();

            conn.Close();
            /*setTable();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Excel.Application application = new Excel.Application();
            /*Workbook wb = application.Workbooks.Open(path1)*/;
            Excel._Worksheet wsh = application.ActiveSheet;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            SqlCommand com = new SqlCommand("SELECT Correspondence.id_Correspondence, Correspondence.tip, Correspondence.Weight, Insurance.Sum, Insurance.Firm, Correspondence.Departure_date, Correspondence.Date_of_receiving FROM Correspondence INNER JOIN Insurance ON Insurance.id_Insurance = Correspondence.id_Insurance WHERE Correspondence.Departure_date BETWEEN @from AND @to", con);

            int row = 0, yaytsa = 3, count = 0;
            SqlDataReader dr1 = com.ExecuteReader();
            while (dr1.Read())
            {
                for (int i = 0; i < dr1.FieldCount; i++)
                {
                    row++;
                    wsh.Cells[yaytsa, row].Borders.Color = System.Drawing.Color.Black.ToArgb();
                    if (i == 1)
                    {
                        wsh.Cells[yaytsa, row] = dr1.GetValue(i).ToString().Trim();
                    }
                    else
                    {
                        wsh.Cells[yaytsa, row] = dr1.GetValue(i).ToString().Trim();
                    }

                    if (row % 8 == 0)
                    {
                        row = 0;
                        yaytsa++;
                        count++;
                    }
                }
            }
            count = count + 2;

            wsh.Columns.AutoFit();
            con.Close();
            application.Visible = true;
        }

        static string GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string id = Convert.ToString(selectedRow.Cells[0].Value);
                if (id != "")
                {
                    selected = int.Parse(id);
                    comboBox1.Text = post_office_address = Convert.ToString(selectedRow.Cells[2].Value);
                    textBox2.Text = fio_sender = Convert.ToString(selectedRow.Cells[3].Value);
                    textBox3.Text = phone_sender = Convert.ToString(selectedRow.Cells[4].Value);
                    textBox4.Text = address_sender = Convert.ToString(selectedRow.Cells[5].Value);
                    textBox5.Text = fio_recipient = Convert.ToString(selectedRow.Cells[6].Value);
                    textBox6.Text = phone_recipient = Convert.ToString(selectedRow.Cells[7].Value);
                    textBox7.Text = address_recipient = Convert.ToString(selectedRow.Cells[8].Value);
                    textBox8.Text = size = Convert.ToString(selectedRow.Cells[9].Value);
                    textBox9.Text = weight = Convert.ToString(selectedRow.Cells[10].Value);
                    textBox13.Text = parcel_contents = Convert.ToString(selectedRow.Cells[11].Value);
                    textBox10.Text = price = Convert.ToString(selectedRow.Cells[12].Value);
                    comboBox2.Text = status = Convert.ToString(selectedRow.Cells[13].Value);
                    comboBox3.Text = type_of_departure = Convert.ToString(selectedRow.Cells[14].Value);

                    /*                dateTimePicker1 = datetime = Convert.ToString(selectedRow.Cells[14].Value);*/
                }
            }
            
        }

        public void setTable()
        {
            dataGridView1.Refresh();

            this.applicationsTableAdapter9.Fill(this.theMailOperatorARMDataSet16.Applications);
            dataGridView1.DataSource = applicationsBindingSource5;



        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            setTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /* string connectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperatorARM';Integrated Security=True";
             string searchQuery = textBox1.Text;

             using (MySqlConnection connection = new MySqlConnection(connectionString))
             {
                 connection.Open();

                 string sqlExpression = "SELECT * FROM dbo.Applications SET post_office_address = @post_office_address, fio_sender = @fio_sender, " +
             "phone_sender = @phone_sender, address_sender = @address_sender, fio_recipient = @fio_recipient, " +
             "phone_recipient = @phone_recipient, address_recipient = @address_recipient, size = @size, weight = @weight, " +
             "parcel_contents = @parcel_contents, price = @price, status = @status  WHERE id = @id LIKE @id";

                 SqlConnection conn = new SqlConnection(connectionString);
                 conn.Open();
                 SqlCommand myCommand = conn.CreateCommand();

                 myCommand.CommandText = sqlExpression;

                 MySqlCommand command = new MySqlCommand(sqlExpression, connection);
                 command.Parameters.AddWithValue("@search", "%" + searchQuery + "%");

                 MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                 myCommand.Parameters.Add("@post_office_address", SqlDbType.VarChar).Value = post_office_address;
                 myCommand.Parameters.Add("@fio_sender", SqlDbType.VarChar).Value = fio_sender;
                 myCommand.Parameters.Add("@phone_sender", SqlDbType.VarChar).Value = phone_sender;
                 myCommand.Parameters.Add("@address_sender", SqlDbType.VarChar).Value = address_sender;
                 myCommand.Parameters.Add("@fio_recipient", SqlDbType.VarChar).Value = fio_recipient;
                 myCommand.Parameters.Add("@phone_recipient", SqlDbType.VarChar).Value = phone_recipient;
                 myCommand.Parameters.Add("@address_recipient", SqlDbType.VarChar).Value = address_recipient;
                 myCommand.Parameters.Add("@size", SqlDbType.VarChar).Value = size;
                 myCommand.Parameters.Add("@weight", SqlDbType.VarChar).Value = weight;
                 myCommand.Parameters.Add("@parcel_contents", SqlDbType.VarChar).Value = parcel_contents;
                 myCommand.Parameters.Add("@price", SqlDbType.Money).Value = price;
                 myCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
                 myCommand.Parameters.Add("@id", SqlDbType.Int).Value = selected;
                 *//*            myCommand.Parameters.Add("@id", SqlDbType.Int).Value = id; // Предполагается, что у вас есть переменная id, которая хранит идентификатор записи*//*

                 myCommand.ExecuteNonQuery();

                 conn.Close();*/

            /*BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = columnNameToSearch + " like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = bs;*/
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sqlExpression = "SELECT * FROM dbo.Applications SET post_office_address = @post_office_address, fio_sender = @fio_sender, " +
             "phone_sender = @phone_sender, address_sender = @address_sender, fio_recipient = @fio_recipient, " +
             "phone_recipient = @phone_recipient, address_recipient = @address_recipient, size = @size, weight = @weight, " +
             "parcel_contents = @parcel_contents, price = @price, status = @status  WHERE id = @id LIKE @id";
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;
            myCommand.Parameters.Add("@id", SqlDbType.Int).Value = selected;


            StringBuilder query = new StringBuilder();
            query.AppendLine("SELECT id");
            query.AppendLine("FROM dbo.Applications WHERE 1=1");
            if (textBox1.TextLength > 0)
            {
                query.AppendLine("AND id = @id");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Method P = new Method();
            var password = GeneratePassword();
            textBox11.Text = password;
        }
    }

        /*private void Form1_Load(object sender, EventArgs e)
        {
            // Заполняем ComboBox значениями для фильтрации
            comboBox1.Items.Add("Значение 1");
            comboBox1.Items.Add("Значение 2");
            comboBox1.Items.Add("Значение 3");

            // Загружаем данные из базы данных в DataGridView
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = "Server=localhost;Database=mydatabase;Uid=username;Pwd=password;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();

                string query = "SELECT * FROM mytable";
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            DataView dv = new DataView((DataTable)dataGridView1.DataSource);
            dv.RowFilter = "ColumnToFilter = '" + selectedValue + "'";
            dataGridView1.DataSource = dv.ToTable();
        }*/
    }
