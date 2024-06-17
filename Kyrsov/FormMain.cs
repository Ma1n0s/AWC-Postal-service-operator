using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kyrsov
{
    public partial class FormMain : Form
    {
        private string connectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperatorARM';Integrated Security=True";

        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee2 newForm = new Employee2();
            newForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Applica newForm = new Applica();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Archive newForm = new Archive();
           newForm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Archive newForm = new Archive();
            newForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            panel2.BackColor = Color.FromArgb(39, 39, 58);
        }

        private void label12_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Other2 newForm = new Other2();
            newForm.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormMain1();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public void FormMain1()
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            About_the_program newForm = new About_the_program();
            newForm.Show();
        }
    }
}
