using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZwierzePlus.Model
{
    public class Szczesliwe_zakonczenie
    {
        [Key]
        public long id_zakonczenia{ get; set; }
        public long id_zwierzecia { get; set; }

        [ForeignKey("id_zwierzecia")]
        public virtual Zwierze Zwierze { get; set; }
        public string opis { get; set; }
       // public long id_zdjecia { get; set; }

    }
}
