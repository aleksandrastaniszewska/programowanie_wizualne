using System.Media;
namespace zadanie_10
{
    public partial class Form1 : Form
    {
        int currId = 0;
        SoundPlayer soundPlayer = new SoundPlayer();
        Dictionary<int, string> files = new Dictionary<int, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string musicFile = "";
            if (checkBox1.Checked)
            {
                Random number = new Random();
                musicFile = files[number.Next(0, files.Count)];
            }
            else
            {
                foreach (var key in files)
                {
                    if (Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) == key.Key)
                    {
                        musicFile = key.Value;
                    }
                }
            }
            if (musicFile != "")
            {
                soundPlayer.SoundLocation = musicFile;
                soundPlayer.Play();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                string name = fileDialog.SafeFileName;
                dataGridView1.Rows.Add(currId, path, name);
                files.Add(currId, path);
                currId++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }
    }
}