using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egzamin
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox1.Text);
            float y = float.Parse(textBox2.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                label3.Text = (x + y).ToString();

            }else if(comboBox1.SelectedIndex == 1)
            {
                label3.Text = (x - y).ToString();
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                label3.Text = (x * y).ToString();
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                label3.Text = (x / y).ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
