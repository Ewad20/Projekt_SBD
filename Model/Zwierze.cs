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
       
        //public long id_gatunku { get; set; }
        public bool kastracja { get; set; }
        public string opis { get; set; }
        public string historia { get; set; }
        public DateTime  data_przyjecia { get; set; }
        public long id_zdjecia { get; set; }
      // public long id_ksiazeczki { get; set; }
     //  public long id_zgloszenia { get; set; }
        public bool zaadoptowany { get; set; }
     //  public long id_spotkania { get; set; }

    //    [ForeignKey("id_gatunku")]
    //    public virtual Gatunek Gatunek { get; set; }

         [ForeignKey("id_zdjecia")]
         public virtual Zdjecie Zdjecie { get; set; }

   //     [ForeignKey("id_ksiazeczki")]
    //    public virtual Ksiazeczka_zdrowia Ksiazeczka_zdrowia { get; set; }

    //    [ForeignKey("id_zgloszenia")]
   //     public virtual Zgloszenie_adopcyjne Zgloszenie_Adopcyjne { get; set; }

   //     [ForeignKey("id_spotkania")]
   //     public virtual Spotkanie Spotkanie { get; set; }
    }
}
