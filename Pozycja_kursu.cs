using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4zad2.Tabele
{
    public class Pozycja_kursu
    {
        [Key]
        [Column("ID_pozycji")]
        public int Id { get; set; }
        [Required]
        public string Status { get; set; }
        public DateTime Odjazd { get; set; }
    }
}
