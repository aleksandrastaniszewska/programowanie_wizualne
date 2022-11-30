using System.Data;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filePath = "C:\\Users\\olasx\\source\\repos\\aleksandrastaniszewska\\programowanie_wizualne\\DataGridViewBookExport.xml";
        string filePath1 = "C:\\Users\\olasx\\source\\repos\\aleksandrastaniszewska\\programowanie_wizualne\\DataGridViewBookImport.xml";
        string filePath2 = "C:\\Users\\olasx\\source\\repos\\aleksandrastaniszewska\\programowanie_wizualne\\DataGridViewUserExport.xml";
        string filePath3 = "C:\\Users\\olasx\\source\\repos\\aleksandrastaniszewska\\programowanie_wizualne\\DataGridViewUserImport.xml";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form newForm = new Form2(this);
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form newForm = new Form3(this);
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

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dT = GetDataTableFromDGV(dataGridView1);
            DataSet dS = new DataSet();
            dS.Tables.Add(dT);
            dS.WriteXml(File.OpenWrite(filePath));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(filePath1);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form newForm = new Form4(this);
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form newForm = new Form5(this);
            newForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dT = GetDataTableFromDGV(dataGridView2);
            DataSet dS = new DataSet();
            dS.Tables.Add(dT);
            dS.WriteXml(File.OpenWrite(filePath2));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(filePath3);
            dataGridView2.Columns.Clear();
            dataGridView2.DataSource = dataSet.Tables[0];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form newForm = new Form6(this);
            newForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form newForm = new Form7(this);
            newForm.Show();
        }
    }
}