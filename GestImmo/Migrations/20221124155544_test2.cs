using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestImmo.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InterventionPrestataire_Interventions_interventionsInterven~",
                table: "InterventionPrestataire");

            migrationBuilder.DropForeignKey(
                name: "FK_Interventions_Bien_BiensId",
                table: "Interventions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InterventionPrestataire",
                table: "InterventionPrestataire");

            migrationBuilder.DropIndex(
                name: "IX_InterventionPrestataire_interventionsInterventionId",
                table: "InterventionPrestataire");

            migrationBuilder.RenameColumn(
                name: "BiensId",
                table: "Interventions",
                newName: "UnBienBiensId");

            migrationBuilder.RenameIndex(
                name: "IX_Interventions_BiensId",
                table: "Interventions",
                newName: "IX_Interventions_UnBienBiensId");

            migrationBuilder.RenameColumn(
                name: "interventionsInterventionId",
                table: "InterventionPrestataire",
                newName: "InterventionListInterventionId");

            migrationBuilder.AddColumn<int>(
                name: "UnBienBiensId",
                table: "Prets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BiensId",
                table: "Contrats",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_InterventionPrestataire",
                table: "InterventionPrestataire",
                columns: new[] { "InterventionListInterventionId", "ListPresta1PrestataireId" });

            migrationBuilder.CreateIndex(
                name: "IX_Prets_UnBienBiensId",
                table: "Prets",
                column: "UnBienBiensId");

            migrationBuilder.CreateIndex(
                name: "IX_InterventionPrestataire_ListPresta1PrestataireId",
                table: "InterventionPrestataire",
                column: "ListPresta1PrestataireId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrats_BiensId",
                table: "Contrats",
                column: "BiensId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contrats_Bien_BiensId",
                table: "Contrats",
                column: "BiensId",
                principalTable: "Bien",
                principalColumn: "BiensId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InterventionPrestataire_Interventions_InterventionListInter~",
                table: "InterventionPrestataire",
                column: "InterventionListInterventionId",
                principalTable: "Interventions",
                principalColumn: "InterventionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interventions_Bien_UnBienBiensId",
                table: "Interventions",
                column: "UnBienBiensId",
                principalTable: "Bien",
                principalColumn: "BiensId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prets_Bien_UnBienBiensId",
                table: "Prets",
                column: "UnBienBiensId",
                principalTable: "Bien",
                principalColumn: "BiensId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contrats_Bien_BiensId",
                table: "Contrats");

            migrationBuilder.DropForeignKey(
                name: "FK_InterventionPrestataire_Interventions_InterventionListInter~",
                table: "InterventionPrestataire");

            migrationBuilder.DropForeignKey(
                name: "FK_Interventions_Bien_UnBienBiensId",
                table: "Interventions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prets_Bien_UnBienBiensId",
                table: "Prets");

            migrationBuilder.DropIndex(
                name: "IX_Prets_UnBienBiensId",
                table: "Prets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InterventionPrestataire",
                table: "InterventionPrestataire");

            migrationBuilder.DropIndex(
                name: "IX_InterventionPrestataire_ListPresta1PrestataireId",
                table: "InterventionPrestataire");

            migrationBuilder.DropIndex(
                name: "IX_Contrats_BiensId",
                table: "Contrats");

            migrationBuilder.DropColumn(
                name: "UnBienBiensId",
                table: "Prets");

            migrationBuilder.DropColumn(
                name: "BiensId",
                table: "Contrats");

            migrationBuilder.RenameColumn(
                name: "UnBienBiensId",
                table: "Interventions",
                newName: "BiensId");

            migrationBuilder.RenameIndex(
                name: "IX_Interventions_UnBienBiensId",
                table: "Interventions",
                newName: "IX_Interventions_BiensId");

            migrationBuilder.RenameColumn(
                name: "InterventionListInterventionId",
                table: "InterventionPrestataire",
                newName: "interventionsInterventionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InterventionPrestataire",
                table: "InterventionPrestataire",
                columns: new[] { "ListPresta1PrestataireId", "interventionsInterventionId" });

            migrationBuilder.CreateIndex(
                name: "IX_InterventionPrestataire_interventionsInterventionId",
                table: "InterventionPrestataire",
                column: "interventionsInterventionId");

            migrationBuilder.AddForeignKey(
                name: "FK_InterventionPrestataire_Interventions_interventionsInterven~",
                table: "InterventionPrestataire",
                column: "interventionsInterventionId",
                principalTable: "Interventions",
                principalColumn: "InterventionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interventions_Bien_BiensId",
                table: "Interventions",
                column: "BiensId",
                principalTable: "Bien",
                principalColumn: "BiensId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
