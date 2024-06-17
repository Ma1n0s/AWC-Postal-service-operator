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

namespace Kyrsov
{
    public partial class Archive : Form
    {
        public Archive()
        {
            InitializeComponent();
        }
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
        string length = "";
        string width = "";
        string height = "";
        string parcel_contents = "";
        string price = "";
        string weight = "";
        string random_password = "";
        string payment = "";
        string region = "";
        string apartment = "";
        string apartment_nubmer = "";
        string street = "";
        string city = "";
        string dispatch_time = "";


        /*string datetime = "";*/

        string connectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperatorARM';Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string post_office_address = comboBox5.Text;
                string fio_sender = textBox2.Text;
                string phone_sender = maskedTextBox2.Text;
                string address_sender = textBox4.Text;
                string fio_recipient = textBox5.Text;
                string phone_recipient = maskedTextBox1.Text;
                string address_recipient = textBox7.Text;
                double length = State.length;
                double width = State.width;
                double height = State.height;
                string weight = textBox9.Text;
                string parcel_contents = textBox13.Text;
                double price = Convert.ToDouble(textBox10.Text);
                string status = comboBox2.Text;
                string type_of_departure = comboBox3.Text;
                string payment = comboBox4.Text;
                string region = AddressPost.region;
                string apartment = AddressPost.apartment;
                string apartment_nubmer = AddressPost.apartment_nubmer;
                string street = AddressPost.street;
                string city = AddressPost.city;
                string dispatch_time = dateTimePicker1.Text;
                string combustion_time = dateTimePicker2.Text;


                string sqlExpression = "INSERT INTO dbo.Applications (post_office_address,fio_sender,phone_sender,address_sender," +
                    "fio_recipient,phone_recipient,address_recipient,length,width,height,weight,parcel_contents,price,status,random_password,type_of_departure,payment,region,apartment," +
                    "apartment_nubmer,street,city,dispatch_time,combustion_time) VALUES (@post_office_address,@fio_sender,@phone_sender," +
                    "@address_sender,@fio_recipient,@phone_recipient,@address_recipient,@length,@width,@height,@weight,@parcel_contents,@price," +
                    "@status,@random_password,@type_of_departure,@payment,@region,@apartment,@apartment_nubmer,@street,@city,@dispatch_time,@combustion_time)";

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
                myCommand.Parameters.Add("@length", SqlDbType.VarChar).Value = length;
                myCommand.Parameters.Add("@height", SqlDbType.VarChar).Value = height;
                myCommand.Parameters.Add("@weight", SqlDbType.VarChar).Value = weight;
                myCommand.Parameters.Add("@width", SqlDbType.VarChar).Value = width;
                myCommand.Parameters.Add("@parcel_contents", SqlDbType.VarChar).Value = parcel_contents;
                myCommand.Parameters.Add("@price", SqlDbType.Money).Value = price;
                myCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
                myCommand.Parameters.Add("@type_of_departure", SqlDbType.VarChar).Value = type_of_departure;
                myCommand.Parameters.Add("@random_password", SqlDbType.VarChar).Value = GeneratePassword();
                myCommand.Parameters.Add("@payment", SqlDbType.VarChar).Value = payment;
                myCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = region;
                myCommand.Parameters.Add("@apartment", SqlDbType.VarChar).Value = apartment;
                myCommand.Parameters.Add("@apartment_nubmer", SqlDbType.VarChar).Value = apartment_nubmer;
                myCommand.Parameters.Add("@street", SqlDbType.VarChar).Value = street;
                myCommand.Parameters.Add("@city", SqlDbType.VarChar).Value = city;
                myCommand.Parameters.Add("@dispatch_time", SqlDbType.Date).Value = Convert.ToString(dispatch_time);
                myCommand.Parameters.Add("@combustion_time", SqlDbType.Date).Value = Convert.ToString(combustion_time);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string sqlExpression2 = "DELETE FROM Archive WHERE id = @id";
            SqlConnection conn2 = new SqlConnection(connectionString);
            conn2.Open();
            SqlCommand myCommand2 = conn2.CreateCommand();

            myCommand2.CommandText = sqlExpression2;
            myCommand2.Parameters.Add("@id", SqlDbType.Int).Value = selected;

            var lastId2 = myCommand2.ExecuteScalar();
        }

        private void Archive_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet2.Archive". При необходимости она может быть перемещена или удалена.
            this.archiveTableAdapter.Fill(this.theMailOperatorARMDataSet2.Archive);

            comboBox3.Items.Add("Заказное письмо (+20 рублей)");
            comboBox3.Items.Add("Заказное письмо 1 класса(+70 рублей)");
            comboBox3.Items.Add("Ценное письмо (+50 рублей)");
            comboBox3.Items.Add("Ценное письмо 1 класса (+100 рублей)");
            comboBox3.Items.Add("Экспресс - письмо EMS(+200 рублей)");
            comboBox3.Items.Add("Бандероль (+120 рублей)");
            comboBox3.Items.Add("Заказная бандероль(+250 рублей)");
            comboBox3.Items.Add("Заказная бандероль 1 класса(+300 рублей)");
            comboBox3.Items.Add("Ценная бандероль (+310 рублей)");
            comboBox3.Items.Add("Ценная бандероль 1 класса(+350 рублей)");
            comboBox3.Items.Add("Заказной мелкий пакет (+30 рублей)");
            comboBox3.Items.Add("Посылка (+50 рублей)");
            comboBox3.Items.Add("Посылка 1 класс (+150 рублей)");
            comboBox3.Items.Add("Ценная посылка (+150 рублей)");
            comboBox3.Items.Add("Экспресс - посылка EMS (+450 рублей)");
            comboBox3.Items.Add("Посылка Стандарт (+160 рублей)");
            comboBox3.SelectedIndex = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlExpression2 = "DELETE FROM Archive WHERE id = @id";

