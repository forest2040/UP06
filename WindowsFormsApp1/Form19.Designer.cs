namespace WindowsFormsApp1
{
    partial class Form19
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
            this.dataSet10 = new WindowsFormsApp1.DataSet10();
            this.mDK0501ObiektnedvizhimostiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new WindowsFormsApp1.DataSet4();
            this.dataSet3 = new WindowsFormsApp1.DataSet3();
            this.domBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rieltorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domTableAdapter = new WindowsFormsApp1.DataSet10TableAdapters.DomTableAdapter();
            this.mDK0501Obiekt_nedvizhimostiTableAdapter = new WindowsFormsApp1.DataSet4TableAdapters.MDK0501Obiekt_nedvizhimostiTableAdapter();
            this.rieltorTableAdapter = new WindowsFormsApp1.DataSet3TableAdapters.rieltorTableAdapter();
            this.dataSet9 = new WindowsFormsApp1.DataSet9();
            this.kvartiraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kvartiraTableAdapter = new WindowsFormsApp1.DataSet9TableAdapters.KvartiraTableAdapter();
            this.dataSet2 = new WindowsFormsApp1.DataSet2();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodpokupatelyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familiyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otchestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elektronnayapochtaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomertelephonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodprodavcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uP06PokupatelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet35 = new WindowsFormsApp1.DataSet35();
            this.potrebnostvzemleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet24 = new WindowsFormsApp1.DataSet24();
            this.potrebnost_v_zemleTableAdapter = new WindowsFormsApp1.DataSet24TableAdapters.Potrebnost_v_zemleTableAdapter();
            this.uP06_PokupatelTableAdapter = new WindowsFormsApp1.DataSet35TableAdapters.UP06_PokupatelTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDK0501ObiektnedvizhimostiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvartiraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uP06PokupatelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potrebnostvzemleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet24)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet10
            // 
            this.dataSet10.DataSetName = "DataSet10";
            this.dataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // domBindingSource
            // 
            this.domBindingSource.DataMember = "Dom";
            this.domBindingSource.DataSource = this.dataSet10;
            // 
            // rieltorBindingSource
            // 
            this.rieltorBindingSource.DataMember = "rieltor";
            this.rieltorBindingSource.DataSource = this.dataSet3;
            // 
            // domTableAdapter
            // 
            this.domTableAdapter.ClearBeforeFill = true;
            // 
            // mDK0501Obiekt_nedvizhimostiTableAdapter
            // 
            this.mDK0501Obiekt_nedvizhimostiTableAdapter.ClearBeforeFill = true;
            // 
            // rieltorTableAdapter
            // 
            this.rieltorTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet9
            // 
            this.dataSet9.DataSetName = "DataSet9";
            this.dataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kvartiraBindingSource
            // 
            this.kvartiraBindingSource.DataMember = "Kvartira";
            this.kvartiraBindingSource.DataSource = this.dataSet9;
            // 
            // kvartiraTableAdapter
            // 
            this.kvartiraTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(8, 100);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 85);
            this.button4.TabIndex = 189;
            this.button4.Text = "Выйти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodpokupatelyaDataGridViewTextBoxColumn,
            this.familiyaDataGridViewTextBoxColumn,
            this.imyaDataGridViewTextBoxColumn,
            this.otchestvoDataGridViewTextBoxColumn,
            this.elektronnayapochtaDataGridViewTextBoxColumn,
            this.nomertelephonaDataGridViewTextBoxColumn,
            this.kodprodavcaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uP06PokupatelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(217, 53);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(996, 295);
            this.dataGridView1.TabIndex = 185;
            // 
            // kodpokupatelyaDataGridViewTextBoxColumn
            // 
            this.kodpokupatelyaDataGridViewTextBoxColumn.DataPropertyName = "kod_pokupatelya";
            this.kodpokupatelyaDataGridViewTextBoxColumn.HeaderText = "kod_pokupatelya";
            this.kodpokupatelyaDataGridViewTextBoxColumn.Name = "kodpokupatelyaDataGridViewTextBoxColumn";
            this.kodpokupatelyaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // familiyaDataGridViewTextBoxColumn
            // 
            this.familiyaDataGridViewTextBoxColumn.DataPropertyName = "familiya";
            this.familiyaDataGridViewTextBoxColumn.HeaderText = "familiya";
            this.familiyaDataGridViewTextBoxColumn.Name = "familiyaDataGridViewTextBoxColumn";
            this.familiyaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imyaDataGridViewTextBoxColumn
            // 
            this.imyaDataGridViewTextBoxColumn.DataPropertyName = "imya";
            this.imyaDataGridViewTextBoxColumn.HeaderText = "imya";
            this.imyaDataGridViewTextBoxColumn.Name = "imyaDataGridViewTextBoxColumn";
            this.imyaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otchestvoDataGridViewTextBoxColumn
            // 
            this.otchestvoDataGridViewTextBoxColumn.DataPropertyName = "otchestvo";
            this.otchestvoDataGridViewTextBoxColumn.HeaderText = "otchestvo";
            this.otchestvoDataGridViewTextBoxColumn.Name = "otchestvoDataGridViewTextBoxColumn";
            this.otchestvoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // elektronnayapochtaDataGridViewTextBoxColumn
            // 
            this.elektronnayapochtaDataGridViewTextBoxColumn.DataPropertyName = "elektronnaya_pochta";
            this.elektronnayapochtaDataGridViewTextBoxColumn.HeaderText = "elektronnaya_pochta";
            this.elektronnayapochtaDataGridViewTextBoxColumn.Name = "elektronnayapochtaDataGridViewTextBoxColumn";
            this.elektronnayapochtaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomertelephonaDataGridViewTextBoxColumn
            // 
            this.nomertelephonaDataGridViewTextBoxColumn.DataPropertyName = "nomer_telephona";
            this.nomertelephonaDataGridViewTextBoxColumn.HeaderText = "nomer_telephona";
            this.nomertelephonaDataGridViewTextBoxColumn.Name = "nomertelephonaDataGridViewTextBoxColumn";
            this.nomertelephonaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodprodavcaDataGridViewTextBoxColumn
            // 
            this.kodprodavcaDataGridViewTextBoxColumn.DataPropertyName = "kod_prodavca";
            this.kodprodavcaDataGridViewTextBoxColumn.HeaderText = "kod_prodavca";
            this.kodprodavcaDataGridViewTextBoxColumn.Name = "kodprodavcaDataGridViewTextBoxColumn";
            this.kodprodavcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uP06PokupatelBindingSource
            // 
            this.uP06PokupatelBindingSource.DataMember = "UP06_Pokupatel";
            this.uP06PokupatelBindingSource.DataSource = this.dataSet35;
            // 
            // dataSet35
            // 
            this.dataSet35.DataSetName = "DataSet35";
            this.dataSet35.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // potrebnostvzemleBindingSource
            // 
            this.potrebnostvzemleBindingSource.DataMember = "Potrebnost_v_zemle";
            this.potrebnostvzemleBindingSource.DataSource = this.dataSet24;
            // 
            // dataSet24
            // 
            this.dataSet24.DataSetName = "DataSet24";
            this.dataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // potrebnost_v_zemleTableAdapter
            // 
            this.potrebnost_v_zemleTableAdapter.ClearBeforeFill = true;
            // 
            // uP06_PokupatelTableAdapter
            // 
            this.uP06_PokupatelTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(607, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 28);
            this.label2.TabIndex = 190;
            this.label2.Text = "Покупатель";
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1236, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form19";
            this.Text = "Форма продавца \"БД покупателя\"";
            this.Load += new System.EventHandler(this.Form19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDK0501ObiektnedvizhimostiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rieltorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvartiraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uP06PokupatelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potrebnostvzemleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet24)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet10 dataSet10;
        private System.Windows.Forms.BindingSource mDK0501ObiektnedvizhimostiBindingSource;
        private DataSet4 dataSet4;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource domBindingSource;
        private System.Windows.Forms.BindingSource rieltorBindingSource;
        private DataSet10TableAdapters.DomTableAdapter domTableAdapter;
        private DataSet4TableAdapters.MDK0501Obiekt_nedvizhimostiTableAdapter mDK0501Obiekt_nedvizhimostiTableAdapter;
        private DataSet3TableAdapters.rieltorTableAdapter rieltorTableAdapter;
        private DataSet9 dataSet9;
        private System.Windows.Forms.BindingSource kvartiraBindingSource;
        private DataSet9TableAdapters.KvartiraTableAdapter kvartiraTableAdapter;
        private DataSet2 dataSet2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet24 dataSet24;
        private System.Windows.Forms.BindingSource potrebnostvzemleBindingSource;
        private DataSet24TableAdapters.Potrebnost_v_zemleTableAdapter potrebnost_v_zemleTableAdapter;
        private DataSet35 dataSet35;
        private System.Windows.Forms.BindingSource uP06PokupatelBindingSource;
        private DataSet35TableAdapters.UP06_PokupatelTableAdapter uP06_PokupatelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodpokupatelyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familiyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otchestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elektronnayapochtaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomertelephonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodprodavcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}