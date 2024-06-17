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
    public partial class UsersMail : Form
    {
        public UsersMail()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Other2 newForm = new Other2();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Applica newForm = new Applica();
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            About_the_program newForm = new About_the_program();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Archive newForm = new Archive();
            newForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel2.BackColor = Color.FromArgb(39, 39, 58);
            panel3.BackColor = Color.FromArgb(51, 51, 76);
        }
    }
}
