using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TP3.NET.MVC.Models
{
    public partial class Disciplina
    {
        public Disciplina()
        {
            Cursos = new HashSet<Curso>();
        }
        [Required]
        public int DisciplinaId { get; set; }
        [Required]
        public string Nome { get; set; } = null!;
        [Required]
        public int Horas { get; set; }
        [Required]
        public int ProfessorId { get; set; }

        public virtual Professor? Professor { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
    }
}
