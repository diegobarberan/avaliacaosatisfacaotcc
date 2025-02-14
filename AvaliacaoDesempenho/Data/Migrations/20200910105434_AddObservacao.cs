﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace AvaliacaoDesempenho.Data.Migrations
{
    public partial class AddObservacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Avaliacoes",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Avaliacoes");
        }
    }
}
