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
    public partial class AddressData2 : Form
    {
        public AddressData2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddressPost2.region2 = comboBox1.Text;
            AddressPost2.street2 = comboBox4.Text;
            AddressPost2.city2 = comboBox3.Text;
            AddressPost2.recipient_index = maskedTextBox1.Text;

            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddressData2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet14.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter3.Fill(this.theMailOperatorARMDataSet14.Applications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet13.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter2.Fill(this.theMailOperatorARMDataSet13.Applications);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet7.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter1.Fill(this.theMailOperatorARMDataSet7.Applications);

        }
    }
}
