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
    public partial class frmNewEntry : Form
    {
        frmJournalViewer parent;
        public frmNewEntry()
        {
            InitializeComponent();
        }

        public frmNewEntry(frmJournalViewer parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Entry obj = new Entry();

            obj.Title = txtJournalTitle.Text;
            obj.Contents = txtJournalEntryContent.Text;
            obj.Date = dteJournalDate.Value;

            parent.addNewEntry(obj);

            this.Close();
        }
    }
}
