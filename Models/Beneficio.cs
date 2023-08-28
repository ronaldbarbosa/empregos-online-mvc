﻿using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace EmpregosOnLine.Models
{
    public class Beneficio
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "{0} deve ter tamanho entre {2} and {1}")]
        public string Titulo { get; set; }
        public ICollection<Vaga> Vagas { get; set; } = new Collection<Vaga>();

        public Beneficio()
        {
        }

        public Beneficio(string titulo)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
        }
    }
}
