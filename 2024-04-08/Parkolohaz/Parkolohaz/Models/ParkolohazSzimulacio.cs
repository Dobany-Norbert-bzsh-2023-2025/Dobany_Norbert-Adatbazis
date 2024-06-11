using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkolohaz.Models
{
    public class ParkolohazSzimulacio:DbContext
    {
        public DbSet<Auto> Auto { get; set; }
        public DbSet<Parkolasok> Parkolasok { get; set; }
        public DbSet<Dij> Dij { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("SERVER=127.0.0.1;USERNAME=root;PASSWORD=;DATABASE=parkoloadatbazis");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Dij>().HasKey(pk => new { pk.Rendszam, pk.Vege });
        }
    }
}
