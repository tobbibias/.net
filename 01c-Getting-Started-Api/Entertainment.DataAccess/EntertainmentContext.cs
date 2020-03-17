using Entertainment.Model;
using Microsoft.EntityFrameworkCore;

namespace Entertainment.DataAccess
{
    public class EntertainmentContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }

        public EntertainmentContext(DbContextOptions<EntertainmentContext> options) : base(options) { }
    }
}