using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP3.NET.MVC.Migrations
{
    public partial class InserindoImagem2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgFile",
                table: "Aluno",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Aluno",
                keyColumn: "AlunoID",
                keyValue: 1,
                columns: new[] { "DataCriacao", "ImgFile" },
                values: new object[] { new DateTime(2023, 12, 15, 15, 55, 48, 99, DateTimeKind.Local).AddTicks(3241), "testeImg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgFile",
                table: "Aluno");

            migrationBuilder.UpdateData(
                table: "Aluno",
                keyColumn: "AlunoID",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2023, 12, 15, 15, 51, 0, 759, DateTimeKind.Local).AddTicks(117));
        }
    }
}
