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
        public string opis_warunkow { get; set; }
        public bool inne_zwierzeta { get; set; }
        public string tresc { get; set; }
    }
}
