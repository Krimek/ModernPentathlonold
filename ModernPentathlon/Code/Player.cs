using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPentathlon.Code
{
    class Player
    {
        public enum Discipline {Swimming, Running, Shooting, CombinedEvent};
        int id;
        string name;
        string surname;
        DateTime dateBirth;
        string sex;
        string club;
        Swimming swimming;
        Running running;
        Shooting shooting;
        CombinedEvent combinedEvent;
        int totalScore;

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
            if (!isTemporary)
            {
                Id = Properties.Settings.Default.IdPlayerNumber++;
                Properties.Settings.Default.Save();
                combinedEvent = new CombinedEvent();
                shooting = new Shooting();
                swimming = new Swimming();
                running = new Running();
            }
        }

        public override string ToString()
        {
            return Name + Surname + DateBirth.ToString() + "\"" + Club + "\"" + Sex + swimming.ToString() + running.ToString() + shooting.ToString() + combinedEvent.ToString() + totalScore;
        }

        public bool Equals(Player p)
        {
            if (p.id == Id)
                return true;
            return false;
        }

        public void Clone(Player p)
        {
            Name = p.Name;
            Surname = p.Surname;
            DateBirth = p.DateBirth;
            Sex = p.Sex;
            Club = p.Club;
        }

        public void AddScore(Discipline discipline, string timeOrScore, string penalty)
        {
            int penalties;
            if (discipline == Discipline.Shooting)
            {
                if (Int32.TryParse(timeOrScore, out int result) && Int32.TryParse(penalty, out penalties))
                {
                    shooting.CalculateResult(result, penalties);
                }
            }
            else
            {
                if(Int32.TryParse(timeOrScore.Substring(0,2), out int minute) && 
                    Int32.TryParse(timeOrScore.Substring(3,2),out int second) && 
                    Int32.TryParse(timeOrScore.Substring(6,2), out int millisecond) && 
                    Int32.TryParse(penalty, out penalties))
                {
                    TimeSpan time = new TimeSpan(0, 0, minute, second, millisecond);
                    if(discipline == Discipline.Running)
                    {
                        running.CalculateResult(time, penalties);
                    }
                    else if(discipline == Discipline.Swimming)
                    {
                        swimming.CalculateResult(time, penalties);
                    }
                    else if(discipline == Discipline.CombinedEvent)
                    {
                        combinedEvent.CalculateResult(time, penalties);
                    }
                }
            }
            UpdateTotalScore();
        }

        private void UpdateTotalScore()
        {
            totalScore = swimming.CompetitionScore + running.CompetitionScore + shooting.CompetitionScore + combinedEvent.CompetitionScore;
        }
    }
}
