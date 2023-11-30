using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP3.NET.MVC.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Aluno",
                columns: new[] { "AlunoID", "DataCriacao", "DataNascimento", "Email", "Nome" },
                values: new object[] { 1, new DateTime(2023, 11, 30, 15, 54, 23, 756, DateTimeKind.Local).AddTicks(6561), new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "teste@teste.com", "Rodrigo Vianna" });

            migrationBuilder.InsertData(
                table: "Professor",
                columns: new[] { "ProfessorID", "DataContratacao", "Email", "Nome" },
                values: new object[] { 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fulano@fulanizando.com", "Fulano" });

            migrationBuilder.InsertData(
                table: "Disciplina",
                columns: new[] { "DisciplinaID", "Horas", "Nome", "ProfessorID" },
                values: new object[] { 1, 0, "Fundamentos de C#", 1 });

            migrationBuilder.InsertData(
                table: "Curso",
                columns: new[] { "CursoID", "AlunoID", "DataFim", "DataInicio", "DisciplinaID", "Nome" },
                values: new object[] { 1, 1, new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, ".NET" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Curso",
                keyColumn: "CursoID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Aluno",
                keyColumn: "AlunoID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Disciplina",
                keyColumn: "DisciplinaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Professor",
                keyColumn: "ProfessorID",
                keyValue: 1);
        }
    }
}
