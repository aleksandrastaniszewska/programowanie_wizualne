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
            form1.dataGridView1.Rows[index].Cells[3].Value = Class1.wyd;
            form1.dataGridView1.Rows[index].Cells[4].Value = Class1.city;
            form1.dataGridView1.Rows[index].Cells[5].Value = Class1.year;
            form1.dataGridView1.Rows[index].Cells[6].Value = Class1.status;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string city1 = textBox5.Text;
            Class1.city = city1;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string year1 = textBox4.Text;
            Class1.year = year1;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status1 = comboBox1.Text;
            Class1.status = status1;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string wyd1 = textBox3.Text;
            Class1.wyd = wyd1;
        }
    }
}
