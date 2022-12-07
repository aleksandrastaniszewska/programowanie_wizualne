namespace lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string animal = comboBox2.SelectedItem.ToString();
            if (comboBox1.SelectedIndex == 0)
            {
                Form newForm = new Form2(animal);
                newForm.Show();
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                Form newForm = new Form3(animal);
                newForm.Show();
            }
            else
            {
                Form newForm = new Form4(animal);
                newForm.Show();
            }
        }
    }
}