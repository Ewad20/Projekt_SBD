using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZwierzePlus.Model
{
    public class Spotkanie
    {
        [Key]
        public long id_spotkania { get; set; }
        public DateTime data { get; set; }
        public string? uwagi { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int numer_telefonu { get; set; }

        public long id_zwierzecia { get; set; }
        [ForeignKey("id_zwierzecia")]
        public virtual Zwierze Zwierze { get; set; }
    }
}
