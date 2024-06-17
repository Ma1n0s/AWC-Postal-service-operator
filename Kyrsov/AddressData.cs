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
        
        private void button1_Click(object sender, EventArgs e)
        {
            AddressPost.region = comboBox1.Text;
            AddressPost.apartment = comboBox6.Text;
            AddressPost.apartment_nubmer = comboBox5.Text;
            AddressPost.street = comboBox4.Text;
            AddressPost.city = comboBox3.Text;
            AddressPost.post_office_address = textBox1.Text;

            this.Close();
        }

        private void AddressData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theMailOperatorARMDataSet3.Applications". При необходимости она может быть перемещена или удалена.
            this.applicationsTableAdapter.Fill(this.theMailOperatorARMDataSet3.Applications);



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(51, 51, 76);
        }
    }
}
