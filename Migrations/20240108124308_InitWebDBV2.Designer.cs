﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationX.Data;

#nullable disable

namespace WebApplicationX.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240108124308_InitWebDBV2")]
    partial class InitWebDBV2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplicationX.Models.Shorten", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CodeLink")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("CountAccess")
                        .HasColumnType("int");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<int>("OriginalLink")
                        .HasColumnType("ntext");

                    b.HasKey("Id");

                    b.ToTable("Shortens");
                });
#pragma warning restore 612, 618
        }
    }
}
