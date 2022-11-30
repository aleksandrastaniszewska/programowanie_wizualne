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

namespace lab7
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private Form1 form1;
        public Form4(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name1 = textBox1.Text;
            User.imie = name1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string surname1 = textBox2.Text;
            User.nazwisko = surname1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var index = form1.dataGridView2.Rows.Add();
            User.id = index.ToString();
            form1.dataGridView2.Rows[index].Cells[0].Value = User.id;
            form1.dataGridView2.Rows[index].Cells[1].Value = User.imie;
            form1.dataGridView2.Rows[index].Cells[2].Value = User.nazwisko;
        }
    }
}
