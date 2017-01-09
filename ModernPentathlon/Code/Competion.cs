using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPentathlon.Code
{
    abstract class Competion
    {
        protected bool finish;
        private TimeSpan time;
        private int competitionScore;
        private int penalty;

        public TimeSpan Time { get => time; set => time = value; }
        public int Penalty { get => penalty; set => penalty = value; }
        public int CompetitionScore { get => competitionScore; set => competitionScore = value; }

        public Competion()
        {

        }

        abstract protected int ConvertTimeToScore();

        public void CalculateResult(TimeSpan time, int penalty)
        {
            Time = time;
            Penalty = penalty;
            CompetitionScore = ConvertTimeToScore() + penalty;
            finish = true; 
        }

    }
}
