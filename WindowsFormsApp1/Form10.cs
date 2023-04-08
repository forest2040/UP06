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
    public partial class Form10 : Form
    {
        public Form10()
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
            da = new SqlDataAdapter("Select *From klient3101", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "klient3101");
            dataGridView1.DataSource = ds.Tables["klient3101"];
            con.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            GetList();
        }
        // Добавление
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into klient3101(kod_klienta,familiya,imya,otchestvo,nomer_telephona, elektronnaya_pochta) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update klient3101 set familiya='" + textBox11.Text + "',imya='" + textBox9.Text + "',otchestvo='" + textBox10.Text + "',nomer_telephona='" + textBox8.Text + "',elektronnaya_pochta='" + textBox7.Text + "' where kod_klienta=" + textBox12.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from klient3101 where kod_klienta=" + textBox18.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into klient3101(kod_klienta,familiya,imya,otchestvo,nomer_telephona, elektronnaya_pochta) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update klient3101 set familiya='" + textBox11.Text + "',imya='" + textBox9.Text + "',otchestvo='" + textBox10.Text + "',nomer_telephona='" + textBox8.Text + "',elektronnaya_pochta='" + textBox7.Text + "' where kod_klienta=" + textBox12.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from klient3101 where kod_klienta=" + textBox18.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
