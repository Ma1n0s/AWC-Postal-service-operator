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
    public partial class FormMain : Form
    {
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
            Applications newForm = new Applications();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Other2 newForm = new Other2();
            newForm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Applications newForm = new Applications();
            newForm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Archive newForm = new Archive();
            newForm.Show();
        }
    }
}
