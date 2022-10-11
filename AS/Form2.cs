using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace AS
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            stopwatch1.Start();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            stopwatch1.Stop();
        }   

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = stopwatch1.Elapsed.ToString("mm\\:ss\\.ff");
        }

    }
}
