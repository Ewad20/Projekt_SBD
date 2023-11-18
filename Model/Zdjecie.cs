using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZwierzePlus.Model
{
    public class Zdjecie
    {
        [Key]
        public long id_zdjecia { get; set; }
        public string link { get; set; }
        public int szerokosc { get; set; }
        public int wysokosc { get; set; }
    }
}
