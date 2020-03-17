using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicse4.Model
{
    class Course
    {
        public String CourseName { get; set; }
        public String CourseID { get; set; }
        public String Description { get; set; }

        public List<Student> Students { get; set; }
        public Course(string courseName, string courseID, string description)
        {
            CourseName = courseName;
            CourseID = courseID;
            Description = description;
        }

    }
}
