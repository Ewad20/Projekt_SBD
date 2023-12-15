using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZwierzePlus.Migrations
{
    /// <inheritdoc />
    public partial class Init15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "id_zwierzecia",
                table: "Zgloszenie_adopcyjne",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Zgloszenie_adopcyjne_id_zwierzecia",
                table: "Zgloszenie_adopcyjne",
                column: "id_zwierzecia");

            migrationBuilder.AddForeignKey(
                name: "FK_Zgloszenie_adopcyjne_Zwierze_id_zwierzecia",
                table: "Zgloszenie_adopcyjne",
                column: "id_zwierzecia",
                principalTable: "Zwierze",
                principalColumn: "id_zwierzecia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zgloszenie_adopcyjne_Zwierze_id_zwierzecia",
                table: "Zgloszenie_adopcyjne");

            migrationBuilder.DropIndex(
                name: "IX_Zgloszenie_adopcyjne_id_zwierzecia",
                table: "Zgloszenie_adopcyjne");

            migrationBuilder.DropColumn(
                name: "id_zwierzecia",
                table: "Zgloszenie_adopcyjne");
        }
    }
}
