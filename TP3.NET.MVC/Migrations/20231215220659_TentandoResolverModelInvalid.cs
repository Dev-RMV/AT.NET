using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP3.NET.MVC.Migrations
{
    public partial class TentandoResolverModelInvalid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Aluno",
                keyColumn: "AlunoID",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2023, 12, 15, 19, 6, 59, 669, DateTimeKind.Local).AddTicks(2928));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Aluno",
                keyColumn: "AlunoID",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2023, 12, 15, 15, 55, 48, 99, DateTimeKind.Local).AddTicks(3241));
        }
    }
}
