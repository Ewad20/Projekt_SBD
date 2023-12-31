﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZwierzePlus.Model
{
    public class Konto_opiekuna
    {
        [Key]
        public long id_konta { get; set; }
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Wprowadź prawidłowy adres e-mail.")]
        [Required(ErrorMessage = "Email jest wymagany.")]
        public string email { get; set; }
        [Required(ErrorMessage = "Numer telefonu jest wymagany.")]
        public int telefon { get; set; }
        [Required(ErrorMessage = "Hasło jest wymagane.")]
        [DataType(DataType.Password)]
        public string haslo { get; set; }
       
        // public long id_zwierzecia { get; set; }

       // [ForeignKey("id_zwierzecia")]
       // public virtual Zwierze Zwierze { get; set; }
  }
}
