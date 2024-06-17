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
using MailMessage = System.Net.Mail.MailMessage;
namespace Kyrsov
{
    public partial class Applica : Form
    {
        public static Applica instance;
        /*private Application wordApp;*/
        private Document reportDoc;
        public Applica()
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
        string combustion_time = "";
        /*string datetime = "";*/

        private void Applica_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter.Fill(this.theMailOperatorARMDataSet.Applications);
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

                var lastId = myCommand.ExecuteScalar();
                /*setTable();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Внимание проверьте данные которые вы ввели,возможно что вы упустили пункт");
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
            /*setTable();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string post_office_address = AddressPost.post_office_address;
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
                string combustion_time = dateTimePicker2.Text;

                string sqlExpression = "UPDATE dbo.Applications SET post_office_address = @post_office_address, fio_sender = @fio_sender, " +
                "phone_sender = @phone_sender, address_sender = @address_sender, fio_recipient = @fio_recipient, " +
                "phone_recipient = @phone_recipient, address_recipient = @address_recipient, length = @length,width = @width,height = @height, weight = @weight, " +
                "parcel_contents = @parcel_contents, price = @price, status = @status , type_of_departure = @type_of_departure, payment = @payment,region = @region,apartment = @apartment," +
                "apartment_nubmer = @apartment_nubmer,street = @street,city = @city,dispatch_time = @dispatch_time, combustion_time = @combustion_time WHERE id = @id";

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
                myCommand.Parameters.Add("@combustion_time", SqlDbType.Date).Value = combustion_time;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
        public void setTable()
        {
            dataGridView1.Refresh();
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

        private void button8_Click(object sender, EventArgs e)
        {
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
                {  "price", textBox10.Text},
            };
            helper.process(items);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dimensions dimensions = new dimensions();
            dimensions.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddressData AddressData = new AddressData();
            AddressData.Show();
        }

        private void Applica_Activated(object sender, EventArgs e)
        {
            State.length.ToString();
            State.width.ToString();
            State.height.ToString();

            comboBox5.Text = AddressPost.post_office_address + "," + AddressPost.region + "," + AddressPost.apartment + "," + AddressPost.apartment_nubmer +
                "," + AddressPost.street + "," + AddressPost.city;

            label22.Text = "Размер:" + State.length + "x" + State.width + "x" + State.height;

            PriceMail();
        }

        private void button11_Click(object sender, EventArgs e)
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
                string combustion_time = dateTimePicker2.Text;

                string sqlExpression = "INSERT INTO dbo.Archive (post_office_address,fio_sender,phone_sender,address_sender," +
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
                myCommand.Parameters.Add("@combustion_time", SqlDbType.Date).Value = combustion_time;

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
                        mailMessage.Body = $"Здравствуйте, вам пришло {comboBox3.Text} прошу вас пройти на почту и забрать посылку" +
                            $"чтобы получить корреспонденцию покажите/скажите пароль {random_password}";

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(51, 51, 76);
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel3.BackColor = Color.FromArgb(39, 39, 58);
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter.Fill(this.theMailOperatorARMDataSet.Applications);
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
    }
}
