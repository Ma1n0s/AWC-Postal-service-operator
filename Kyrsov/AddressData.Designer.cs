namespace Kyrsov
{
    partial class AddressData
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.applicationsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.theMailOperatorARMDataSet11 = new Kyrsov.TheMailOperatorARMDataSet11();
            this.applicationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.theMailOperatorARMDataSet6 = new Kyrsov.TheMailOperatorARMDataSet6();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.applicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theMailOperatorARMDataSet5 = new Kyrsov.TheMailOperatorARMDataSet5();
            this.theMailOperatorARMDataSet4 = new Kyrsov.TheMailOperatorARMDataSet4();
            this.theMailOperatorARMDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationsTableAdapter = new Kyrsov.TheMailOperatorARMDataSet5TableAdapters.ApplicationsTableAdapter();
            this.applicationsTableAdapter1 = new Kyrsov.TheMailOperatorARMDataSet6TableAdapters.ApplicationsTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.applicationsTableAdapter2 = new Kyrsov.TheMailOperatorARMDataSet11TableAdapters.ApplicationsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Область";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "город";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Улица";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Квартира";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Номер квартиры";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.applicationsBindingSource2;
            this.comboBox1.DisplayMember = "region";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // applicationsBindingSource2
            // 
            this.applicationsBindingSource2.DataMember = "Applications";
            this.applicationsBindingSource2.DataSource = this.theMailOperatorARMDataSet11;
            // 
            // theMailOperatorARMDataSet11
            // 
            this.theMailOperatorARMDataSet11.DataSetName = "TheMailOperatorARMDataSet11";
            this.theMailOperatorARMDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicationsBindingSource1
            // 
            this.applicationsBindingSource1.DataMember = "Applications";
            this.applicationsBindingSource1.DataSource = this.theMailOperatorARMDataSet6;
            // 
            // theMailOperatorARMDataSet6
            // 
            this.theMailOperatorARMDataSet6.DataSetName = "TheMailOperatorARMDataSet6";
            this.theMailOperatorARMDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.applicationsBindingSource2;
            this.comboBox3.DisplayMember = "city";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(108, 94);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 8;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.applicationsBindingSource2;
            this.comboBox4.DisplayMember = "street";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(108, 121);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(208, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Индекс почтового отделения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // applicationsBindingSource
            // 
            this.applicationsBindingSource.DataMember = "Applications";
            this.applicationsBindingSource.DataSource = this.theMailOperatorARMDataSet5;
            // 
            // theMailOperatorARMDataSet5
            // 
            this.theMailOperatorARMDataSet5.DataSetName = "TheMailOperatorARMDataSet5";
            this.theMailOperatorARMDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // theMailOperatorARMDataSet4
            // 
            this.theMailOperatorARMDataSet4.DataSetName = "TheMailOperatorARMDataSet4";
            this.theMailOperatorARMDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // theMailOperatorARMDataSet4BindingSource
            // 
            this.theMailOperatorARMDataSet4BindingSource.DataSource = this.theMailOperatorARMDataSet4;
            this.theMailOperatorARMDataSet4BindingSource.Position = 0;
            // 
            // applicationsTableAdapter
            // 
            this.applicationsTableAdapter.ClearBeforeFill = true;
            // 
            // applicationsTableAdapter1
            // 
            this.applicationsTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.applicationsBindingSource2;
            this.comboBox2.DisplayMember = "post_office_address";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(105, 216);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // applicationsTableAdapter2
            // 
            this.applicationsTableAdapter2.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 48);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AddressData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 306);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddressData";
            this.Text = "AddressData";
            this.Load += new System.EventHandler(this.AddressData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet4BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource theMailOperatorARMDataSet4BindingSource;
        private TheMailOperatorARMDataSet4 theMailOperatorARMDataSet4;
        private TheMailOperatorARMDataSet5 theMailOperatorARMDataSet5;
        private System.Windows.Forms.BindingSource applicationsBindingSource;
        private TheMailOperatorARMDataSet5TableAdapters.ApplicationsTableAdapter applicationsTableAdapter;
        private TheMailOperatorARMDataSet6 theMailOperatorARMDataSet6;
        private System.Windows.Forms.BindingSource applicationsBindingSource1;
        private TheMailOperatorARMDataSet6TableAdapters.ApplicationsTableAdapter applicationsTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox2;
        private TheMailOperatorARMDataSet11 theMailOperatorARMDataSet11;
        private System.Windows.Forms.BindingSource applicationsBindingSource2;
        private TheMailOperatorARMDataSet11TableAdapters.ApplicationsTableAdapter applicationsTableAdapter2;
        private System.Windows.Forms.Panel panel1;
    }
}