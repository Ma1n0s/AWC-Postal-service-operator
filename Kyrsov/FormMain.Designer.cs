namespace Kyrsov
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnham = new System.Windows.Forms.PictureBox();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuConf = new System.Windows.Forms.FlowLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnham)).BeginInit();
            this.sideBar.SuspendLayout();
            this.menuConf.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btnham);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1557, 40);
            this.panel3.TabIndex = 17;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1264, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(293, 40);
            this.panel6.TabIndex = 22;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // btnham
            // 
            this.btnham.Image = global::Kyrsov.Properties.Resources.Menu;
            this.btnham.Location = new System.Drawing.Point(11, 7);
            this.btnham.Name = "btnham";
            this.btnham.Size = new System.Drawing.Size(28, 25);
            this.btnham.TabIndex = 20;
            this.btnham.TabStop = false;
            this.btnham.Click += new System.EventHandler(this.btnham_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sideBar.Controls.Add(this.menuConf);
            this.sideBar.Controls.Add(this.panel1);
            this.sideBar.Controls.Add(this.panel2);
            this.sideBar.Controls.Add(this.panel4);
            this.sideBar.Controls.Add(this.panel5);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sideBar.Location = new System.Drawing.Point(0, 40);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(200, 700);
            this.sideBar.TabIndex = 20;
            this.sideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // menuConf
            // 
            this.menuConf.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuConf.Controls.Add(this.button5);
            this.menuConf.Controls.Add(this.button7);
            this.menuConf.Controls.Add(this.button8);
            this.menuConf.Location = new System.Drawing.Point(3, 3);
            this.menuConf.Name = "menuConf";
            this.menuConf.Size = new System.Drawing.Size(204, 51);
            this.menuConf.TabIndex = 21;
            this.menuConf.Paint += new System.Windows.Forms.PaintEventHandler(this.menuConf_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button5.Image = global::Kyrsov.Properties.Resources.Bookmark;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 45);
            this.button5.TabIndex = 22;
            this.button5.Text = "          Главная";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button7.Image = global::Kyrsov.Properties.Resources.Check_Mark;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(3, 54);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 40);
            this.button7.TabIndex = 23;
            this.button7.Text = "          Создание и отправление ";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button8.Image = global::Kyrsov.Properties.Resources.Key;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(3, 100);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 40);
            this.button8.TabIndex = 24;
            this.button8.Text = "          Проверка и выдача";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 48);
            this.panel1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Image = global::Kyrsov.Properties.Resources.User_Male1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "          Сотрудники";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(3, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 48);
            this.panel2.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.Image = global::Kyrsov.Properties.Resources.File1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "          Архив";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(3, 168);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 48);
            this.panel4.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.Image = global::Kyrsov.Properties.Resources.Scroll;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 40);
            this.button4.TabIndex = 19;
            this.button4.Text = "          Отчётность";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button6);
            this.panel5.Location = new System.Drawing.Point(3, 222);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(202, 48);
            this.panel5.TabIndex = 25;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button6.Image = global::Kyrsov.Properties.Resources.Info;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 40);
            this.button6.TabIndex = 18;
            this.button6.Text = "          О программе";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // menu
            // 
            this.menu.Interval = 10;
            this.menu.Tick += new System.EventHandler(this.menu_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 740);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Text = "Главная форма";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnham)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.menuConf.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox btnham;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.FlowLayoutPanel menuConf;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer menu;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
    }
}