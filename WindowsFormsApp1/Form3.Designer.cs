namespace WindowsFormsApp1
{
    partial class Form3
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
            this.dataSet2 = new WindowsFormsApp1.DataSet2();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodobiektanedvizhimosiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koordinatblDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDK0501ObiektnedvizhimostiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet12 = new WindowsFormsApp1.DataSet12();
            this.rieltorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new WindowsFormsApp1.DataSet3();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rieltorTableAdapter = new WindowsFormsApp1.DataSet3TableAdapters.rieltorTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.dataSet4 = new WindowsFormsApp1.DataSet4();
            this.mDK0501ObiektnedvizhimostiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDK0501Obiekt_nedvizhimostiTableAdapter = new WindowsFormsApp1.DataSet4TableAdapters.MDK0501Obiekt_nedvizhimostiTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mDK0501Obiekt_nedvizhimostiTableAdapter1 = new WindowsFormsApp1.DataSet12TableAdapters.MDK0501Obiekt_nedvizhimostiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDK0501ObiektnedvizhimostiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDK0501ObiektnedvizhimostiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1269, 517);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 28);
            this.button3.TabIndex = 79;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(1131, 521);
            this.textBox18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(116, 21);
            this.textBox18.TabIndex = 67;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(809, 455);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 66;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodobiektanedvizhimosiDataGridViewTextBoxColumn,
            this.nazvanieDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.koordinatblDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mDK0501ObiektnedvizhimostiBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(220, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(996, 295);
            this.dataGridView1.TabIndex = 53;
            // 
            // kodobiektanedvizhimosiDataGridViewTextBoxColumn
            // 
            this.kodobiektanedvizhimosiDataGridViewTextBoxColumn.DataPropertyName = "kod_obiekta_nedvizhimosi";
            this.kodobiektanedvizhimosiDataGridViewTextBoxColumn.HeaderText = "kod_obiekta_nedvizhimosi";
            this.kodobiektanedvizhimosiDataGridViewTextBoxColumn.Name = "kodobiektanedvizhimosiDataGridViewTextBoxColumn";
            // 
            // nazvanieDataGridViewTextBoxColumn
            // 
            this.nazvanieDataGridViewTextBoxColumn.DataPropertyName = "nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.HeaderText = "nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.Name = "nazvanieDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // koordinatblDataGridViewTextBoxColumn
            // 
            this.koordinatblDataGridViewTextBoxColumn.DataPropertyName = "koordinatbl";
            this.koordinatblDataGridViewTextBoxColumn.HeaderText = "koordinatbl";
            this.koordinatblDataGridViewTextBoxColumn.Name = "koordinatblDataGridViewTextBoxColumn";
            // 
            // mDK0501ObiektnedvizhimostiBindingSource1
            // 
            this.mDK0501ObiektnedvizhimostiBindingSource1.DataMember = "MDK0501Obiekt_nedvizhimosti";
            this.mDK0501ObiektnedvizhimostiBindingSource1.DataSource = this.dataSet12;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet12";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rieltorBindingSource
            // 
            this.rieltorBindingSource.DataMember = "rieltor";
            this.rieltorBindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(369, 455);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 52;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(49, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Координаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(62, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Код объекта недвижимости";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(220, 418);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 21);
            this.textBox3.TabIndex = 43;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(220, 450);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 21);
            this.textBox4.TabIndex = 42;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(220, 386);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 21);
            this.textBox2.TabIndex = 41;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 354);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 21);
            this.textBox1.TabIndex = 40;
            // 
            // rieltorTableAdapter
            // 
            this.rieltorTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(14, 102);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 85);
            this.button4.TabIndex = 90;
            this.button4.Text = "Выйти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mDK0501ObiektnedvizhimostiBindingSource
            // 
            this.mDK0501ObiektnedvizhimostiBindingSource.DataMember = "MDK0501Obiekt_nedvizhimosti";
            this.mDK0501ObiektnedvizhimostiBindingSource.DataSource = this.dataSet4;
            // 
            // mDK0501Obiekt_nedvizhimostiTableAdapter
            // 
            this.mDK0501Obiekt_nedvizhimostiTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(504, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 103;
            this.label9.Text = "Координаты";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(517, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 102;
            this.label10.Text = "Адрес";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(502, 391);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 16);
            this.label18.TabIndex = 101;
            this.label18.Text = "Название";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(456, 354);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(213, 16);
            this.label19.TabIndex = 100;
            this.label19.Text = "Код объекта недвижимости";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(675, 418);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(116, 21);
            this.textBox11.TabIndex = 98;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(675, 450);
            this.textBox12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(116, 21);
            this.textBox12.TabIndex = 97;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(675, 386);
            this.textBox13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(116, 21);
            this.textBox13.TabIndex = 96;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(675, 354);
            this.textBox19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(116, 21);
            this.textBox19.TabIndex = 95;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(912, 523);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 16);
            this.label11.TabIndex = 109;
            this.label11.Text = "Код объекта недвижимости";
            // 
            // mDK0501Obiekt_nedvizhimostiTableAdapter1
            // 
            this.mDK0501Obiekt_nedvizhimostiTableAdapter1.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1377, 608);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Форма риелтора \"Объекты недвижимости\"";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDK0501ObiektnedvizhimostiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDK0501ObiektnedvizhimostiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet2 dataSet2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource rieltorBindingSource;
        private DataSet3TableAdapters.rieltorTableAdapter rieltorTableAdapter;
        private System.Windows.Forms.Button button4;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource mDK0501ObiektnedvizhimostiBindingSource;
        private DataSet4TableAdapters.MDK0501Obiekt_nedvizhimostiTableAdapter mDK0501Obiekt_nedvizhimostiTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodobiektanedvizhimosiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koordinatblDataGridViewTextBoxColumn;
        private DataSet12 dataSet12;
        private System.Windows.Forms.BindingSource mDK0501ObiektnedvizhimostiBindingSource1;
        private DataSet12TableAdapters.MDK0501Obiekt_nedvizhimostiTableAdapter mDK0501Obiekt_nedvizhimostiTableAdapter1;
    }
}