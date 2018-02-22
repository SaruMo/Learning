using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynchronousDelegates
{
    public partial class Form1 : Form
    {
        delegate void StartProcessDelegate( int val );

        delegate void ShowProgressDelegate( int val );

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Start_Click( object sender, EventArgs e )
        {
            //var progDelBad = new StartProcessDelegate(StartProcessBad);
            var progDelGood = new StartProcessDelegate(StartProcessGood);
            //progDelBad.BeginInvoke( 100, null, null );
            progDelGood.BeginInvoke( 100, null, null );
        }

        //this is bad because the helper thread is changing the UI directly. InvalidOperationException.
        private void StartProcessBad( int max )
        {
            this.ProgressBar.Maximum = max;
            for ( int i = 0; i <= max; i++ )
            {
                System.Threading.Thread.Sleep( 10 );
                this.Lbl_Progress.Text = $"{i.ToString()}%";
                this.ProgressBar.Value = i;
            }
        }

        private void StartProcessGood( int max )
        {
            ShowProgress( 0 );
            for ( int i = 0; i <= max; i++ )
            {
                System.Threading.Thread.Sleep( 10 );
                ShowProgress( i );
            }
        }

        private void ShowProgress( int progress )
        {
            //If we're calling on a background thread
            if ( Lbl_Progress.InvokeRequired == true )
            {
                var del = new ShowProgressDelegate(ShowProgress);
                this.BeginInvoke( del,  progress );
            }
            else
            {
                Lbl_Progress.Text = $"{progress}%";
                ProgressBar.Value = progress;
            }
        }
    }
}
