using Exercicse4.Dbaccess;
using Exercicse4.Model;
using System;
using System.Collections.Generic;

namespace Exercicse4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student("Knut", "Jensen", "Jens");
            Student stud2 = new Student("Jhonny", "joe", "Knutsen");
            Student stud3 = new Student("Sarah", "Oiler", "Berg");
            Student stud4 = new Student("Tiril", "", "Johansson");

            Course a = new Course("Cooking", "CoC", "A course about cooking");
            Course b = new Course("math", "MA", "A course about Math");
            Course c = new Course("Meth101", "Me1", "A course about cooking meth");

            List<Student> studentList = new List<Student>();

            studentList.Add(stud1);
            studentList.Add(stud2);
            studentList.Add(stud3);
            studentList.Add(stud4);

            a.Students = studentList;
            b.Students = studentList;
            c.Students = studentList;


            using (var db = new studentCoursesContext())
            {
                /*
                db.Students.AddRange(studentList);
                db.Courses.Add(a);
                db.Courses.Add(b);
                db.Courses.Add(c);
                
                var count = db.SaveChanges();

                Console.WriteLine("{0} records saved to database.", count);
                */

                Console.WriteLine("\n All courses in the database: \n");

                foreach (Course course in db.Courses)
                {
                    Console.WriteLine(course.CourseName + " : \n");

                }
                foreach (Student student in db.Students)
                {
                    Console.WriteLine(student.FirstName + ",");
                }
            }
        }
    }
}
