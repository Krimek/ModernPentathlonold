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

namespace ModernPentathlon.Windows.NewCompetition
{
    /// <summary>
    /// Interaction logic for NewCompetition.xaml
    /// </summary>
    public partial class NewCompetition : Window
    {
        Page1NewCompetition p1;
        Page2NewCompetition p2;
        Page3NewCompetition p3;

        public string nameCompetition, dateCompetition, placeCompetition, typeCompetition, organizer, swimLine, shootPlace; 

        public NewCompetition()
        {
            InitializeComponent();
            p1 = new Page1NewCompetition();
            p2 = new Page2NewCompetition();
            p3 = new Page3NewCompetition();
            p1.Init(this);
            p2.Init(this);
            p3.Init(this);
            Show1Page();
        }

        public void Show1Page()
        {
            newCompetitionFrame.NavigationService.Navigate(p1);
        }
        public void Show2Page()
        {
            newCompetitionFrame.NavigationService.Navigate(p2);
        }
        public void Show3Page()
        {
            newCompetitionFrame.NavigationService.Navigate(p3);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void FinishCreate()
        {
            Properties.Settings.Default.NameCompetition = nameCompetition;
            Properties.Settings.Default.DateOfCompetition = dateCompetition;
            Properties.Settings.Default.PlaceCompetition = placeCompetition;
            Properties.Settings.Default.NumberOfLineOnPool = Convert.ToInt32(swimLine);
            Properties.Settings.Default.NumberOfPlaceShoot = Convert.ToInt32(shootPlace);
            Properties.Settings.Default.Organizer = organizer;
            Properties.Settings.Default.Save();
            //DialogResult Result = MessageBox.Show("Czy chcesz zaimportować listę zawodników?" "Import zawodnikow", MessageBoxButton.YesNo, MessageBoxImage.Question);
            
            Close();
        }
    }
}
