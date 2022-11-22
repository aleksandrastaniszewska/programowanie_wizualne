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
        string filePath = "C:\\Users\\olasx\\source\\repos\\aleksandrastaniszewska\\programowanie_wizualne\\DataGridViewExport.csv";
        string filePath2 = "C:\\Users\\olasx\\source\\repos\\aleksandrastaniszewska\\programowanie_wizualne\\DataGridViewImport.csv";
        string filePath4 = "C:\\Users\\olasx\\source\\repos\\aleksandrastaniszewska\\programowanie_wizualne\\xmlExport.xml";
        string filePath3 = "C:\\Users\\olasx\\source\\repos\\aleksandrastaniszewska\\programowanie_wizualne\\xmlImport.xml";

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

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add(column.HeaderText);
                }
            }
            

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dT = GetDataTableFromDGV(dataGridView1);
            DataSet dS = new DataSet();
            dS.Tables.Add(dT);
            dS.WriteXml(File.OpenWrite(filePath3));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(filePath4);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}