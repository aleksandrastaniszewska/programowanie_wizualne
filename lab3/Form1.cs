using System.IO;
using System.Data;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filePath = "C:\\Users\\olasx\\source\\repos\\programowanie_wizualne\\DataGridViewExport.csv";
        string filePath2 = "C:\\Users\\olasx\\source\\repos\\programowanie_wizualne\\DataGridViewImport.csv";
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.SelectAll();
            DataObject dataObject = dataGridView1.GetClipboardContent();
            File.WriteAllText(filePath, dataObject.GetText(TextDataFormat.CommaSeparatedValue));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            File.ReadLines(filePath2).Skip(1)
                .Select(x => x.Split(','))
                .ToList()
                .ForEach(line => dataGridView1.Rows.Add(line.Where(e => !string.IsNullOrEmpty(e)).ToArray()));
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form newForm = new Form2(this);
            newForm.Show();
        }
    }
}