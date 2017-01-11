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
    /// Interaction logic for Page3NewCompetition.xaml
    /// </summary>
    public partial class Page3NewCompetition : Page
    {
        private NewCompetition nC;

        public Page3NewCompetition()
        {
            InitializeComponent();
        }

        internal void Init(NewCompetition nC)
        {
            this.nC = nC;
        }

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            nC.FinishCreate();
        }

        private void PreviewButton_Click(object sender, RoutedEventArgs e)
        {
            nC.Show2Page();
        }
    }
}
