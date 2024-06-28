using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trabalho3_carteira.Migrations
{
    /// <inheritdoc />
    public partial class mudanca_tabela_movimentacoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Saldo_dia",
                table: "Movimentacoes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Saldo_dia",
                table: "Movimentacoes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
