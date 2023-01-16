namespace lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int max = 0;
            var num = new List<NumericUpDown> { numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8 };
            for (int i = 0; i < num.Count - 1 ; i++)
            {
                if (max < num[i].Value)
                {
                    max = Decimal.ToInt32(num[i].Value);
                }
            }
            if (max != 0)
            {
                dataGridView1.Rows.Add(max-1);
            }

            int row = 0;
            int[] arr = { 2, 4, 6, 8, 10, 12, 20, 100 };
            Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Gold, Color.Fuchsia, Color.HotPink, Color.Gray, Color.Lavender };
            for (int i = 0; i < num.Count ; i++)
            {
                if (num[i].Value!= 0)//dice2
                {
                    int roll = Decimal.ToInt32(num[i].Value);
                    for (int j = 0; j < roll; j++)
                    {
                        Random r = new Random();
                        int random = r.Next(1, arr[i]+1);
                        dataGridView1[row, j].Value = random;
                        dataGridView1[row, j].Style.BackColor = colors[i];
                    }
                }
                row++;
            }

            
        }
    }
}