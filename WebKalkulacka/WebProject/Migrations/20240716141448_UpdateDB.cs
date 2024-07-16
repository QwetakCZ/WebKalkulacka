using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProject.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number1",
                table: "Calculations");

            migrationBuilder.DropColumn(
                name: "Number2",
                table: "Calculations");

            migrationBuilder.AddColumn<string>(
                name: "Numbers",
                table: "Calculations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Numbers",
                table: "Calculations");

            migrationBuilder.AddColumn<double>(
                name: "Number1",
                table: "Calculations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Number2",
                table: "Calculations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
