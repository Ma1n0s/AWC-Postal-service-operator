using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MailMessage = System.Net.Mail.MailMessage;
namespace Kyrsov
{
    public partial class Applica : Form
    {
        public static Applica instance;
        /*private Application wordApp;*/
        private Document reportDoc;
        test test;
        public Applica()
        {
            InitializeComponent();

        }
        public event EventHandler<string> DataUpdated;


        public void UpdateComboBox6(string newValue)
        {
            comboBox6.SelectedItem = newValue;
        }

        Applica applica;
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
        string length = "";
        string width = "";
        string height = "";
        string parcel_contents = "";
        string price = "";
        string weight = "";
        string random_password = "";
        string payment = "";
        string region = "";
        string street = "";
        string city = "";
        string dispatch_time = "";
        string combustion_time = "";
        string email_sender = "";
        string email_recipient = "";

        public AddressData MdiContainer { get; internal set; }

        /*string datetime = "";*/

        private void Applica_Load(object sender, EventArgs e)
        {
           

            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet16.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter5.Fill(this.theMailOperatorARMDataSet16.Applications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet15.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter4.Fill(this.theMailOperatorARMDataSet15.Applications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet8.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter3.Fill(this.theMailOperatorARMDataSet8.Applications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet5.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter2.Fill(this.theMailOperatorARMDataSet5.Applications);

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
                string email_sender = textBox4.Text;
                string email_recipient = textBox3.Text;

                string sqlExpression = "INSERT INTO dbo.Applications (post_office_address,fio_sender,phone_sender,address_sender," +
                    "fio_recipient,phone_recipient,address_recipient,length,width,height,weight,parcel_contents,price,status,random_password,type_of_departure,payment,region," +
                    "street,city,dispatch_time,combustion_time,region2,street2,city2,recipient_index,email_sender,email_recipient) VALUES (@post_office_address,@fio_sender,@phone_sender," +
                    "@address_sender,@fio_recipient,@phone_recipient,@address_recipient,@length,@width,@height,@weight,@parcel_contents,@price," +
                    "@status,@random_password,@type_of_departure,@payment,@region,@street,@city,@dispatch_time,@combustion_time,@region2,@street2,@city2,@recipient_index,@email_sender,@email_recipient)";

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
                myCommand.Parameters.Add("@email_sender", SqlDbType.VarChar).Value = email_sender;
                myCommand.Parameters.Add("@email_recipient", SqlDbType.VarChar).Value = email_recipient;
                var lastId = myCommand.ExecuteScalar();
                SMS($"Здравствуйте,ваша корреспонденция отправлена");
                /*CheckNotification();*/
                setTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Message;
            Message = "Вы хотите удалить эту запись ?";
            if (MessageBox.Show(Message, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            string sqlExpression = "DELETE FROM Applications WHERE id = @id";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand myCommand = conn.CreateCommand();

            myCommand.CommandText = sqlExpression;
            myCommand.Parameters.Add("@id", SqlDbType.Int).Value = selected;

            var lastId = myCommand.ExecuteScalar();
        }

        private void button3_Click(object sender, EventArgs e)
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
                string email_sender = textBox4.Text;
                string email_recipient = textBox3.Text;

                string sqlExpression = "UPDATE dbo.Applications SET post_office_address = @post_office_address, fio_sender = @fio_sender, " +
                "phone_sender = @phone_sender, address_sender = @address_sender, fio_recipient = @fio_recipient," +
                "phone_recipient = @phone_recipient, address_recipient = @address_recipient, length = @length,width = @width,height = @height, weight = @weight, " +
                "parcel_contents = @parcel_contents, price = @price, status = @status , type_of_departure = @type_of_departure, payment = @payment,region = @region," +
                "street = @street,city = @city,dispatch_time = @dispatch_time, combustion_time = @combustion_time, region2 = @region2,street2 = @street2,city2 = @city2,recipient_index = @recipient_index, email_sender = @email_sender,email_recipient = @email_recipient WHERE id = @id";

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
                myCommand.Parameters.Add("@width", SqlDbType.VarChar).Value = width;
                myCommand.Parameters.Add("@height", SqlDbType.VarChar).Value = height;
                myCommand.Parameters.Add("@weight", SqlDbType.VarChar).Value = weight;
                myCommand.Parameters.Add("@parcel_contents", SqlDbType.VarChar).Value = parcel_contents;
                myCommand.Parameters.Add("@price", SqlDbType.Money).Value = price;
                myCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
                myCommand.Parameters.Add("@type_of_departure", SqlDbType.VarChar).Value = type_of_departure;
                myCommand.Parameters.Add("@payment", SqlDbType.VarChar).Value = payment;
                myCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = region;
                myCommand.Parameters.Add("@street", SqlDbType.VarChar).Value = street;
                myCommand.Parameters.Add("@city", SqlDbType.VarChar).Value = city;
                myCommand.Parameters.Add("@dispatch_time", SqlDbType.Date).Value = dispatch_time;
                myCommand.Parameters.Add("@combustion_time", SqlDbType.Date).Value = combustion_time;
                myCommand.Parameters.Add("@region2", SqlDbType.VarChar).Value = region2;
                myCommand.Parameters.Add("@street2", SqlDbType.VarChar).Value = street2;
                myCommand.Parameters.Add("@city2", SqlDbType.VarChar).Value = city2;
                myCommand.Parameters.Add("@recipient_index", SqlDbType.VarChar).Value = recipient_index;
                myCommand.Parameters.Add("@email_sender", SqlDbType.VarChar).Value = email_sender;
                myCommand.Parameters.Add("@email_recipient", SqlDbType.VarChar).Value = email_recipient;
                myCommand.Parameters.Add("@id", SqlDbType.Int).Value = selected;
                /*            myCommand.Parameters.Add("@id", SqlDbType.Int).Value = id; */

                myCommand.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вы не дописали данные");
            }
        }
        static string GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    maskedTextBox3.Text = phone_recipient = Convert.ToString(selectedRow.Cells[6].Value);
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
                    textBox11.Text = email_recipient = Convert.ToString(selectedRow.Cells[28].Value);
                        /*                dateTimePicker1 = datetime = Convert.ToString(selectedRow.Cells[14].Value);*/

                    }
            }
            label22.Text = "Размер:" + height + "x" + length + "x" + width;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вы не дописали данные");
            }
        }
        public void setTable()
        {
            comboBox6.Text = AddressPost.region + "," + AddressPost.city + "," + AddressPost.street;
            comboBox7.Text = AddressPost2.region2 + "," + AddressPost2.city2 + "," + AddressPost2.street2;
            comboBox5.Text = AddressPost.post_office_address;
            comboBox1.Text = AddressPost2.recipient_index;
            dataGridView1.Refresh();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            string query = "SELECT * FROM dbo.Applications WHERE id LIKE @searchValue OR post_office_address LIKE @searchValue OR fio_sender like @searchValue OR phone_sender LIKE @searchValue OR address_sender LIKE @searchValue OR fio_recipient LIKE @searchValue OR phone_recipient LIKE @searchValue OR address_recipient LIKE @searchValue OR length LIKE @searchValue OR width LIKE @searchValue OR height LIKE @searchValue OR weight LIKE @searchValue OR parcel_contents LIKE @searchValue OR price LIKE @searchValue OR status LIKE @searchValue OR random_password LIKE @searchValue OR type_of_departure LIKE @searchValue OR payment LIKE @searchValue OR region LIKE @searchValue OR street LIKE @searchValue OR city LIKE @searchValue OR dispatch_time LIKE @searchValue OR combustion_time LIKE @searchValue OR region2 LIKE @searchValue OR street2 LIKE @searchValue OR city2 LIKE @searchValue OR recipient_index LIKE @searchValue OR email_sender LIKE @searchValue OR email_recipient LIKE @searchValue";

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

        private void button8_Click(object sender, EventArgs e)
        {
            var helper = new WordHepler("talon.docx");

            var items = new Dictionary<string, string>
            {
                /*{ "id", comboBox1.Text},*/
                { "post_office_address", comboBox5.Text},
                /*{ "FIO_sender", textBox2.Text},
                { "phone_sender", textBox3.Text},*/
                { "address_sender", comboBox6.Text},
                /*{ "FIO_recipient", textBox5.Text},
                { "phone_recipient", textBox6.Text},*/
                { "address_recipient",comboBox7.Text},
                /*{ "size", textBox8.Text},*/
                { "weight", textBox9.Text},
                { "length", Convert.ToString(State.length) },
                { "width", Convert.ToString(State.width) },
                { "height",Convert.ToString(State.height) },
                /*{ "cost", textBox10.Text},*/
                { "status", comboBox2.Text},
                { "payment", comboBox4.Text},
                { "type_of_departure", comboBox3.Text},
                {  "price", textBox10.Text},
            };
            helper.process(items);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dimensions dimensions = new dimensions();
            dimensions.Show();
            dimensions.FormClosed += FormMain_FormClosed;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddressData AddressData = new AddressData();
            AddressData.Show();
            AddressData.FormClosed += FormMain_FormClosed;
        }

        private void Applica_Activated(object sender, EventArgs e)
        {
            State.length.ToString();
            State.width.ToString();
            State.height.ToString();

            comboBox6.Text =  AddressPost.region +
                "," + AddressPost.city + "," + AddressPost.street;
            comboBox5.Text = AddressPost.post_office_address;


            comboBox7.Text =  AddressPost2.region2 +
                "," + AddressPost2.city2 + "," + AddressPost2.street2;
            comboBox1.Text = AddressPost2.recipient_index;

            label22.Text = "Размер:" + State.length + "x" + State.width + "x" + State.height;

            PriceMail();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dimensions dimensions = new dimensions();
            dimensions.Show();
            dimensions.FormClosed += FormMain_FormClosed;
        }

        private void button9_Click(object sender, EventArgs e)
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
                string email_sender = textBox4.Text;
                string email_recipient = textBox3.Text;


                string sqlExpression = "INSERT INTO dbo.Archive (post_office_address,fio_sender,phone_sender,address_sender," +
                    "fio_recipient,phone_recipient,address_recipient,length,width,height,weight,parcel_contents,price,status,random_password,type_of_departure,payment,region," +
                    "street,city,dispatch_time,combustion_time,region2,street2,city2,recipient_index,email_sender,email_recipient) VALUES (@post_office_address,@fio_sender,@phone_sender," +
                    "@address_sender,@fio_recipient,@phone_recipient,@address_recipient,@length,@width,@height,@weight,@parcel_contents,@price," +
                    "@status,@random_password,@type_of_departure,@payment,@region,@street,@city,@dispatch_time,@combustion_time,@region2,@street2,@city2,@recipient_index,@email_sender,@email_recipient)";

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
                myCommand.Parameters.Add("@random_password", SqlDbType.VarChar).Value = random_password;
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
                myCommand.Parameters.Add("@email_sender", SqlDbType.VarChar).Value = email_sender;
                myCommand.Parameters.Add("@email_recipient", SqlDbType.VarChar).Value = email_recipient;

                var lastId2 = myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Запись уходит под удаление");
            }
            string sqlExpression2 = "DELETE FROM Applications WHERE id = @id";

