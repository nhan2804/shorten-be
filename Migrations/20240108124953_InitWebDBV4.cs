using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationX.Migrations
{
    /// <inheritdoc />
    public partial class InitWebDBV4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CodeLink",
                table: "Shortens",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CodeLink",
                table: "Shortens",
                type: "int",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
