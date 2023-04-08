namespace WindowsFormsApp1
{
    partial class Form21
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
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.klient3101TableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.klient3101TableAdapter();
            this.mDKPotrebnostTableAdapter = new WindowsFormsApp1.DataSet21TableAdapters.MDKPotrebnostTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.paroli_prodavcovTableAdapter = new WindowsFormsApp1.DataSet39TableAdapters.paroli_prodavcovTableAdapter();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.klient3101BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paroliprodavcovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet39 = new WindowsFormsApp1.DataSet39();
            this.mDKPotrebnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet21 = new WindowsFormsApp1.DataSet21();
            this.dataSet40 = new WindowsFormsApp1.DataSet40();
            this.parolipokupateleyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paroli_pokupateleyTableAdapter = new WindowsFormsApp1.DataSet40TableAdapters.Paroli_pokupateleyTableAdapter();
            this.kodparoleyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodpokupatelyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klient3101BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paroliprodavcovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDKPotrebnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parolipokupateleyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(604, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 18);
            this.label5.TabIndex = 149;
            this.label5.Text = "Код покупателя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(635, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 148;
            this.label6.Text = "Пароль";
            // 
            // klient3101TableAdapter
            // 
            this.klient3101TableAdapter.ClearBeforeFill = true;
            // 
            // mDKPotrebnostTableAdapter
            // 
            this.mDKPotrebnostTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(635, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 146;
            this.label8.Text = "Код паролей";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 310);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 127;
            // 
            // paroli_prodavcovTableAdapter
            // 
            this.paroli_prodavcovTableAdapter.ClearBeforeFill = true;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(768, 313);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 145;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(391, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 135;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(35, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 134;
            this.label4.Text = "Код покупателя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(66, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 133;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(66, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 132;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(66, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 131;
            this.label1.Text = "Код паролей";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(262, 362);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 130;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(262, 388);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 129;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 336);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 128;
            // 
            // klient3101BindingSource
            // 
            this.klient3101BindingSource.DataMember = "klient3101";
            this.klient3101BindingSource.DataSource = this.dataSet1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(635, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 147;
            this.label7.Text = "Логин";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(38, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 69);
            this.button4.TabIndex = 144;
            this.button4.Text = "Выйти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_3);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1275, 457);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 143;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_3);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(1004, 438);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 18);
            this.label18.TabIndex = 142;
            this.label18.Text = "Код паролей";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(1153, 438);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 141;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(894, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 140;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(768, 391);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 139;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(768, 339);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 137;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(768, 365);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 138;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodparoleyDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.parolDataGridViewTextBoxColumn,
            this.kodpokupatelyaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parolipokupateleyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(215, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(854, 240);
            this.dataGridView1.TabIndex = 136;
            // 
            // paroliprodavcovBindingSource
            // 
            this.paroliprodavcovBindingSource.DataMember = "paroli_prodavcov";
            this.paroliprodavcovBindingSource.DataSource = this.dataSet39;
            // 
            // dataSet39
            // 
            this.dataSet39.DataSetName = "DataSet39";
            this.dataSet39.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mDKPotrebnostBindingSource
            // 
            this.mDKPotrebnostBindingSource.DataMember = "MDKPotrebnost";
            this.mDKPotrebnostBindingSource.DataSource = this.dataSet21;
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet21";
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet40
            // 
            this.dataSet40.DataSetName = "DataSet40";
            this.dataSet40.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parolipokupateleyBindingSource
            // 
            this.parolipokupateleyBindingSource.DataMember = "Paroli_pokupateley";
            this.parolipokupateleyBindingSource.DataSource = this.dataSet40;
            // 
            // paroli_pokupateleyTableAdapter
            // 
            this.paroli_pokupateleyTableAdapter.ClearBeforeFill = true;
            // 
            // kodparoleyDataGridViewTextBoxColumn
            // 
            this.kodparoleyDataGridViewTextBoxColumn.DataPropertyName = "kod_paroley";
            this.kodparoleyDataGridViewTextBoxColumn.HeaderText = "kod_paroley";
            this.kodparoleyDataGridViewTextBoxColumn.Name = "kodparoleyDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // parolDataGridViewTextBoxColumn
            // 
            this.parolDataGridViewTextBoxColumn.DataPropertyName = "parol";
            this.parolDataGridViewTextBoxColumn.HeaderText = "parol";
            this.parolDataGridViewTextBoxColumn.Name = "parolDataGridViewTextBoxColumn";
            // 
            // kodpokupatelyaDataGridViewTextBoxColumn
            // 
            this.kodpokupatelyaDataGridViewTextBoxColumn.DataPropertyName = "kod_pokupatelya";
            this.kodpokupatelyaDataGridViewTextBoxColumn.HeaderText = "kod_pokupatelya";
            this.kodpokupatelyaDataGridViewTextBoxColumn.Name = "kodpokupatelyaDataGridViewTextBoxColumn";
            // 
            // Form21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1353, 524);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form21";
            this.Text = "Форма \"Пароли покупателей\"";
            this.Load += new System.EventHandler(this.Form21_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klient3101BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paroliprodavcovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDKPotrebnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parolipokupateleyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DataSet1TableAdapters.klient3101TableAdapter klient3101TableAdapter;
        private DataSet21TableAdapters.MDKPotrebnostTableAdapter mDKPotrebnostTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private DataSet39TableAdapters.paroli_prodavcovTableAdapter paroli_prodavcovTableAdapter;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource klient3101BindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource paroliprodavcovBindingSource;
        private DataSet39 dataSet39;
        private System.Windows.Forms.BindingSource mDKPotrebnostBindingSource;
        private DataSet21 dataSet21;
        private DataSet40 dataSet40;
        private System.Windows.Forms.BindingSource parolipokupateleyBindingSource;
        private DataSet40TableAdapters.Paroli_pokupateleyTableAdapter paroli_pokupateleyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodparoleyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodpokupatelyaDataGridViewTextBoxColumn;
    }
}