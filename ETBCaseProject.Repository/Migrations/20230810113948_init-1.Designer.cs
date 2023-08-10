﻿// <auto-generated />
using System;
using ETBCaseProject.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ETBCaseProject.Repository.Migrations
{
    [DbContext(typeof(EtbDbContext))]
    [Migration("20230810113948_init-1")]
    partial class init1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ETBCaseProject.Core.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1993, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1492),
                            CreatedDate = new DateTime(2023, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1520),
                            MailAddress = "mehmetyilmaz@gmail.com",
                            Name = "Mehmet",
                            PhoneNumber = "05334567891",
                            Surname = "Yıldırım"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1998, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1524),
                            CreatedDate = new DateTime(2023, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1525),
                            MailAddress = "cenkkilic@gmail.com",
                            Name = "Cenk",
                            PhoneNumber = "05354577891",
                            Surname = "Kılıç"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1983, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1529),
                            CreatedDate = new DateTime(2023, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1530),
                            MailAddress = "cerenanac@gmail.com",
                            Name = "Ceren",
                            PhoneNumber = "05334578681",
                            Surname = "Anaç"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1983, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1532),
                            CreatedDate = new DateTime(2023, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1534),
                            MailAddress = "mertaltin@gmail.com",
                            Name = "Mert",
                            PhoneNumber = "05334578681",
                            Surname = "Altın"
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(1983, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1536),
                            CreatedDate = new DateTime(2023, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1537),
                            MailAddress = "hüseyindagli@gmail.com",
                            Name = "Hüseyin",
                            PhoneNumber = "05334578681",
                            Surname = "Dağlı"
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(1983, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1540),
                            CreatedDate = new DateTime(2023, 8, 10, 14, 39, 48, 790, DateTimeKind.Local).AddTicks(1541),
                            MailAddress = "buseeren@gmail.com",
                            Name = "Buse",
                            PhoneNumber = "05334578681",
                            Surname = "Eren"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
