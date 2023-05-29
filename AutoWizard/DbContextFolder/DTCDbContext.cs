using AutoWizard.Model;
using Microsoft.EntityFrameworkCore;

namespace AutoWizard.DbContextFolder
{
    public class DTCDbContext : DbContext
    {
        public DTCDbContext(DbContextOptions<DTCDbContext> options) : base(options)
        {
            
        }

        public DbSet<DTCCode> DTCCodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DTCCode>().HasKey(d => d.Id);
           
            // other entity configurations
        }
    }
}
