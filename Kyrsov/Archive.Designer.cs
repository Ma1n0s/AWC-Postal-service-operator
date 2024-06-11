namespace Kyrsov
{
    partial class Archive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archive));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postofficeaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiosenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonesenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresssenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiorecipientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonerecipientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressrecipientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelcontentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randompasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeofdepartureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentnubmerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatchtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archiveBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.theMailOperatorARMDataSet12 = new Kyrsov.TheMailOperatorARMDataSet12();
            this.archiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theMailOperatorARMDataSet8 = new Kyrsov.TheMailOperatorARMDataSet8();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.archiveTableAdapter = new Kyrsov.TheMailOperatorARMDataSet8TableAdapters.ArchiveTableAdapter();
            this.archiveTableAdapter1 = new Kyrsov.TheMailOperatorARMDataSet12TableAdapters.ArchiveTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet8)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.postofficeaddressDataGridViewTextBoxColumn,
            this.fiosenderDataGridViewTextBoxColumn,
            this.phonesenderDataGridViewTextBoxColumn,
            this.addresssenderDataGridViewTextBoxColumn,
            this.fiorecipientDataGridViewTextBoxColumn,
            this.phonerecipientDataGridViewTextBoxColumn,
            this.addressrecipientDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.parcelcontentsDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.randompasswordDataGridViewTextBoxColumn,
            this.typeofdepartureDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.apartmentDataGridViewTextBoxColumn,
            this.apartmentnubmerDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.dispatchtimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.archiveBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(249, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 122);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postofficeaddressDataGridViewTextBoxColumn
            // 
            this.postofficeaddressDataGridViewTextBoxColumn.DataPropertyName = "post_office_address";
            this.postofficeaddressDataGridViewTextBoxColumn.HeaderText = "post_office_address";
            this.postofficeaddressDataGridViewTextBoxColumn.Name = "postofficeaddressDataGridViewTextBoxColumn";
            // 
            // fiosenderDataGridViewTextBoxColumn
            // 
            this.fiosenderDataGridViewTextBoxColumn.DataPropertyName = "fio_sender";
            this.fiosenderDataGridViewTextBoxColumn.HeaderText = "fio_sender";
            this.fiosenderDataGridViewTextBoxColumn.Name = "fiosenderDataGridViewTextBoxColumn";
            // 
            // phonesenderDataGridViewTextBoxColumn
            // 
            this.phonesenderDataGridViewTextBoxColumn.DataPropertyName = "phone_sender";
            this.phonesenderDataGridViewTextBoxColumn.HeaderText = "phone_sender";
            this.phonesenderDataGridViewTextBoxColumn.Name = "phonesenderDataGridViewTextBoxColumn";
            // 
            // addresssenderDataGridViewTextBoxColumn
            // 
            this.addresssenderDataGridViewTextBoxColumn.DataPropertyName = "address_sender";
            this.addresssenderDataGridViewTextBoxColumn.HeaderText = "address_sender";
            this.addresssenderDataGridViewTextBoxColumn.Name = "addresssenderDataGridViewTextBoxColumn";
            // 
            // fiorecipientDataGridViewTextBoxColumn
            // 
            this.fiorecipientDataGridViewTextBoxColumn.DataPropertyName = "fio_recipient";
            this.fiorecipientDataGridViewTextBoxColumn.HeaderText = "fio_recipient";
            this.fiorecipientDataGridViewTextBoxColumn.Name = "fiorecipientDataGridViewTextBoxColumn";
            // 
            // phonerecipientDataGridViewTextBoxColumn
            // 
            this.phonerecipientDataGridViewTextBoxColumn.DataPropertyName = "phone_recipient";
            this.phonerecipientDataGridViewTextBoxColumn.HeaderText = "phone_recipient";
            this.phonerecipientDataGridViewTextBoxColumn.Name = "phonerecipientDataGridViewTextBoxColumn";
            // 
            // addressrecipientDataGridViewTextBoxColumn
            // 
            this.addressrecipientDataGridViewTextBoxColumn.DataPropertyName = "address_recipient";
            this.addressrecipientDataGridViewTextBoxColumn.HeaderText = "address_recipient";
            this.addressrecipientDataGridViewTextBoxColumn.Name = "addressrecipientDataGridViewTextBoxColumn";
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // parcelcontentsDataGridViewTextBoxColumn
            // 
            this.parcelcontentsDataGridViewTextBoxColumn.DataPropertyName = "parcel_contents";
            this.parcelcontentsDataGridViewTextBoxColumn.HeaderText = "parcel_contents";
            this.parcelcontentsDataGridViewTextBoxColumn.Name = "parcelcontentsDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // randompasswordDataGridViewTextBoxColumn
            // 
            this.randompasswordDataGridViewTextBoxColumn.DataPropertyName = "random_password";
            this.randompasswordDataGridViewTextBoxColumn.HeaderText = "random_password";
            this.randompasswordDataGridViewTextBoxColumn.Name = "randompasswordDataGridViewTextBoxColumn";
            // 
            // typeofdepartureDataGridViewTextBoxColumn
            // 
            this.typeofdepartureDataGridViewTextBoxColumn.DataPropertyName = "type_of_departure";
            this.typeofdepartureDataGridViewTextBoxColumn.HeaderText = "type_of_departure";
            this.typeofdepartureDataGridViewTextBoxColumn.Name = "typeofdepartureDataGridViewTextBoxColumn";
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "payment";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "region";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            // 
            // apartmentDataGridViewTextBoxColumn
            // 
            this.apartmentDataGridViewTextBoxColumn.DataPropertyName = "apartment";
            this.apartmentDataGridViewTextBoxColumn.HeaderText = "apartment";
            this.apartmentDataGridViewTextBoxColumn.Name = "apartmentDataGridViewTextBoxColumn";
            // 
            // apartmentnubmerDataGridViewTextBoxColumn
            // 
            this.apartmentnubmerDataGridViewTextBoxColumn.DataPropertyName = "apartment_nubmer";
            this.apartmentnubmerDataGridViewTextBoxColumn.HeaderText = "apartment_nubmer";
            this.apartmentnubmerDataGridViewTextBoxColumn.Name = "apartmentnubmerDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // dispatchtimeDataGridViewTextBoxColumn
            // 
            this.dispatchtimeDataGridViewTextBoxColumn.DataPropertyName = "dispatch_time";
            this.dispatchtimeDataGridViewTextBoxColumn.HeaderText = "dispatch_time";
            this.dispatchtimeDataGridViewTextBoxColumn.Name = "dispatchtimeDataGridViewTextBoxColumn";
            // 
            // archiveBindingSource1
            // 
            this.archiveBindingSource1.DataMember = "Archive";
            this.archiveBindingSource1.DataSource = this.theMailOperatorARMDataSet12;
            // 
            // theMailOperatorARMDataSet12
            // 
            this.theMailOperatorARMDataSet12.DataSetName = "TheMailOperatorARMDataSet12";
            this.theMailOperatorARMDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // archiveBindingSource
            // 
            this.archiveBindingSource.DataMember = "Archive";
            this.archiveBindingSource.DataSource = this.theMailOperatorARMDataSet8;
            // 
            // theMailOperatorARMDataSet8
            // 
            this.theMailOperatorARMDataSet8.DataSetName = "TheMailOperatorARMDataSet8";
            this.theMailOperatorARMDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вернуть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // archiveTableAdapter
            // 
            this.archiveTableAdapter.ClearBeforeFill = true;
            // 
            // archiveTableAdapter1
            // 
            this.archiveTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 450);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(118, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 100);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 100);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Archive";
            this.Text = "Archive";
            this.Load += new System.EventHandler(this.Archive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private TheMailOperatorARMDataSet8 theMailOperatorARMDataSet8;
        private System.Windows.Forms.BindingSource archiveBindingSource;
        private TheMailOperatorARMDataSet8TableAdapters.ArchiveTableAdapter archiveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postofficeaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiosenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonesenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresssenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiorecipientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonerecipientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressrecipientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelcontentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randompasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeofdepartureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentnubmerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatchtimeDataGridViewTextBoxColumn;
        private TheMailOperatorARMDataSet12 theMailOperatorARMDataSet12;
        private System.Windows.Forms.BindingSource archiveBindingSource1;
        private TheMailOperatorARMDataSet12TableAdapters.ArchiveTableAdapter archiveTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}