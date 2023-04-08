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
    public partial class Form25 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form25()
        {
            InitializeComponent();
            con = new SqlConnection("data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user57_db;persist security info=True;user id=user57_db;password=user57;MultipleActiveResultSets=True;App=EntityFramework");
        }

        private void Form25_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
         
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
         
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
           
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            string id = textBox3.Text;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM aukcuonnaya_firma where login='" + textBox1.Text + "' AND parol='" + textBox2.Text + "' AND kod_firmbl='" + textBox3.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Вы успешно вошли");
                Form6 frm2 = new Form6();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильные данные. Проверьте логин и пароль");
            }
            con.Close();
        }

        private void button4_Click_3(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2();
            frm1.Show();
            this.Hide();
        }
    }
}
