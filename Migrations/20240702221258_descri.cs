﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trabalho3_carteira.Migrations
{
    /// <inheritdoc />
    public partial class descri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Saldo_total",
                table: "Carteira");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Movimentacoes",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Movimentacoes",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Saldo_total",
                table: "Carteira",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
