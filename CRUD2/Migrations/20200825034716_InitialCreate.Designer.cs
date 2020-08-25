﻿// <auto-generated />
using CRUD2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD2.Migrations
{
    [DbContext(typeof(TransactionDbContext))]
    [Migration("20200825034716_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRUD2.Models.TransactionModel", b =>
                {
                    b.Property<int>("TransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountController")
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Amount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("BeneficaryName")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Code")
                        .HasColumnType("varchar(11)");

                    b.HasKey("TransactionID");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
