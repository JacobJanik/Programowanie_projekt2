using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4zad2.Tabele
{
    public class Kierowca
    {
        [Key]
        [Column("ID_kierowcy")]
        public int Id { get; set; }
        [Required]
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Nr_tel { get; set; }
        public string Adres { get;set; }
        public DateTime Data_ur { get; set; }
    }
}
