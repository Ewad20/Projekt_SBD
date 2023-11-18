using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZwierzePlus.Migrations
{
    /// <inheritdoc />
    public partial class Init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gatunek",
                columns: table => new
                {
                    id_gatunku = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    typ_rasy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    max_wysokosc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gatunek", x => x.id_gatunku);
                });

            migrationBuilder.CreateTable(
                name: "Wpis",
                columns: table => new
                {
                    id_wpisu = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tytul = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wpis", x => x.id_wpisu);
                });

            migrationBuilder.CreateTable(
                name: "Zdjecie",
                columns: table => new
                {
                    id_zdjecia = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    szerokosc = table.Column<int>(type: "int", nullable: false),
                    wysokosc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zdjecie", x => x.id_zdjecia);
                });

            migrationBuilder.CreateTable(
                name: "Zgloszenie_adopcyjne",
                columns: table => new
                {
                    id_zgloszenia = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_urodzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    opis_warunkow = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    inne_zwierzeta = table.Column<bool>(type: "bit", nullable: false),
                    tresc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zgloszenie_adopcyjne", x => x.id_zgloszenia);
                });

            migrationBuilder.CreateTable(
                name: "Ksiazeczka_Zdrowia",
                columns: table => new
                {
                    id_ksiazeczki = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data_zalozenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    matka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ojciec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_wpisu = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ksiazeczka_Zdrowia", x => x.id_ksiazeczki);
                    table.ForeignKey(
                        name: "FK_Ksiazeczka_Zdrowia_Wpis_id_wpisu",
                        column: x => x.id_wpisu,
                        principalTable: "Wpis",
                        principalColumn: "id_wpisu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Konto_opiekuna",
                columns: table => new
                {
                    id_konta = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefon = table.Column<int>(type: "int", nullable: false),
                    haslo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_zwierzecia = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konto_opiekuna", x => x.id_konta);
                });

            migrationBuilder.CreateTable(
                name: "Opiekun",
                columns: table => new
                {
                    id_opiekuna = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_urodzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    plec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_zatrudnienia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_konta = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opiekun", x => x.id_opiekuna);
                    table.ForeignKey(
                        name: "FK_Opiekun_Konto_opiekuna_id_konta",
                        column: x => x.id_konta,
                        principalTable: "Konto_opiekuna",
                        principalColumn: "id_konta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spotkanie",
                columns: table => new
                {
                    id_spotkania = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_zgloszenia = table.Column<long>(type: "bigint", nullable: false),
                    id_opiekuna = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spotkanie", x => x.id_spotkania);
                    table.ForeignKey(
                        name: "FK_Spotkanie_Opiekun_id_opiekuna",
                        column: x => x.id_opiekuna,
                        principalTable: "Opiekun",
                        principalColumn: "id_opiekuna",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spotkanie_Zgloszenie_adopcyjne_id_zgloszenia",
                        column: x => x.id_zgloszenia,
                        principalTable: "Zgloszenie_adopcyjne",
                        principalColumn: "id_zgloszenia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zwierze",
                columns: table => new
                {
                    id_zwierzecia = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wiek = table.Column<int>(type: "int", nullable: false),
                    plec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_gatunku = table.Column<long>(type: "bigint", nullable: false),
                    kastracja = table.Column<bool>(type: "bit", nullable: false),
                    opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    historia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_przyjecia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_zdjecia = table.Column<long>(type: "bigint", nullable: false),
                    id_ksiazeczki = table.Column<long>(type: "bigint", nullable: false),
                    id_zgloszenia = table.Column<long>(type: "bigint", nullable: false),
                    zaadoptowany = table.Column<bool>(type: "bit", nullable: false),
                    id_spotkania = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zwierze", x => x.id_zwierzecia);
                    table.ForeignKey(
                        name: "FK_Zwierze_Gatunek_id_gatunku",
                        column: x => x.id_gatunku,
                        principalTable: "Gatunek",
                        principalColumn: "id_gatunku",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zwierze_Ksiazeczka_Zdrowia_id_ksiazeczki",
                        column: x => x.id_ksiazeczki,
                        principalTable: "Ksiazeczka_Zdrowia",
                        principalColumn: "id_ksiazeczki",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zwierze_Spotkanie_id_spotkania",
                        column: x => x.id_spotkania,
                        principalTable: "Spotkanie",
                        principalColumn: "id_spotkania",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zwierze_Zdjecie_id_zdjecia",
                        column: x => x.id_zdjecia,
                        principalTable: "Zdjecie",
                        principalColumn: "id_zdjecia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zwierze_Zgloszenie_adopcyjne_id_zgloszenia",
                        column: x => x.id_zgloszenia,
                        principalTable: "Zgloszenie_adopcyjne",
                        principalColumn: "id_zgloszenia",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Szczesliwe_Zakonczenie",
                columns: table => new
                {
                    id_zakonczenia = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_zwierzecia = table.Column<long>(type: "bigint", nullable: false),
                    opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_zdjecia = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Szczesliwe_Zakonczenie", x => x.id_zakonczenia);
                    table.ForeignKey(
                        name: "FK_Szczesliwe_Zakonczenie_Zdjecie_id_zdjecia",
                        column: x => x.id_zdjecia,
                        principalTable: "Zdjecie",
                        principalColumn: "id_zdjecia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Szczesliwe_Zakonczenie_Zwierze_id_zwierzecia",
                        column: x => x.id_zwierzecia,
                        principalTable: "Zwierze",
                        principalColumn: "id_zwierzecia",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Konto_opiekuna_id_zwierzecia",
                table: "Konto_opiekuna",
                column: "id_zwierzecia");

            migrationBuilder.CreateIndex(
                name: "IX_Ksiazeczka_Zdrowia_id_wpisu",
                table: "Ksiazeczka_Zdrowia",
                column: "id_wpisu");

            migrationBuilder.CreateIndex(
                name: "IX_Opiekun_id_konta",
                table: "Opiekun",
                column: "id_konta");

            migrationBuilder.CreateIndex(
                name: "IX_Spotkanie_id_opiekuna",
                table: "Spotkanie",
                column: "id_opiekuna");

            migrationBuilder.CreateIndex(
                name: "IX_Spotkanie_id_zgloszenia",
                table: "Spotkanie",
                column: "id_zgloszenia");

            migrationBuilder.CreateIndex(
                name: "IX_Szczesliwe_Zakonczenie_id_zdjecia",
                table: "Szczesliwe_Zakonczenie",
                column: "id_zdjecia");

            migrationBuilder.CreateIndex(
                name: "IX_Szczesliwe_Zakonczenie_id_zwierzecia",
                table: "Szczesliwe_Zakonczenie",
                column: "id_zwierzecia");

            migrationBuilder.CreateIndex(
                name: "IX_Zwierze_id_gatunku",
                table: "Zwierze",
                column: "id_gatunku");

            migrationBuilder.CreateIndex(
                name: "IX_Zwierze_id_ksiazeczki",
                table: "Zwierze",
                column: "id_ksiazeczki");

            migrationBuilder.CreateIndex(
                name: "IX_Zwierze_id_spotkania",
                table: "Zwierze",
                column: "id_spotkania");

            migrationBuilder.CreateIndex(
                name: "IX_Zwierze_id_zdjecia",
                table: "Zwierze",
                column: "id_zdjecia");

            migrationBuilder.CreateIndex(
                name: "IX_Zwierze_id_zgloszenia",
                table: "Zwierze",
                column: "id_zgloszenia");

            migrationBuilder.AddForeignKey(
                name: "FK_Konto_opiekuna_Zwierze_id_zwierzecia",
                table: "Konto_opiekuna",
                column: "id_zwierzecia",
                principalTable: "Zwierze",
                principalColumn: "id_zwierzecia",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Konto_opiekuna_Zwierze_id_zwierzecia",
                table: "Konto_opiekuna");

            migrationBuilder.DropTable(
                name: "Szczesliwe_Zakonczenie");

            migrationBuilder.DropTable(
                name: "Zwierze");

            migrationBuilder.DropTable(
                name: "Gatunek");

            migrationBuilder.DropTable(
                name: "Ksiazeczka_Zdrowia");

            migrationBuilder.DropTable(
                name: "Spotkanie");

            migrationBuilder.DropTable(
                name: "Zdjecie");

            migrationBuilder.DropTable(
                name: "Wpis");

            migrationBuilder.DropTable(
                name: "Opiekun");

            migrationBuilder.DropTable(
                name: "Zgloszenie_adopcyjne");

            migrationBuilder.DropTable(
                name: "Konto_opiekuna");
        }
    }
}
