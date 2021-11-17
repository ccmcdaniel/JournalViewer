using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalViewer
{
    public class Entry
    {
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime Date { get; set; }

        public Entry()
        {
            Title = "";
            Contents = "";
            Date = DateTime.Now;
        }

        public Entry(string t, string c, DateTime d)
        {
            Title = t;
            Contents = c;
            Date = d;
        }
    }
}
