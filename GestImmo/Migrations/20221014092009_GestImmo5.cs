using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestImmo.Migrations
{
    public partial class GestImmo5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interventions_Bien_BiensId",
                table: "Interventions");

            migrationBuilder.AlterColumn<int>(
                name: "BiensId",
                table: "Interventions",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Interventions_Bien_BiensId",
                table: "Interventions",
                column: "BiensId",
                principalTable: "Bien",
                principalColumn: "BiensId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interventions_Bien_BiensId",
                table: "Interventions");

            migrationBuilder.AlterColumn<int>(
                name: "BiensId",
                table: "Interventions",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Interventions_Bien_BiensId",
                table: "Interventions",
                column: "BiensId",
                principalTable: "Bien",
                principalColumn: "BiensId");
        }
    }
}
