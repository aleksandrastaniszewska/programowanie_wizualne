namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filePath = "C:\\Users\\student\\source\\repos\\aleksandrastaniszewska\\programowanie_wizualne\\DataGridViewBookExport.csv";
        string filePath1 = "C:\\Users\\student\\source\\repos\\aleksandrastaniszewska\\programowanie_wizualne\\DataGridViewUserExport.csv";
        string filePath2 = "C:\\Users\\student\\source\\repos\\aleksandrastaniszewska\\programowanie_wizualne\\DataGridViewBookImport.csv";
        string filePath3 = "C:\\Users\\student\\source\\repos\\aleksandrastaniszewska\\programowanie_wizualne\\DataGridViewUserImport.csv";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var index = dataGridView1.Rows.Add();
            dataGridView1.Rows[index].Cells[0].Value = index.ToString();
            dataGridView1.Rows[index].Cells[1].Value = "test";
            dataGridView1.Rows[index].Cells[2].Value = "test";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.SelectAll();
            DataObject dataObject = dataGridView1.GetClipboardContent();
            File.WriteAllText(filePath, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            File.ReadLines(filePath2).Skip(1)
                .Select(x => x.Split(';'))
                .ToList()
                .ForEach(line => dataGridView1.Rows.Add(line.Where(e => !string.IsNullOrEmpty(e)).ToArray()));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var index = dataGridView2.Rows.Add();
            dataGridView2.Rows[index].Cells[0].Value = index.ToString();
            dataGridView2.Rows[index].Cells[1].Value = "test";
            dataGridView2.Rows[index].Cells[2].Value = "test";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView2.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView2.SelectAll();
            DataObject dataObject = dataGridView2.GetClipboardContent();
            File.WriteAllText(filePath1, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            File.ReadLines(filePath3).Skip(1)
                .Select(x => x.Split(';'))
                .ToList()
                .ForEach(line => dataGridView2.Rows.Add(line.Where(e => !string.IsNullOrEmpty(e)).ToArray()));
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}