using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZwierzePlus.Migrations
{
    /// <inheritdoc />
    public partial class Init18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "numer_kontaktowy",
                table: "Zgloszenie_adopcyjne",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numer_kontaktowy",
                table: "Zgloszenie_adopcyjne");
        }
    }
}
