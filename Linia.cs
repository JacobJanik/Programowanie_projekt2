using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4zad2.Tabele
{
    public class Linia
    {
        [Key]
        [Column("Nr_linii")]
        public int Id { get; set; }
        [Required]
        public virtual ICollection<Autobus> Autobusy { get; set; } = new List<Autobus>();
        public string Kierunek { get; set; }
    }
}
