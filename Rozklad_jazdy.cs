using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4zad2.Tabele
{
    public class Rozklad_jazdy
    {
        [Key]
        [Column("ID_rozkladu")]
        public int Id { get; set; }
        [Required]
        public int Dni_robocze { get; set; }
        public int Soboty { get; set;}
        public int Niedziele { get; set; }
        public virtual ICollection<Pozycja_kursu> Pozycja { get; set; } = new List<Pozycja_kursu>();
    }
}
