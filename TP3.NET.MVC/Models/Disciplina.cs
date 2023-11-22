using System;
using System.Collections.Generic;

namespace TP3.NET.MVC.Models
{
    public partial class Disciplina
    {
        public Disciplina()
        {
            Cursos = new HashSet<Curso>();
        }

        public int DisciplinaId { get; set; }
        public string Nome { get; set; } = null!;
        public int? Horas { get; set; }
        public int? ProfessorId { get; set; }

        public virtual Professor? Professor { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
    }
}
