using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationX.Migrations
{
    /// <inheritdoc />
    public partial class InitWebDBV5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Shortens",
                type: "text",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Shortens",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Shortens");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Shortens");
        }
    }
}
