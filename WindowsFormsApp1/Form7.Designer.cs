namespace WindowsFormsApp1
{
    partial class Form7
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
            this.label11 = new System.Windows.Forms.Label();
            this.dataSet2 = new WindowsFormsApp1.DataSet2();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodaukcionnyiveshiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerlotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodfirmblDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodprodavcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aukcuonnyeveshiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet38 = new WindowsFormsApp1.DataSet38();
            this.kvartiraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet9 = new WindowsFormsApp1.DataSet9();
            this.mDK0501ObiektnedvizhimostiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new WindowsFormsApp1.DataSet4();
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
            this.mDK0501Obiekt_nedvizhimostiTableAdapter = new WindowsFormsApp1.DataSet4TableAdapters.MDK0501Obiekt_nedvizhimostiTableAdapter();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.kvartiraTableAdapter = new WindowsFormsApp1.DataSet9TableAdapters.KvartiraTableAdapter();
            this.aukcuonnye_veshiTableAdapter = new WindowsFormsApp1.DataSet38TableAdapters.aukcuonnye_veshiTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aukcuonnyeveshiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvartiraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDK0501ObiektnedvizhimostiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(929, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 16);
            this.label11.TabIndex = 144;
            this.label11.Text = "Код аукционной вещи";
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(12, 91);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 85);
            this.button4.TabIndex = 125;
            this.button4.Text = "Выйти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1226, 447);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 28);
            this.button3.TabIndex = 124;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(1104, 447);
            this.textBox18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(116, 20);
            this.textBox18.TabIndex = 123;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(809, 442);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 122;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodaukcionnyiveshiDataGridViewTextBoxColumn,
            this.nomerlotaDataGridViewTextBoxColumn,
            this.nazvanieDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.kodfirmblDataGridViewTextBoxColumn,
            this.kodprodavcaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aukcuonnyeveshiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(218, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(996, 295);
            this.dataGridView1.TabIndex = 121;
            // 
            // kodaukcionnyiveshiDataGridViewTextBoxColumn
            // 
            this.kodaukcionnyiveshiDataGridViewTextBoxColumn.DataPropertyName = "kod_aukcionnyi_veshi";
            this.kodaukcionnyiveshiDataGridViewTextBoxColumn.HeaderText = "kod_aukcionnyi_veshi";
            this.kodaukcionnyiveshiDataGridViewTextBoxColumn.Name = "kodaukcionnyiveshiDataGridViewTextBoxColumn";
            // 
            // nomerlotaDataGridViewTextBoxColumn
            // 
            this.nomerlotaDataGridViewTextBoxColumn.DataPropertyName = "nomer_lota";
            this.nomerlotaDataGridViewTextBoxColumn.HeaderText = "nomer_lota";
            this.nomerlotaDataGridViewTextBoxColumn.Name = "nomerlotaDataGridViewTextBoxColumn";
            // 
            // nazvanieDataGridViewTextBoxColumn
            // 
            this.nazvanieDataGridViewTextBoxColumn.DataPropertyName = "nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.HeaderText = "nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.Name = "nazvanieDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // kodfirmblDataGridViewTextBoxColumn
            // 
            this.kodfirmblDataGridViewTextBoxColumn.DataPropertyName = "kod_firmbl";
            this.kodfirmblDataGridViewTextBoxColumn.HeaderText = "kod_firmbl";
            this.kodfirmblDataGridViewTextBoxColumn.Name = "kodfirmblDataGridViewTextBoxColumn";
            // 
            // kodprodavcaDataGridViewTextBoxColumn
            // 
            this.kodprodavcaDataGridViewTextBoxColumn.DataPropertyName = "kod_prodavca";
            this.kodprodavcaDataGridViewTextBoxColumn.HeaderText = "kod_prodavca";
            this.kodprodavcaDataGridViewTextBoxColumn.Name = "kodprodavcaDataGridViewTextBoxColumn";
            // 
            // aukcuonnyeveshiBindingSource
            // 
            this.aukcuonnyeveshiBindingSource.DataMember = "aukcuonnye_veshi";
            this.aukcuonnyeveshiBindingSource.DataSource = this.dataSet38;
            // 
            // dataSet38
            // 
            this.dataSet38.DataSetName = "DataSet38";
            this.dataSet38.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kvartiraBindingSource
            // 
            this.kvartiraBindingSource.DataMember = "Kvartira";
            this.kvartiraBindingSource.DataSource = this.dataSet9;
            // 
            // dataSet9
            // 
            this.dataSet9.DataSetName = "DataSet9";
            this.dataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mDK0501ObiektnedvizhimostiBindingSource
            // 
            this.mDK0501ObiektnedvizhimostiBindingSource.DataMember = "MDK0501Obiekt_nedvizhimosti";
            this.mDK0501ObiektnedvizhimostiBindingSource.DataSource = this.dataSet4;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.button1.Location = new System.Drawing.Point(359, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 120;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(47, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 118;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(47, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 117;
            this.label3.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 116;
            this.label2.Text = "Номер лота";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 115;
            this.label1.Text = "Код аукционной вещи";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(218, 407);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 113;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(218, 439);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 20);
            this.textBox4.TabIndex = 112;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 375);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 111;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 343);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 110;
            // 
            // rieltorTableAdapter
            // 
            this.rieltorTableAdapter.ClearBeforeFill = true;
            // 
            // mDK0501Obiekt_nedvizhimostiTableAdapter
            // 
            this.mDK0501Obiekt_nedvizhimostiTableAdapter.ClearBeforeFill = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(676, 411);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(116, 20);
            this.textBox5.TabIndex = 148;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(676, 443);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(116, 20);
            this.textBox6.TabIndex = 147;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(676, 379);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(116, 20);
            this.textBox7.TabIndex = 146;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(676, 347);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(116, 20);
            this.textBox8.TabIndex = 145;
            // 
            // kvartiraTableAdapter
            // 
            this.kvartiraTableAdapter.ClearBeforeFill = true;
            // 
            // aukcuonnye_veshiTableAdapter
            // 
            this.aukcuonnye_veshiTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(48, 504);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 156;
            this.label9.Text = "Код продавца";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(48, 472);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 155;
            this.label10.Text = "Код фирмы";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(218, 467);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(116, 20);
            this.textBox9.TabIndex = 154;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(218, 499);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(116, 20);
            this.textBox10.TabIndex = 153;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(676, 467);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(116, 20);
            this.textBox11.TabIndex = 158;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(676, 499);
            this.textBox12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(116, 20);
            this.textBox12.TabIndex = 157;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(502, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 164;
            this.label5.Text = "Код продавца";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(502, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 163;
            this.label6.Text = "Код фирмы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(501, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 162;
            this.label7.Text = "Цена";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(501, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 161;
            this.label8.Text = "Название";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(499, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 16);
            this.label12.TabIndex = 160;
            this.label12.Text = "Номер лота";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(501, 343);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 16);
            this.label13.TabIndex = 159;
            this.label13.Text = "Код аукционной вещи";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(1153, 371);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 28);
            this.button5.TabIndex = 165;
            this.button5.Text = "Сохранить в Excel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1386, 556);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label11);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form7";
            this.Text = "Форма аукционной фирмы \"Аукционные вещи\"";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aukcuonnyeveshiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvartiraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDK0501ObiektnedvizhimostiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private DataSet2 dataSet2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mDK0501ObiektnedvizhimostiBindingSource;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource rieltorBindingSource;
        private DataSet3 dataSet3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private DataSet3TableAdapters.rieltorTableAdapter rieltorTableAdapter;
        private DataSet4TableAdapters.MDK0501Obiekt_nedvizhimostiTableAdapter mDK0501Obiekt_nedvizhimostiTableAdapter;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private DataSet9 dataSet9;
        private System.Windows.Forms.BindingSource kvartiraBindingSource;
        private DataSet9TableAdapters.KvartiraTableAdapter kvartiraTableAdapter;
        private DataSet38 dataSet38;
        private System.Windows.Forms.BindingSource aukcuonnyeveshiBindingSource;
        private DataSet38TableAdapters.aukcuonnye_veshiTableAdapter aukcuonnye_veshiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodaukcionnyiveshiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerlotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodfirmblDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodprodavcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
    }
}