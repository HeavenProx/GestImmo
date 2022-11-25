using System.Collections;
using System.Collections.Generic;
using GestImmo.Data.Models;
using GestImmo.Models;
using Microsoft.EntityFrameworkCore;

namespace GestImmo.DAL
{
    public class GestImmoContext : DbContext
    {
        public DbSet<Biens> Bien { get; set; }
        public DbSet<Contrat>? Contrats { get; set; }
        public DbSet<Pret>? Prets { get; set; }
        public DbSet<Locataire>? Locataires { get; set; }
        public DbSet<Intervention>? Interventions { get; set; }
        public DbSet<Prestataire>? Prestataires { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Database=GestImmo;Username=postgres;Password=Hugoemma1103");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Habitat>().ToTable("Habitat");
            modelBuilder.Entity<Maison>().ToTable("Maison");
            modelBuilder.Entity<Box>().ToTable("Box");
            modelBuilder.Entity<Appartement>().ToTable("Appartement");
        }

        public static GestImmoContext? instance;

        public static GestImmoContext getInstance()
        {
            if (instance == null)
            {
                instance = new GestImmoContext();
            }
            return instance;
        }

    }

    //GestImmoContext ctx = GestImmoContext.getInstance();

    /*foreach(Biens bien in ctx.Biens)
    {
        this.lstBiens.Items.Add(Biens.Nom);
    }*/
}
