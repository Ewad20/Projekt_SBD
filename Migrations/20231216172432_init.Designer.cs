﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZwierzePlus.Model;

#nullable disable

namespace ZwierzePlus.Migrations
{
    [DbContext(typeof(SchroniskoContext))]
    [Migration("20231216172432_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ZwierzePlus.Model.Gatunek", b =>
                {
                    b.Property<long>("id_gatunku")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id_gatunku"));

                    b.Property<int>("max_wysokosc")
                        .HasColumnType("int");

                    b.Property<string>("nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("typ_rasy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_gatunku");

                    b.ToTable("Gatunek");
                });

            modelBuilder.Entity("ZwierzePlus.Model.Konto_opiekuna", b =>
                {
                    b.Property<long>("id_konta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id_konta"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("haslo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("telefon")
                        .HasColumnType("int");

                    b.HasKey("id_konta");

                    b.ToTable("Konto_opiekuna");
                });

            modelBuilder.Entity("ZwierzePlus.Model.Ksiazeczka_zdrowia", b =>
                {
                    b.Property<long>("id_ksiazeczki")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id_ksiazeczki"));

                    b.Property<DateTime>("data_zalozenia")
                        .HasColumnType("datetime2");

                    b.Property<long>("id_zwierzecia")
                        .HasColumnType("bigint");

                    b.Property<string>("matka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ojciec")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_ksiazeczki");

                    b.HasIndex("id_zwierzecia");

                    b.ToTable("Ksiazeczka_Zdrowia");
                });

            modelBuilder.Entity("ZwierzePlus.Model.Opiekun", b =>
                {
                    b.Property<long>("id_opiekuna")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id_opiekuna"));

                    b.Property<DateTime>("data_urodzenia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("data_zatrudnienia")
                        .HasColumnType("datetime2");

                    b.Property<long?>("id_konta")
                        .HasColumnType("bigint");

                    b.Property<string>("imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("plec")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_opiekuna");

                    b.ToTable("Opiekun");
                });

            modelBuilder.Entity("ZwierzePlus.Model.Spotkanie", b =>
                {
                    b.Property<long>("id_spotkania")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id_spotkania"));

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<long>("id_zwierzecia")
                        .HasColumnType("bigint");

                    b.Property<string>("imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numer_telefonu")
                        .HasColumnType("int");

                    b.Property<string>("uwagi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_spotkania");

                    b.HasIndex("id_zwierzecia");

                    b.ToTable("Spotkanie");
                });

            modelBuilder.Entity("ZwierzePlus.Model.Szczesliwe_zakonczenie", b =>
                {
                    b.Property<long>("id_zakonczenia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id_zakonczenia"));

                    b.Property<long>("id_zwierzecia")
                        .HasColumnType("bigint");

                    b.Property<string>("opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zdjecie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_zakonczenia");

                    b.HasIndex("id_zwierzecia");

                    b.ToTable("Szczesliwe_Zakonczenie");
                });

            modelBuilder.Entity("ZwierzePlus.Model.Wpis", b =>
                {
                    b.Property<long>("id_wpisu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id_wpisu"));

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<long>("id_ksiazeczki")
                        .HasColumnType("bigint");

                    b.Property<string>("opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tytul")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_wpisu");

                    b.HasIndex("id_ksiazeczki");

                    b.ToTable("Wpis");
                });

            modelBuilder.Entity("ZwierzePlus.Model.Zdjecie", b =>
                {
                    b.Property<long>("id_zdjecia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id_zdjecia"));

                    b.Property<string>("link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("szerokosc")
                        .HasColumnType("int");

                    b.Property<int>("wysokosc")
                        .HasColumnType("int");

                    b.HasKey("id_zdjecia");

                    b.ToTable("Zdjecie");
                });

            modelBuilder.Entity("ZwierzePlus.Model.Zgloszenie_adopcyjne", b =>
                {
                    b.Property<long>("id_zgloszenia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id_zgloszenia"));

                    b.Property<DateTime>("data_urodzenia")
                        .HasColumnType("datetime2");

                    b.Property<long?>("id_zwierzecia")
                        .HasColumnType("bigint");

                    b.Property<string>("imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("inne_zwierzeta")
                        .HasColumnType("bit");

                    b.Property<string>("nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numer_kontaktowy")
                        .HasColumnType("int");

                    b.Property<string>("opis_warunkow")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tresc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_zgloszenia");

                    b.HasIndex("id_zwierzecia");

                    b.ToTable("Zgloszenie_adopcyjne");
                });

            modelBuilder.Entity("ZwierzePlus.Model.Zwierze", b =>
                {
                    b.Property<long>("id_zwierzecia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id_zwierzecia"));

                    b.Property<DateTime>("data_przyjecia")
                        .HasColumnType("datetime2");

                    b.Property<string>("historia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("id_gatunku")
                        .HasColumnType("bigint");

                    b.Property<long>("id_zdjecia")
                        .HasColumnType("bigint");

                    b.Property<string>("imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("kastracja")
                        .HasColumnType("bit");

                    b.Property<string>("opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("plec")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("wiek")
                        .HasColumnType("int");

                    b.Property<bool>("zaadoptowany")
                        .HasColumnType("bit");

                    b.HasKey("id_zwierzecia");

                    b.HasIndex("id_gatunku");

                    b.HasIndex("id_zdjecia");

                    b.ToTable("Zwierze");
                });

            modelBuilder.Entity("ZwierzePlus.Model.Ksiazeczka_zdrowia", b =>
                {
                    b.HasOne("ZwierzePlus.Model.Zwierze", "Zwierze")
                        .WithMany()
                        .HasForeignKey("id_zwierzecia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zwierze");
                });

            modelBuilder.Entity("ZwierzePlus.Model.Spotkanie", b =>
                {
                    b.HasOne("ZwierzePlus.Model.Zwierze", "Zwierze")
                        .WithMany("Spotkania")
                        .HasForeignKey("id_zwierzecia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zwierze");
                });

            modelBuilder.Entity("ZwierzePlus.Model.Szczesliwe_zakonczenie", b =>
                {
                    b.HasOne("ZwierzePlus.Model.Zwierze", "Zwierze")
                        .WithMany("Zakonczenia")
                        .HasForeignKey("id_zwierzecia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zwierze");
                });

            modelBuilder.Entity("ZwierzePlus.Model.Wpis", b =>
                {
                    b.HasOne("ZwierzePlus.Model.Ksiazeczka_zdrowia", "Ksiazeczka")
                        .WithMany("Wpis")
                        .HasForeignKey("id_ksiazeczki")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ksiazeczka");
                });

            modelBuilder.Entity("ZwierzePlus.Model.Zgloszenie_adopcyjne", b =>
                {
                    b.HasOne("ZwierzePlus.Model.Zwierze", "Zwierze")
                        .WithMany("Zgloszenia")
                        .HasForeignKey("id_zwierzecia");

                    b.Navigation("Zwierze");
                });

            modelBuilder.Entity("ZwierzePlus.Model.Zwierze", b =>
                {
                    b.HasOne("ZwierzePlus.Model.Gatunek", "Gatunek")
                        .WithMany()
                        .HasForeignKey("id_gatunku")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZwierzePlus.Model.Zdjecie", "Zdjecie")
                        .WithMany()
                        .HasForeignKey("id_zdjecia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gatunek");

                    b.Navigation("Zdjecie");
                });

            modelBuilder.Entity("ZwierzePlus.Model.Ksiazeczka_zdrowia", b =>
                {
                    b.Navigation("Wpis");
                });

            modelBuilder.Entity("ZwierzePlus.Model.Zwierze", b =>
                {
                    b.Navigation("Spotkania");

                    b.Navigation("Zakonczenia");

                    b.Navigation("Zgloszenia");
                });
#pragma warning restore 612, 618
        }
    }
}
