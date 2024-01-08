using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationX.Migrations
{
    /// <inheritdoc />
    public partial class InitWebDBV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Shortens");

            migrationBuilder.AlterColumn<string>(
                name: "OriginalLink",
                table: "Shortens",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "ntext")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OriginalLink",
                table: "Shortens",
                type: "ntext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "Shortens",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
