using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZwierzePlus.Migrations
{
    /// <inheritdoc />
    public partial class Init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_zgloszenia",
                table: "Zwierze");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "id_zgloszenia",
                table: "Zwierze",
                type: "bigint",
                nullable: true);
        }
    }
}
