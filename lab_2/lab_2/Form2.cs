using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_2
{
    public partial class Form2 : Form
    {
        int prev=-1;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                sum += 15;
            }
            else
            {
                sum -= 15;
            }
            label1.Text = sum.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                sum += 25;
            }
            else
            {
                sum -= 25;
            }
            label1.Text = sum.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                sum += 35;
            }
            else
            {
                sum -= 35;
            }
            label1.Text = sum.ToString();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (prev != comboBox1.SelectedIndex + 1)
            {
                sum = sum - (prev * 100) + ((comboBox1.SelectedIndex + 1) * 100);
                prev = comboBox1.SelectedIndex + 1;
                label1.Text = sum.ToString();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                sum += 10;
            }
            else
            {
                sum -= 10;
            }
            label1.Text = sum.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                sum += 20;
            }
            else
            {
                sum -= 20;
            }
            label1.Text = sum.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                sum += 30;
            }
            else
            {
                sum -= 30;
            }
            label1.Text = sum.ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                sum += 40;
            }
            else
            {
                sum -= 40;
            }
            label1.Text = sum.ToString();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                sum += 50;
            }
            else
            {
                sum -= 50;
            }
            label1.Text = sum.ToString();
        }

        private void CloseForm2(object sender, EventArgs e)
        {
            Class1.flag2 = true;
            Class1.sum2 = sum;
        }
    }
}
