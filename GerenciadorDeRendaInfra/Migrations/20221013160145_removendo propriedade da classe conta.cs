using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeRendaInfra.Migrations
{
    public partial class removendopropriedadedaclasseconta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conta_Previsao_PrevisaoId",
                table: "Conta");

            migrationBuilder.DropIndex(
                name: "IX_Conta_PrevisaoId",
                table: "Conta");

            migrationBuilder.DropColumn(
                name: "PrevisaoId",
                table: "Conta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PrevisaoId",
                table: "Conta",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conta_PrevisaoId",
                table: "Conta",
                column: "PrevisaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Conta_Previsao_PrevisaoId",
                table: "Conta",
                column: "PrevisaoId",
                principalTable: "Previsao",
                principalColumn: "Id");
        }
    }
}
