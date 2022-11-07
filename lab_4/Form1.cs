using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap btm;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                btm = new Bitmap(ofd.FileName);
                this.pictureBox1.Image = btm;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color curColor;
            for (int i = 0; i < btm.Width; i++)
            {
                for (int j = 0; j < btm.Height; j++)
                {
                    curColor = btm.GetPixel(i, j);
                    if (curColor.R == 0 && curColor.G == 0 && curColor.B == 0)
                    {

                    }
                    else
                    {
                        btm.SetPixel(i, j, Color.White);
                    }
                }
            }

            pictureBox1.Image = btm;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Color curColor;
            for (int i = 0; i < btm.Width; i++)
            {
                for (int j = 0; j < btm.Height; j++)
                {
                    curColor = btm.GetPixel(i, j);
                    if (curColor.R < 50 && curColor.G > 150 && curColor.B < 50)
                    {

                    }
                    else
                    {
                        btm.SetPixel(i, j, Color.White);
                    }
                }
            }

            pictureBox1.Image = btm;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}