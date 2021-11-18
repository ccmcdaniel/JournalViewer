using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JournalViewer
{
    public enum EntryMode
    {
        None,
        Edit,
        Add
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            frmMain f;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            f = new frmMain();
            Application.Run(f);

            f.Hide();
        }
    }
}
