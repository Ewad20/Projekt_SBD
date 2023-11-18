using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZwierzePlus.Model
{
    public class Gatunek
    {
        [Key]
        public long id_gatunku { get; set; }
        public string nazwa { get; set; }
        public string typ_rasy { get; set; }
        public int max_wysokosc { get; set; }

    }
}
