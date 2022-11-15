using System.Diagnostics.Metrics;

namespace lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(open.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Dictionary<string, int> SeqDictionary = new Dictionary<string, int>();
            for(int i = 0; i < textBox1.Text.Length-3; i++)
            {
                string seq = textBox1.Text.Substring(i,4);
                if (SeqDictionary.ContainsKey(seq))
                {
                    SeqDictionary[seq]++;
                }
                else
                {
                    SeqDictionary.Add(seq,1);
                }
            }
            listView1.Items.Clear();
            foreach (KeyValuePair<string, int> elem in SeqDictionary)
            {
                listView1.Items.Add(string.Concat(elem.Key, " ", elem.Value));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}