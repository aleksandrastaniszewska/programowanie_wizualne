using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.DataFormats;

namespace test2
{
    [XmlRoot("form")]
    public class FieldsToXML
    {
        [XmlElement("course")]
        public string course { get; set; }

        [XmlElement("studiesInTermOf")]
        public string studiesInTermOf { get; set; }

        [XmlElement("studiesProfile")]
        public string studiesProfile { get; set; }

        [XmlElement("studiesForm")]
        public string studiesForm { get; set; }

        [XmlElement("studiesLvl")]
        public string studiesLvl { get; set; }

        [XmlElement("firstNameTextBox")]
        public string firstNameTextBox { get; set; }

        [XmlElement("firstNameTextBox2")]
        public string firstNameTextBox2 { get; set; }

        [XmlElement("index")]
        public string index { get; set; }
        [XmlElement("index2")]
        public string index2 { get; set; }

        [XmlElement("inputDataTextBox")]
        public string inputDataTextBox { get; set; }

        [XmlElement("inputDataTextBox2")]
        public string inputDataTextBox2 { get; set; }
        [XmlElement("thesisTitleTextBox")]
        public string thesisTitleTextBox { get; set; }

        [XmlElement("englishTitleTextBox")]
        public string englishTitleTextBox { get; set; }

        [XmlElement("entryDate")]
        public string entryDate { get; set; }

        [XmlElement("scope")]
        public string scope { get; set; }

        [XmlElement("deadlineDatePicker")]
        public string deadlineDatePicker { get; set; }

        [XmlElement("promoterDataTextBox")]
        public string promoterDataTextBox { get; set; }
        [XmlElement("organization")]
        public string organization { get; set; }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filePath = "C:\\Users\\olasx\\source\\repos\\lab9\\lab9\\FormData.xml";

        private bool ValidateInput()
        {
            // Sprawdzamy, czy wszystkie pola formularza s¹ wype³nione.
            if ((string.IsNullOrEmpty(firstNameTextBox.Text) && firstNameTextBox.Text.Length < 255) ||
                !Regex.IsMatch(index.Text, @"^\d{6}$") || 
                !Regex.IsMatch(inputDataTextBox.Text, @"^\d{2}/\d{2}/\d{4}$") ||
                !Regex.IsMatch(index2.Text, @"^\d{6}$") ||
                !Regex.IsMatch(inputDataTextBox2.Text, @"^\d{2}/\d{2}/\d{4}$") ||
                !Regex.IsMatch(deadlineDatePicker.Text, @"^\d{2}/\d{2}/\d{4}$") || 
                (string.IsNullOrEmpty(firstNameTextBox2.Text) && firstNameTextBox2.Text.Length < 255) ||
                (string.IsNullOrEmpty(course.Text) && course.Text.Length < 255) || 
                (string.IsNullOrEmpty(thesisTitleTextBox.Text) && thesisTitleTextBox.Text.Length < 255) ||
                (string.IsNullOrEmpty(englishTitleTextBox.Text) && englishTitleTextBox.Text.Length < 255) ||
                (string.IsNullOrEmpty(inputDataTextBox.Text) && inputDataTextBox.Text.Length < 255) ||
                (string.IsNullOrEmpty(studiesInTermOf.Text) && studiesInTermOf.Text.Length < 255) || 
                (string.IsNullOrEmpty(studiesProfile.Text) && studiesProfile.Text.Length < 255) ||
                (string.IsNullOrEmpty(studiesForm.Text) && studiesForm.Text.Length < 255) ||
                (string.IsNullOrEmpty(studiesLvl.Text) && studiesLvl.Text.Length < 255) ||
                (string.IsNullOrEmpty(entryDate.Text) && entryDate.Text.Length < 255) ||
                (string.IsNullOrEmpty(scope.Text) && scope.Text.Length < 255) ||
                (string.IsNullOrEmpty(promoterDataTextBox.Text) && promoterDataTextBox.Text.Length < 255) || 
                (string.IsNullOrEmpty(organization.Text) && organization.Text.Length < 255)
                )
            {
                // Jeœli któreœ z pól jest puste, wyœwietlamy komunikat o b³êdzie.
                MessageBox.Show("Proszê wype³niæ wszystkie pola formularza.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                FieldsToXML newForm = new FieldsToXML
                {
                    course = course.Text,
                    studiesForm = studiesForm.Text,
                    studiesProfile = studiesProfile.Text,
                    studiesLvl = studiesLvl.Text,
                    firstNameTextBox = firstNameTextBox.Text,
                    firstNameTextBox2 = firstNameTextBox2.Text,
                    index = index.Text,
                    index2 = index2.Text,
                    inputDataTextBox = inputDataTextBox.Text,
                    inputDataTextBox2 = inputDataTextBox2.Text,
                    thesisTitleTextBox = thesisTitleTextBox.Text,
                    englishTitleTextBox = englishTitleTextBox.Text,
                    entryDate = entryDate.Text,
                    scope = scope.Text,
                    promoterDataTextBox = promoterDataTextBox.Text,
                    deadlineDatePicker = deadlineDatePicker.Text,
                    organization = organization.Text,
                    studiesInTermOf = studiesInTermOf.Text,
                };

                XmlSerializer serializer = new XmlSerializer(typeof(FieldsToXML));
                using (TextWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, newForm);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(FieldsToXML));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                FieldsToXML newData = (FieldsToXML)xmlSerializer.Deserialize(fs);
                course.Text = newData.course;
                studiesForm.Text = newData.studiesForm;
                studiesProfile.Text = newData.studiesProfile;
                studiesLvl.Text = newData.studiesLvl;
                firstNameTextBox.Text = newData.firstNameTextBox;
                firstNameTextBox2.Text = newData.firstNameTextBox2;
                index.Text = newData.index;
                index2.Text = newData.index2;
                inputDataTextBox.Text = newData.inputDataTextBox;
                inputDataTextBox2.Text = newData.inputDataTextBox2;
                thesisTitleTextBox.Text = newData.thesisTitleTextBox;
                englishTitleTextBox.Text = newData.englishTitleTextBox;
                entryDate.Text = newData.entryDate;
                scope.Text = newData.scope;
                promoterDataTextBox.Text = newData.promoterDataTextBox;
                deadlineDatePicker.Text = newData.deadlineDatePicker;
                organization.Text = newData.organization;
                studiesInTermOf.Text = newData.studiesInTermOf;
            }
        }
    }
}