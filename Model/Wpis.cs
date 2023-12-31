﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZwierzePlus.Model
{
    public class Wpis
    {
        [Key]
        public long id_wpisu { get; set; }
        public DateTime data { get; set; }
        public string tytul { get; set; }
        public string opis{ get; set; }
        public long id_ksiazeczki { get; set; }

        [ForeignKey("id_ksiazeczki")]
        public virtual Ksiazeczka_zdrowia Ksiazeczka { get; set; }
    }
}
