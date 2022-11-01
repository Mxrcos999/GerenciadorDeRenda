using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciadorDeRendaInfra.Migrations
{
    public partial class colunasadicionadasatabelaconta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EntradaId",
                table: "Conta",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SaidaId",
                table: "Conta",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EntradaId",
                table: "Conta");

            migrationBuilder.DropColumn(
                name: "SaidaId",
                table: "Conta");
        }
    }
}
