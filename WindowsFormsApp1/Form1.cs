using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet31.UP06_Pokupatel' table. You can move, or remove it, as needed.
            this.uP06_PokupatelTableAdapter.Fill(this.dataSet31.UP06_Pokupatel);
            // TODO: This line of code loads data into the 'dataSet30.Pokupatel' table. You can move, or remove it, as needed.
            this.pokupatelTableAdapter.Fill(this.dataSet30.Pokupatel);
            // TODO: This line of code loads data into the 'dataSet29.prodavec' table. You can move, or remove it, as needed.
            this.prodavecTableAdapter.Fill(this.dataSet29.prodavec);
            // TODO: This line of code loads data into the 'dataSet28.aukcuonnye_veshi' table. You can move, or remove it, as needed.
            this.aukcuonnye_veshiTableAdapter.Fill(this.dataSet28.aukcuonnye_veshi);
            // TODO: This line of code loads data into the 'dataSet27.aukcuonnaya_firma' table. You can move, or remove it, as needed.
            this.aukcuonnaya_firmaTableAdapter1.Fill(this.dataSet27.aukcuonnaya_firma);
            // TODO: This line of code loads data into the 'dataSet26.aukcuonnaya_firma' table. You can move, or remove it, as needed.
            this.aukcuonnaya_firmaTableAdapter.Fill(this.dataSet26.aukcuonnaya_firma);
            // TODO: This line of code loads data into the 'dataSet17.Zemlya' table. You can move, or remove it, as needed.
            this.zemlyaTableAdapter1.Fill(this.dataSet17.Zemlya);
            // TODO: This line of code loads data into the 'dataSet16.Dom' table. You can move, or remove it, as needed.
            this.domTableAdapter1.Fill(this.dataSet16.Dom);
            // TODO: This line of code loads data into the 'dataSet15.Kvartira' table. You can move, or remove it, as needed.
            this.kvartiraTableAdapter1.Fill(this.dataSet15.Kvartira);
            // TODO: This line of code loads data into the 'dataSet14.MDK0501Obiekt_nedvizhimosti' table. You can move, or remove it, as needed.
            this.mDK0501Obiekt_nedvizhimostiTableAdapter2.Fill(this.dataSet14.MDK0501Obiekt_nedvizhimosti);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
