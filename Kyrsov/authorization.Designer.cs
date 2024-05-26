namespace Kyrsov
{
    partial class avtor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.employsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theMailOperatorARMDataSet = new Kyrsov.TheMailOperatorARMDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theMailOperatorDataSet = new Kyrsov.TheMailOperatorDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeTableAdapter = new Kyrsov.TheMailOperatorDataSetTableAdapters.EmployeeTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.employsTableAdapter = new Kyrsov.TheMailOperatorARMDataSetTableAdapters.EmploysTableAdapter();
            this.theMailOperatorARMDataSet1 = new Kyrsov.TheMailOperatorARMDataSet1();
            this.employsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employsTableAdapter1 = new Kyrsov.TheMailOperatorARMDataSet1TableAdapters.EmploysTableAdapter();
            this.theMailOperatorDataSet1 = new Kyrsov.TheMailOperatorDataSet1();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter1 = new Kyrsov.TheMailOperatorDataSet1TableAdapters.EmployeeTableAdapter();
            this.employeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.theMailOperatorDataSet2 = new Kyrsov.TheMailOperatorDataSet2();
            this.employeeTableAdapter2 = new Kyrsov.TheMailOperatorDataSet2TableAdapters.EmployeeTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.employsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // employsBindingSource
            // 
            this.employsBindingSource.DataMember = "Employs";
            this.employsBindingSource.DataSource = this.theMailOperatorARMDataSet;
            // 
            // theMailOperatorARMDataSet
            // 
            this.theMailOperatorARMDataSet.DataSetName = "TheMailOperatorARMDataSet";
            this.theMailOperatorARMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.theMailOperatorDataSet;
            // 
            // theMailOperatorDataSet
            // 
            this.theMailOperatorDataSet.DataSetName = "TheMailOperatorDataSet";
            this.theMailOperatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(99, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 26);
            this.label4.TabIndex = 44;
            this.label4.Text = "АВТОРИЗАЦИЯ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 39;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(83, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Логин";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Ошибка(текст)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(77, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Пароль";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(155, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 40;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Создать аккаунт";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(243, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 47;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // employsTableAdapter
            // 
            this.employsTableAdapter.ClearBeforeFill = true;
            // 
            // theMailOperatorARMDataSet1
            // 
            this.theMailOperatorARMDataSet1.DataSetName = "TheMailOperatorARMDataSet1";
            this.theMailOperatorARMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employsBindingSource1
            // 
            this.employsBindingSource1.DataMember = "Employs";
            this.employsBindingSource1.DataSource = this.theMailOperatorARMDataSet1;
            // 
            // employsTableAdapter1
            // 
            this.employsTableAdapter1.ClearBeforeFill = true;
            // 
            // theMailOperatorDataSet1
            // 
            this.theMailOperatorDataSet1.DataSetName = "TheMailOperatorDataSet1";
            this.theMailOperatorDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.theMailOperatorDataSet1;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // employeeBindingSource2
            // 
            this.employeeBindingSource2.DataMember = "Employee";
            this.employeeBindingSource2.DataSource = this.theMailOperatorDataSet2;
            // 
            // theMailOperatorDataSet2
            // 
            this.theMailOperatorDataSet2.DataSetName = "TheMailOperatorDataSet2";
            this.theMailOperatorDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter2
            // 
            this.employeeTableAdapter2.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(387, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 250);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // avtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(863, 647);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Name = "avtor";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.avtor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorARMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theMailOperatorDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private TheMailOperatorDataSet theMailOperatorDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private TheMailOperatorDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private TheMailOperatorARMDataSet theMailOperatorARMDataSet;
        private System.Windows.Forms.BindingSource employsBindingSource;
        private TheMailOperatorARMDataSetTableAdapters.EmploysTableAdapter employsTableAdapter;
        private TheMailOperatorARMDataSet1 theMailOperatorARMDataSet1;
        private System.Windows.Forms.BindingSource employsBindingSource1;
        private TheMailOperatorARMDataSet1TableAdapters.EmploysTableAdapter employsTableAdapter1;
        private TheMailOperatorDataSet1 theMailOperatorDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private TheMailOperatorDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private TheMailOperatorDataSet2 theMailOperatorDataSet2;
        private System.Windows.Forms.BindingSource employeeBindingSource2;
        private TheMailOperatorDataSet2TableAdapters.EmployeeTableAdapter employeeTableAdapter2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

