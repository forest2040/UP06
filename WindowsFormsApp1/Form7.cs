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
    public partial class Form7 : Form
    {
        public Form7()
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
            da = new SqlDataAdapter("Select *From aukcuonnye_veshi", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "aukcuonnye_veshi");
            dataGridView1.DataSource = ds.Tables["aukcuonnye_veshi"];
            con.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            GetList();
        }
        // Добавление
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into Kvartira(kod_kvartirbl,etazh,kolichestvo_komnat,ploshad) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
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
            cmd.CommandText = "update Kvartira set etazh='" + textBox7.Text + "',kolichestvo_komnat='" + textBox5.Text + "',ploshad='" + textBox6.Text +  "' where kod_kvartirbl=" + textBox8.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from Kvartira where kod_kvartirbl=" + textBox18.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into aukcuonnye_veshi(kod_aukcionnyi_veshi,nomer_lota,nazvanie,cena,kod_firmbl,kod_prodavca) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update aukcuonnye_veshi set nomer_lota='" + textBox7.Text + "',nazvanie='" + textBox5.Text + "',cena='" + textBox6.Text + "',kod_firmbl='" + textBox11.Text + "',kod_prodavca='" + textBox12.Text + "' where kod_aukcionnyi_veshi=" + textBox8.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from aukcuonnye_veshi where kod_aukcionnyi_veshi=" + textBox18.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

        }
    }
}
