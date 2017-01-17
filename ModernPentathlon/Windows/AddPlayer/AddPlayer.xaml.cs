using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ModernPentathlon.Windows.AddPlayer
{
    /// <summary>
    /// Interaction logic for AddPlayer.xaml
    /// </summary>
    public partial class AddPlayer : Window
    {
        private string startTimeSwim;
        public bool cancelAddPlayer;
        private string name;
        private string surname;
        private string club;
        private string sex;
        private DateTime dateBirth;

        public string NamePlayer { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Club { get => club; set => club = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime DateBirth { get => dateBirth; set => dateBirth = value; }
        public string StartTimeSwim { get => startTimeSwim; set => startTimeSwim = value; }

        public AddPlayer()
        {
            InitializeComponent();
        }

        public AddPlayer(Code.Player p)
        {
            string sex;
            InitializeComponent();
            name_textBox.Text = p.Name;
            surname_textBox.Text = p.Surname;
            club_textBox.Text = p.Club;
            if (p.Sex == "M")
                sex = "Mężczyzna";
            else
                sex = "Kobieta";
            sex_comboBox.Text = sex;
            birthDate_datePicker.Text = p.DateBirth.ToShortDateString();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            cancelAddPlayer = true;
            Close();
        }

        private void Applybutton_Click(object sender, RoutedEventArgs e)
        {
            NamePlayer = name_textBox.Text;
            Surname = surname_textBox.Text;
            Club = club_textBox.Text;
            Sex = sex_comboBox.Text;
            startTimeSwim = swimTime_textBox.Text;
            DateBirth = new DateTime(Convert.ToInt32(birthDate_datePicker.Text.Substring(6, 4)), 
                Convert.ToInt32(birthDate_datePicker.Text.Substring(3, 2)), 
                Convert.ToInt32(birthDate_datePicker.Text.Substring(0, 2)));
            Close();
        }
    }
}
