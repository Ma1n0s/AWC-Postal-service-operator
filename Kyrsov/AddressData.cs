using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsov
{
    public partial class AddressData : Form
    {
        public static Applica instance;
        public AddressData()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        Applica applica;
        private void button1_Click(object sender, EventArgs e)
        {
            AddressPost.region = comboBox1.Text;
            AddressPost.street = comboBox4.Text;
            AddressPost.city = comboBox3.Text;
            AddressPost.post_office_address = maskedTextBox1.Text;

            this.Close();
          
        }
        private void applica_Load(object sender, FormClosedEventArgs e)
        {
            applica = null;
        }

        private void AddressData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet21.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter6.Fill(this.theMailOperatorARMDataSet21.Applications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet20.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter5.Fill(this.theMailOperatorARMDataSet20.Applications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet19.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter4.Fill(this.theMailOperatorARMDataSet19.Applications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet12.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter3.Fill(this.theMailOperatorARMDataSet12.Applications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet11.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter2.Fill(this.theMailOperatorARMDataSet11.Applications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet6.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter1.Fill(this.theMailOperatorARMDataSet6.Applications);




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(51, 51, 76);
        }
    }
}
