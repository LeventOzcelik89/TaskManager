using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System.Xml;
using TaskManager.Application.Interfaces.Context;
using TaskManager.Domain.Common;
using TaskManager.Domain.Entities;

namespace TaskManager.Persistence.Context
{
    public class ApplicationDbContext : DbContext, IApplicationContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        { }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SH_User> SH_User { get; set; }
        public virtual DbSet<UT_Country> UT_Country { get; set; }
        public virtual DbSet<UT_City> UT_City { get; set; }
        public virtual DbSet<UT_Town> UT_Town { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaseEntity>(builder =>
            {
                builder.Property(e => e.Id)
                    .HasValueGenerator<SequentialGuidValueGenerator>()
                    .ValueGeneratedOnAdd();
            });



            //  modelBuilder.Entity<SH_User>()
            //      .HasOptional<Standard>(s => s.Standard)
            //      .WithMany()
            //      .WillCascadeOnDelete(false);

        }
    }
}
