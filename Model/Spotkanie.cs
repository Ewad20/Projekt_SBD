using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZwierzePlus.Model
{
    public class Spotkanie
    {
        [Key]
        public long id_spotkania { get; set; }
        public DateTime data { get; set; }
        public long id_zgloszenia { get; set; }
        public long id_opiekuna { get; set; }

        [ForeignKey("id_zgloszenia")]
        public virtual Zgloszenie_adopcyjne Zgloszenie_Adopcyjne{ get; set; }

        [ForeignKey("id_opiekuna")]
        public virtual Opiekun Opiekun { get; set; }

    }
}
