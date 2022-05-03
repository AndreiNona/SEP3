﻿// <auto-generated />
using EfcDataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfcDataBase.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220503132407_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("Entities.Address", b =>
                {
                    b.Property<string>("firsLine")
                        .HasColumnType("TEXT");

                    b.Property<string>("secondLine")
                        .HasColumnType("TEXT");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("zipCode")
                        .HasColumnType("INTEGER");

                    b.HasKey("firsLine", "secondLine");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Entities.Order", b =>
                {
                    b.Property<int>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("clientId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("iscompleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("item")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("orderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Entities.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("height")
                        .HasColumnType("REAL");

                    b.Property<double>("lenght")
                        .HasColumnType("REAL");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("value")
                        .HasColumnType("REAL");

                    b.Property<double>("weight")
                        .HasColumnType("REAL");

                    b.Property<double>("width")
                        .HasColumnType("REAL");

                    b.HasKey("productId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("SecurityLevel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}