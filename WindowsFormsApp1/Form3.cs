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
    public partial class Form3 : Form
    {
        public Form3()
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
            da = new SqlDataAdapter("Select *From MDK0501Obiekt_nedvizhimosti", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "MDK0501Obiekt_nedvizhimosti");
            dataGridView1.DataSource = ds.Tables["MDK0501Obiekt_nedvizhimosti"];
            con.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet12.MDK0501Obiekt_nedvizhimosti' table. You can move, or remove it, as needed.
            this.mDK0501Obiekt_nedvizhimostiTableAdapter1.Fill(this.dataSet12.MDK0501Obiekt_nedvizhimosti);
            GetList();
        }
        // Добавление
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into MDK0501Obiekt_nedvizhimosti(kod_obiekta_nedvizhimosi,nazvanie,adres,koordinatbl) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
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
            cmd.CommandText = "update MDK0501Obiekt_nedvizhimosti set nazvanie='" + textBox13.Text + "',adres='" + textBox11.Text + "',koordinatbl='" + textBox12.Text + "' where kod_obiekta_nedvizhimosi=" + textBox19.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from MDK0501Obiekt_nedvizhimosti where kod_obiekta_nedvizhimosi=" + textBox18.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }
    }
}
