// <auto-generated />
using System;
using GestImmo.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GestImmo.Migrations
{
    [DbContext(typeof(GestImmoContext))]
    [Migration("20221124160249_test3")]
    partial class test3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GestImmo.Models.Biens", b =>
                {
                    b.Property<int>("BiensId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BiensId"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Surface")
                        .HasColumnType("integer");

                    b.Property<int>("Valeur")
                        .HasColumnType("integer");

                    b.HasKey("BiensId");

                    b.ToTable("Bien");
                });

            modelBuilder.Entity("GestImmo.Models.Contrat", b =>
                {
                    b.Property<int>("ContratId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ContratId"));

                    b.Property<int>("BiensId")
                        .HasColumnType("integer");

                    b.Property<string>("DateDebut")
                        .HasColumnType("text");

                    b.Property<string>("DateFin")
                        .HasColumnType("text");

                    b.Property<int>("Loyer")
                        .HasColumnType("integer");

                    b.HasKey("ContratId");

                    b.HasIndex("BiensId");

                    b.ToTable("Contrats");
                });

            modelBuilder.Entity("GestImmo.Models.Intervention", b =>
                {
                    b.Property<int>("InterventionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("InterventionId"));

                    b.Property<int>("Date")
                        .HasColumnType("integer");

                    b.Property<string>("Information")
                        .HasColumnType("text");

                    b.Property<int>("MontantTTC")
                        .HasColumnType("integer");

                    b.Property<int>("UnBienBiensId")
                        .HasColumnType("integer");

                    b.HasKey("InterventionId");

                    b.HasIndex("UnBienBiensId");

                    b.ToTable("Interventions");
                });

            modelBuilder.Entity("GestImmo.Models.Locataire", b =>
                {
                    b.Property<int>("LocataireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LocataireId"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("NomLoc")
                        .HasColumnType("text");

                    b.Property<string>("PrenomLoc")
                        .HasColumnType("text");

                    b.Property<string>("Profession")
                        .HasColumnType("text");

                    b.HasKey("LocataireId");

                    b.ToTable("Locataires");
                });

            modelBuilder.Entity("GestImmo.Models.Prestataire", b =>
                {
                    b.Property<int>("PrestataireId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PrestataireId"));

                    b.Property<string>("AdresseEntreprise")
                        .HasColumnType("text");

                    b.Property<string>("Nom")
                        .HasColumnType("text");

                    b.Property<string>("Prenom")
                        .HasColumnType("text");

                    b.Property<string>("RaisonSociale")
                        .HasColumnType("text");

                    b.Property<string>("Telephone")
                        .HasColumnType("text");

                    b.HasKey("PrestataireId");

                    b.ToTable("Prestataires");
                });

            modelBuilder.Entity("GestImmo.Models.Pret", b =>
                {
                    b.Property<int>("PretId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PretId"));

                    b.Property<int>("Apport")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DebutPret")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Duree")
                        .HasColumnType("integer");

                    b.Property<int>("Mensualite")
                        .HasColumnType("integer");

                    b.Property<int>("UnBienBiensId")
                        .HasColumnType("integer");

                    b.HasKey("PretId");

                    b.HasIndex("UnBienBiensId");

                    b.ToTable("Prets");
                });

            modelBuilder.Entity("InterventionPrestataire", b =>
                {
                    b.Property<int>("InterventionListInterventionId")
                        .HasColumnType("integer");

                    b.Property<int>("ListPresta1PrestataireId")
                        .HasColumnType("integer");

                    b.HasKey("InterventionListInterventionId", "ListPresta1PrestataireId");

                    b.HasIndex("ListPresta1PrestataireId");

                    b.ToTable("InterventionPrestataire");
                });

            modelBuilder.Entity("GestImmo.Models.Box", b =>
                {
                    b.HasBaseType("GestImmo.Models.Biens");

                    b.Property<int>("BoxId")
                        .HasColumnType("integer");

                    b.ToTable("Box", (string)null);
                });

            modelBuilder.Entity("GestImmo.Models.Habitat", b =>
                {
                    b.HasBaseType("GestImmo.Models.Biens");

                    b.Property<int>("Cave")
                        .HasColumnType("integer");

                    b.Property<int>("HabitatId")
                        .HasColumnType("integer");

                    b.Property<int>("NbChambre")
                        .HasColumnType("integer");

                    b.Property<int>("NbPieces")
                        .HasColumnType("integer");

                    b.Property<int>("Parking")
                        .HasColumnType("integer");

                    b.ToTable("Habitat", (string)null);
                });

            modelBuilder.Entity("GestImmo.Models.Appartement", b =>
                {
                    b.HasBaseType("GestImmo.Models.Habitat");

                    b.Property<int>("AppartementId")
                        .HasColumnType("integer");

                    b.Property<int>("Assenceur")
                        .HasColumnType("integer");

                    b.Property<bool>("ChauffCommun")
                        .HasColumnType("boolean");

                    b.Property<int>("Etage")
                        .HasColumnType("integer");

                    b.ToTable("Appartement", (string)null);
                });

            modelBuilder.Entity("GestImmo.Models.Maison", b =>
                {
                    b.HasBaseType("GestImmo.Models.Habitat");

                    b.Property<int>("MaisonId")
                        .HasColumnType("integer");

                    b.ToTable("Maison", (string)null);
                });

            modelBuilder.Entity("GestImmo.Models.Contrat", b =>
                {
                    b.HasOne("GestImmo.Models.Biens", "Bien")
                        .WithMany()
                        .HasForeignKey("BiensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bien");
                });

            modelBuilder.Entity("GestImmo.Models.Intervention", b =>
                {
                    b.HasOne("GestImmo.Models.Biens", "UnBien")
                        .WithMany()
                        .HasForeignKey("UnBienBiensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UnBien");
                });

            modelBuilder.Entity("GestImmo.Models.Pret", b =>
                {
                    b.HasOne("GestImmo.Models.Biens", "UnBien")
                        .WithMany()
                        .HasForeignKey("UnBienBiensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UnBien");
                });

            modelBuilder.Entity("InterventionPrestataire", b =>
                {
                    b.HasOne("GestImmo.Models.Intervention", null)
                        .WithMany()
                        .HasForeignKey("InterventionListInterventionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestImmo.Models.Prestataire", null)
                        .WithMany()
                        .HasForeignKey("ListPresta1PrestataireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GestImmo.Models.Box", b =>
                {
                    b.HasOne("GestImmo.Models.Biens", null)
                        .WithOne()
                        .HasForeignKey("GestImmo.Models.Box", "BiensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GestImmo.Models.Habitat", b =>
                {
                    b.HasOne("GestImmo.Models.Biens", null)
                        .WithOne()
                        .HasForeignKey("GestImmo.Models.Habitat", "BiensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GestImmo.Models.Appartement", b =>
                {
                    b.HasOne("GestImmo.Models.Habitat", null)
                        .WithOne()
                        .HasForeignKey("GestImmo.Models.Appartement", "BiensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GestImmo.Models.Maison", b =>
                {
                    b.HasOne("GestImmo.Models.Habitat", null)
                        .WithOne()
                        .HasForeignKey("GestImmo.Models.Maison", "BiensId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
