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
        public Other2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string sqlExpression = "SELECT Correspondence.id_Correspondence, Correspondence.tip, Correspondence.Weight, Correspondence.Sum, Correspondence.Firm, Correspondence.Departure_date, Correspondence.Date_of_receiving FROM Correspondence INNER JOIN Insurance ON Insurance.id_Insurance = Correspondence.id_Insurance WHERE Correspondence.Departure_date BETWEEN @from AND @to";
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
            }*/
        }
    }
}
