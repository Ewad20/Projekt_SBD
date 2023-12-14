using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZwierzePlus.Migrations
{
    /// <inheritdoc />
    public partial class zdjecie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "id_zdjecia",
                table: "Zwierze",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Zwierze_id_zdjecia",
                table: "Zwierze",
                column: "id_zdjecia");

            migrationBuilder.AddForeignKey(
                name: "FK_Zwierze_Zdjecie_id_zdjecia",
                table: "Zwierze",
                column: "id_zdjecia",
                principalTable: "Zdjecie",
                principalColumn: "id_zdjecia",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zwierze_Zdjecie_id_zdjecia",
                table: "Zwierze");

            migrationBuilder.DropIndex(
                name: "IX_Zwierze_id_zdjecia",
                table: "Zwierze");

            migrationBuilder.DropColumn(
                name: "id_zdjecia",
                table: "Zwierze");
        }
    }
}
