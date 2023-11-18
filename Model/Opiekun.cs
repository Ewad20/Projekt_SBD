using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZwierzePlus.Model
{
    public class Opiekun
    {
        [Key]
        public long id_opiekuna { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public DateTime data_urodzenia{ get; set; }
        public string plec { get; set; }
        public DateTime data_zatrudnienia { get; set; }
        public long id_konta { get; set; }

        [ForeignKey ("id_konta")]
        public virtual Konto_opiekuna Konto_opiekuna { get; set; }

    }
}
