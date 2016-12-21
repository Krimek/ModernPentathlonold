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
    /// Interaction logic for Page2NewCompetition.xaml
    /// </summary>
    public partial class Page2NewCompetition : Page
    {
        Page1NewCompetition p1;
        Page3NewCompetition p3;

        public Page2NewCompetition()
        {
            InitializeComponent();
        }

        private void PreviewButton_Click(object sender, RoutedEventArgs e)
        {
            if (p1 == null)
                p1 = new Page1NewCompetition();
            NavigationService.Navigate(p1);
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (p3 == null)
                p3 = new Page3NewCompetition();
            NavigationService.Navigate(p3);
        }
    }
}
