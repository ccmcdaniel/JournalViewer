using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JournalViewer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            frmJournalViewer obj = new frmJournalViewer(this);
            obj.Show();
            
            //Enable a 100 ms timer to countdown.
            //This timer will delay calling "Hide" so
            //that way the dummy form does not reappear
            //on startup.

            timer1.Enabled = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Hide the dummy form and disable the timer.
            Hide();
            timer1.Enabled = false;
        }
    }
}
