﻿// <auto-generated />
using System;
using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExpenseTracker.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Expense_Tracker.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryIcon")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("CategoryTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CategoryType")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Expense_Tracker.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("TransactionAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TransactionNote")
                        .HasColumnType("nvarchar(75)");

                    b.HasKey("TransactionID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Expense_Tracker.Models.Transaction", b =>
                {
                    b.HasOne("Expense_Tracker.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}