﻿// <auto-generated />
using CargoApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CargoApp.Migrations
{
    [DbContext(typeof(ParcelDbContext))]
    [Migration("20230131170950_MyThirdMigration")]
    partial class MyThirdMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CargoApp.Models.Parcel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("parcelDepth")
                        .HasColumnType("int");

                    b.Property<int>("parcelDimensionPrice")
                        .HasColumnType("int");

                    b.Property<double>("parcelFinalPrice")
                        .HasColumnType("float");

                    b.Property<int>("parcelHeight")
                        .HasColumnType("int");

                    b.Property<string>("parcelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("parcelWeight")
                        .HasColumnType("int");

                    b.Property<int>("parcelWeightPrice")
                        .HasColumnType("int");

                    b.Property<int>("parcelWidth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Parcels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            parcelDepth = 100,
                            parcelDimensionPrice = 0,
                            parcelFinalPrice = 0.0,
                            parcelHeight = 100,
                            parcelWeight = 100,
                            parcelWeightPrice = 0,
                            parcelWidth = 100
                        },
                        new
                        {
                            Id = 2,
                            parcelDepth = 50,
                            parcelDimensionPrice = 0,
                            parcelFinalPrice = 0.0,
                            parcelHeight = 50,
                            parcelWeight = 50,
                            parcelWeightPrice = 0,
                            parcelWidth = 50
                        },
                        new
                        {
                            Id = 3,
                            parcelDepth = 25,
                            parcelDimensionPrice = 0,
                            parcelFinalPrice = 0.0,
                            parcelHeight = 25,
                            parcelWeight = 25,
                            parcelWeightPrice = 0,
                            parcelWidth = 25
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
