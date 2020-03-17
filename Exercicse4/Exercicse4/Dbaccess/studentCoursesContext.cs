using Exercicse4.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicse4.Dbaccess
{
    class studentCoursesContext: DbContext
    {

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer(@"Server=Donau.hiof.no;User ID=tobiasgs;Password=UArBd6rH;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Database=tobiasgs;");

           /* SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource="Donau.hiof.no",
                UserID = "tobiasgs",
                Password = "UArBd6rH",
                ConnectTimeout = 30,
                Encrypt = false,
                TrustServerCertificate = false,
                ApplicationIntent = ApplicationIntent.ReadWrite,
                MultiSubnetFailover = false,
                Database

            };
            */
        
        }
    }
}
