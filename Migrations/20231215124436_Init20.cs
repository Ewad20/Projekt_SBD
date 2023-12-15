using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZwierzePlus.Migrations
{
    /// <inheritdoc />
    public partial class Init20 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_zdjecia",
                table: "Szczesliwe_Zakonczenie");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "id_zdjecia",
                table: "Szczesliwe_Zakonczenie",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
