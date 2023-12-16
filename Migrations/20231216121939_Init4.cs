using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZwierzePlus.Migrations
{
    /// <inheritdoc />
    public partial class Init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "opis",
                table: "Spotkanie");

            migrationBuilder.AddColumn<string>(
                name: "uwagi",
                table: "Spotkanie",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "uwagi",
                table: "Spotkanie");

            migrationBuilder.AddColumn<string>(
                name: "opis",
                table: "Spotkanie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
