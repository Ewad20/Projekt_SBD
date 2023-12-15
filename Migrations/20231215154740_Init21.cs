using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZwierzePlus.Migrations
{
    /// <inheritdoc />
    public partial class Init21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_wpisu",
                table: "Ksiazeczka_Zdrowia",
                newName: "id_zwierzecia");

            migrationBuilder.AlterColumn<string>(
                name: "ojciec",
                table: "Ksiazeczka_Zdrowia",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "matka",
                table: "Ksiazeczka_Zdrowia",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Ksiazeczka_Zdrowia_id_zwierzecia",
                table: "Ksiazeczka_Zdrowia",
                column: "id_zwierzecia");

            migrationBuilder.AddForeignKey(
                name: "FK_Ksiazeczka_Zdrowia_Zwierze_id_zwierzecia",
                table: "Ksiazeczka_Zdrowia",
                column: "id_zwierzecia",
                principalTable: "Zwierze",
                principalColumn: "id_zwierzecia",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ksiazeczka_Zdrowia_Zwierze_id_zwierzecia",
                table: "Ksiazeczka_Zdrowia");

            migrationBuilder.DropIndex(
                name: "IX_Ksiazeczka_Zdrowia_id_zwierzecia",
                table: "Ksiazeczka_Zdrowia");

            migrationBuilder.RenameColumn(
                name: "id_zwierzecia",
                table: "Ksiazeczka_Zdrowia",
                newName: "id_wpisu");

            migrationBuilder.AlterColumn<string>(
                name: "ojciec",
                table: "Ksiazeczka_Zdrowia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "matka",
                table: "Ksiazeczka_Zdrowia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
