namespace Kyrsov
{
    partial class AddressData2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressData2));
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.applicationsTableAdapter = new Kyrsov.TheMailOperatorARMDataSet3TableAdapters.ApplicationsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.theMailOperatorARMDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.applicationsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.theMailOperatorARMDataSet7 = new Kyrsov.TheMailOperatorARMDataSet7();
            this.applicationsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.theMailOperatorARMDataSet3 = new Kyrsov.TheMailOperatorARMDataSet3();
            this.applicationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.applicationsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.applicationsTableAdapter1 = new Kyrsov.TheMailOperatorARMDataSet7TableAdapters.ApplicationsTableAdapter();
            this.theMailOperatorARMDataSet13 = new Kyrsov.TheMailOperatorARMDataSet13();
            this.applicationsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.applicationsTableAdapter2 = new Kyrsov.TheMailOperatorARMDataSet13TableAdapters.ApplicationsTableAdapter();
            this.theMailOperatorARMDataSet14 = new Kyrsov.TheMailOperatorARMDataSet14();
            this.applicationsBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.applicationsTableAdapter3 = new Kyrsov.TheMailOperatorARMDataSet14TableAdapters.ApplicationsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(22, 144);
            this.maskedTextBox1.Mask = "000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(45, 20);
            this.maskedTextBox1.TabIndex = 36;
            this.maskedTextBox1.ValidatingType = typeof(int);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // applicationsTableAdapter
            // 
            this.applicationsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 35);
            this.panel1.TabIndex = 35;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 34;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Индекс почтового отделения";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.applicationsBindingSource6;
            this.comboBox3.DisplayMember = "city2";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(72, 76);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 31;
            // 
            // applicationsBindingSource4
            // 
            this.applicationsBindingSource4.DataMember = "Applications";
            this.applicationsBindingSource4.DataSource = this.theMailOperatorARMDataSet7;
            // 
            // theMailOperatorARMDataSet7
            // 
            this.theMailOperatorARMDataSet7.DataSetName = "TheMailOperatorARMDataSet7";
            this.theMailOperatorARMDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicationsBindingSource3
            // 
            this.applicationsBindingSource3.DataMember = "Applications";
            this.applicationsBindingSource3.DataSource = this.theMailOperatorARMDataSet3;
            // 
            // theMailOperatorARMDataSet3
            // 
            this.theMailOperatorARMDataSet3.DataSetName = "TheMailOperatorARMDataSet3";
            this.theMailOperatorARMDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.applicationsBindingSource5;
            this.comboBox4.DisplayMember = "street2";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(72, 103);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.applicationsBindingSource4;
            this.comboBox1.DisplayMember = "region2";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Улица";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "город";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Область";
            // 
            // applicationsTableAdapter1
            // 
            this.applicationsTableAdapter1.ClearBeforeFill = true;
            // 
            // theMailOperatorARMDataSet13
            // 
            this.theMailOperatorARMDataSet13.DataSetName = "TheMailOperatorARMDataSet13";
            this.theMailOperatorARMDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicationsBindingSource5
            // 
            this.applicationsBindingSource5.DataMember = "Applications";
            this.applicationsBindingSource5.DataSource = this.theMailOperatorARMDataSet13;
            // 
            // applicationsTableAdapter2
            // 
            this.applicationsTableAdapter2.ClearBeforeFill = true;
            // 
            // theMailOperatorARMDataSet14
            // 
            this.theMailOperatorARMDataSet14.DataSetName = "TheMailOperatorARMDataSet14";
            this.theMailOperatorARMDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicationsBindingSource6
            // 
            this.applicationsBindingSource6.DataMember = "Applications";
            this.applicationsBindingSource6.DataSource = this.theMailOperatorARMDataSet14;
            // 
            // applicationsTableAdapter3
            // 
            this.applicationsTableAdapter3.ClearBeforeFill = true;
            // 
            // AddressData2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 227);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddressData2";
            this.Text = "Введите данные";
            this.Load += new System.EventHandler(this.AddressData2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private TheMailOperatorARMDataSet3TableAdapters.ApplicationsTableAdapter applicationsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource theMailOperatorARMDataSet4BindingSource;
        private System.Windows.Forms.BindingSource applicationsBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource applicationsBindingSource3;
        private TheMailOperatorARMDataSet3 theMailOperatorARMDataSet3;
        private System.Windows.Forms.BindingSource applicationsBindingSource1;
        private System.Windows.Forms.BindingSource applicationsBindingSource2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private TheMailOperatorARMDataSet7 theMailOperatorARMDataSet7;
        private System.Windows.Forms.BindingSource applicationsBindingSource4;
        private TheMailOperatorARMDataSet7TableAdapters.ApplicationsTableAdapter applicationsTableAdapter1;
        private TheMailOperatorARMDataSet13 theMailOperatorARMDataSet13;
        private System.Windows.Forms.BindingSource applicationsBindingSource5;
        private TheMailOperatorARMDataSet13TableAdapters.ApplicationsTableAdapter applicationsTableAdapter2;
        private TheMailOperatorARMDataSet14 theMailOperatorARMDataSet14;
        private System.Windows.Forms.BindingSource applicationsBindingSource6;
        private TheMailOperatorARMDataSet14TableAdapters.ApplicationsTableAdapter applicationsTableAdapter3;
    }
}