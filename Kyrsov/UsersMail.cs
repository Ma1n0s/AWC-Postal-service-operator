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
    public partial class UsersMail : Form
    {
        test2 test2;
        test test;
        Applica applica;
        Employee2 Employee2;
        Archive Archive;
        Other2 Other2;
        About_the_program About_the_program;
        FormMain FormMain2;
        public UsersMail()
        {
            InitializeComponent();
        }
        private string connectionString = @"Data Source=DESKTOP-OK9RI9B\MSSQLSERVER1;Initial Catalog='TheMailOperatorARM';Integrated Security=True";
        private void test_Load(object sender, EventArgs e)
        {
            LoadUserData();
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
            panel2.BackColor = Color.FromArgb(39, 39, 58);
            panel3.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void btnham_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
        bool sidebarExpland = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpland)
            {
                sideBar.Width -= 10;
                if (sideBar.Width <= 40)
                {
                    sidebarExpland = false;
                    sidebarTransition.Stop();

                    button5.Width = sideBar.Width;
                    button3.Width = sideBar.Width;
                    button6.Width = sideBar.Width;
                    button4.Width = sideBar.Width;
                    menuConf.Width = sideBar.Width;
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width >= 200)
                {
                    sidebarExpland = true;
                    sidebarTransition.Stop();

                    button5.Width = sideBar.Width;
                    button3.Width = sideBar.Width;
                    button6.Width = sideBar.Width;
                    button4.Width = sideBar.Width;
                    menuConf.Width = sideBar.Width;
                }
            }
        }
        bool menuExpand = false;
        private void menu_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuConf.Height += 10;
                if (menuConf.Height >= 133)
                {
                    menu.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuConf.Height -= 10;
                if (menuConf.Height <= 53)
                {
                    menu.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Employee2 == null)
            {
                Employee2 = new Employee2();
                Employee2.FormClosed += Employee2_Load;
                Employee2.MdiParent = this;
                Employee2.Dock = DockStyle.Fill;
                Employee2.Show();
            }
            else
            {
                Employee2.Activate();
            }
        }
        private void Employee2_Load(object sender, FormClosedEventArgs e)
        {
            Employee2 = null;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (Archive == null)
            {
                Archive = new Archive();
                Archive.FormClosed += Archive_Load;
                Archive.MdiParent = this;
                Archive.Dock = DockStyle.Fill;
                Archive.Show();
            }
            else
            {
                Archive.Activate();
            }
        }
        private void Other2_Load(object sender, FormClosedEventArgs e)
        {
            Other2 = null;
        }
        private void Archive_Load(object sender, FormClosedEventArgs e)
        {
            Archive = null;
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (Other2 == null)
            {
                Other2 = new Other2();
                Other2.FormClosed += Other2_Load;
                Other2.MdiParent = this;
                Other2.Dock = DockStyle.Fill;
                Other2.Show();
            }
            else
            {
                Other2.Activate();
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (About_the_program == null)
            {
                About_the_program = new About_the_program();
                About_the_program.FormClosed += About_the_program_Load;
                About_the_program.MdiParent = this;
                About_the_program.Dock = DockStyle.Fill;
                About_the_program.Show();
            }
            else
            {
                About_the_program.Activate();
            }
        }
        private void About_the_program_Load(object sender, FormClosedEventArgs e)
        {
            About_the_program = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            menu.Start();
        }

        private void sideBar_Paint(object sender, PaintEventArgs e)
        {
            sideBar.BackColor = Color.FromArgb(23, 24, 31);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (applica == null)
            {
                applica = new Applica();
                applica.FormClosed += applica_Load;
                applica.MdiParent = this;
                applica.Dock = DockStyle.Fill;
                applica.Show();
            }
            else
            {
                applica.Activate();
            }
        }
        private void applica_Load(object sender, FormClosedEventArgs e)
        {
            applica = null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (test == null)
            {
                test = new test();
                test.FormClosed += test_Load;
                test.MdiParent = this;
                test.Dock = DockStyle.Fill;
                test.Show();
            }
            else
            {
                test.Activate();
            }
        }
        private void test_Load(object sender, FormClosedEventArgs e)
        {
            test = null;

        }
        private void LoadUserData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                label1.Text = "Вы авторизованы как: " + user.UserName;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void menuConf_Paint(object sender, PaintEventArgs e)
        {
            menuConf.BackColor = Color.FromArgb(51, 51, 76);
        }

    }
}
