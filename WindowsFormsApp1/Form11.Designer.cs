namespace WindowsFormsApp1
{
    partial class Form11
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
            this.rieltorTableAdapter = new WindowsFormsApp1.DataSet3TableAdapters.rieltorTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodrieltoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otchestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolyaotkomisiiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rieltorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new WindowsFormsApp1.DataSet3();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet2 = new WindowsFormsApp1.DataSet2();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // rieltorTableAdapter
            // 
            this.rieltorTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(29, 100);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 85);
            this.button4.TabIndex = 125;
            this.button4.Text = "Выйти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(947, 490);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 16);
            this.label15.TabIndex = 120;
            this.label15.Text = "Код риелтора";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(499, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 119;
            this.label6.Text = "Доля от комиссии";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(514, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 118;
            this.label7.Text = "Отчество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(527, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 117;
            this.label8.Text = "Имя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(512, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 116;
            this.label9.Text = "Фамилия";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(512, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 16);
            this.label10.TabIndex = 115;
            this.label10.Text = "Код риелтора";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1260, 514);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 28);
            this.button3.TabIndex = 114;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(1103, 488);
            this.textBox18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(116, 20);
            this.textBox18.TabIndex = 109;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(815, 514);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 108;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(671, 485);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(116, 20);
            this.textBox8.TabIndex = 107;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(671, 421);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(116, 20);
            this.textBox9.TabIndex = 106;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(671, 453);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(116, 20);
            this.textBox10.TabIndex = 105;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(671, 389);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(116, 20);
            this.textBox11.TabIndex = 104;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(671, 357);
            this.textBox12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(116, 20);
            this.textBox12.TabIndex = 103;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodrieltoraDataGridViewTextBoxColumn,
            this.familiyaDataGridViewTextBoxColumn,
            this.imyaDataGridViewTextBoxColumn,
            this.otchestvoDataGridViewTextBoxColumn,
            this.dolyaotkomisiiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rieltorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(235, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(996, 295);
            this.dataGridView1.TabIndex = 102;
            // 
            // kodrieltoraDataGridViewTextBoxColumn
            // 
            this.kodrieltoraDataGridViewTextBoxColumn.DataPropertyName = "kod_rieltora";
            this.kodrieltoraDataGridViewTextBoxColumn.HeaderText = "kod_rieltora";
            this.kodrieltoraDataGridViewTextBoxColumn.Name = "kodrieltoraDataGridViewTextBoxColumn";
            // 
            // familiyaDataGridViewTextBoxColumn
            // 
            this.familiyaDataGridViewTextBoxColumn.DataPropertyName = "familiya";
            this.familiyaDataGridViewTextBoxColumn.HeaderText = "familiya";
            this.familiyaDataGridViewTextBoxColumn.Name = "familiyaDataGridViewTextBoxColumn";
            // 
            // imyaDataGridViewTextBoxColumn
            // 
            this.imyaDataGridViewTextBoxColumn.DataPropertyName = "imya";
            this.imyaDataGridViewTextBoxColumn.HeaderText = "imya";
            this.imyaDataGridViewTextBoxColumn.Name = "imyaDataGridViewTextBoxColumn";
            // 
            // otchestvoDataGridViewTextBoxColumn
            // 
            this.otchestvoDataGridViewTextBoxColumn.DataPropertyName = "otchestvo";
            this.otchestvoDataGridViewTextBoxColumn.HeaderText = "otchestvo";
            this.otchestvoDataGridViewTextBoxColumn.Name = "otchestvoDataGridViewTextBoxColumn";
            // 
            // dolyaotkomisiiDataGridViewTextBoxColumn
            // 
            this.dolyaotkomisiiDataGridViewTextBoxColumn.DataPropertyName = "dolya_ot_komisii";
            this.dolyaotkomisiiDataGridViewTextBoxColumn.HeaderText = "dolya_ot_komisii";
            this.dolyaotkomisiiDataGridViewTextBoxColumn.Name = "dolyaotkomisiiDataGridViewTextBoxColumn";
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
            this.button1.Location = new System.Drawing.Point(380, 509);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 101;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(49, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 100;
            this.label5.Text = "Доля от комиссии";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(64, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 99;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(77, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 98;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(62, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 97;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 96;
            this.label1.Text = "Код риелтора";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(235, 480);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(116, 20);
            this.textBox5.TabIndex = 95;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(235, 416);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 94;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(235, 448);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 20);
            this.textBox4.TabIndex = 93;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 384);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 20);
            this.textBox2.TabIndex = 92;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 352);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 91;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1358, 551);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form11";
            this.Text = "Форма \"Риелтор\"";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet3TableAdapters.rieltorTableAdapter rieltorTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodrieltoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otchestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolyaotkomisiiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rieltorBindingSource;
        private DataSet3 dataSet3;
        private System.Windows.Forms.Button button1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}