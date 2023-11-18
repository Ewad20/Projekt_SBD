using Microsoft.EntityFrameworkCore;



namespace ZwierzePlus.Model
{
    public class SchroniskoContext : DbContext
    {
        public DbSet<Opiekun> Opiekun { get; set; }
        public DbSet<Konto_opiekuna> Konto_opiekuna { get; set; }
        public DbSet<Zwierze> Zwierze { get; set; }
        public DbSet<Gatunek> Gatunek { get; set; }
        public DbSet<Zgloszenie_adopcyjne> Zgloszenie_adopcyjne { get; set; }
        public DbSet<Spotkanie> Spotkanie { get; set; }
        public DbSet<Szczesliwe_zakonczenie> Szczesliwe_Zakonczenie { get; set; }
        public DbSet<Zdjecie> Zdjecie { get; set; }
        public DbSet<Ksiazeczka_zdrowia> Ksiazeczka_Zdrowia { get; set; }
        public DbSet<Wpis> Wpis { get; set; }


        public SchroniskoContext(DbContextOptions options) : base(options)
        { 

        }
    }
}
// Jak będę pisać modele to do Init dodaje 2,3,4 
// dotnet ef migrations add Initi++ (2,3,4 itp)
// dotnet ef database update
// przejscie do konsoli = ctrl + ~