using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TaskManager.Persistence.Context;

public partial class TaskManagerContext : DbContext
{
    public TaskManagerContext()
    {
    }

    public TaskManagerContext(DbContextOptions<TaskManagerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ShUser> ShUsers { get; set; }

    public virtual DbSet<UtCity> UtCities { get; set; }

    public virtual DbSet<UtCountry> UtCountries { get; set; }

    public virtual DbSet<UtTown> UtTowns { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=TaskManager;Trusted_Connection=True;TrustServerCertificate=True", sqlOption => sqlOption.UseNetTopologySuite());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ShUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SH_User");

            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.CellPhone)
                .IsRequired()
                .HasMaxLength(10);
            entity.Property(e => e.Changed).HasColumnType("datetime");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(250);
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.IdentityNumber)
                .IsRequired()
                .HasMaxLength(11);
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(250);
        });

        modelBuilder.Entity<UtCity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UT_City");

            entity.Property(e => e.Changed).HasColumnType("datetime");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PlateNumber)
                .IsRequired()
                .HasMaxLength(2);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<UtCountry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UT_Country");

            entity.Property(e => e.Changed).HasColumnType("datetime");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<UtTown>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UT_Town");

            entity.Property(e => e.Changed).HasColumnType("datetime");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
