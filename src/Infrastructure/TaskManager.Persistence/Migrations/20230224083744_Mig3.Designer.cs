﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManager.Persistence.Context;

namespace TaskManager.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230224083744_Mig3")]
    partial class Mig3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskManager.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TaskManager.Domain.Entities.SH_User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CellPhone")
                        .HasColumnType("varchar(10)");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("IdentityNumber")
                        .HasColumnType("varchar(11)");

                    b.Property<bool?>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .HasColumnType("varchar(250)");

                    b.Property<Guid>("TownId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("TownId");

                    b.ToTable("SH_User");
                });

            modelBuilder.Entity("TaskManager.Domain.Entities.UT_City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PhoneCode")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("PlateNumber")
                        .HasColumnType("varchar(2)");

                    b.HasKey("Id");

                    b.ToTable("UT_City");
                });

            modelBuilder.Entity("TaskManager.Domain.Entities.UT_Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code2")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Code3")
                        .HasColumnType("varchar(3)");

                    b.Property<Guid?>("CreatedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PhoneCode")
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("UT_Country");
                });

            modelBuilder.Entity("TaskManager.Domain.Entities.UT_Town", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("UT_Town");
                });

            modelBuilder.Entity("TaskManager.Domain.Entities.SH_User", b =>
                {
                    b.HasOne("TaskManager.Domain.Entities.UT_City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManager.Domain.Entities.UT_Town", "Town")
                        .WithMany()
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Town");
                });

            modelBuilder.Entity("TaskManager.Domain.Entities.UT_Town", b =>
                {
                    b.HasOne("TaskManager.Domain.Entities.UT_City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });
#pragma warning restore 612, 618
        }
    }
}