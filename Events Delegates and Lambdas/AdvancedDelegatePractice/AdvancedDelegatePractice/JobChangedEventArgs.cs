using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedDelegatePractice
{
    public class JobChangedEventArgs : EventArgs
    {
        public int Job { get; set; }
    }
}
