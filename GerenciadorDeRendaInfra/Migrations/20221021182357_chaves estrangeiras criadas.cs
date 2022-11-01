using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeRendaInfra.Migrations
{
    public partial class chavesestrangeirascriadas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Conta_EntradaId",
                table: "Conta",
                column: "EntradaId");

            migrationBuilder.CreateIndex(
                name: "IX_Conta_SaidaId",
                table: "Conta",
                column: "SaidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Conta_Entrada_EntradaId",
                table: "Conta",
                column: "EntradaId",
                principalTable: "Entrada",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Conta_Saida_SaidaId",
                table: "Conta",
                column: "SaidaId",
                principalTable: "Saida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conta_Entrada_EntradaId",
                table: "Conta");

            migrationBuilder.DropForeignKey(
                name: "FK_Conta_Saida_SaidaId",
                table: "Conta");

            migrationBuilder.DropIndex(
                name: "IX_Conta_EntradaId",
                table: "Conta");

            migrationBuilder.DropIndex(
                name: "IX_Conta_SaidaId",
                table: "Conta");
        }
    }
}
