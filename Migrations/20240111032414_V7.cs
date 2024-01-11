using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationX.Migrations
{
    /// <inheritdoc />
    public partial class V7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "asn",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "continent_code",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "country_capital",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "country_code",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "country_flag",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "country_neighbours",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "country_phone",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "currency_plural",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "currency_rates",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "currency_symbol",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "latitude",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "longitude",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "success",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "timezone",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "timezone_dstOffset",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "timezone_gmt",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "timezone_gmtOffset",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "timezone_name",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "type",
                table: "InfoIps");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "InfoIps",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "InfoIps",
                type: "datetime(6)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "InfoIps");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "InfoIps");

            migrationBuilder.AddColumn<string>(
                name: "asn",
                table: "InfoIps",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "continent_code",
                table: "InfoIps",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "country_capital",
                table: "InfoIps",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "country_code",
                table: "InfoIps",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "country_flag",
                table: "InfoIps",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "country_neighbours",
                table: "InfoIps",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "country_phone",
                table: "InfoIps",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "currency_plural",
                table: "InfoIps",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<double>(
                name: "currency_rates",
                table: "InfoIps",
                type: "double",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "currency_symbol",
                table: "InfoIps",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<double>(
                name: "latitude",
                table: "InfoIps",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "longitude",
                table: "InfoIps",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "success",
                table: "InfoIps",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "timezone",
                table: "InfoIps",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "timezone_dstOffset",
                table: "InfoIps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "timezone_gmt",
                table: "InfoIps",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "timezone_gmtOffset",
                table: "InfoIps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "timezone_name",
                table: "InfoIps",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "InfoIps",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
