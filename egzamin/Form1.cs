namespace egzamin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            if(login == password)
            {
                if(login == "matematyk")
                {
                    Form2 form2 = new Form2();
                    form2.ShowDialog();

                }else if(login == "filozof")
                {
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("B³¹d");
            }
        }
    }
}