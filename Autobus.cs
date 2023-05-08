using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4zad2.Tabele
{
    public class Autobus
    {
        [Key]
        [Column("Nr_rejestracji")]
        public string Id { get; set; }
        [Required]
        public virtual ICollection<Kierowca>Kierowcy { get; set; }= new List<Kierowca>();
        public string Marka { get; set; }
        public string Model { get; set; }

        public DateTime Rocznik { get; set; }
    }
}
