
namespace JournalViewer
{
    partial class frmJournalViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewJournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openJournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveJounralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddNewEntry = new System.Windows.Forms.Button();
            this.grdEntryViewer = new System.Windows.Forms.DataGridView();
            this.clmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblFileOpened = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEntryViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.grdEntryViewer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFileOpened, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(816, 493);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(388, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewJournalToolStripMenuItem,
            this.openJournalToolStripMenuItem,
            this.saveJounralToolStripMenuItem,
            this.exitProgramToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createNewJournalToolStripMenuItem
            // 
            this.createNewJournalToolStripMenuItem.Name = "createNewJournalToolStripMenuItem";
            this.createNewJournalToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.createNewJournalToolStripMenuItem.Text = "Create New Journal";
            this.createNewJournalToolStripMenuItem.Click += new System.EventHandler(this.createNewJournalToolStripMenuItem_Click);
            // 
            // openJournalToolStripMenuItem
            // 
            this.openJournalToolStripMenuItem.Name = "openJournalToolStripMenuItem";
            this.openJournalToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.openJournalToolStripMenuItem.Text = "Open Journal ";
            this.openJournalToolStripMenuItem.Click += new System.EventHandler(this.openJournalToolStripMenuItem_Click);
            // 
            // saveJounralToolStripMenuItem
            // 
            this.saveJounralToolStripMenuItem.Name = "saveJounralToolStripMenuItem";
            this.saveJounralToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.saveJounralToolStripMenuItem.Text = "Save Jounral";
            this.saveJounralToolStripMenuItem.Click += new System.EventHandler(this.saveJounralToolStripMenuItem_Click);
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitProgramToolStripMenuItem.Text = "Exit Program";
            this.exitProgramToolStripMenuItem.Click += new System.EventHandler(this.exitProgramToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddNewEntry);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 436);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(382, 34);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnAddNewEntry
            // 
            this.btnAddNewEntry.Location = new System.Drawing.Point(3, 3);
            this.btnAddNewEntry.Name = "btnAddNewEntry";
            this.btnAddNewEntry.Size = new System.Drawing.Size(106, 31);
            this.btnAddNewEntry.TabIndex = 0;
            this.btnAddNewEntry.Text = "Add New Entry";
            this.btnAddNewEntry.UseVisualStyleBackColor = true;
            this.btnAddNewEntry.Click += new System.EventHandler(this.btnAddNewEntry_Click);
            // 
            // grdEntryViewer
            // 
            this.grdEntryViewer.AllowUserToAddRows = false;
            this.grdEntryViewer.AllowUserToDeleteRows = false;
            this.grdEntryViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEntryViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEntryViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTitle,
            this.clmContents,
            this.clm,
            this.clmEdit,
            this.clmView,
            this.clmDelete});
            this.tableLayoutPanel1.SetColumnSpan(this.grdEntryViewer, 2);
            this.grdEntryViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEntryViewer.Location = new System.Drawing.Point(23, 33);
            this.grdEntryViewer.Name = "grdEntryViewer";
            this.grdEntryViewer.ReadOnly = true;
            this.grdEntryViewer.Size = new System.Drawing.Size(770, 397);
            this.grdEntryViewer.TabIndex = 2;
            this.grdEntryViewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEntryViewer_CellContentClick);
            // 
            // clmTitle
            // 
            this.clmTitle.FillWeight = 15F;
            this.clmTitle.HeaderText = "Title";
            this.clmTitle.Name = "clmTitle";
            this.clmTitle.ReadOnly = true;
            // 
            // clmContents
            // 
            this.clmContents.FillWeight = 50F;
            this.clmContents.HeaderText = "Entry Contents";
            this.clmContents.Name = "clmContents";
            this.clmContents.ReadOnly = true;
            // 
            // clm
            // 
            this.clm.FillWeight = 15F;
            this.clm.HeaderText = "Date Created";
            this.clm.Name = "clm";
            this.clm.ReadOnly = true;
            // 
            // clmEdit
            // 
            this.clmEdit.FillWeight = 10F;
            this.clmEdit.HeaderText = "Edit";
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            this.clmEdit.Text = "Edit";
            this.clmEdit.UseColumnTextForButtonValue = true;
            // 
            // clmView
            // 
            this.clmView.FillWeight = 10F;
            this.clmView.HeaderText = "View";
            this.clmView.Name = "clmView";
            this.clmView.ReadOnly = true;
            this.clmView.Text = "View";
            this.clmView.UseColumnTextForButtonValue = true;
            // 
            // clmDelete
            // 
            this.clmDelete.FillWeight = 10F;
            this.clmDelete.HeaderText = "Delete";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Text = "Delete";
            this.clmDelete.UseColumnTextForButtonValue = true;
            // 
            // lblFileOpened
            // 
            this.lblFileOpened.AutoSize = true;
            this.lblFileOpened.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFileOpened.Location = new System.Drawing.Point(411, 0);
            this.lblFileOpened.Name = "lblFileOpened";
            this.lblFileOpened.Size = new System.Drawing.Size(382, 30);
            this.lblFileOpened.TabIndex = 3;
            this.lblFileOpened.Text = "No File Opened....";
            this.lblFileOpened.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "journal";
            this.saveFileDialog1.FileName = "NewJournal.journal";
            this.saveFileDialog1.Filter = "Journal files|*.journal";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Journal|*.journal";
            // 
            // frmJournalViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 493);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmJournalViewer";
            this.Text = "Journal Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmJournalViewer_FormClosed);
            this.Load += new System.EventHandler(this.frmJournalViewer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEntryViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewJournalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openJournalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveJounralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProgramToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddNewEntry;
        private System.Windows.Forms.DataGridView grdEntryViewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContents;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm;
        private System.Windows.Forms.DataGridViewButtonColumn clmEdit;
        private System.Windows.Forms.DataGridViewButtonColumn clmView;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblFileOpened;
    }
}