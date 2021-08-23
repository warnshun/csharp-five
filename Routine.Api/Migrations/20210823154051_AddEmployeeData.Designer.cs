﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Routine.Api.Data;

namespace Routine.Api.Migrations
{
    [DbContext(typeof(RoutineDbContext))]
    [Migration("20210823154051_AddEmployeeData")]
    partial class AddEmployeeData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("Routine.Api.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Introduction")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            Introduction = "Microsoft Company",
                            Name = "Microsoft"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            Introduction = "Google Company",
                            Name = "Google"
                        },
                        new
                        {
                            Id = new Guid("5efc910b-2f45-43df-afae-620d40542853"),
                            Introduction = "Apple Company",
                            Name = "Apple"
                        });
                });

            modelBuilder.Entity("Routine.Api.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5b9e8ecd-71a5-46b5-8ec4-2a7a002d9ada"),
                            CompanyId = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            DateOfBirth = new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "MS231",
                            FirstName = "Nick",
                            Gender = 1,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("2e1c7b17-b912-43ed-896c-652735a00b6d"),
                            CompanyId = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            DateOfBirth = new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "MS245",
                            FirstName = "Vince",
                            Gender = 1,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("eb6401ae-9113-4d6c-9d2d-e9cc6208f1c6"),
                            CompanyId = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            DateOfBirth = new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "MS279",
                            FirstName = "Maria",
                            Gender = 0,
                            LastName = "Los"
                        },
                        new
                        {
                            Id = new Guid("7e2ebe97-11da-4b62-b644-f2885b7f038c"),
                            CompanyId = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            DateOfBirth = new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "GG231",
                            FirstName = "Nick",
                            Gender = 1,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("7061fd5a-b7ee-45a0-8a97-566f6dfc5c2e"),
                            CompanyId = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            DateOfBirth = new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "GG245",
                            FirstName = "Vince",
                            Gender = 1,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("94981ae0-0954-446c-87a8-58abbdbe8d6f"),
                            CompanyId = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            DateOfBirth = new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "GG279",
                            FirstName = "Maria",
                            Gender = 0,
                            LastName = "Los"
                        },
                        new
                        {
                            Id = new Guid("bbbf271a-e6f9-4584-a882-236e51114f6f"),
                            CompanyId = new Guid("5efc910b-2f45-43df-afae-620d40542853"),
                            DateOfBirth = new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "AP231",
                            FirstName = "Nick",
                            Gender = 1,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("86d7915c-2575-438a-ac40-47ddaafa3708"),
                            CompanyId = new Guid("5efc910b-2f45-43df-afae-620d40542853"),
                            DateOfBirth = new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "AP245",
                            FirstName = "Vince",
                            Gender = 1,
                            LastName = "Carter"
                        },
                        new
                        {
                            Id = new Guid("4666e3ea-d14f-4996-a036-b3737bbda486"),
                            CompanyId = new Guid("5efc910b-2f45-43df-afae-620d40542853"),
                            DateOfBirth = new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "AP279",
                            FirstName = "Maria",
                            Gender = 0,
                            LastName = "Los"
                        });
                });

            modelBuilder.Entity("Routine.Api.Entities.Employee", b =>
                {
                    b.HasOne("Routine.Api.Entities.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Routine.Api.Entities.Company", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}