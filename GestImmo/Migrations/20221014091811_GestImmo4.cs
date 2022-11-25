using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GestImmo.Migrations
{
    public partial class GestImmo4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdresseEntreprise",
                table: "Interventions");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Interventions");

            migrationBuilder.DropColumn(
                name: "Nom",
                table: "Interventions");

            migrationBuilder.DropColumn(
                name: "Prenom",
                table: "Interventions");

            migrationBuilder.DropColumn(
                name: "RaisonSociale",
                table: "Interventions");

            migrationBuilder.DropColumn(
                name: "Telephone",
                table: "Interventions");

            migrationBuilder.RenameColumn(
                name: "PretataireId",
                table: "Interventions",
                newName: "PrestataireId");

            migrationBuilder.CreateTable(
                name: "Prestataires",
                columns: table => new
                {
                    PrestataireId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RaisonSociale = table.Column<string>(type: "text", nullable: true),
                    Nom = table.Column<string>(type: "text", nullable: true),
                    Prenom = table.Column<string>(type: "text", nullable: true),
                    Telephone = table.Column<string>(type: "text", nullable: true),
                    AdresseEntreprise = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestataires", x => x.PrestataireId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interventions_PrestataireId",
                table: "Interventions",
                column: "PrestataireId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interventions_Prestataires_PrestataireId",
                table: "Interventions",
                column: "PrestataireId",
                principalTable: "Prestataires",
                principalColumn: "PrestataireId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interventions_Prestataires_PrestataireId",
                table: "Interventions");

            migrationBuilder.DropTable(
                name: "Prestataires");

            migrationBuilder.DropIndex(
                name: "IX_Interventions_PrestataireId",
                table: "Interventions");

            migrationBuilder.RenameColumn(
                name: "PrestataireId",
                table: "Interventions",
                newName: "PretataireId");

            migrationBuilder.AddColumn<string>(
                name: "AdresseEntreprise",
                table: "Interventions",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Interventions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nom",
                table: "Interventions",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prenom",
                table: "Interventions",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RaisonSociale",
                table: "Interventions",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telephone",
                table: "Interventions",
                type: "text",
                nullable: true);
        }
    }
}
