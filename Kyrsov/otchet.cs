using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace Kyrsov
{
    public partial class otchet : Form
    {
        Form form;
        public string path1 = @"C:\Users\kiril\Desktop\kyrsov\Kyrsov\Kyrsov\stat_otchet.xlsx";
        public otchet()
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

        private void button2_Click(object sender, EventArgs e)
        {
            Excel.Application application = new Excel.Application();
            Workbook wb = application.Workbooks.Open(path1);
            Excel._Worksheet wsh = application.ActiveSheet;

            var fromDate = dateTimePicker1.Value;
            var toDate = dateTimePicker2.Value;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            SqlCommand com = new SqlCommand("SELECT Correspondence.id_Correspondence, Correspondence.tip, Correspondence.Weight, Insurance.Sum, Insurance.Firm, Correspondence.Departure_date, Correspondence.Date_of_receiving FROM Correspondence INNER JOIN Insurance ON Insurance.id_Insurance = Correspondence.id_Insurance WHERE Correspondence.Departure_date BETWEEN @from", con);

            com.Parameters.Add("@from", SqlDbType.Date).Value = fromDate;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToShortTimeString();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_the_program newForm = new About_the_program();
            newForm.Show();
        }

        private void инструкцияToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void прокатыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void otchet_Load(object sender, EventArgs e)
        {

        }
    }
}
