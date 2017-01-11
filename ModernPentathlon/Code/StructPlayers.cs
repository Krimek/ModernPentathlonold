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
        
        public static Player GetPlayer(int id)
        {
            foreach (Player p in ListOfPlayer)
            {
                if (p.Equals(id))
                    return p;
            }
            return null;
        }

        public static Player GetPlayer(string name, string surname)
        {
            foreach(Player p in ListOfPlayer)
            {
                if (p.Equals(name, surname))
                    return p;
            }
            return null;
        }

        public static void RemovePlayer(Player player)
        {
            ListOfPlayer.Remove(player);
        }

        public static void RemovePlayer(int id)
        {
            RemovePlayer(GetPlayer(id));
        }

        public static void RemovePlayer(string name, string surname)
        {
            RemovePlayer(GetPlayer(name, surname));
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

        public static List<string> GetSortNameAndSurnameMen()
        {
            IEnumerable<string> m = from Player p in GetListMen()
                                    orderby p.Name
                                    select p.Name + " " + p.Surname;
            return m.ToList();
        }

        public static List<string> GetSortNameAndSurnameWomen()
        {
            IEnumerable<string> m = from Player p in GetListWomen()
                                    orderby p.Name
                                    select p.Name + " " + p.Surname;
            return m.ToList();
        }

        public static List<string> GetSortNameAndSurnameAll()
        {
            IEnumerable<string> m = from Player p in ListOfPlayer
                                    orderby p.Name
                                    select p.Name + " " + p.Surname;
            return m.ToList();
        }
    }
}
