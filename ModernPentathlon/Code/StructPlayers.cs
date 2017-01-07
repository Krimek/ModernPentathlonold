using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPentathlon.Code
{
    static class StructPlayers
    {
        static List<Player> ListOfPlayer = new List<Player>();

        static void EditPlayer(Player player)
        {
            int id = player.Id;
            foreach (Player p in ListOfPlayer)
            {
                if (p.Id == id)
                {
                    p.Clone(player);
                    break;
                }
            }
            
        }

        static void RemovePlayer(Player player)
        {
            ListOfPlayer.Remove(player);
        }
        static void RemovePlayer(int id)
        {
            int position = 0;
            foreach(Player p in ListOfPlayer)
            {
                if (p.Id == id)
                {
                    ListOfPlayer.RemoveAt(position);
                    break;
                }
                position++;
            }
        }

        static List<Player> GetListMen()
        {
            IEnumerable<Player> m = from Player p in ListOfPlayer
                                    where p.Sex == "m"
                                    select p;
            return m.ToList();
        }

        static List<Player> GetListWomen()
        {
            IEnumerable<Player> w = from Player p in ListOfPlayer
                                    where p.Sex == "w"
                                    select p;
            return w.ToList();
        }
    }
}
