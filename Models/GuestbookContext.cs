//This will connect the database to Entity

using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class GuestbookContext : DbContext
    {
        public DbSet<GuestbookEntry> Entries { get; set; } 
        public GuestbookContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder op)
        {
            op.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDb_csh_project;Trusted_Connection=True;");
        }
    }
}
