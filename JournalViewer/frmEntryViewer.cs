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
    public partial class frmEntryViewer : Form
    {
        frmJournalViewer parent;
        Entry entry;

        public frmEntryViewer()
        {
            InitializeComponent();
        }

        public frmEntryViewer(frmJournalViewer parent_form, Entry entry_obj)
        {
            InitializeComponent();
            this.parent = parent_form;
            this.entry = entry_obj;

            setupViewer();
        }

        private void setupViewer()
        {
            txtContents.Text = entry.Contents;
            lblTitle.Text = entry.Title;
            lblDate.Text = entry.Date.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmEntryViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
