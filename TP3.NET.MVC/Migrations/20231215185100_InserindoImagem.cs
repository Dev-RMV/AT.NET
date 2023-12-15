using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP3.NET.MVC.Migrations
{
    public partial class InserindoImagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Aluno",
                keyColumn: "AlunoID",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2023, 12, 15, 15, 51, 0, 759, DateTimeKind.Local).AddTicks(117));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Aluno",
                keyColumn: "AlunoID",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2023, 11, 30, 15, 54, 23, 756, DateTimeKind.Local).AddTicks(6561));
        }
    }
}
