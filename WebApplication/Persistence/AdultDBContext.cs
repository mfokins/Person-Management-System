using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;

namespace WebApplication.Persistence
{
    public class AdultDBContext : DbContext
    {
        public DbSet<Adult> Adults { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source = adults.db");
        }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     // modelBuilder.Entity<Job>()
        //     //     .HasOne<Adult>()
        //     //     .WithMany()
        //     //     .HasForeignKey(p => p.JobID);
        //
        //     modelBuilder.Entity<Adult>().HasOne<Job>().WithOne().HasForeignKey("Job").HasPrincipalKey("Adult");
        //
        //   //  modelBuilder.Entity<Adult>().Navigation(b => b.Job).UsePropertyAccessMode(PropertyAccessMode.Property);
        // }
    }
}