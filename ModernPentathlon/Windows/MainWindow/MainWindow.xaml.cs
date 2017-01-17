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
            choosePlayerList_comboBox.SelectedIndex = 2;
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
        
        private void AddPlayer()
        {
            Windows.AddPlayer.AddPlayer addPlayer = new Windows.AddPlayer.AddPlayer();
            addPlayer.ShowDialog();
            if (!addPlayer.cancelAddPlayer)
            {
                Player p = new Player(true) { Name = addPlayer.NamePlayer, Surname = addPlayer.Surname, Club = addPlayer.Club, DateBirth = addPlayer.DateBirth, Sex = addPlayer.Sex };
                StructPlayers.ListOfPlayer.Add(new Player(false));
                StructPlayers.EditPlayer(StructPlayers.ListOfPlayer.Last().Id, p);
                RefreshPlayerList();
            }
        }

        private void EditPlayer()
        {
            if (playerList_listBox.SelectedIndex != -1)
            {
                string[] s = playerList_listBox.SelectedItem.ToString().Split();
                Player p = StructPlayers.GetPlayer(s[1], s[0]);
                Windows.AddPlayer.AddPlayer addPlayer = new Windows.AddPlayer.AddPlayer(p);
                addPlayer.ShowDialog();
                if (!addPlayer.cancelAddPlayer)
                {
                    StructPlayers.RemovePlayer(p);
                    Player player = new Player(true) { Name = addPlayer.NamePlayer, Surname = addPlayer.Surname, Club = addPlayer.Club, DateBirth = addPlayer.DateBirth, Sex = addPlayer.Sex };
                    StructPlayers.ListOfPlayer.Add(new Player(false));
                    StructPlayers.EditPlayer(StructPlayers.ListOfPlayer.Last().Id, player);
                    RefreshPlayerList();
                }
            }
        }

        /*************************************************EVENT**************************************************************/

        private void AddPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            AddPlayer();
        }

        private void EditPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            EditPlayer();   
        }

        private void DeletePlayerButton_Click(object sender, RoutedEventArgs e)
        {
            if (playerList_listBox.SelectedIndex != -1)
            {
                string[] s = playerList_listBox.SelectedItem.ToString().Split();
                StructPlayers.RemovePlayer(s[1], s[0]);
                RefreshPlayerList();
            }
        }

        private void ChoosePlayerListComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RefreshPlayerList();
        }

        private void PlayerListListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            EditPlayer();
        }

        /******************************************************MENU**********************************************************/
        
        private void NewCompetitionMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Windows.NewCompetition.NewCompetition newCompetition = new Windows.NewCompetition.NewCompetition();
            newCompetition.ShowDialog();
        }

        private void AddPlayerMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AddPlayer();
        }

        private void CloseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
