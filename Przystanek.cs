using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4zad2.Tabele
{
    public class Przystanek
    {
        [Key]
        [Column("Nr_przystanku")]
        public string Id { get; set; }
        [Required]
        public string Nazwa { get; set; }
        public string Lokalizacja { get; set; }
        public virtual ICollection<Rozklad_jazdy> Rozklady { get; set; } = new List<Rozklad_jazdy>();
    }
}
