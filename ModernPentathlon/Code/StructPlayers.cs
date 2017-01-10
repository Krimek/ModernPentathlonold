using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPentathlon.Code
{
    static class StructPlayers
    {
        public static List<Player> ListOfPlayer = new List<Player>();

        public static void EditPlayer(Player player)
        {
            foreach (Player p in ListOfPlayer)
            {
                if (p.Equals(player))
                {
                    p.Clone(player);
                    break;
                }
            }
        }

        public static void RemovePlayer(Player player)
        {
            ListOfPlayer.Remove(player);
        }

        public static void RemovePlayer(int id)
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

        public static List<Player> GetListMen()
        {
            IEnumerable<Player> m = from Player p in ListOfPlayer
                                    where p.Sex == "m"
                                    select p;
            return m.ToList();
        }

        public static List<Player> GetListWomen()
        {
            IEnumerable<Player> w = from Player p in ListOfPlayer
                                    where p.Sex == "w"
                                    select p;
            return w.ToList();
        }
    }
}
