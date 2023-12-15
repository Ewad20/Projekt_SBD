using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZwierzePlus.Migrations
{
    /// <inheritdoc />
    public partial class Init19 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Szczesliwe_Zakonczenie_id_zwierzecia",
                table: "Szczesliwe_Zakonczenie",
                column: "id_zwierzecia");

            migrationBuilder.AddForeignKey(
                name: "FK_Szczesliwe_Zakonczenie_Zwierze_id_zwierzecia",
                table: "Szczesliwe_Zakonczenie",
                column: "id_zwierzecia",
                principalTable: "Zwierze",
                principalColumn: "id_zwierzecia",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Szczesliwe_Zakonczenie_Zwierze_id_zwierzecia",
                table: "Szczesliwe_Zakonczenie");

            migrationBuilder.DropIndex(
                name: "IX_Szczesliwe_Zakonczenie_id_zwierzecia",
                table: "Szczesliwe_Zakonczenie");
        }
    }
}
