using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZwierzePlus.Model
{
    public enum Plec
    {
        Samiec,
        Samica
    }
    public class Zwierze
    {
        [Key]
        public long id_zwierzecia { get; set; }
        public string imie { get; set; }
        public int wiek { get; set; }
        public string plec { get; set; }
        public long id_gatunku { get; set; }

        [ForeignKey("id_gatunku")]
        public virtual Gatunek Gatunek { get; set; }
        public bool kastracja { get; set; }
        public string opis { get; set; }
        public string historia { get; set; }
        public DateTime  data_przyjecia { get; set; }
        public long id_zdjecia { get; set; }

        [ForeignKey("id_zdjecia")]
        public virtual Zdjecie Zdjecie { get; set; }
        public virtual ICollection<Zgloszenie_adopcyjne> Zgloszenia { get; set; }
        public bool zaadoptowany { get; set; }
        public virtual ICollection<Szczesliwe_zakonczenie> Zakonczenia { get; set; }
        public virtual ICollection<Spotkanie> Spotkania { get; set; }

    }
}
