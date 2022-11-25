using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestImmo.Migrations
{
    public partial class GestImmo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habitacle_Habitat_BiensId",
                table: "Habitacle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Habitacle",
                table: "Habitacle");

            migrationBuilder.RenameTable(
                name: "Habitacle",
                newName: "Maison");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Maison",
                table: "Maison",
                column: "BiensId");

            migrationBuilder.AddForeignKey(
                name: "FK_Maison_Habitat_BiensId",
                table: "Maison",
                column: "BiensId",
                principalTable: "Habitat",
                principalColumn: "BiensId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Maison_Habitat_BiensId",
                table: "Maison");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Maison",
                table: "Maison");

            migrationBuilder.RenameTable(
                name: "Maison",
                newName: "Habitacle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Habitacle",
                table: "Habitacle",
                column: "BiensId");

            migrationBuilder.AddForeignKey(
                name: "FK_Habitacle_Habitat_BiensId",
                table: "Habitacle",
                column: "BiensId",
                principalTable: "Habitat",
                principalColumn: "BiensId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
