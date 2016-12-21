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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModernPentathlon.Windows.NewCompetition
{
    /// <summary>
    /// Interaction logic for Page1NewCompetition.xaml
    /// </summary>
    public partial class Page1NewCompetition : DefaultPageNewCompetition
    {
        public Page1NewCompetition()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            Page2NewCompetition p2 = new Page2NewCompetition();
            NavigationService.Navigate(p2);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
