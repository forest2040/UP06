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
    public partial class Form22 : Form
    {
        public Form22()
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
            da = new SqlDataAdapter("Select *From UP06_Pokupatel", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "UP06_Pokupatel");
            dataGridView1.DataSource = ds.Tables["UP06_Pokupatel"];
            con.Close();
        }

        private void Form22_Load(object sender, EventArgs e)
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
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            Form15 frm = new Form15();
            frm.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into UP06_Pokupatel(kod_pokupatelya,familiya,imya,otchestvo,elektronnaya_pochta,nomer_telephona,kod_prodavca) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox13.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update UP06_Pokupatel set familiya='" + textBox12.Text + "',imya='" + textBox8.Text + "',otchestvo='" + textBox11.Text + "',elektronnaya_pochta='" + textBox10.Text + "',nomer_telephona='" + textBox9.Text + "',kod_prodavca='" + textBox7.Text + "' where kod_pokupatelya=" + textBox14.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete UP06_Pokupatel where kod_pokupatelya=" + textBox18.Text + "";
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
