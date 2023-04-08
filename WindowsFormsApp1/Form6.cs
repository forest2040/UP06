using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 frm = new Form14();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form27 frm = new Form27();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form22 frm = new Form22();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form16 frm = new Form16();
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form21 frm = new Form21();
            frm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form26 frm = new Form26();
            frm.Show();
            this.Hide();
        }
    }
}
