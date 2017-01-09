using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernPentathlon.Code
{
    class CombinedEvent : Competion
    {
        public CombinedEvent()
        {
            
        }

        protected override int ConvertTimeToScore()
        {
            return (int)Time.TotalSeconds;
        }
    }
}
