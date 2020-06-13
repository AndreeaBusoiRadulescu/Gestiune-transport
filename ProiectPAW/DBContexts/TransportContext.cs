using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Genereaza maparea tabelelor bazei de date cu entitatile din Models.
/// Intelege singur maparea, nu este nevoie sa specificam detalii
/// </summary>

namespace ProiectPAW
{
    class TransportContext : DbContext
    {
        private static bool _created = false;
        public TransportContext()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            String _path = Path.GetFullPath("..\\..\\transporturi.db");
            Console.Write(_path);
            optionsBuilder.UseSqlite("Data source=" + _path);
        }

        public DbSet<Transport> Transporturi { get; set; }
        public DbSet<Sofer> Soferi { get; set; }
        public DbSet<Masina> Masini { get; set; }
    }
}
