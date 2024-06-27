namespace Kyrsov
{
    partial class test
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.theMailOperatorARMDataSet22 = new Kyrsov.TheMailOperatorARMDataSet22();
            this.applicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationsTableAdapter = new Kyrsov.TheMailOperatorARMDataSet22TableAdapters.ApplicationsTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio_recipient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_recipient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_of_departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fio_recipient,
            this.phone_recipient,
            this.type_of_departure,
            this.payment});
            this.dataGridView1.DataSource = this.applicationsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(296, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 382);
            this.dataGridView1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выдать ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите пароль";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // theMailOperatorARMDataSet22
            // 
            this.theMailOperatorARMDataSet22.DataSetName = "TheMailOperatorARMDataSet22";
            this.theMailOperatorARMDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicationsBindingSource
            // 
            this.applicationsBindingSource.DataMember = "Applications";
            this.applicationsBindingSource.DataSource = this.theMailOperatorARMDataSet22;
            // 
            // applicationsTableAdapter
            // 
            this.applicationsTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // fio_recipient
            // 
            this.fio_recipient.DataPropertyName = "fio_recipient";
            this.fio_recipient.HeaderText = "ФИО получателя";
            this.fio_recipient.Name = "fio_recipient";
            // 
            // phone_recipient
            // 
            this.phone_recipient.DataPropertyName = "phone_recipient";
            this.phone_recipient.HeaderText = "Телефон получателя";
            this.phone_recipient.Name = "phone_recipient";
            // 
            // type_of_departure
            // 
            this.type_of_departure.DataPropertyName = "type_of_departure";
            this.type_of_departure.HeaderText = "Тип корреспонденции";
            this.type_of_departure.Name = "type_of_departure";
            // 
            // payment
            // 
            this.payment.DataPropertyName = "payment";
            this.payment.HeaderText = "Статус оплаты";
            this.payment.Name = "payment";
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 382);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private TheMailOperatorARMDataSet22 theMailOperatorARMDataSet22;
        private System.Windows.Forms.BindingSource applicationsBindingSource;
        private TheMailOperatorARMDataSet22TableAdapters.ApplicationsTableAdapter applicationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio_recipient;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_recipient;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_of_departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
    }
}