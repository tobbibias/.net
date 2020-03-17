using Notable.Model;
using System;
using System.Text;
using Notable.DataAcess;


namespace Notable
{
    class Program
    {
        static void Main(string[] args)
        {

             using (var db = new NoteContext())
             {
                 var note1 = new Note("Today we learned about strings and databaeses.","DotNet","Databases",DateTime.Now,1);
                 db.Notes.Add(note1);
                 var count = db.SaveChanges();

                 Console.WriteLine("{0} records saved to database", count);

                 Console.WriteLine();
                 Console.WriteLine("All Notes in database:");

                 foreach(var note in db.Notes)
                 {
                     Console.WriteLine(" - {0}",note.ToString());
                 }
             }

           
        }
    }
}
