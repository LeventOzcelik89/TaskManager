using Microsoft.EntityFrameworkCore;
using TaskManager.Application.Interfaces.Context;
using TaskManager.Domain.Entities;

namespace TaskManager.Persistence.Context
{
    public class ApplicationDbContext : DbContext, IApplicationContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<SH_User> SH_User { get; set; }
        public DbSet<UT_Country> UT_Country { get; set; }
        public DbSet<UT_City> UT_City { get; set; }
        public DbSet<UT_Town> UT_Town { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //  modelBuilder.Entity<SH_User>()
            //      .HasOptional<Standard>(s => s.Standard)
            //      .WithMany()
            //      .WillCascadeOnDelete(false);

        }
    }
}
