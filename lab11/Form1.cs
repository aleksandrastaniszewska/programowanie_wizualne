using lab11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace lab11
{
    public class Airport
    {
        public string ICAO { get; set; }
        public string IATA { get; set; }
        public int NumberOfPassengers { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
    }
    public partial class Form1 : Form
    {
        List<Airport> airportList = new List<Airport>();

        public Form1()
        {
            InitializeComponent();
            LoadAirportData();
            DisplayAirports();
        }

        private void LoadAirportData()
        {
            string filePath = "C:\\Users\\olasx\\source\\repos\\lab11\\lab11\\Dane-Testowe-1.csv";
            string fileData = File.ReadAllText(filePath);

            string[] dataSplitByEnters = fileData.Split("\n");
            string[] finalData = dataSplitByEnters.Skip(1).ToArray();

            foreach (string i in finalData)
            {
                string[] values = i.Split(",");
                Airport airport = new Airport();
                if (values.Length > 6)
                {
                    airport.City = values[0];
                    airport.Province = values[1];
                    airport.ICAO = values[2];
                    airport.IATA = values[4];
                    airport.NumberOfPassengers = Int32.Parse(values[5].Replace(" ", ""));
                    airportList.Add(airport);
                }
            }
        }

        private void DisplayAirports()
        {
            listBox1.DataSource = airportList;
            listBox1.DisplayMember = "IATA";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Airport selected = (Airport)listBox1.SelectedItem;
            string result = "";
            if (selected == null)
            {
                MessageBox.Show("Nie wybrano lotniska.");
                return;
            }
            if (checkBox1.Checked)
            {
                result += "ICAO: " + selected.ICAO + "\n";
            }
            if (checkBox2.Checked)
            {
                result += "IATA: " + selected.IATA + "\n";
            }
            if (checkBox3.Checked)
            {
                result += "Liczba pasa¿erów: " + selected.NumberOfPassengers + "\n";
            }
            if (checkBox4.Checked)
            {
                result += "Województwo: " + selected.Province + "\n";
            }
            if (checkBox5.Checked)
            {
                result += "Miasto: " + selected.City + "\n";
            }
            if (result != "")
            {
                Form2 form2 = new Form2(result);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie zaznaczono checkboxa");
                return;
            }

        }
    }
}