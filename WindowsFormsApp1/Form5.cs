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
using System.Configuration;
namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = this.PopulateDataGridView();
        }

        private DataTable PopulateDataGridView()
        {
            string query = "SELECT nazvanie,koordinatbl FROM MDK0501Obiekt_nedvizhimosti";
            query += " WHERE koordinatbl LIKE '%' + @koordinatbl + '%'";
            query += " OR @koordinatbl = ''";
            string constr = @"data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user57_db;persist security info=True;user id=user57_db;password=user57;MultipleActiveResultSets=True;App=EntityFramework";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@koordinatbl", textBox2.Text.Trim());
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = this.PopulateDataGridView();
        }
    }
}
