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

namespace Kyrsov
{
    public partial class Other2 : Form
    {
        Form form;
        public string path1 = @"C:\Users\kiril\Desktop\kyrsov\Kyrsov\Kyrsov\stat_otchet.xlsx";
        public Other2()
        {
            InitializeComponent();
            this.form = form;
        }
        public string connectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperatorARM';Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string sqlExpression = "INSERT INTO dbo.Applications (post_office_address,fio_sender,phone_sender,address_sender," +
                    "fio_recipient,phone_recipient,address_recipient,length,width,height,weight,parcel_contents,price,status,random_password,type_of_departure,payment,region,apartment," +
                    "apartment_nubmer,street,city,dispatch_time) VALUES (@post_office_address,@fio_sender,@phone_sender," +
                    "@address_sender,@fio_recipient,@phone_recipient,@address_recipient,@length,@width,@height,@weight,@parcel_contents,@price," +
                    "@status,@random_password,@type_of_departure,@payment,@region,@apartment,@apartment_nubmer,@street,@city,@dispatch_time)";
            SqlConnection conn = new SqlConnection(connectionString);

            var fromDate = dateTimePicker1.Value;

            conn.Open();
            SqlCommand command = new SqlCommand(sqlExpression, conn);
            command.Parameters.Add("@from", SqlDbType.Date).Value = fromDate;
            command.CommandText = sqlExpression;
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[7]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }
            reader.Close();
            conn.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Other2_Load(object sender, EventArgs e)
        {

        }
    }
}
