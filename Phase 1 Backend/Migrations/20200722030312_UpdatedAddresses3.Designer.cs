﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Phase_1_Backend.Data;

namespace Phase_1_Backend.Migrations
{
    [DbContext(typeof(StudentContext))]
    [Migration("20200722030312_UpdatedAddresses3")]
    partial class UpdatedAddresses3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Phase_1_Backend.Address", b =>
                {
                    b.Property<int>("addressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("addressType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("postcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)")
                        .HasMaxLength(4);

                    b.Property<string>("street_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("street_num")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("studentID")
                        .HasColumnType("int");

                    b.Property<string>("suburb")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("addressID");

                    b.HasIndex("studentID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Phase_1_Backend.Student", b =>
                {
                    b.Property<int>("studentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("emailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("middleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("timeCreated")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("studentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Phase_1_Backend.Address", b =>
                {
                    b.HasOne("Phase_1_Backend.Student", null)
                        .WithMany("Address")
                        .HasForeignKey("studentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
