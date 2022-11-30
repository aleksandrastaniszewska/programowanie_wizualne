using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
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
            Book.tytul = title1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string title1 = textBox1.Text;
            Book.autor = title1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var index = form1.dataGridView1.Rows.Add();
            Book.id = index.ToString();
            form1.dataGridView1.Rows[index].Cells[0].Value = Book.id;
            form1.dataGridView1.Rows[index].Cells[1].Value = Book.tytul;
            form1.dataGridView1.Rows[index].Cells[2].Value = Book.autor;
            form1.dataGridView1.Rows[index].Cells[3].Value = Book.status;
        }
    }
}
