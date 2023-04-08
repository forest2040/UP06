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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void GetList()
        {
            con = new SqlConnection(@"data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user57_db;persist security info=True;user id=user57_db;password=user57;MultipleActiveResultSets=True;App=EntityFramework");
            da = new SqlDataAdapter("Select *From aukcuonnaya_firma", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "aukcuonnaya_firma");
            dataGridView1.DataSource = ds.Tables["aukcuonnaya_firma"];
            con.Close();
        }

   
        // Добавление
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into MDKPredlozhenie(kod_predlozhenia,klient,rieltor,obiekt_nedvizhimosti,cena) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text +  "')";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update MDKPredlozhenie set klient='" + textBox11.Text + "',rieltor='" + textBox9.Text + "',obiekt_nedvizhimosti='" + textBox10.Text + "',cena='" + textBox8.Text + "' where kod_predlozhenia=" + textBox12.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from MDKPredlozhenie where kod_predlozhenia=" + textBox18.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet36.aukcuonnaya_firma' table. You can move, or remove it, as needed.
            this.aukcuonnaya_firmaTableAdapter.Fill(this.dataSet36.aukcuonnaya_firma);
            // TODO: This line of code loads data into the 'dataSet20.MDKPredlozhenie' table. You can move, or remove it, as needed.
            this.mDKPredlozhenieTableAdapter.Fill(this.dataSet20.MDKPredlozhenie);
            GetList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into aukcuonnaya_firma(kod_firmbl,nazvanie,adres,elektronnaya_pochta,nomer_telephona) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update aukcuonnaya_firma set nazvanie='" + textBox11.Text + "',adres='" + textBox9.Text + "',elektronnaya_pochta='" + textBox10.Text + "',nomer_telephona='" + textBox8.Text + "' where kod_firmbl=" + textBox12.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from aukcuonnaya_firma where kod_firmbl=" + textBox18.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }
    }
}
