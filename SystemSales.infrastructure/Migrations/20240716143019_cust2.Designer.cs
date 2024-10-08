﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SystemSales.infrastructure.Context;

#nullable disable

namespace SystemSales.infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240716143019_cust2")]
    partial class cust2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SystemSales.Data.Entities.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BranchCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("branches");
                });

            modelBuilder.Entity("SystemSales.Data.Entities.Customer", b =>
                {
                    b.Property<string>("CustomerCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerCode");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("SystemSales.Data.Entities.CustomerTransactions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customer_Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_Invoice_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("record_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("voucher_Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("voucher_Credit")
                        .HasColumnType("float");

                    b.Property<double?>("voucher_Debit")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Customer_Code");

                    b.ToTable("customerTransactions");
                });

            modelBuilder.Entity("SystemSales.Data.Entities.CustomerTransactions", b =>
                {
                    b.HasOne("SystemSales.Data.Entities.Customer", "Customer")
                        .WithMany("Transactions")
                        .HasForeignKey("Customer_Code");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("SystemSales.Data.Entities.Customer", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
