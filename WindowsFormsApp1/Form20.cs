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
    public partial class Form20 : Form
    {
        public Form20()
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
            da = new SqlDataAdapter("Select *From bd_aukcuonnoy_firmbl", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "bd_aukcuonnoy_firmbl");
            dataGridView1.DataSource = ds.Tables["bd_aukcuonnoy_firmbl"];
            con.Close();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            GetList();
        }
        // Добавление
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into Sdelka(kod_potrebnosti_v_zemle,min_ploshad,max_ploshad) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "')";
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
            cmd.CommandText = "update Potrebnost_v_zemle set min_ploshad='" + textBox7.Text + "',max_ploshad'" + textBox5.Text + "' where kod_potrebnosti_v_zemle=" + textBox8.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from Potrebnost_v_zemle where kod_potrebnosti_v_zemle=" + textBox18.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from Sdelka where kod_sdelki=" + textBox18.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into bd_aukcuonnoy_firmbl(kod_bd,informacia_ob_aukcuone,informacia_o_predmetah,kod_firmbl) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update bd_aukcuonnoy_firmbl set informacia_ob_aukcuone='" + textBox7.Text + "',informacia_o_predmetah='" + textBox5.Text + "',kod_firmbl='" + textBox6.Text + "' where kod_bd=" + textBox8.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from bd_aukcuonnoy_firmbl where kod_bd=" + textBox18.Text + "";
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
    }
}
