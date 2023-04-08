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
    public partial class Form18 : Form
    {
        public Form18()
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
            da = new SqlDataAdapter("Select *From prodavec", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "prodavec");
            dataGridView1.DataSource = ds.Tables["prodavec"];
            con.Close();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet33.prodavec' table. You can move, or remove it, as needed.
            this.prodavecTableAdapter.Fill(this.dataSet33.prodavec);
            GetList();
        }
        // Добавление
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into prodavec(kod_potrebnosti_v_dome,min_ploshad,max_ploshad,min_kolvo_komnat,max_kolvo_komnat,min_etazhnost,max_etazhnost) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox13.Text + "')";
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
            cmd.CommandText = "update prodavec set min_ploshad='" + textBox12.Text + "',max_ploshad='" + textBox11.Text + "',min_kolvo_komnat='" + textBox9.Text + "',max_kolvo_komnat='" + textBox10.Text + "',min_etazhnost='" + textBox8.Text + "',max_etazhnost='" + textBox7.Text + "' where kod_potrebnosti_v_dome=" + textBox14.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete prodavec where kod_potrebnosti_v_dome=" + textBox18.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }
  

        private void button1_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into prodavec(kod_prodavca,familiya,imya,otchestvo,kolichestvo_tovarov,elektronnaya_pochta,nomer_telephona,kod_firmbl) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox13.Text + "','" + textBox15.Text  + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            Form15 frm = new Form15();
            frm.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update prodavec set familiya='" + textBox12.Text + "',imya='" + textBox11.Text + "',otchestvo='" + textBox9.Text + "',kolichestvo_tovarov='" + textBox10.Text + "',elektronnaya_pochta='" + textBox8.Text + "',nomer_telephona='" + textBox7.Text + "',kod_firmbl='" + textBox16.Text + "' where kod_prodavca=" + textBox14.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete prodavec where kod_prodavca=" + textBox18.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }
    }
}
