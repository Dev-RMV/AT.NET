using System;
using System.Collections.Generic;

namespace TP3.NET.MVC.Models
{
    public partial class Professor
    {
        public Professor()
        {
            Disciplinas = new HashSet<Disciplina>();
        }

        public int ProfessorId { get; set; }
        public string Nome { get; set; } = null!;
        public DateTime? DataContratacao { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<Disciplina> Disciplinas { get; set; }
    }
}
