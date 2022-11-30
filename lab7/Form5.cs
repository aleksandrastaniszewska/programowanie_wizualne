﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private Form1 form1;
        public Form5(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.textBox1.Text;
            for (int i = 0; i < form1.dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var test = form1.dataGridView2.Rows[i].Cells[j].Value;
                    string curID = (string)test;
                    if (curID == id)
                    {
                        form1.dataGridView2.Rows.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
