﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP3.NET.MVC.Data;

#nullable disable

namespace TP3.NET.MVC.Migrations
{
    [DbContext(typeof(MasterContext))]
    [Migration("20231215185100_InserindoImagem")]
    partial class InserindoImagem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TP3.NET.MVC.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AlunoID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlunoId"), 1L, 1);

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("AlunoId");

                    b.HasIndex(new[] { "Email" }, "UQ__Aluno__A9D10534D909EC1D")
                        .IsUnique();

                    b.ToTable("Aluno", (string)null);

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DataCriacao = new DateTime(2023, 12, 15, 15, 51, 0, 759, DateTimeKind.Local).AddTicks(117),
                            DataNascimento = new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "teste@teste.com",
                            Nome = "Rodrigo Vianna"
                        });
                });

            modelBuilder.Entity("TP3.NET.MVC.Models.Curso", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CursoID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CursoId"), 1L, 1);

                    b.Property<int>("AlunoId")
                        .HasColumnType("int")
                        .HasColumnName("AlunoID");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("date");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("date");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int")
                        .HasColumnName("DisciplinaID");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("CursoId");

                    b.HasIndex("AlunoId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("Curso", (string)null);

                    b.HasData(
                        new
                        {
                            CursoId = 1,
                            AlunoId = 1,
                            DataFim = new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInicio = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DisciplinaId = 1,
                            Nome = ".NET"
                        });
                });

            modelBuilder.Entity("TP3.NET.MVC.Models.Disciplina", b =>
                {
                    b.Property<int>("DisciplinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DisciplinaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisciplinaId"), 1L, 1);

                    b.Property<int>("Horas")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int")
                        .HasColumnName("ProfessorID");

                    b.HasKey("DisciplinaId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplina", (string)null);

                    b.HasData(
                        new
                        {
                            DisciplinaId = 1,
                            Horas = 0,
                            Nome = "Fundamentos de C#",
                            ProfessorId = 1
                        });
                });

            modelBuilder.Entity("TP3.NET.MVC.Models.Professor", b =>
                {
                    b.Property<int>("ProfessorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProfessorID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfessorId"), 1L, 1);

                    b.Property<DateTime>("DataContratacao")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ProfessorId");

                    b.HasIndex(new[] { "Email" }, "UQ__Professo__A9D1053464587175")
                        .IsUnique();

                    b.ToTable("Professor", (string)null);

                    b.HasData(
                        new
                        {
                            ProfessorId = 1,
                            DataContratacao = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "fulano@fulanizando.com",
                            Nome = "Fulano"
                        });
                });

            modelBuilder.Entity("TP3.NET.MVC.Models.Curso", b =>
                {
                    b.HasOne("TP3.NET.MVC.Models.Aluno", "Aluno")
                        .WithMany("Cursos")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Curso__AlunoID__1C1D2798");

                    b.HasOne("TP3.NET.MVC.Models.Disciplina", "Disciplina")
                        .WithMany("Cursos")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Curso__Disciplin__1D114BD1");

                    b.Navigation("Aluno");

                    b.Navigation("Disciplina");
                });

            modelBuilder.Entity("TP3.NET.MVC.Models.Disciplina", b =>
                {
                    b.HasOne("TP3.NET.MVC.Models.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Disciplin__Profe__1940BAED");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("TP3.NET.MVC.Models.Aluno", b =>
                {
                    b.Navigation("Cursos");
                });

            modelBuilder.Entity("TP3.NET.MVC.Models.Disciplina", b =>
                {
                    b.Navigation("Cursos");
                });

            modelBuilder.Entity("TP3.NET.MVC.Models.Professor", b =>
                {
                    b.Navigation("Disciplinas");
                });
#pragma warning restore 612, 618
        }
    }
}
