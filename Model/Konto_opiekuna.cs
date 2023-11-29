using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZwierzePlus.Model
{
    public class Konto_opiekuna
    {
        [Key]
        public long id_konta { get; set; }
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Wprowadź prawidłowy adres e-mail.")]
        public string email { get; set; }
        public int telefon { get; set; }
        public string haslo { get; set; }
       
        // public long id_zwierzecia { get; set; }

       // [ForeignKey("id_zwierzecia")]
       // public virtual Zwierze Zwierze { get; set; }
  }
}
