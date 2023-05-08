using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4zad2.Tabele
{
    public class KomunikacjaContext : DbContext
    {
       public virtual DbSet<Autobus> Autobusy {  get; set; }
       public virtual DbSet<Kierowca>Kierowcy { get; set; }
       public virtual DbSet<Linia>Linie { get; set; }
       public virtual DbSet<Pozycja_kursu>Pozycje { get; set; }
       public virtual DbSet<Przystanek>Przystanki { get; set; }
       public virtual DbSet<Rozklad_jazdy>Rozklady { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\\\SQLExpress;Database=Komunikacja;Trusted_Connection=True;TrustServerCertificate=True;\");\r\n}");
        }
    }
}
