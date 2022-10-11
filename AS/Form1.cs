namespace AS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form newForm = new Form2();
            Form lastForm = new Form1();
            lastForm.Hide();
            newForm.Show(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("hh:mm");
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}