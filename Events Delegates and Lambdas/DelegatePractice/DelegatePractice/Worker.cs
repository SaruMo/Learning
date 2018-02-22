using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    public delegate void TheDelegateHandler( object sender, PracticeEventArgs theArgs );

    public class Worker
    {
        public event TheDelegateHandler WorkerEvent;
        //public event EventHandler<PracticeEventArgs> WorkerEvent; //this method works as well without needing to define a custom delegate.
        public event EventHandler WorkCompleted;

        public void DoWork(int theHours)
        {
            OnWorkerEvent( new PracticeEventArgs( theHours ) );
            OnWorkCompleted();
        }

        protected virtual void OnWorkerEvent( PracticeEventArgs theArgs )
        {
            ( WorkerEvent )?.Invoke( this, theArgs );
        }

        protected virtual void OnWorkCompleted()
        {
            ( WorkCompleted )?.Invoke(this, EventArgs.Empty);
        }
    }
}
