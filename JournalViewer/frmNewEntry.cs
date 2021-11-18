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
    public partial class frmEntryForm : Form
    {
        frmJournalViewer parent;
        EntryMode mode;
        Entry entry;

        public frmEntryForm()
        {
            InitializeComponent();
            mode = EntryMode.None;
        }


        public frmEntryForm(frmJournalViewer parent, EntryMode mode, Entry entry = null)
        {
            InitializeComponent();

            //The parent is a reference to the main form.  Needed to pass back our
            //entry data back to parent.
            this.parent = parent;

            //Store which mode we are in.  Add or Edit entry?
            this.mode = mode;

            //Store a reference to the entry itself.  Should default to null if in
            //add mode.
            this.entry = entry;

            //If we are in edit mode, then fill the form with the current entry
            //contents.
            if (mode == EntryMode.Edit)
            {
                this.Text  = "Edit Entry";
                fillForm();
            }
            else if(mode == EntryMode.Add)
            {
                this.Text = "Add New Entry";
            }
        }

        private void fillForm()
        {
            //Copy the entry data from the Entry object
            //to the form controls.
            txtJournalEntryContent.Text = entry.Contents;
            txtJournalTitle.Text = entry.Title;
            dteJournalDate.Value = entry.Date;
        }




        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (mode == EntryMode.Add)
            {
                //Create a new Entry Object
                Entry obj = new Entry();

                //Fill it with the text entered in from the text box
                obj.Title = txtJournalTitle.Text;
                obj.Contents = txtJournalEntryContent.Text;

                //Store the DateTime value from the Date box in our entry
                //object.
                obj.Date = dteJournalDate.Value;

                //Pass the object back to the parent to be added to the
                //journalEntries lise.
                parent.addNewEntry(obj);
            }
            else if(mode == EntryMode.Edit)
            {
                //Remember that everything in C# is passed by reference.
                //This means that when we passed the entry object from
                //the parent form, we have direct access to that entry
                //from inside the journalEntries list.  This means
                //that editing and changing the attributes inside
                //this entry reference also effects the one
                //back in the original list, thus making it MUCH
                //easier to make changes to the original content.
                entry.Contents = txtJournalEntryContent.Text;
                entry.Title = txtJournalTitle.Text;
                entry.Date = dteJournalDate.Value;

                //After we made our changes to the entry, we
                //can refresh our grid.
                parent.updateGrid();
            }

            //This closes and sends the form to the garbage collector.
            this.Close();
        }

        private void frmEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
