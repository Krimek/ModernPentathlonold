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
        enum Sex { K, M};
        string club;
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

        public Player()
        {
            
        }
    }
}
