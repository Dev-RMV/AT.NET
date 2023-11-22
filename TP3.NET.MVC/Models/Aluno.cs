using System;
using System.Collections.Generic;

namespace TP3.NET.MVC.Models
{
    public partial class Aluno
    {
        public Aluno()
        {
            Cursos = new HashSet<Curso>();
        }

        public int AlunoId { get; set; }
        public string Nome { get; set; } = null!;
        public DateTime? DataNascimento { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<Curso> Cursos { get; set; }
    }
}
