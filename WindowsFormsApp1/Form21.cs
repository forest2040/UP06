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
    public partial class Form21 : Form
    {
        public Form21()
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
            da = new SqlDataAdapter("Select *From Paroli_pokupateley", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Paroli_pokupateley");
            dataGridView1.DataSource = ds.Tables["Paroli_pokupateley"];
            con.Close();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            GetList();
        }
        // Добавление
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into paroli_prodavcov(kod_paroley,login,parol,kod_prodavca) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update paroli_prodavcov set login='" + textBox12.Text + "',parol='" + textBox11.Text + "',kod_prodavca='" + textBox9.Text + "' where kod_paroley=" + textBox14.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from paroli_prodavcov where kod_paroley=" + textBox18.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into paroli_prodavcov(kod_paroley,login,parol,kod_prodavca) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update paroli_prodavcov set login='" + textBox12.Text + "',parol='" + textBox11.Text + "',kod_prodavca='" + textBox9.Text + "' where kod_paroley=" + textBox14.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from paroli_prodavcov where kod_paroley=" + textBox18.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button4_Click_3(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            this.Hide();
        }
    }
}
