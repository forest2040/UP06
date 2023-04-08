namespace WindowsFormsApp1
{
    partial class Form17
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
            this.dataSet21 = new WindowsFormsApp1.DataSet21();
            this.mDKPotrebnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDKPotrebnostTableAdapter = new WindowsFormsApp1.DataSet21TableAdapters.MDKPotrebnostTableAdapter();
            this.klient3101TableAdapter = new WindowsFormsApp1.DataSet1TableAdapters.klient3101TableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodaukcionnyiveshiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerlotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodfirmblDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodprodavcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aukcuonnyeveshiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet34 = new WindowsFormsApp1.DataSet34();
            this.potrebnostvkvartireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet22 = new WindowsFormsApp1.DataSet22();
            this.klient3101BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.potrebnost_v_kvartireTableAdapter = new WindowsFormsApp1.DataSet22TableAdapters.Potrebnost_v_kvartireTableAdapter();
            this.aukcuonnye_veshiTableAdapter = new WindowsFormsApp1.DataSet34TableAdapters.aukcuonnye_veshiTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDKPotrebnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aukcuonnyeveshiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potrebnostvkvartireBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klient3101BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet21";
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mDKPotrebnostBindingSource
            // 
            this.mDKPotrebnostBindingSource.DataMember = "MDKPotrebnost";
            this.mDKPotrebnostBindingSource.DataSource = this.dataSet21;
            // 
            // mDKPotrebnostTableAdapter
            // 
            this.mDKPotrebnostTableAdapter.ClearBeforeFill = true;
            // 
            // klient3101TableAdapter
            // 
            this.klient3101TableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(6, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 69);
            this.button4.TabIndex = 147;
            this.button4.Text = "Выйти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
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
            this.dataGridView1.Location = new System.Drawing.Point(173, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(854, 240);
            this.dataGridView1.TabIndex = 136;
            // 
            // kodaukcionnyiveshiDataGridViewTextBoxColumn
            // 
            this.kodaukcionnyiveshiDataGridViewTextBoxColumn.DataPropertyName = "kod_aukcionnyi_veshi";
            this.kodaukcionnyiveshiDataGridViewTextBoxColumn.HeaderText = "kod_aukcionnyi_veshi";
            this.kodaukcionnyiveshiDataGridViewTextBoxColumn.Name = "kodaukcionnyiveshiDataGridViewTextBoxColumn";
            this.kodaukcionnyiveshiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomerlotaDataGridViewTextBoxColumn
            // 
            this.nomerlotaDataGridViewTextBoxColumn.DataPropertyName = "nomer_lota";
            this.nomerlotaDataGridViewTextBoxColumn.HeaderText = "nomer_lota";
            this.nomerlotaDataGridViewTextBoxColumn.Name = "nomerlotaDataGridViewTextBoxColumn";
            this.nomerlotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazvanieDataGridViewTextBoxColumn
            // 
            this.nazvanieDataGridViewTextBoxColumn.DataPropertyName = "nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.HeaderText = "nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.Name = "nazvanieDataGridViewTextBoxColumn";
            this.nazvanieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodfirmblDataGridViewTextBoxColumn
            // 
            this.kodfirmblDataGridViewTextBoxColumn.DataPropertyName = "kod_firmbl";
            this.kodfirmblDataGridViewTextBoxColumn.HeaderText = "kod_firmbl";
            this.kodfirmblDataGridViewTextBoxColumn.Name = "kodfirmblDataGridViewTextBoxColumn";
            this.kodfirmblDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodprodavcaDataGridViewTextBoxColumn
            // 
            this.kodprodavcaDataGridViewTextBoxColumn.DataPropertyName = "kod_prodavca";
            this.kodprodavcaDataGridViewTextBoxColumn.HeaderText = "kod_prodavca";
            this.kodprodavcaDataGridViewTextBoxColumn.Name = "kodprodavcaDataGridViewTextBoxColumn";
            this.kodprodavcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aukcuonnyeveshiBindingSource
            // 
            this.aukcuonnyeveshiBindingSource.DataMember = "aukcuonnye_veshi";
            this.aukcuonnyeveshiBindingSource.DataSource = this.dataSet34;
            // 
            // dataSet34
            // 
            this.dataSet34.DataSetName = "DataSet34";
            this.dataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // potrebnostvkvartireBindingSource
            // 
            this.potrebnostvkvartireBindingSource.DataMember = "Potrebnost_v_kvartire";
            this.potrebnostvkvartireBindingSource.DataSource = this.dataSet22;
            // 
            // dataSet22
            // 
            this.dataSet22.DataSetName = "DataSet22";
            this.dataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klient3101BindingSource
            // 
            this.klient3101BindingSource.DataMember = "klient3101";
            this.klient3101BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // potrebnost_v_kvartireTableAdapter
            // 
            this.potrebnost_v_kvartireTableAdapter.ClearBeforeFill = true;
            // 
            // aukcuonnye_veshiTableAdapter
            // 
            this.aukcuonnye_veshiTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(489, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 28);
            this.label2.TabIndex = 148;
            this.label2.Text = "Аукционные вещи";
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1042, 287);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form17";
            this.Text = "Форма продавца \"Аукционные вещи\"";
            this.Load += new System.EventHandler(this.Form17_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDKPotrebnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aukcuonnyeveshiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potrebnostvkvartireBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klient3101BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet21 dataSet21;
        private System.Windows.Forms.BindingSource mDKPotrebnostBindingSource;
        private DataSet21TableAdapters.MDKPotrebnostTableAdapter mDKPotrebnostTableAdapter;
        private DataSet1TableAdapters.klient3101TableAdapter klient3101TableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource klient3101BindingSource;
        private DataSet1 dataSet1;
        private DataSet22 dataSet22;
        private System.Windows.Forms.BindingSource potrebnostvkvartireBindingSource;
        private DataSet22TableAdapters.Potrebnost_v_kvartireTableAdapter potrebnost_v_kvartireTableAdapter;
        private DataSet34 dataSet34;
        private System.Windows.Forms.BindingSource aukcuonnyeveshiBindingSource;
        private DataSet34TableAdapters.aukcuonnye_veshiTableAdapter aukcuonnye_veshiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodaukcionnyiveshiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerlotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodfirmblDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodprodavcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}