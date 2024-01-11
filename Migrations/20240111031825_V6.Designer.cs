﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationX.Data;

#nullable disable

namespace WebApplicationX.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240111031825_V6")]
    partial class V6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplicationX.Models.InfoIP", b =>
                {
                    b.Property<int>("IdInfo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ShortenId")
                        .HasColumnType("int");

                    b.Property<string>("asn")
                        .HasColumnType("longtext");

                    b.Property<string>("city")
                        .HasColumnType("text");

                    b.Property<string>("continent")
                        .HasColumnType("text");

                    b.Property<string>("continent_code")
                        .HasColumnType("longtext");

                    b.Property<string>("country")
                        .HasColumnType("text");

                    b.Property<string>("country_capital")
                        .HasColumnType("longtext");

                    b.Property<string>("country_code")
                        .HasColumnType("longtext");

                    b.Property<string>("country_flag")
                        .HasColumnType("longtext");

                    b.Property<string>("country_neighbours")
                        .HasColumnType("longtext");

                    b.Property<string>("country_phone")
                        .HasColumnType("longtext");

                    b.Property<string>("currency")
                        .HasColumnType("text");

                    b.Property<string>("currency_code")
                        .HasColumnType("text");

                    b.Property<string>("currency_plural")
                        .HasColumnType("longtext");

                    b.Property<double?>("currency_rates")
                        .HasColumnType("double");

                    b.Property<string>("currency_symbol")
                        .HasColumnType("longtext");

                    b.Property<string>("ip")
                        .HasColumnType("text");

                    b.Property<string>("isp")
                        .HasColumnType("text");

                    b.Property<double>("latitude")
                        .HasColumnType("double");

                    b.Property<double>("longitude")
                        .HasColumnType("double");

                    b.Property<string>("org")
                        .HasColumnType("text");

                    b.Property<string>("region")
                        .HasColumnType("text");

                    b.Property<bool?>("success")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("timezone")
                        .HasColumnType("longtext");

                    b.Property<int>("timezone_dstOffset")
                        .HasColumnType("int");

                    b.Property<string>("timezone_gmt")
                        .HasColumnType("longtext");

                    b.Property<int>("timezone_gmtOffset")
                        .HasColumnType("int");

                    b.Property<string>("timezone_name")
                        .HasColumnType("longtext");

                    b.Property<string>("type")
                        .HasColumnType("longtext");

                    b.HasKey("IdInfo");

                    b.ToTable("InfoIps");
                });

            modelBuilder.Entity("WebApplicationX.Models.Shorten", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CodeLink")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CountAccess")
                        .HasColumnType("int");

                    b.Property<string>("OriginalLink")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Shortens");
                });
#pragma warning restore 612, 618
        }
    }
}
