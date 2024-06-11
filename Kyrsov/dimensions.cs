using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kyrsov
{
    public partial class dimensions : Form
    {
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
        public dimensions()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(@"E:\Kyrsov\Kyrsov\Properties\dimension-size-s.PNG");
            pictureBox1.Image = b;
            ActivateButton(sender as Control);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(@"E:\Kyrsov\Kyrsov\Properties\dimension-size-m.PNG");
            pictureBox1.Image = b;
            ActivateButton(sender as Control);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(@"E:\Kyrsov\Kyrsov\Properties\dimension-size-l.PNG");
            pictureBox1.Image = b;
            ActivateButton(sender as Control);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(@"E:\Kyrsov\Kyrsov\Properties\dimension-size-xl.PNG");
            pictureBox1.Image = b;
            ActivateButton(sender as Control);
        }
        Control SelectedButton;
        public void ActivateButton(Control control)
        {
            if (SelectedButton != null)
            {
                SelectedButton.BackColor = Color.White;
            }
            SelectedButton = control as Control;
            SelectedButton.BackColor = Color.Red;

            /*textBox1.Text = control.Text;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var arr = SelectedButton.Text.Split('x');
            State.length = double.Parse(arr[0]);
            State.width = double.Parse(arr[1]);
            State.height = double.Parse(arr[2]);

            this.Close();
        }

        private void dimensions_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            State.length = double.Parse(textBox1.Text);
            State.width = double.Parse(textBox2.Text);
            State.height = double.Parse(textBox3.Text);


            this.Close();
        }
    }
}
