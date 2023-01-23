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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath1 = "C:Users\\students\\Desktop\\test.csv";
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.SelectAll();
            DataObject dataObject = dataGridView1.GetClipboardContent();
            File.WriteAllText(filePath1, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int w = Int32.Parse(textBox1.Text);
            int k = Int32.Parse(textBox2.Text);
            dataGridView1.Rows.Add(w);
            
            for (int i = 0; i < k; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                dataGridView1.Columns.Add(column);
            }

            if(comboBox1.SelectedIndex == 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    row.DefaultCellStyle.BackColor = Color.Red;
            }else if(comboBox1.SelectedIndex == 1)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    row.DefaultCellStyle.BackColor = Color.Blue;
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    row.DefaultCellStyle.BackColor = Color.Green;
            }
            
        }
    }
}
