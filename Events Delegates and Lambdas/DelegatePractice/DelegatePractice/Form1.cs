using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatePractice
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            var worker = new Worker();

            //standard event handler hookup
            worker.WorkerEvent += new TheDelegateHandler(TheHandler);
            //delegate inference example
            worker.WorkerEvent += TheHandler;
            //anonymous method example
            worker.WorkerEvent += delegate( object theSender, PracticeEventArgs theArgs ) 
                                { Console.WriteLine( $"{theSender.ToString()} {theArgs.Hours}"); };
            //lambda example
            worker.WorkerEvent += (s, e) => Console.WriteLine( $"{s.ToString()} {e.Hours}");

            worker.WorkCompleted += TheWorkComplete;
            worker.DoWork( 10 );

            TheDelegateHandler del1 = TheHandler;
            del1 += TheHandler;
            del1( this, new PracticeEventArgs( 5 ) );

            Action<string> TheAction = ( s ) => Console.WriteLine( s );
            TheAction( "This is how to use the Action<T> delegate with a lambda.\n" +
                       "You can also assign methods to Action<T>" );

            Func<string, bool> TheFunc = ( s ) =>
            {
                Console.WriteLine( s );
                return true;
            };
            TheFunc( "This is a Func. They can have multiple params and must have a return type" );
        }

        public static void TheHandler( object sender, PracticeEventArgs theArg )
        {
            Console.WriteLine( $"{sender.ToString()} {theArg.Hours}");
        }

        public static void TheWorkComplete( object sender, EventArgs e )
        {
            Console.WriteLine("Finished");
        }
    }
}