            SqlConnection conn2 = new SqlConnection(connectionString);
            conn2.Open();
            SqlCommand myCommand2 = conn2.CreateCommand();

            myCommand2.CommandText = sqlExpression2;
            myCommand2.Parameters.Add("@id", SqlDbType.Int).Value = selected;

            var lastId = myCommand2.ExecuteScalar();
            /*setTable();*/
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        static string GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel2.BackColor = Color.FromArgb(51, 51, 76);
            panel3.BackColor = Color.FromArgb(39, 39, 58);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddressData AddressData = new AddressData();
            AddressData.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void PriceMail()
        {
            double result = 0;
            int[] points = { 20, 70, 50, 100,
                            200, 120, 250, 300,
                            310, 350, 30, 50,
                            150, 150, 450, 160 };

            result += points[comboBox3.SelectedIndex];

            result = (State.length + State.width + State.height) + points[comboBox3.SelectedIndex];

            textBox10.Text = result.ToString();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            string query = "SELECT * FROM dbo.Applications WHERE id LIKE @searchValue OR post_office_address LIKE @searchValue OR fio_sender like @searchValue OR phone_sender LIKE @searchValue OR address_sender LIKE @searchValue OR fio_recipient LIKE @searchValue OR phone_recipient LIKE @searchValue OR address_recipient LIKE @searchValue OR length LIKE @searchValue OR width LIKE @searchValue OR height LIKE @searchValue OR weight LIKE @searchValue OR parcel_contents LIKE @searchValue OR price LIKE @searchValue OR status LIKE @searchValue OR random_password LIKE @searchValue OR type_of_departure LIKE @searchValue OR payment LIKE @searchValue OR region LIKE @searchValue  OR apartment LIKE @searchValue OR apartment_nubmer LIKE @searchValue OR street LIKE @searchValue OR city LIKE @searchValue OR dispatch_time LIKE @searchValue OR combustion_time LIKE @searchValue";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dimensions dimensions = new dimensions();
            dimensions.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dimensions dimensions = new dimensions();
            dimensions.Show();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string id = Convert.ToString(selectedRow.Cells[0].Value);
                if (id != "")
                {
                    selected = int.Parse(id);
                    comboBox5.Text = post_office_address = Convert.ToString(selectedRow.Cells[1].Value);
                    textBox2.Text = fio_sender = Convert.ToString(selectedRow.Cells[2].Value);
                    maskedTextBox2.Text = phone_sender = Convert.ToString(selectedRow.Cells[3].Value);
                    textBox4.Text = address_sender = Convert.ToString(selectedRow.Cells[4].Value);
                    textBox5.Text = fio_recipient = Convert.ToString(selectedRow.Cells[5].Value);
                    maskedTextBox1.Text = phone_recipient = Convert.ToString(selectedRow.Cells[6].Value);
                    textBox7.Text = address_recipient = Convert.ToString(selectedRow.Cells[7].Value);
                    height = Convert.ToString(selectedRow.Cells[8].Value);
                    length = Convert.ToString(selectedRow.Cells[9].Value);
                    width = Convert.ToString(selectedRow.Cells[10].Value);
                    textBox9.Text = weight = Convert.ToString(selectedRow.Cells[11].Value);
                    textBox13.Text = parcel_contents = Convert.ToString(selectedRow.Cells[12].Value);
                    textBox10.Text = price = Convert.ToString(selectedRow.Cells[13].Value);
                    comboBox2.Text = status = Convert.ToString(selectedRow.Cells[14].Value);
                    random_password = Convert.ToString(selectedRow.Cells[15].Value);
                    comboBox3.Text = type_of_departure = Convert.ToString(selectedRow.Cells[16].Value);
                    comboBox4.Text = payment = Convert.ToString(selectedRow.Cells[17].Value);
                    AddressPost.region = Convert.ToString(selectedRow.Cells[19].Value);
                    AddressPost.apartment = Convert.ToString(selectedRow.Cells[20].Value);
                    AddressPost.apartment_nubmer = Convert.ToString(selectedRow.Cells[21].Value);
                    AddressPost.street = Convert.ToString(selectedRow.Cells[22].Value);
                    AddressPost.city = Convert.ToString(selectedRow.Cells[23].Value);
                    /*dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells[24].Value);*/
                    /* dateTimePicker2.Value = Convert.ToDateTime(selectedRow.Cells[25].Value);*/
                    /*                dateTimePicker1 = datetime = Convert.ToString(selectedRow.Cells[14].Value);*/

                }
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddressData AddressData = new AddressData();
            AddressData.Show();
        }

        private void Archive_Activated(object sender, EventArgs e)
        {
            State.length.ToString();
            State.width.ToString();
            State.height.ToString();

            comboBox5.Text = AddressPost.post_office_address + " " + AddressPost.region + " " + AddressPost.apartment + " " + AddressPost.apartment_nubmer +
                " " + AddressPost.street + " " + AddressPost.city;

            label22.Text = "Размер:" + State.length + "x" + State.width + "x" + State.height;

            PriceMail();
        }
    }
}
