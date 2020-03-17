using System;
using System.Collections.Generic;
using System.Text;

namespace Notable.Model
{
    class Note : IComparable<Note>
    {

        public String NoteID { get; set; }
        public String Content { get; set; }
        public String Description { get; set; }
        public String Title { get; set; }
        public List<String> Tags  { get; set; }
        public String Course  { get; set; }
        public DateTime Date { get; set; }

        public int CompareTo(Note other)
        {
            throw new NotImplementedException();
        }
    }
}
