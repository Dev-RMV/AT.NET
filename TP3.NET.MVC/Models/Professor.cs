using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TP3.NET.MVC.Models
{
    public partial class Professor
    {
        public Professor()
        {
            Disciplinas = new HashSet<Disciplina>();
        }
        [Required]
        public int ProfessorId { get; set; }
        [Required]
        public string Nome { get; set; } = null!;
        [Required]
        public DateTime DataContratacao { get; set; }
        [Required]
        public string Email { get; set; }

        public virtual ICollection<Disciplina> Disciplinas { get; set; }
    }
}
