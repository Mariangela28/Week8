using FinalFantasy.FinalFantasy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.FinalFantasy.RepositoriesEF
{
    public class FinalFantasyContext : DbContext

    {
        public DbSet<Giocatore> Giocatori { get; set; }
        public DbSet<Mostro> Mostri { get; set; }
        public DbSet<Eroe> Eroi { get; set; }
        public DbSet<Livello> Livelli { get; set; }
        public DbSet<Arma> Armi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
        {
            optBuilder.UseSqlServer(@"Persist Security Info = False; Integrated Security = true; 
                                    Initial Catalog = FinalFantasy; Server = .\SQLEXPRESS");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration<Giocatore>(new GiocatoreConfiguration());
            modelBuilder.ApplyConfiguration<Mostro>(new MostroConfiguration());
            modelBuilder.ApplyConfiguration<Eroe>(new EroeConfiguration());
            modelBuilder.ApplyConfiguration<Livello>(new LivelloConfiguration());
            modelBuilder.ApplyConfiguration<Arma>(new ArmaConfiguration());
        }




    }
}
