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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form13 frm = new Form13();
            frm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form23 frm = new Form23();
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form24 frm = new Form24();
            frm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form14 frm = new Form14();
            frm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form15 frm = new Form15();
            frm.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form20 frm = new Form20();
            frm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form25 frm = new Form25();
            frm.Show();
            this.Hide();
        }
    }
}
