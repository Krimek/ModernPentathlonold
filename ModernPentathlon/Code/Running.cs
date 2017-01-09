using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPentathlon.Code
{
    class Running : Competion
    {
        public Running()
        {

        }

        protected override int ConvertTimeToScore()
        {
            return (int) Time.TotalSeconds;
        }
    }
}
