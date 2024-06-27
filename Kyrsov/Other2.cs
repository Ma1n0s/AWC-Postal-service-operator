using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;using Excel = Microsoft.Office.Interop.Excel;

namespace Kyrsov
{
    public partial class Other2 : Form
    {
        Form form;
        public string path1 = @"E:\diplom\Kyrsov\bin\Debug\stat_otchet.xlsx";
        public Other2()
        {
            InitializeComponent();

        }
        public string connectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperatorARM';Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string sqlExpression = "SELECT Applications.id, Applications.type_of_departure, Applications.weight, Applications.price,  Applications.payment,Applications.fio_sender,Applications.dispatch_time , Applications.combustion_time FROM Applications WHERE Applications.dispatch_time BETWEEN @from AND @to";
            SqlConnection conn = new SqlConnection(connectionString);

            var fromDate = dateTimePicker1.Value;
            var toDate = dateTimePicker2.Value;

            conn.Open();
            SqlCommand command = new SqlCommand(sqlExpression, conn);
            command.Parameters.Add("@from", SqlDbType.Date).Value = fromDate;
            command.Parameters.Add("@to", SqlDbType.Date).Value = toDate;
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
                data[data.Count - 1][7] = reader[7].ToString();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Excel.Application application = new Excel.Application();
            Workbook wb = application.Workbooks.Open(path1);
            Excel._Worksheet wsh = application.ActiveSheet;

            var fromDate = dateTimePicker1.Value;
            var toDate = dateTimePicker2.Value;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            SqlCommand com = new SqlCommand("SELECT Applications.id, Applications.type_of_departure, Applications.weight, Applications.price,  Applications.payment,Applications.fio_sender,Applications.dispatch_time , Applications.combustion_time FROM Applications WHERE Applications.dispatch_time BETWEEN @from AND @to", con);

            com.Parameters.Add("@from", SqlDbType.Date).Value = fromDate;
            com.Parameters.Add("@to", SqlDbType.Date).Value = toDate;
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


    }
}
