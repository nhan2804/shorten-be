using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationX.Migrations
{
    /// <inheritdoc />
    public partial class InitWebDBV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CodeLink",
                table: "Shortens",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountAccess",
                table: "Shortens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OriginalLink",
                table: "Shortens",
                type: "text",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodeLink",
                table: "Shortens");

            migrationBuilder.DropColumn(
                name: "CountAccess",
                table: "Shortens");

            migrationBuilder.DropColumn(
                name: "OriginalLink",
                table: "Shortens");
        }
    }
}
