using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (prev1 != comboBox1.SelectedIndex + 1)
            {
                sum = sum - (prev1 * 200) + ((comboBox1.SelectedIndex + 1) * 200);
                prev1 = comboBox1.SelectedIndex + 1;
                label1.Text = sum.ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (prev2 != comboBox2.SelectedIndex + 1)
            {
                sum = sum - (prev2 * 150) + ((comboBox2.SelectedIndex + 1) * 150);
                prev2 = comboBox2.SelectedIndex + 1;
                label1.Text = sum.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CloseForm3(object sender, EventArgs e)
        {
            Class1.flag3 = true;
            Class1.sum3 = sum;
        }
    }
}
