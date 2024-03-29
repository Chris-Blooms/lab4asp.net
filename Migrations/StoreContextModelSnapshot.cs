﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PagesMariaDB.Models;

namespace PagesMariaDB.Migrations
{
    [DbContext(typeof(StoreContext))]
    partial class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("PagesMariaDB.Models.Product", b =>
                {
                    b.Property<uint>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.Property<uint>("Stock")
                        .HasColumnType("int unsigned");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("PagesMariaDB.Models.Rating", b =>
                {
                    b.Property<uint>("RatingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<string>("Comment")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<uint?>("ProductID")
                        .HasColumnType("int unsigned");

                    b.Property<uint>("Score")
                        .HasColumnType("int unsigned");

                    b.HasKey("RatingID");

                    b.HasIndex("ProductID");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("PagesMariaDB.Models.Rating", b =>
                {
                    b.HasOne("PagesMariaDB.Models.Product", "Product")
                        .WithMany("Ratings")
                        .HasForeignKey("ProductID");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PagesMariaDB.Models.Product", b =>
                {
                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
