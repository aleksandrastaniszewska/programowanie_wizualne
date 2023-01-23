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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            int.TryParse(textBox1.Text, out x);
            int.TryParse(textBox1.Text, out y);

            if (comboBox1.SelectedIndex == 0)
            {

                label3.Text = (Math.Sqrt(x)).ToString();

            }
            else if (comboBox1.SelectedIndex == 1)
            {

                label3.Text = (x * x).ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {

                label3.Text = (Math.Pow(x, y)).ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {

                label3.Text = (Math.Sin(x)).ToString();
            }
            else if (comboBox1.SelectedIndex == 4)
            {

                label3.Text = (Math.Cos(x)).ToString();
            }
            else if (comboBox1.SelectedIndex == 5)
            {

                label3.Text = (Math.Tan(x)).ToString();
            }
            else if (comboBox1.SelectedIndex == 6)
            {

                label3.Text = (1 / Math.Tan(x)).ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
