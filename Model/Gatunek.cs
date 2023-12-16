using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZwierzePlus.Model
{
    public class Gatunek
    {
        [Key]
        public long id_gatunku { get; set; }
        [Required(ErrorMessage = "Nazwa jest wymagana.")]
        public string nazwa { get; set; }
        [Required(ErrorMessage = "Typ jest wymagany.")]
        public string typ_rasy { get; set; }
        [Required(ErrorMessage = "Wysokość jest wymagana.")]
        public int max_wysokosc { get; set; }

    }
}
