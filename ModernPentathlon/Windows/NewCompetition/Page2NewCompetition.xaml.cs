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
        private NewCompetition nC;

        public Page2NewCompetition()
        {
            InitializeComponent();
        }

        public void Init(NewCompetition nC)
        {
            this.nC = nC;
        }

        private void PreviewButton_Click(object sender, RoutedEventArgs e)
        {
            nC.Show1Page();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            nC.swimLine = numberLineSwim_textBox.Text;
            nC.shootPlace = numberShootPlace_textBox.Text;
            nC.Show3Page();
        }
        
    }
}
