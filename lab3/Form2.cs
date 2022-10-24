using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace lab3
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var index = form1.dataGridView1.Rows.Add();
            Class1.id = index.ToString();
            form1.dataGridView1.Rows[index].Cells[0].Value = Class1.title;
            form1.dataGridView1.Rows[index].Cells[1].Value = Class1.author;
            form1.dataGridView1.Rows[index].Cells[2].Value = Class1.id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string title1 = textBox1.Text;
            Class1.title = title1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string author1 = textBox2.Text;
            Class1.author = author1;
        }
    }
}
