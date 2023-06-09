﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PetInfrastructure;

#nullable disable

namespace PetSalon.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PetsEntity.Animal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long?>("PersonId")
                        .HasColumnType("bigint");

                    b.Property<long>("PersonalId")
                        .HasColumnType("bigint");

                    b.Property<long>("ServiceId")
                        .HasColumnType("bigint");

                    b.Property<string>("Spacies")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("PetsEntity.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long>("Number")
                        .HasColumnType("bigint");

                    b.Property<long>("RegularCustomerId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RegularCustomerId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("PetsEntity.RegularCustomer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long>("Number")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("RegularCustomers");
                });

            modelBuilder.Entity("PetsEntity.Service", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<string>("ServiceName")
                        .HasColumnType("text");

                    b.Property<int>("Time")
                        .HasColumnType("integer");

                    b.Property<long>("WorkerId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("WorkerId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("PetsEntity.Worker", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Experience")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long>("Number")
                        .HasColumnType("bigint");

                    b.Property<long>("Salary")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("PetsEntity.Animal", b =>
                {
                    b.HasOne("PetsEntity.Person", "Person")
                        .WithMany("Animals")
                        .HasForeignKey("PersonId");

                    b.HasOne("PetsEntity.Service", "Service")
                        .WithMany("Animals")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("PetsEntity.Person", b =>
                {
                    b.HasOne("PetsEntity.RegularCustomer", "RegularCustomer")
                        .WithMany("Persons")
                        .HasForeignKey("RegularCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegularCustomer");
                });

            modelBuilder.Entity("PetsEntity.Service", b =>
                {
                    b.HasOne("PetsEntity.Worker", "Worker")
                        .WithMany("Services")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("PetsEntity.Person", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("PetsEntity.RegularCustomer", b =>
                {
                    b.Navigation("Persons");
                });

            modelBuilder.Entity("PetsEntity.Service", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("PetsEntity.Worker", b =>
                {
                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
