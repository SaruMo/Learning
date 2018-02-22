using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedDelegatePractice
{
    //a singleton class implementing the Mediator pattern
    public sealed class Mediator
    {
        //static members
        private static readonly Mediator _instance = new Mediator(); // the only instance created

        private Mediator(){} // hides the constructor.

        public static Mediator GetMediator()
        {
            return _instance;
        }

        //instance members
        public event EventHandler<JobChangedEventArgs> JobChanged;

        public void OnJobChanged(object sender)
        {
            ( JobChanged )?.Invoke( sender, new JobChangedEventArgs(){Job = 1} );
            Console.WriteLine( "The event object: " + sender.ToString() );
        }
    }
}
