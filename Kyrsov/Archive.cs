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
        string email_sender = "";
        string email_recipient = "";


        /*string datetime = "";*/

        string connectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperatorARM';Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string post_office_address = AddressPost.post_office_address;
                string fio_sender = textBox2.Text;
                string phone_sender = maskedTextBox2.Text;
                string address_sender = comboBox6.Text;
                string fio_recipient = textBox5.Text;
                string phone_recipient = maskedTextBox1.Text;
                string address_recipient = comboBox7.Text;
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
                string street = AddressPost.street;
                string city = AddressPost.city;
                string dispatch_time = dateTimePicker1.Text;
                string combustion_time = dateTimePicker2.Text;
                string region2 = AddressPost2.region2;
                string street2 = AddressPost2.street2;
                string city2 = AddressPost2.city2;
                string recipient_index = AddressPost2.recipient_index;

                string sqlExpression = "INSERT INTO dbo.Applications (post_office_address,fio_sender,phone_sender,address_sender," +
                     "fio_recipient,phone_recipient,address_recipient,length,width,height,weight,parcel_contents,price,status,random_password,type_of_departure,payment,region," +
                     "street,city,dispatch_time,combustion_time,region2,street2,city2,recipient_index) VALUES (@post_office_address,@fio_sender,@phone_sender," +
                     "@address_sender,@fio_recipient,@phone_recipient,@address_recipient,@length,@width,@height,@weight,@parcel_contents,@price," +
                     "@status,@random_password,@type_of_departure,@payment,@region,@street,@city,@dispatch_time,@combustion_time,@region2,@street2,@city2,@recipient_index)";

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
                myCommand.Parameters.Add("@street", SqlDbType.VarChar).Value = street;
                myCommand.Parameters.Add("@city", SqlDbType.VarChar).Value = city;
                myCommand.Parameters.Add("@dispatch_time", SqlDbType.Date).Value = Convert.ToString(dispatch_time);
                myCommand.Parameters.Add("@combustion_time", SqlDbType.Date).Value = Convert.ToString(combustion_time);
                myCommand.Parameters.Add("@region2", SqlDbType.VarChar).Value = region2;
                myCommand.Parameters.Add("@street2", SqlDbType.VarChar).Value = street2;
                myCommand.Parameters.Add("@city2", SqlDbType.VarChar).Value = city2;
                myCommand.Parameters.Add("@recipient_index", SqlDbType.VarChar).Value = recipient_index;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*string sqlExpression2 = "DELETE FROM Archive WHERE id = @id";
            SqlConnection conn2 = new SqlConnection(connectionString);
            conn2.Open();
            SqlCommand myCommand2 = conn2.CreateCommand();

            myCommand2.CommandText = sqlExpression2;
            myCommand2.Parameters.Add("@id", SqlDbType.Int).Value = selected;

            var lastId2 = myCommand2.ExecuteScalar();*/
        }

        private void Archive_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet18.Archive". При необходимости она может быть перемещена или удалена.
            this.archiveTableAdapter4.Fill(this.theMailOperatorARMDataSet18.Archive);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet17.Archive". При необходимости она может быть перемещена или удалена.
            this.archiveTableAdapter3.Fill(this.theMailOperatorARMDataSet17.Archive);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet10.Archive". При необходимости она может быть перемещена или удалена.
            this.archiveTableAdapter2.Fill(this.theMailOperatorARMDataSet10.Archive);


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
        static string GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddressData AddressData = new AddressData();
            AddressData.Show();
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

            comboBox5.Text = AddressPost.post_office_address + " " + AddressPost.region +
                " " + AddressPost.street + " " + AddressPost.city;

            /*label22.Text = "Размер:" + State.length + "x" + State.width + "x" + State.height;*/

            PriceMail();
        }

        private void button_search_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    string id = Convert.ToString(selectedRow.Cells[0].Value);
                    if (id != "")
                    {
                        selected = int.Parse(id);
                        comboBox5.Text = AddressPost.post_office_address = Convert.ToString(selectedRow.Cells[1].Value);
                        textBox2.Text = fio_sender = Convert.ToString(selectedRow.Cells[2].Value);
                        maskedTextBox2.Text = phone_sender = Convert.ToString(selectedRow.Cells[3].Value);
                        comboBox6.Text = address_sender = Convert.ToString(selectedRow.Cells[4].Value);
                        textBox5.Text = fio_recipient = Convert.ToString(selectedRow.Cells[5].Value);
                        maskedTextBox1.Text = phone_recipient = Convert.ToString(selectedRow.Cells[6].Value);
                        comboBox7.Text = address_recipient = Convert.ToString(selectedRow.Cells[7].Value);
                        State.height = Convert.ToDouble(selectedRow.Cells[8].Value);
                        State.length = Convert.ToDouble(selectedRow.Cells[9].Value);
                        State.width = Convert.ToDouble(selectedRow.Cells[10].Value);
                        textBox9.Text = weight = Convert.ToString(selectedRow.Cells[11].Value);
                        textBox13.Text = parcel_contents = Convert.ToString(selectedRow.Cells[12].Value);
                        textBox10.Text = price = Convert.ToString(selectedRow.Cells[13].Value);
                        comboBox2.Text = status = Convert.ToString(selectedRow.Cells[14].Value);
                        random_password = Convert.ToString(selectedRow.Cells[15].Value);
                        comboBox3.Text = type_of_departure = Convert.ToString(selectedRow.Cells[16].Value);
                        comboBox4.Text = payment = Convert.ToString(selectedRow.Cells[17].Value);
                        AddressPost.region = Convert.ToString(selectedRow.Cells[18].Value);
                        AddressPost.street = Convert.ToString(selectedRow.Cells[19].Value);
                        AddressPost.city = Convert.ToString(selectedRow.Cells[20].Value);
                        dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells[21].Value);
                        dateTimePicker2.Value = Convert.ToDateTime(selectedRow.Cells[22].Value);
                        AddressPost2.region2 = Convert.ToString(selectedRow.Cells[23].Value);
                        AddressPost2.street2 = Convert.ToString(selectedRow.Cells[24].Value);
                        AddressPost2.city2 = Convert.ToString(selectedRow.Cells[25].Value);
                        comboBox1.Text = AddressPost2.recipient_index = Convert.ToString(selectedRow.Cells[26].Value);
                        textBox4.Text = email_sender = Convert.ToString(selectedRow.Cells[27].Value);
                        textBox3.Text = email_recipient = Convert.ToString(selectedRow.Cells[28].Value);
                        /*                dateTimePicker1 = datetime = Convert.ToString(selectedRow.Cells[14].Value);*/

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet18.Archive". При необходимости она может быть перемещена или удалена.
            this.archiveTableAdapter4.Fill(this.theMailOperatorARMDataSet18.Archive);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Получаем данные из архива
                string sqlExpression = "SELECT * FROM Archive WHERE id = @id";

                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand myCommand = conn.CreateCommand();

                myCommand.CommandText = sqlExpression;
                myCommand.Parameters.Add("@id", SqlDbType.Int).Value = selected;

                SqlDataReader reader = myCommand.ExecuteReader();

                if (reader.Read())
                {
                    // Получаем данные из архива
                    string post_office_address = reader["post_office_address"].ToString();
                    string fio_sender = reader["fio_sender"].ToString();
                    string phone_sender = reader["phone_sender"].ToString();
                    string address_sender = reader["address_sender"].ToString();
                    string fio_recipient = reader["fio_recipient"].ToString();
                    string phone_recipient = reader["phone_recipient"].ToString();
                    string address_recipient = reader["address_recipient"].ToString();
                    string length = reader["length"].ToString();
                    string height = reader["height"].ToString();
                    string weight = reader["weight"].ToString();
                    string width = reader["width"].ToString();
                    string parcel_contents = reader["parcel_contents"].ToString();
                    string price = reader["price"].ToString();
                    string status = reader["status"].ToString();
                    string type_of_departure = reader["type_of_departure"].ToString();
                    string random_password = reader["random_password"].ToString();
                    string payment = reader["payment"].ToString();
                    string region = reader["region"].ToString();
                    string street = reader["street"].ToString();
                    string city = reader["city"].ToString();
                    string dispatch_time = reader["dispatch_time"].ToString();
                    string combustion_time = reader["combustion_time"].ToString();
                    string region2 = reader["region2"].ToString();
                    string street2 = reader["street2"].ToString();
                    string city2 = reader["city2"].ToString();
                    string recipient_index = reader["recipient_index"].ToString();
                    string email_sender = reader["email_sender"].ToString();
                    string email_recipient = reader["email_recipient"].ToString();

                    string sqlExpression2 = "INSERT INTO Applications (post_office_address, fio_sender, phone_sender, address_sender, fio_recipient, " +
                        "phone_recipient, address_recipient, length, width, height, weight, parcel_contents, price, status, random_password," +
                        "type_of_departure, payment, region, street, city, dispatch_time, combustion_time, region2, street2, city2, recipient_index,email_sender,email_recipient) " +
                        "VALUES (@post_office_address, @fio_sender, @phone_sender, @address_sender, @fio_recipient, @phone_recipient, @address_recipient, " +
                        "@length, @width, @height, @weight, @parcel_contents, @price, @status,@random_password, @type_of_departure, @payment, @region, @street, @city, " +
                        "@dispatch_time, @combustion_time, @region2, @street2, @city2, @recipient_index,@email_sender,@email_recipient)";

                    conn.Close();
                    conn.Open();
                    SqlCommand myCommand2 = conn.CreateCommand();

                    myCommand2.CommandText = sqlExpression2;

                    myCommand2.Parameters.Add("@post_office_address", SqlDbType.VarChar).Value = post_office_address;
                    myCommand2.Parameters.Add("@fio_sender", SqlDbType.VarChar).Value = fio_sender;
                    myCommand2.Parameters.Add("@phone_sender", SqlDbType.VarChar).Value = phone_sender;
                    myCommand2.Parameters.Add("@address_sender", SqlDbType.VarChar).Value = address_sender;
                    myCommand2.Parameters.Add("@fio_recipient", SqlDbType.VarChar).Value = fio_recipient;
                    myCommand2.Parameters.Add("@phone_recipient", SqlDbType.VarChar).Value = phone_recipient;
                    myCommand2.Parameters.Add("@address_recipient", SqlDbType.VarChar).Value = address_recipient;
                    myCommand2.Parameters.Add("@length", SqlDbType.VarChar).Value = length;
                    myCommand2.Parameters.Add("@height", SqlDbType.VarChar).Value = height;
                    myCommand2.Parameters.Add("@weight", SqlDbType.VarChar).Value = weight;
                    myCommand2.Parameters.Add("@width", SqlDbType.VarChar).Value = width;
                    myCommand2.Parameters.Add("@parcel_contents", SqlDbType.VarChar).Value = parcel_contents;
                    myCommand2.Parameters.Add("@price", SqlDbType.Money).Value = price;
                    myCommand2.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
                    myCommand2.Parameters.Add("@type_of_departure", SqlDbType.VarChar).Value = type_of_departure;
                    myCommand2.Parameters.Add("@random_password", SqlDbType.VarChar).Value = random_password;
                    myCommand2.Parameters.Add("@payment", SqlDbType.VarChar).Value = payment;
                    myCommand2.Parameters.Add("@region", SqlDbType.VarChar).Value = region;
                    myCommand2.Parameters.Add("@street", SqlDbType.VarChar).Value = street;
                    myCommand2.Parameters.Add("@city", SqlDbType.VarChar).Value = city;
                    myCommand2.Parameters.Add("@dispatch_time", SqlDbType.Date).Value = Convert.ToString(dispatch_time);
                    myCommand2.Parameters.Add("@combustion_time", SqlDbType.Date).Value = Convert.ToString(combustion_time);
                    myCommand2.Parameters.Add("@region2", SqlDbType.VarChar).Value = region2;
                    myCommand2.Parameters.Add("@street2", SqlDbType.VarChar).Value = street2;
                    myCommand2.Parameters.Add("@city2", SqlDbType.VarChar).Value = city2;
                    myCommand2.Parameters.Add("@recipient_index", SqlDbType.VarChar).Value = recipient_index;
                    myCommand2.Parameters.Add("@email_sender", SqlDbType.VarChar).Value = email_sender;
                    myCommand2.Parameters.Add("@email_recipient", SqlDbType.VarChar).Value = email_recipient;


                    myCommand2.ExecuteNonQuery();

                    // Удаляем данные из архива
                    string sqlExpression3 = "DELETE FROM Archive WHERE id = @id";

                    SqlCommand myCommand3 = conn.CreateCommand();
                    myCommand3.CommandText = sqlExpression3;
                    myCommand3.Parameters.Add("@id", SqlDbType.Int).Value = selected;
                    myCommand3.ExecuteNonQuery();

                    MessageBox.Show("Данные успешно возвращены из архива");
                }
                else
                {
                    MessageBox.Show("Данные с указанным ID не найдены в архиве");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при возвращении данных из архива: " + ex.Message);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            string query = "SELECT * FROM dbo.Archive WHERE id LIKE @searchValue OR post_office_address LIKE @searchValue OR fio_sender like @searchValue OR phone_sender LIKE @searchValue OR address_sender LIKE @searchValue OR fio_recipient LIKE @searchValue OR phone_recipient LIKE @searchValue OR address_recipient LIKE @searchValue OR length LIKE @searchValue OR width LIKE @searchValue OR height LIKE @searchValue OR weight LIKE @searchValue OR parcel_contents LIKE @searchValue OR price LIKE @searchValue OR status LIKE @searchValue OR random_password LIKE @searchValue OR type_of_departure LIKE @searchValue OR payment LIKE @searchValue OR region LIKE @searchValue OR street LIKE @searchValue OR city LIKE @searchValue OR dispatch_time LIKE @searchValue OR combustion_time LIKE @searchValue OR region2 LIKE @searchValue OR street2 LIKE @searchValue OR city2 LIKE @searchValue OR recipient_index LIKE @searchValue OR email_sender LIKE @searchValue OR email_recipient LIKE @searchValue";

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
