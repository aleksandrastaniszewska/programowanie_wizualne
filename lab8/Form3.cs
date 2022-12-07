using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form3 : Form
    {
        int size = 4;
        string type;
        int id, id2;
        private System.Windows.Forms.Timer time;
        bool displayed = false;
        List<string> animals = new List<string>();

        public Form3(string animal)
        {
            type = animal;
            Random rnd = new Random();
            id = rnd.Next(0, 9);
            id2 = rnd.Next(0, 9);
            while (id == id2)
            {
                id2 = rnd.Next(0, 9);
            }
            InitializeComponent();
            this.Shown += board;
            time = new System.Windows.Forms.Timer();
            time.Tick += delegate {
                if (!this.displayed)
                {
                    Form5 form5 = new Form5("Przegrales");
                    form5.Show();
                    time.Stop();
                }
            };
            time.Interval = (int)TimeSpan.FromSeconds(3).TotalMilliseconds;
            time.Start();
        }

        private void click_button(object sender, EventArgs e)
        {
            var currBtn = sender as Button;
            if (int.Parse(currBtn.Text.Substring(0)) == id)
            {
                currBtn.Text = type;
                Form5 form5 = new Form5("Wygrales");
                form5.Show();
                displayed = true;

            }
            else if (int.Parse(currBtn.Text.Substring(0)) == id2)
            {
                currBtn.Text = "Krokodyl";
                Random rnd = new Random();
                int chance = rnd.Next(0, 2);
                if (chance == 0)
                {
                    Form5 form5 = new Form5("Przegrales");
                    form5.Show();
                    displayed = true;

                }
            }
            else
            {
                animals.Add("pies");
                animals.Add("kot");
                animals.Add("ptak");
                Random rnd = new Random();
                int an = rnd.Next(0, 3);
                while (animals[an] == type)
                {
                    an = rnd.Next(0, 3);
                }
                currBtn.Text = animals[an];
            }
        }
        private void board(object sender, EventArgs e)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Button newBtn = new Button();
                    this.Controls.Add(newBtn);
                    newBtn.Text = ((i * size) + j).ToString();
                    newBtn.Location = new Point(i * 100, j * 100);
                    newBtn.Size = new Size(100, 100);
                    newBtn.Click += click_button;
                }
            }
            this.ClientSize = new System.Drawing.Size(size * 100, size * 100);
        }
    }
}
