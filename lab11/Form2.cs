namespace lab11
{
    public partial class Form2 : Form
    {
        public Form2(string text)
        {
            InitializeComponent();
            this.label1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
