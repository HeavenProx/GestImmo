using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GestImmo.Migrations
{
    public partial class GestImmo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locataires",
                columns: table => new
                {
                    LocataireId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomLoc = table.Column<string>(type: "text", nullable: true),
                    PrenomLoc = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Profession = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locataires", x => x.LocataireId);
                });

            migrationBuilder.CreateTable(
                name: "Prets",
                columns: table => new
                {
                    PretId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Apport = table.Column<int>(type: "integer", nullable: false),
                    Mensualite = table.Column<int>(type: "integer", nullable: false),
                    Duree = table.Column<int>(type: "integer", nullable: false),
                    DebutPret = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prets", x => x.PretId);
                });

            migrationBuilder.CreateTable(
                name: "Bien",
                columns: table => new
                {
                    BiensId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Valeur = table.Column<int>(type: "integer", nullable: false),
                    Adresse = table.Column<string>(type: "text", nullable: true),
                    Surface = table.Column<int>(type: "integer", nullable: false),
                    PretId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bien", x => x.BiensId);
                    table.ForeignKey(
                        name: "FK_Bien_Prets_PretId",
                        column: x => x.PretId,
                        principalTable: "Prets",
                        principalColumn: "PretId");
                });

            migrationBuilder.CreateTable(
                name: "Box",
                columns: table => new
                {
                    BiensId = table.Column<int>(type: "integer", nullable: false),
                    BoxId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Box", x => x.BiensId);
                    table.ForeignKey(
                        name: "FK_Box_Bien_BiensId",
                        column: x => x.BiensId,
                        principalTable: "Bien",
                        principalColumn: "BiensId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contrats",
                columns: table => new
                {
                    ContratId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Loyer = table.Column<int>(type: "integer", nullable: false),
                    DateDebut = table.Column<string>(type: "text", nullable: true),
                    DateFin = table.Column<string>(type: "text", nullable: true),
                    BiensId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrats", x => x.ContratId);
                    table.ForeignKey(
                        name: "FK_Contrats_Bien_BiensId",
                        column: x => x.BiensId,
                        principalTable: "Bien",
                        principalColumn: "BiensId");
                });

            migrationBuilder.CreateTable(
                name: "Habitat",
                columns: table => new
                {
                    BiensId = table.Column<int>(type: "integer", nullable: false),
                    HabitatId = table.Column<int>(type: "integer", nullable: false),
                    NbPieces = table.Column<int>(type: "integer", nullable: false),
                    NbChambre = table.Column<int>(type: "integer", nullable: false),
                    Cave = table.Column<int>(type: "integer", nullable: false),
                    Parking = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitat", x => x.BiensId);
                    table.ForeignKey(
                        name: "FK_Habitat_Bien_BiensId",
                        column: x => x.BiensId,
                        principalTable: "Bien",
                        principalColumn: "BiensId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interventions",
                columns: table => new
                {
                    InterventionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<int>(type: "integer", nullable: false),
                    MontantTTC = table.Column<int>(type: "integer", nullable: false),
                    Information = table.Column<string>(type: "text", nullable: true),
                    BiensId = table.Column<int>(type: "integer", nullable: true),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    PretataireId = table.Column<int>(type: "integer", nullable: true),
                    RaisonSociale = table.Column<string>(type: "text", nullable: true),
                    Nom = table.Column<string>(type: "text", nullable: true),
                    Prenom = table.Column<string>(type: "text", nullable: true),
                    Telephone = table.Column<string>(type: "text", nullable: true),
                    AdresseEntreprise = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interventions", x => x.InterventionId);
                    table.ForeignKey(
                        name: "FK_Interventions_Bien_BiensId",
                        column: x => x.BiensId,
                        principalTable: "Bien",
                        principalColumn: "BiensId");
                });

            migrationBuilder.CreateTable(
                name: "Appartement",
                columns: table => new
                {
                    BiensId = table.Column<int>(type: "integer", nullable: false),
                    AppartementId = table.Column<int>(type: "integer", nullable: false),
                    Etage = table.Column<int>(type: "integer", nullable: false),
                    Assenceur = table.Column<int>(type: "integer", nullable: false),
                    ChauffCommun = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appartement", x => x.BiensId);
                    table.ForeignKey(
                        name: "FK_Appartement_Habitat_BiensId",
                        column: x => x.BiensId,
                        principalTable: "Habitat",
                        principalColumn: "BiensId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Habitacle",
                columns: table => new
                {
                    BiensId = table.Column<int>(type: "integer", nullable: false),
                    MaisonId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitacle", x => x.BiensId);
                    table.ForeignKey(
                        name: "FK_Habitacle_Habitat_BiensId",
                        column: x => x.BiensId,
                        principalTable: "Habitat",
                        principalColumn: "BiensId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bien_PretId",
                table: "Bien",
                column: "PretId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrats_BiensId",
                table: "Contrats",
                column: "BiensId");

            migrationBuilder.CreateIndex(
                name: "IX_Interventions_BiensId",
                table: "Interventions",
                column: "BiensId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appartement");

            migrationBuilder.DropTable(
                name: "Box");

            migrationBuilder.DropTable(
                name: "Contrats");

            migrationBuilder.DropTable(
                name: "Habitacle");

            migrationBuilder.DropTable(
                name: "Interventions");

            migrationBuilder.DropTable(
                name: "Locataires");

            migrationBuilder.DropTable(
                name: "Habitat");

            migrationBuilder.DropTable(
                name: "Bien");

            migrationBuilder.DropTable(
                name: "Prets");
        }
    }
}
