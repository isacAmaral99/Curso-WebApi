using EFCoreWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreWebApi.Data
{
    public class HeroiContext :DbContext
    {

        public DbSet<Heroi> Herois { get; set; }

        public DbSet<Batalha> Batalhas { get; set; }

        public DbSet<Arma> Armas { get; set; }

        public DbSet<HeroiBatalha> HeroiBatalha { get; set; }

        public DbSet<IdentidadeSecreta> IdentidadeSecreta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HeroApp;Data Source=desktop-ouvkjrn\\sqlexpress");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(entity => 
            {
                entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
            });
        }
    }
}
