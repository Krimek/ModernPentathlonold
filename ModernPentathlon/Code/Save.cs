using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPentathlon.Code
{
    static class Save
    {
        
        public static bool SaveCompetition()
        {
            using (StreamWriter sw = new StreamWriter(@"cos.mpent"))
            {
                sw.WriteLine(Properties.Settings.Default.NameCompetition);
                sw.WriteLine(Properties.Settings.Default.PlaceCompetition);
                sw.WriteLine(Properties.Settings.Default.DateOfCompetition);
                sw.WriteLine(Properties.Settings.Default.NumberOfLineOnPool);
                sw.WriteLine(Properties.Settings.Default.NumberOfPlaceShoot);
                foreach(Player p in StructPlayers.ListOfPlayer)
                {
                    sw.WriteLine(p.ToString());
                }
                return true;
            }
        }
    }
}
