using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4zad2.Tabele
{
    public class Rozklad_przystanku
    {
        public virtual ICollection<Przystanek> Przystanki { get; set; } = new List<Przystanek>();
        public virtual ICollection<Rozklad_jazdy> Rozklady { get; set; } = new List<Rozklad_jazdy>();
    }
}
