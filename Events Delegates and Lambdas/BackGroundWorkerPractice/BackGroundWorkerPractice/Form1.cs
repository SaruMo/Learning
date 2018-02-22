using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackGroundWorkerPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Start_Click( object sender, EventArgs e )
        {
            BackWorker.RunWorkerAsync();
        }

        private void Btn_Cancel_Click( object sender, EventArgs e )
        {
            BackWorker.CancelAsync();
        }

        private void BackWorker_DoWork( object sender, DoWorkEventArgs e )
        {
            //not called on main thread
            e.Result = Calculate( sender as BackgroundWorker, e );
        }

        private void BackWorker_ProgressChanged( object sender, ProgressChangedEventArgs e )
        {
            //called on main thread
            ProgressBar.Value = e.ProgressPercentage;
        }

        private void BackWorker_RunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e )
        {
            //called on main thread
        }

        private long Calculate( BackgroundWorker instance, DoWorkEventArgs e )
        {
            for ( int i = 0; i < 100; i++ )
            {
                if ( instance.CancellationPending )
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep( 100 );
                    instance.ReportProgress( i );
                }
            }
            
            return 0L;
        }
    }
}
