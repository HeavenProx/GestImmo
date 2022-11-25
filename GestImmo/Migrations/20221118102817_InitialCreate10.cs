using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestImmo.Migrations
{
    public partial class InitialCreate10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bien_Prets_PretId",
                table: "Bien");

            migrationBuilder.DropForeignKey(
                name: "FK_Contrats_Bien_BiensId",
                table: "Contrats");

            migrationBuilder.DropIndex(
                name: "IX_Contrats_BiensId",
                table: "Contrats");

            migrationBuilder.DropIndex(
                name: "IX_Bien_PretId",
                table: "Bien");

            migrationBuilder.DropColumn(
                name: "BiensId",
                table: "Contrats");

            migrationBuilder.DropColumn(
                name: "PretId",
                table: "Bien");

            migrationBuilder.AddColumn<string>(
                name: "Nom",
                table: "Bien",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nom",
                table: "Bien");

            migrationBuilder.AddColumn<int>(
                name: "BiensId",
                table: "Contrats",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PretId",
                table: "Bien",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contrats_BiensId",
                table: "Contrats",
                column: "BiensId");

            migrationBuilder.CreateIndex(
                name: "IX_Bien_PretId",
                table: "Bien",
                column: "PretId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bien_Prets_PretId",
                table: "Bien",
                column: "PretId",
                principalTable: "Prets",
                principalColumn: "PretId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contrats_Bien_BiensId",
                table: "Contrats",
                column: "BiensId",
                principalTable: "Bien",
                principalColumn: "BiensId");
        }
    }
}
