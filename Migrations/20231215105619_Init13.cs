using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZwierzePlus.Migrations
{
    /// <inheritdoc />
    public partial class Init13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zgloszenie_adopcyjne_Zwierze_Zwierzeid_zwierzecia",
                table: "Zgloszenie_adopcyjne");

            migrationBuilder.DropIndex(
                name: "IX_Zgloszenie_adopcyjne_Zwierzeid_zwierzecia",
                table: "Zgloszenie_adopcyjne");

            migrationBuilder.DropColumn(
                name: "Zwierzeid_zwierzecia",
                table: "Zgloszenie_adopcyjne");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Zwierzeid_zwierzecia",
                table: "Zgloszenie_adopcyjne",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Zgloszenie_adopcyjne_Zwierzeid_zwierzecia",
                table: "Zgloszenie_adopcyjne",
                column: "Zwierzeid_zwierzecia");

            migrationBuilder.AddForeignKey(
                name: "FK_Zgloszenie_adopcyjne_Zwierze_Zwierzeid_zwierzecia",
                table: "Zgloszenie_adopcyjne",
                column: "Zwierzeid_zwierzecia",
                principalTable: "Zwierze",
                principalColumn: "id_zwierzecia");
        }
    }
}
