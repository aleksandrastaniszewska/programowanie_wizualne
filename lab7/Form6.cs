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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private Form1 form1;
        public Form6(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string id = this.textBox1.Text;
            for (int i = 0; i < form1.dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var test = form1.dataGridView1.Rows[i].Cells[j].Value;
                    string curID = (string)test;
                    if (curID == id)
                    {
                        var test1 = form1.dataGridView1.Rows[i].Cells[3].Value;
                        string stat = (string)test1;
                        if (stat == "dostępna")
                        {
                            form1.dataGridView1.Rows[i].Cells[3].Value = "wypożyczona";
                        }
                    }
                }
            }
        }
    }
}
