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
using Google.Protobuf.Compiler;
using System.Runtime.Remoting.Messaging;
using System.Collections;
using System.Net.Mail;
using System.Net;
using MailMessage = System.Net.Mail.MailMessage;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using MySqlX.XDevAPI.Common;


namespace Kyrsov
{

    public partial class Applications : Form
    {
        public static Applications instance;
        /*private Application wordApp;*/
        private Document reportDoc;
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
        string datetime = "";
        private void Applications_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet10.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter5.Fill(this.theMailOperatorARMDataSet10.Applications);

            comboBox3.Items.Add("Заказное письмо (+20 рублей)");
            comboBox3.Items.Add("Заказное письмо 1 класса(+20 рублей)");
            comboBox3.Items.Add("Ценное письмо (+50 рублей)");
            comboBox3.Items.Add("Ценное письмо 1 класса (+50 рублей)");
            comboBox3.Items.Add("Экспресс - письмо EMS(+50 рублей)");
            comboBox3.Items.Add("Бандероль (+50 рублей)");
            comboBox3.Items.Add("Заказная бандероль(+50 рублей)");
            comboBox3.Items.Add("Заказная бандероль 1 класса(+50 рублей)");
            comboBox3.Items.Add("Ценная бандероль (+50 рублей)");
            comboBox3.Items.Add("Ценная бандероль 1 класса(+50 рублей)");
            comboBox3.Items.Add("Заказной мелкий пакет (+50 рублей)");
            comboBox3.Items.Add("Посылка (+50 рублей)");
            comboBox3.Items.Add("Посылка 1 класс (+50 рублей)");
            comboBox3.Items.Add("Ценная посылка (+50 рублей)");
            comboBox3.Items.Add("Экспресс - посылка EMS (+50 рублей)");
            comboBox3.Items.Add("Посылка Стандарт (+50 рублей)");
            comboBox3.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string post_office_address = AddressPost.post_office_address;
                string fio_sender = textBox2.Text;
                string phone_sender = textBox3.Text;
                string address_sender = textBox4.Text;
                string fio_recipient = textBox5.Text;
                string phone_recipient = textBox6.Text;
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


                string sqlExpression = "INSERT INTO dbo.Applications (post_office_address,fio_sender,phone_sender,address_sender," +
                    "fio_recipient,phone_recipient,address_recipient,length,width,height,weight,parcel_contents,price,status,random_password,type_of_departure,payment,region,apartment," +
                    "apartment_nubmer,street,city,dispatch_time) VALUES (@post_office_address,@fio_sender,@phone_sender," +
                    "@address_sender,@fio_recipient,@phone_recipient,@address_recipient,@length,@width,@height,@weight,@parcel_contents,@price," +
                    "@status,@random_password,@type_of_departure,@payment,@region,@apartment,@apartment_nubmer,@street,@city,@dispatch_time)";

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
                myCommand.Parameters.Add("@dispatch_time", SqlDbType.Date).Value = dispatch_time;

                var lastId = myCommand.ExecuteScalar();
                /*setTable();*/
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }

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
            try
            {
            string post_office_address = AddressPost.post_office_address;
            string fio_sender = textBox2.Text;
            string phone_sender = textBox3.Text;
            string address_sender = textBox4.Text;
            string fio_recipient = textBox5.Text;
            string phone_recipient = textBox6.Text;
            string address_recipient = textBox7.Text;
            double length = State.length;
            double width = State.width;
            double height = State.height;
            string weight = textBox9.Text;
            string parcel_contents = textBox13.Text;
            /*float password = float.Parse(textBox8.Text);*/
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

            string sqlExpression = "UPDATE dbo.Applications SET post_office_address = @post_office_address, fio_sender = @fio_sender, " +
            "phone_sender = @phone_sender, address_sender = @address_sender, fio_recipient = @fio_recipient, " +
            "phone_recipient = @phone_recipient, address_recipient = @address_recipient, length = @length,width = @width,height = @height, weight = @weight, " +
            "parcel_contents = @parcel_contents, price = @price, status = @status , type_of_departure = @type_of_departure, payment = @payment,region = @region,apartment = @apartment,apartment_nubmer = @apartment_nubmer,street = @street,city = @city,dispatch_time = @dispatch_time WHERE id = @id";

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
            myCommand.Parameters.Add("@apartment", SqlDbType.VarChar).Value = apartment;
            myCommand.Parameters.Add("@apartment_nubmer", SqlDbType.VarChar).Value = apartment_nubmer;
            myCommand.Parameters.Add("@street", SqlDbType.VarChar).Value = street;
            myCommand.Parameters.Add("@city", SqlDbType.VarChar).Value = city;
            myCommand.Parameters.Add("@dispatch_time", SqlDbType.Date).Value = dispatch_time;
            myCommand.Parameters.Add("@id", SqlDbType.Int).Value = selected;
            /*            myCommand.Parameters.Add("@id", SqlDbType.Int).Value = id; // Предполагается, что у вас есть переменная id, которая хранит идентификатор записи*/

            myCommand.ExecuteNonQuery();

            conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*setTable();*/
        }

