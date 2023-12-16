using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZwierzePlus.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spotkanie_Zwierze_Zwierzeid_zwierzecia",
                table: "Spotkanie");

            migrationBuilder.DropIndex(
                name: "IX_Spotkanie_Zwierzeid_zwierzecia",
                table: "Spotkanie");

            migrationBuilder.DropColumn(
                name: "Zwierzeid_zwierzecia",
                table: "Spotkanie");

            migrationBuilder.DropColumn(
                name: "id_opiekuna",
                table: "Spotkanie");

            migrationBuilder.RenameColumn(
                name: "id_zgloszenia",
                table: "Spotkanie",
                newName: "id_zwierzecia");

            migrationBuilder.AddColumn<string>(
                name: "imie",
                table: "Spotkanie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nazwisko",
                table: "Spotkanie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "numer_telefonu",
                table: "Spotkanie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "opis",
                table: "Spotkanie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Spotkanie_id_zwierzecia",
                table: "Spotkanie",
                column: "id_zwierzecia");

            migrationBuilder.AddForeignKey(
                name: "FK_Spotkanie_Zwierze_id_zwierzecia",
                table: "Spotkanie",
                column: "id_zwierzecia",
                principalTable: "Zwierze",
                principalColumn: "id_zwierzecia",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spotkanie_Zwierze_id_zwierzecia",
                table: "Spotkanie");

            migrationBuilder.DropIndex(
                name: "IX_Spotkanie_id_zwierzecia",
                table: "Spotkanie");

            migrationBuilder.DropColumn(
                name: "imie",
                table: "Spotkanie");

            migrationBuilder.DropColumn(
                name: "nazwisko",
                table: "Spotkanie");

            migrationBuilder.DropColumn(
                name: "numer_telefonu",
                table: "Spotkanie");

            migrationBuilder.DropColumn(
                name: "opis",
                table: "Spotkanie");

            migrationBuilder.RenameColumn(
                name: "id_zwierzecia",
                table: "Spotkanie",
                newName: "id_zgloszenia");

            migrationBuilder.AddColumn<long>(
                name: "Zwierzeid_zwierzecia",
                table: "Spotkanie",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "id_opiekuna",
                table: "Spotkanie",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Spotkanie_Zwierzeid_zwierzecia",
                table: "Spotkanie",
                column: "Zwierzeid_zwierzecia");

            migrationBuilder.AddForeignKey(
                name: "FK_Spotkanie_Zwierze_Zwierzeid_zwierzecia",
                table: "Spotkanie",
                column: "Zwierzeid_zwierzecia",
                principalTable: "Zwierze",
                principalColumn: "id_zwierzecia");
        }
    }
}
