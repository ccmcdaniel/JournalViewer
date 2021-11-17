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
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
