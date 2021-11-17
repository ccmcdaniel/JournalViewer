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
    public partial class frmJournalViewer : Form
    {
        frmMain parent;
        List<Entry> journalEntries = new List<Entry>();

        public frmJournalViewer()
        {
            InitializeComponent();
        }

        public frmJournalViewer(frmMain parent)
        {
            InitializeComponent();
            this.parent = parent;
            parent.Hide();
            parent.Visible = false;
        }

        private void frmJournalViewer_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewEntry_Click(object sender, EventArgs e)
        {
            string[] row = new string[3];

            row[0] = "Test Title";
            row[1] = "Test Entry Contents";
            row[2] = DateTime.Now.ToString();

            dataGridView1.Rows.Add(row);
        }
    }
}
