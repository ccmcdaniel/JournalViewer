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
        //May not be needed, but have a reference back to the starting class.
        frmMain parent;
        
        //Stores the entry data for our journal.
        List<Entry> journalEntries = new List<Entry>();
        
        //Stores the currently opened file.
        string fileOpened = "";

        public frmJournalViewer()
        {
            InitializeComponent();
        }

        public frmJournalViewer(frmMain parent)
        {
            InitializeComponent();

            //Set the parent of the form.
            this.parent = parent;

            //Is SUPPOSED
            parent.Hide();
            parent.Visible = false;
        }

        private void frmJournalViewer_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewEntry_Click(object sender, EventArgs e)
        {
            frmEntryForm obj = new frmEntryForm(this, EntryMode.Add, null);

            obj.Show();
        }

        public void addNewEntry(Entry obj)
        {
            journalEntries.Add(obj);
            updateGrid();
        }

        public void updateGrid()
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

        private void setCurrentFile(string fileName)
        {
            fileOpened = fileName;
            lblFileOpened.Text = fileName;
        }

        private void createNewJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //User has selected a file and we are ready to create the new file.

                StreamWriter file = new StreamWriter(saveFileDialog1.FileName);

                string save_data = JsonSerializer.Serialize(journalEntries);

                file.Write(save_data);

                setCurrentFile(saveFileDialog1.FileName);

                file.Close();
            }
        }

        private void openJournalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(openFileDialog1.FileName);

                string file_data = file.ReadToEnd();

                journalEntries = JsonSerializer.Deserialize<List<Entry>>(file_data);

                updateGrid();

                setCurrentFile(openFileDialog1.FileName);

                file.Close();
            }
        }

        private void saveJounralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveJournal();
        }

        private void saveJournal()
        {
            try
            {
                StreamWriter file = new StreamWriter(fileOpened);

                string save_data = JsonSerializer.Serialize(journalEntries);

                file.Write(save_data);

                file.Close();

                MessageBox.Show("Save Successfully to \"" + fileOpened + "\".", "Journal Saved");
            }
            catch (Exception)
            {
                MessageBox.Show("Error:  Could not open file.  Make sure you either open an exiting file or " +
                    "create a new file.  Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void grdEntryViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //An index of -1 means the user clicked on the header column.  Back out and do nothing.
            if (e.RowIndex == -1)
                return;

            //If we clicked on Edit button....
            if (e.ColumnIndex == grdEntryViewer.Columns["clmEdit"].Index)
            {
                Entry entry = journalEntries[e.RowIndex];
                frmEntryForm obj = new frmEntryForm(this, EntryMode.Edit, entry);
                obj.Show();

            }

            //If we clicked on View button....
            else if (e.ColumnIndex == grdEntryViewer.Columns["clmView"].Index)
            {
                Entry entry = journalEntries[e.RowIndex];
                frmEntryViewer obj = new frmEntryViewer(this, entry);
                obj.Show();
            }

            //If we clicked on Delete button....
            else if (e.ColumnIndex == grdEntryViewer.Columns["clmDelete"].Index)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove this from your journal?", "Remove Entry", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    journalEntries.RemoveAt(e.RowIndex);
                    updateGrid();
                }
            }
        }

        //Defines what happens when we press the forms "x"(close) button.
        private void frmJournalViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Start form Shutdown
            closeProgram();
        }

        void closeProgram()
        {
            DialogResult result = MessageBox.Show("Do you want to save your journal?", "Close Program", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                saveJournal();

                //Close the entire application and destroy all forms.
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeProgram();
        }
    }
}