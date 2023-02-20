using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using GestImmo.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using Microsoft.Extensions.Configuration;

namespace GestImmo.Data.DAL
{
    public class ImmoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Utilisation avec le Gestionnaire de Secret : dotnet
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<ImmoContext>()
                .Build();
            var passwordDotnet = configuration["GestImmoPasswordDotnet"];
            var databaseDotnet = configuration["GestImmoDatabaseDotnet"];
            var usernameDotnet = configuration["GestImmoUsernameDotnet"];

            //Configuration avec les Variables d'Environments
            var password = Environment.GetEnvironmentVariable("GestImmoPassword", EnvironmentVariableTarget.User);
            var username = Environment.GetEnvironmentVariable("GestImmoUsername", EnvironmentVariableTarget.User);
            var database = Environment.GetEnvironmentVariable("GestImmoDatabase", EnvironmentVariableTarget.User);

            //Connection à la BDD
            optionsBuilder.UseNpgsql("Host=localhost;Database="+ databaseDotnet + ";Username=" + usernameDotnet + ";Password="+ passwordDotnet);
        }

        public DbSet<Contrat> Contrat { get; set; }

        public DbSet<Bien> Bien { get; set; }

        public DbSet<Intervention> Intervention { get; set; }

        public DbSet<Locataire> Locataire { get; set; }

        public DbSet<Prestataire> Prestataire { get; set; }

        public DbSet<Pret> Pret { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Logement>().ToTable("Logement");
            modelBuilder.Entity<Appartement>().ToTable("Appartement");
            modelBuilder.Entity<Maison>().ToTable("Maison");
            modelBuilder.Entity<Box>().ToTable("Box");
        }

        private static ImmoContext? instance;

        public static ImmoContext getInstance()
        {
            if (instance == null)
            {
                instance = new ImmoContext();
            }

            return instance;
        }

        

    }

}


