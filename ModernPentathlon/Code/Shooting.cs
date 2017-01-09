using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPentathlon.Code
{
    class Shooting : Competion
    {
        int score;
        public Shooting()
        {

        }
        protected override int ConvertTimeToScore()
        {
            return (int) score;
        }
        public void CalculateResult(int score, int penalty)
        {
            this.score = score;
            this.Penalty = penalty;
            CompetitionScore = score + penalty;
        }
    }
}