            SqlConnection conn2 = new SqlConnection(connectionString);
            conn2.Open();
            SqlCommand myCommand2 = conn2.CreateCommand();

            myCommand2.CommandText = sqlExpression2;
            myCommand2.Parameters.Add("@id", SqlDbType.Int).Value = selected;

            var lastId = myCommand2.ExecuteScalar();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
        private void SendMessage()
        {
            try
            {

                string smtpServer = "smtp.mail.ru";
                int smtpPort = 587;
                string smtpUsername = "mailsender747@mail.ru";
                string smtpPassword = "mJMAi3QUw4dNrfGfcKi9";
                string recipientEmail = textBox11.Text;

                using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
                {
                    smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                    smtpClient.EnableSsl = true;

                    using (MailMessage mailMessage = new MailMessage())
                    {
                        mailMessage.From = new MailAddress(smtpUsername);
                        mailMessage.To.Add(recipientEmail);
                        mailMessage.Subject = $"Почта рядом сообщение для пользователя {fio_recipient}";
                        mailMessage.Body = $"Здравствуйте, вам пришло { comboBox3.Text} прошу вас пройти на почту и забрать посылку чтобы получить корреспонденцию покажите/ скажите пароль { random_password}  на индексу/ адрессу { comboBox1.Text},{ comboBox7.Text}";
                        try
                        {
                            // Отправляем сообщение
                            smtpClient.Send(mailMessage);
                            Console.WriteLine("Сообщение успешно отправлено.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ошибка отправки сообщения: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в" + ex.Message);
            }
        }
        private void CheckNotification()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Applications";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        DateTime dateFromDB = reader.GetDateTime(reader.GetOrdinal("DateField"));
                        DateTime selectedDate = dateTimePicker2.Value.Date;

                        if (dateFromDB == selectedDate)
                        {
                            SendMessage();
                        }
                    }
                }
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            /*panel2.BackColor = Color.FromArgb(51, 51, 76);*/
            /*panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel3.BackColor = Color.FromArgb(39, 39, 58);*/
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriceMail();
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

        private void button6_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet16.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter5.Fill(this.theMailOperatorARMDataSet16.Applications);
            setTable();
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddressData2 AddressData = new AddressData2();
            AddressData.Show();
            AddressData.FormClosed += FormMain_FormClosed;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                string post_office_address = AddressPost.post_office_address;
                


                string sqlExpression = "INSERT INTO dbo.Archive (post_office_address) VALUES (@post_office_address)";

                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand myCommand = conn.CreateCommand();

                myCommand.CommandText = sqlExpression;

                myCommand.Parameters.Add("@post_office_address", SqlDbType.VarChar).Value = post_office_address;
                

                var lastId = myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вы не дописали данные");
            }
        }

        public void SMS(string text)
        {
            string apiId = "A03A4240-4531-048E-4F24-C6D8A42F235B";
            string phoneNumber = maskedTextBox3.Text;
            string message = text;

            using (WebClient client = new WebClient())
            {
                string result = client.DownloadString($"https://sms.ru/sms/send?api_id={apiId}&to={phoneNumber}&msg={message}");

                if (result.Contains("100"))
                {
                    Console.WriteLine("SMS sent successfully");
                }
                else
                {
                    Console.WriteLine("Failed to send SMS");
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            SMS($"Здравствуйте, вам пришло {comboBox3.Text} прошу вас пройти на почту и забрать посылку чтобы получить корреспонденцию покажите/скажите пароль {random_password} на индексу/адрессу {comboBox1.Text},{comboBox7.Text}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (test == null)
            {
                test = new test();
                test.FormClosed += test_Load;
                test.Dock = DockStyle.Fill;
                test.Show();
            }
            else
            {
                test.Activate();
            }
        }
        private void test_Load(object sender, FormClosedEventArgs e)
        {
            test = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        private void UpdateComboBoxItems()
        {

           
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            setTable();
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            setTable();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            this.comboBox6.Text = comboBox6.Text = AddressPost.region +
                "," + AddressPost.city + "," + AddressPost.street;

            this.comboBox5.Text = comboBox5.Text = AddressPost.post_office_address;

            comboBox7.Text = AddressPost2.region2 +
                "," + AddressPost2.city2 + "," + AddressPost2.street2;
            comboBox1.Text = AddressPost2.recipient_index;

            label22.Text = "Размер:" + State.length + "x" + State.width + "x" + State.height;

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click_3(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void applica_Load(object sender, FormClosedEventArgs e)
        {
            applica = null;
        }

        private void button7_Click_4(object sender, EventArgs e)
        {

        }

        private void Applica_FormClosed(object sender, FormClosedEventArgs e)
        {
            applica = null;
        }
    }
}
