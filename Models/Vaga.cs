﻿using EmpregosOnLine.Models.Enums;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace EmpregosOnLine.Models
{
    public class Vaga
    {
        public Guid Id { get; set; }
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Tipo de Vaga")]
        public TipoVaga TipoVaga { get; set; }
        [Display(Name = "Tipo de Contrato")]
        public TipoContrato TipoContrato { get; set; }
        [Display(Name = "Perfil")]
        public TipoPerfil TipoPerfil { get; set; }
        public Empresa Empresa { get; set; }
        public Guid EmpresaId { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "Salário")]
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} deve ser entre {1} a {2}")]
        public Decimal Salario { get; set; }
        [Display(Name = "Salário à Combinar")]
        public bool ACombinarSalario { get; set; }
        public bool Ativa { get; set; } = true;
        public ICollection<Beneficio> Beneficios { get; set; } = new Collection<Beneficio>();
        public ICollection<Habilidade> Habilidades { get; set; } = new Collection<Habilidade>();

        public Vaga(string titulo, string descricao, TipoVaga tipoVaga, TipoContrato tipoContrato, TipoPerfil tipoPerfil, Empresa empresa, decimal salario, bool aCombinarSalario)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            Descricao = descricao;
            TipoVaga = tipoVaga;
            TipoContrato = tipoContrato;
            TipoPerfil = tipoPerfil;
            Empresa = empresa;
            Salario = salario;
            ACombinarSalario = aCombinarSalario;
        }

        public Vaga()
        {
        }
    }
}
