using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestImmo.Migrations
{
    public partial class GestImmo6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interventions_Prestataires_PrestataireId",
                table: "Interventions");

            migrationBuilder.DropIndex(
                name: "IX_Interventions_PrestataireId",
                table: "Interventions");

            migrationBuilder.DropColumn(
                name: "PrestataireId",
                table: "Interventions");

            migrationBuilder.CreateTable(
                name: "InterventionPrestataire",
                columns: table => new
                {
                    ListPresta1PrestataireId = table.Column<int>(type: "integer", nullable: false),
                    interventionsInterventionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterventionPrestataire", x => new { x.ListPresta1PrestataireId, x.interventionsInterventionId });
                    table.ForeignKey(
                        name: "FK_InterventionPrestataire_Interventions_interventionsInterven~",
                        column: x => x.interventionsInterventionId,
                        principalTable: "Interventions",
                        principalColumn: "InterventionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterventionPrestataire_Prestataires_ListPresta1Prestataire~",
                        column: x => x.ListPresta1PrestataireId,
                        principalTable: "Prestataires",
                        principalColumn: "PrestataireId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InterventionPrestataire_interventionsInterventionId",
                table: "InterventionPrestataire",
                column: "interventionsInterventionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InterventionPrestataire");

            migrationBuilder.AddColumn<int>(
                name: "PrestataireId",
                table: "Interventions",
                type: "integer",
                nullable: true);

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
    }
}
