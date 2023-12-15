using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZwierzePlus.Model
{
    public class Zgloszenie_adopcyjne
    {
        [Key]
        public long id_zgloszenia { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public DateTime data_urodzenia { get; set; }
        public int numer_kontaktowy { get; set; }
        public string opis_warunkow { get; set; }
        public bool inne_zwierzeta { get; set; }
        public string tresc { get; set; }
        public long? id_zwierzecia { get; set; }

        [ForeignKey("id_zwierzecia")]
        public virtual Zwierze Zwierze { get; set; }
    }
}
