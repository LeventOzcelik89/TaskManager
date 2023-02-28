using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=TaskManager;Trusted_Connection=True;TrustServerCertificate=True", x => x.UseNetTopologySuite());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ShUser>(entity =>
        {
            entity.ToTable("SH_User");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
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
            entity.Property(e => e.IdentityNumber)
                .IsRequired()
                .HasMaxLength(11);
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(250);

            entity.HasOne(d => d.City).WithMany(p => p.ShUserCities)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK___SH_User_CityId___UT_City_Id");

            entity.HasOne(d => d.Town).WithMany(p => p.ShUserTowns)
                .HasForeignKey(d => d.TownId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK___SH_User_TownId___UT_Town_Id");
        });

        modelBuilder.Entity<UtCity>(entity =>
        {
            entity.ToTable("UT_City");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Changed).HasColumnType("datetime");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PlateNumber)
                .IsRequired()
                .HasMaxLength(2);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<UtCountry>(entity =>
        {
            entity.ToTable("UT_Country");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Changed).HasColumnType("datetime");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Shape).HasColumnType("geometry");
        });

        modelBuilder.Entity<UtTown>(entity =>
        {
            entity.ToTable("UT_Town");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Changed).HasColumnType("datetime");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Shape).HasColumnType("geometry");

            entity.HasOne(d => d.City).WithMany(p => p.InverseCity)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK___UT_Town_CityId___UT_City_Id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
