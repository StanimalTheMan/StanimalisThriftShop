﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StanimalisThriftShopRazor_Temp.Data;

#nullable disable

namespace StanimalisThriftShopRazor_Temp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240216151732_AddCategoryToDb")]
    partial class AddCategoryToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StanimalisThriftShopRazor_Temp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Jerseys"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Caps"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Collectibles"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}