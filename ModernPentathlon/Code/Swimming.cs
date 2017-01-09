using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPentathlon.Code
{
    class Swimming : Competion
    {
        public Swimming()
        {

        }

        protected override int ConvertTimeToScore()
        {
            return (int) Time.TotalSeconds;
        }
    }
}
