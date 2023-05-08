using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4zad2.Tabele
{
    public class Kolejnosc_trasy
    {
        public virtual ICollection<Linia> Linie { get; set; } = new List<Linia>();
        public virtual ICollection<Przystanek> Przystanki { get; set; } = new List<Przystanek>();
    }
}