        static string GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
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
                    textBox3.Text = phone_sender = Convert.ToString(selectedRow.Cells[3].Value);
                    textBox4.Text = address_sender = Convert.ToString(selectedRow.Cells[4].Value);
                    textBox5.Text = fio_recipient = Convert.ToString(selectedRow.Cells[5].Value);
                    textBox6.Text = phone_recipient = Convert.ToString(selectedRow.Cells[6].Value);
                    textBox7.Text = address_recipient = Convert.ToString(selectedRow.Cells[7].Value);
                    State.height = Convert.ToInt32(selectedRow.Cells[8].Value);
                    State.length = Convert.ToInt32(selectedRow.Cells[9].Value);
                    State.width  = Convert.ToInt32(selectedRow.Cells[10].Value);
                    textBox9.Text = weight = Convert.ToString(selectedRow.Cells[11].Value);
                    textBox13.Text = parcel_contents = Convert.ToString(selectedRow.Cells[12].Value);
                    textBox10.Text = price = Convert.ToString(selectedRow.Cells[13].Value);
                    comboBox2.Text = status = Convert.ToString(selectedRow.Cells[14].Value);
                    comboBox3.Text = type_of_departure = Convert.ToString(selectedRow.Cells[16].Value);
                    comboBox4.Text = payment = Convert.ToString(selectedRow.Cells[17].Value);
                    /*AddressPost.region = Convert.ToString(selectedRow.Cells[19].Value);
                    AddressPost.apartment = Convert.ToString(selectedRow.Cells[20].Value);
                    AddressPost.apartment_nubmer = Convert.ToString(selectedRow.Cells[21].Value);
                    AddressPost.street = Convert.ToString(selectedRow.Cells[22].Value);
                    AddressPost.city = Convert.ToString(selectedRow.Cells[23].Value);*/
                    /*dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells[23].Value);*/
                    /*                dateTimePicker1 = datetime = Convert.ToString(selectedRow.Cells[14].Value);*/
                }
            }
        }

        public void setTable()
        {
            dataGridView1.Refresh();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet10.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter5.Fill(this.theMailOperatorARMDataSet10.Applications);



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

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sqlExpression = "SELECT * FROM dbo.Applications SET post_office_address = @post_office_address, fio_sender = @fio_sender, " +
             "phone_sender = @phone_sender, address_sender = @address_sender, fio_recipient = @fio_recipient, " +
             "phone_recipient = @phone_recipient, address_recipient = @address_recipient, size = @size, weight = @weight, " +
             "parcel_contents = @parcel_contents, price = @price, status = @status  WHERE name = "+textBox1.Text +"id = @id LIKE @id";
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
            /*Method P = new Method();
            var password = GeneratePassword();
            textBox11.Text = password;*/
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*Other1 newForm = new Other1();
            newForm.Show();*/
            var helper = new WordHepler("talon.docx");

            var items = new Dictionary<string, string>
            {
                /*{ "id", comboBox1.Text},*/
                { "post_office_address", comboBox5.Text},
                /*{ "FIO_sender", textBox2.Text},
                { "phone_sender", textBox3.Text},*/
                { "address_sender", textBox4.Text},
                /*{ "FIO_recipient", textBox5.Text},
                { "phone_recipient", textBox6.Text},*/
                { "address_recipient", textBox7.Text},
                /*{ "size", textBox8.Text},*/
                { "weight", textBox9.Text},
                /*{ "cost", textBox10.Text},*/
                { "status", comboBox2.Text},
                { "payment", comboBox4.Text},
                { "type_of_departure", comboBox3.Text},
            };
            helper.process(items);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            AddressData AddressData = new AddressData();
            AddressData.Show();
        }

        private void Applications_Activated(object sender, EventArgs e)
        {
            
            State.length.ToString();
            State.width.ToString();
            State.height.ToString();

            comboBox5.Text = AddressPost.post_office_address + " " + AddressPost.region + " " + AddressPost.apartment + " " + AddressPost.apartment_nubmer + 
                " " + AddressPost.street + " " + AddressPost.city;

            label22.Text = "Размер:" + State.length + "x" + State.width + "x" +State.height;

            double result = 0;
            int[] points = { 20, 50, 50 };

            result += points[comboBox3.SelectedIndex];


            result = (State.length + State.width + State.height) + points[comboBox3.SelectedIndex];

            label14.Text = result.ToString();



        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string post_office_address = AddressPost.post_office_address;
                string fio_sender = textBox2.Text;
                string phone_sender = textBox3.Text;
                string address_sender = textBox4.Text;
                string fio_recipient = textBox5.Text;
                string phone_recipient = textBox6.Text;
                string address_recipient = textBox7.Text;
                double length = State.length;
                double width = State.width;
                double height = State.height;
                string weight = textBox9.Text;
                string parcel_contents = textBox13.Text;
                /*float password = float.Parse(textBox8.Text);*/
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

                string sqlExpression = "INSERT INTO dbo.Archive (post_office_address,fio_sender,phone_sender,address_sender," +
                    "fio_recipient,phone_recipient,address_recipient,length,width,height,weight,parcel_contents,price,status,random_password,type_of_departure,payment,region,apartment," +
                    "apartment_nubmer,street,city,dispatch_time) VALUES (@post_office_address,@fio_sender,@phone_sender," +
                    "@address_sender,@fio_recipient,@phone_recipient,@address_recipient,@length,@width,@height,@weight,@parcel_contents,@price," +
                    "@status,@random_password,@type_of_departure,@payment,@region,@apartment,@apartment_nubmer,@street,@city,@dispatch_time)";
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
            myCommand.Parameters.Add("@random_password", SqlDbType.VarChar).Value = GeneratePassword();
            myCommand.Parameters.Add("@type_of_departure", SqlDbType.VarChar).Value = type_of_departure;
            myCommand.Parameters.Add("@payment", SqlDbType.VarChar).Value = payment;
            myCommand.Parameters.Add("@region", SqlDbType.VarChar).Value = region;
            myCommand.Parameters.Add("@apartment", SqlDbType.VarChar).Value = apartment;
            myCommand.Parameters.Add("@apartment_nubmer", SqlDbType.VarChar).Value = apartment_nubmer;
            myCommand.Parameters.Add("@street", SqlDbType.VarChar).Value = street;
            myCommand.Parameters.Add("@city", SqlDbType.VarChar).Value = city;
            myCommand.Parameters.Add("@dispatch_time", SqlDbType.Date).Value = dispatch_time;

            var lastId2 = myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string sqlExpression2 = "DELETE FROM Applications WHERE id = @id";

            SqlConnection conn2 = new SqlConnection(connectionString);
            conn2.Open();
            SqlCommand myCommand2 = conn2.CreateCommand();

            myCommand2.CommandText = sqlExpression2;
            myCommand2.Parameters.Add("@id", SqlDbType.Int).Value = selected;

            var lastId = myCommand2.ExecuteScalar();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddressData AddressData = new AddressData();
            AddressData.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            SendMessage();
        }
        private void SendMessage()
        {
            // Настройки SMTP-сервера Mail.ru
           
            string smtpServer = "smtp.mail.ru"; //smpt сервер(зависит от почты отправителя)
            int smtpPort = 587; // Обычно используется порт 587 для TLS
            string smtpUsername = "mailsender747@mail.ru"; //твоя почта, с которой отправляется сообщение
            string smtpPassword = "45gvsd@gdr";//пароль приложения (от почты)

            // Создаем объект клиента SMTP
            using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                // Настройки аутентификации
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(smtpUsername);
                    mailMessage.To.Add("kirill000e@gmail.com"); // Укажите адрес получателя
                    mailMessage.Subject = "Заголовок сообщения (тема)";
                    mailMessage.Body = $"Текст сообщения";

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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(39, 39, 58);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            double result = 0;
            int[] points = { 20, 50, 50 };

            result += points[comboBox3.SelectedIndex];


            result = (State.length + State.width + State.height) + points[comboBox3.SelectedIndex];

            label14.Text = result.ToString();

        }
    }
        
}
