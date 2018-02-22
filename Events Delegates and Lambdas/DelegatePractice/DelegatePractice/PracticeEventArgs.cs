using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    public class PracticeEventArgs : System.EventArgs
    {
        public PracticeEventArgs(int theHours)
        {
            Hours = theHours;
        }

        public int Hours { get; set; }
    }
}
