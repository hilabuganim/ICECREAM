﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace icecream.Migrations.Order
{
    [DbContext(typeof(IceContext))]
    [Migration("20211113225912_Create_Ice")]
    partial class Create_Ice
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("icecream.Models.Addresses", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("houseNumber")
                        .HasColumnType("int");

                    b.Property<string>("street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("icecream.Models.Icecream", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("icecreamDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("icecreamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<int>("sellerId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Icecream");
                });

            modelBuilder.Entity("icecream.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("airPollution")
                        .HasColumnType("float");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("clientFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int>("houseNumber")
                        .HasColumnType("int");

                    b.Property<double>("humidity")
                        .HasColumnType("float");

                    b.Property<int>("icecreamId")
                        .HasColumnType("int");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("temp")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("icecream.Models.Seller", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("houseNumber")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("storeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Seller");
                });
#pragma warning restore 612, 618
        }
    }
}
