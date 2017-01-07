using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPentathlon.Code
{
    class Player
    {
        int id;
        string name;
        string surname;
        DateTime dateBirth;
        string sex;
        string club;
        Competion score;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                if (value.Equals("kobieta") || value.Equals("Kobieta") || value.Equals("K") || value.Equals("k") || value.Equals("W") || value.Equals("women") || value.Equals("Women") || value.Equals("w"))
                    sex = "K";
                else if (value.Equals("mężczyzna") || value.Equals("Mężczyzna") || value.Equals("M") || value.Equals("m") || value.Equals("Mezczyzna") || value.Equals("mezczyzna") || value.Equals("Men") || value.Equals("men"))
                    sex = "M";
            }
        }
        public DateTime DateBirth
        {
            get
            {
                return dateBirth;
            }
            set
            {
                dateBirth = value;
            }
        }
        public string Club
        {
            get
            {
                return club;
            }
            set
            {
                club = value;
            }
        }

        public Player(bool isTemporary)
        {
            if (isTemporary)
            {
                Id = Properties.Settings.Default.IdPlayerNumber++;
                score = new Competion();
                Properties.Settings.Default.Save();
            }
        }

        public void Clone(Player p)
        {
            Name = p.Name;
            Surname = p.Surname;
            DateBirth = p.DateBirth;
            Sex = p.Sex;
            Club = p.Club;
        }
    }
}
