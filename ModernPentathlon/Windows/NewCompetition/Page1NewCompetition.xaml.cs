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
    public partial class Page1NewCompetition : Page
    {
        private NewCompetition nC;

        public Page1NewCompetition()
        {
            InitializeComponent();
        }

        public void Init(NewCompetition nC)
        {
            this.nC = nC;
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            nC.nameCompetition = nameCompetition_textBox.Text;
            nC.placeCompetition = placeCompetition_textBox.Text;
            nC.dateCompetition = dateCompetition_textBox.Text;
            nC.typeCompetition = typeCompetition_comboBox.Text;
            nC.organizer = organizer_textBox.Text;
            nC.Show2Page();
        }
    }
}
