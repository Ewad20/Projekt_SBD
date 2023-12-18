using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZwierzePlus.Model
{
    public class Ksiazeczka_zdrowia
    {
        [Key]
        public long id_ksiazeczki { get; set; }
        public DateTime data_zalozenia { get; set; }
        public string? matka { get; set; }
        public string? ojciec { get; set; }
        public long id_zwierzecia { get; set; }

        [ForeignKey("id_zwierzecia")]
        public virtual Zwierze Zwierze { get; set; }
        public List<Wpis>? Wpis { get; set; }

    }
}
