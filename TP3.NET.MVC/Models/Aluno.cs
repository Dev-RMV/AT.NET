using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP3.NET.MVC.Models
{
    public partial class Aluno
    {
        public Aluno()
        {
            Cursos = new HashSet<Curso>();
        }
        [Required]
        public int AlunoId { get; set; }
        
        public string? ImgFile { get; set; }
        [Required]
        public string Nome { get; set; } = null!;
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime DataCriacao {get; set; }
        [NotMapped]
        public IFormFile? FormFile { get; set; }

        public virtual ICollection<Curso> Cursos { get; set; }
    }
}
