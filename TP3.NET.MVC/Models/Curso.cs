using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TP3.NET.MVC.Models
{
    public partial class Curso
    {
        [Required]
        public int CursoId { get; set; }
        [Required]
        public string Nome { get; set; } = null!;
        [Required]
        public DateTime DataInicio { get; set; }
        [Required]
        public DateTime DataFim { get; set; }
        [Required]
        public int AlunoId { get; set; }
        [Required]
        public int DisciplinaId { get; set; }

        public virtual Aluno? Aluno { get; set; }
        public virtual Disciplina? Disciplina { get; set; }
    }
}
