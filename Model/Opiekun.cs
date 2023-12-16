using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZwierzePlus.Model
{
    public class Opiekun
    {
        [Key]
        public long id_opiekuna { get; set; }
        [Required(ErrorMessage = "Imię jest wymagane.")]
        public string imie { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane.")]
        public string nazwisko { get; set; }
        public DateTime data_urodzenia{ get; set; }
        public string plec { get; set; }
        public DateTime data_zatrudnienia { get; set; }
        [Required(ErrorMessage = "Kod jest wymagany.")]
        public string kod { get; set; }
        public long id_konta { get; set; }

      //  [ForeignKey ("id_konta")]
     //   public virtual Konto_opiekuna Konto_opiekuna { get; set; }

    }
}
