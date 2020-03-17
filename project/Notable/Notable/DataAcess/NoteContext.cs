using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Notable.Model;
using System;

namespace Notable.DataAcess
{
    class NoteContext :  DbContext
    {
        public DbSet<Note> Notes {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = "(localdb)\\MSSQLLocalDB",
                InitialCatalog = "Notable",
                IntegratedSecurity = true
            };
            optionsBuilder.UseSqlServer(builder.ConnectionString.ToString());
        }
       
    }
}
