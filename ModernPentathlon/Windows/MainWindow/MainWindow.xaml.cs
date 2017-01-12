using ModernPentathlon.Code;
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

namespace ModernPentathlon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Properties.Settings.Default.IdPlayerNumber = 0;
            Properties.Settings.Default.Save();
        }

        private void NewCompetitionMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Windows.NewCompetition.NewCompetition newCompetition = new Windows.NewCompetition.NewCompetition();
            newCompetition.ShowDialog();
        }

        private void RefreshPlayerList()
        {
            List<string> playerList;
            playerList_listBox.Items.Clear();

            if (choosePlayerList_comboBox.SelectedIndex == 0)
                playerList = StructPlayers.GetSortNameAndSurnameMen();
            else if (choosePlayerList_comboBox.SelectedIndex == 1)
                playerList = StructPlayers.GetSortNameAndSurnameWomen();
            else
                playerList = StructPlayers.GetSortNameAndSurnameAll();

            foreach(string s in playerList)
            {
                playerList_listBox.Items.Add(s);
            }
        }

        /*************************************************EVENT**************************************************************/

        private void AddPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            Windows.AddPlayer.AddPlayer addplayer = new Windows.AddPlayer.AddPlayer();
            addplayer.ShowDialog();
            if (!addplayer.cancelAddPlayer)
            {
                Player p = new Player(true) { Name = addplayer.NamePlayer, Surname = addplayer.Surname, Club = addplayer.Club, DateBirth = addplayer.DateBirth, Sex = addplayer.Sex };
                StructPlayers.ListOfPlayer.Add(new Player(false));
                StructPlayers.EditPlayer(StructPlayers.ListOfPlayer.Last().Id, p);
                RefreshPlayerList();
            }
        }

        private void EditPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            if (playerList_listBox.SelectedIndex != -1)
            {
                string[] s = playerList_listBox.SelectedItem.ToString().Split();
                Player p = StructPlayers.GetPlayer(s[0], s[1]);
            }
        }

        private void DeletePlayerButton_Click(object sender, RoutedEventArgs e)
        {
            if (playerList_listBox.SelectedIndex != -1)
            {
                string[] s = playerList_listBox.SelectedItem.ToString().Split();
                StructPlayers.RemovePlayer(s[0], s[1]);
                RefreshPlayerList();
            }
        }

        private void ChoosePlayerListComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RefreshPlayerList();
        }
    }
}
