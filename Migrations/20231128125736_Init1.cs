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
                name: "Konto_opiekuna",
                columns: table => new
                {
                    id_konta = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefon = table.Column<int>(type: "int", nullable: false),
                    haslo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konto_opiekuna", x => x.id_konta);
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
                name: "Zwierze",
                columns: table => new
                {
                    id_zwierzecia = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wiek = table.Column<int>(type: "int", nullable: false),
                    plec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    kastracja = table.Column<bool>(type: "bit", nullable: false),
                    opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    historia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_przyjecia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    zaadoptowany = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zwierze", x => x.id_zwierzecia);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gatunek");

            migrationBuilder.DropTable(
                name: "Konto_opiekuna");

            migrationBuilder.DropTable(
                name: "Ksiazeczka_Zdrowia");

            migrationBuilder.DropTable(
                name: "Opiekun");

            migrationBuilder.DropTable(
                name: "Spotkanie");

            migrationBuilder.DropTable(
                name: "Szczesliwe_Zakonczenie");

            migrationBuilder.DropTable(
                name: "Wpis");

            migrationBuilder.DropTable(
                name: "Zdjecie");

            migrationBuilder.DropTable(
                name: "Zgloszenie_adopcyjne");

            migrationBuilder.DropTable(
                name: "Zwierze");
        }
    }
}
