﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SQLInjection.Data;

#nullable disable

namespace SQLInjection.Migrations
{
    [DbContext(typeof(EmployeeDataContext))]
    [Migration("20240413190151_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("SQLInjection.Data.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Employee", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Frank",
                            Password = "pass123",
                            Username = "frank1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bob",
                            Password = "safe321",
                            Username = "coolguy"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sarah",
                            Password = "word17",
                            Username = "haras"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
