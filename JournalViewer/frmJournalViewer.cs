using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

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
            frmNewEntry obj = new frmNewEntry(this);

            obj.Show();
        }

        public void addNewEntry(Entry obj)
        {
            journalEntries.Add(obj);
            updateGrid();
        }

        private void updateGrid()
        {
            //Clear out all entries currently in the row.
            grdEntryViewer.Rows.Clear();

            //Re-add the entries from List<Entries> object
            foreach (Entry e in journalEntries)
            {
                string[] row = new string[3];

                row[0] = e.Title;
                row[1] = e.Contents;
                row[2] = e.Date.ToString();

                grdEntryViewer.Rows.Add(row);
            }
        }

        private void createNewJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //User has selected a file and we are ready to create the new file.

                StreamWriter file = new StreamWriter(saveFileDialog1.FileName);

                string save_data = JsonSerializer.Serialize(journalEntries);

                file.Write(save_data);

                file.Close();
            }
        }

        private void openJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(openFileDialog1.FileName);

                string file_data = file.ReadToEnd();

                journalEntries = JsonSerializer.Deserialize<List<Entry>>(file_data);

                updateGrid();

                file.Close();
            }
        }
    }
}
