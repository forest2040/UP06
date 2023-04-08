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
    public partial class Form17 : Form
    {
        public Form17()
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

        private void Form17_Load(object sender, EventArgs e)
        {
            GetList();
        }
      

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form15 frm = new Form15();
            frm.Show();
            this.Hide();
        }
    }
}
