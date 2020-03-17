using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Notable.Model
{


    class Note : IComparable<Object>
    {
        

        public int Id { get; set;}



        public string Content { set; get; }
        public  string Course { set; get; }
        public  string Subject { set; get; }
        public DateTime Date { set; get; }

        public Note(string content, string course, string subject, DateTime date,int id)
        {
            Id = id;
            Content = content;
            Course = course;
            Subject = subject;
            Date = date;
        }

        public string Signature => $"{Subject} {Date}";

        

        override
        public string ToString()
        {
            return Course +"-"+Subject + "-" +Date.Day+"-"+Date.Month+"-"+Date.Year;
        }

        public int CompareTo([AllowNull] Object other)
        {
            throw new NotImplementedException();
        }
    }
}