﻿using EmpregosOnLine.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpregosOnLine.Models.ViewModels
{
    public class VagaFormViewModel
    {
        public Guid Id { get; set; }
        public IEnumerable<Habilidade> Habilidades { get; set; }
        public List<Habilidade> HabilidadesSelecionadas { get; set; } = new List<Habilidade>();
        public IEnumerable<Beneficio> Beneficios { get; set; }
        public List<Beneficio> BeneficiosSelecionados { get; set; } =  new List<Beneficio>();
        [NotMapped]
        public List<TipoContrato> TiposContrato { get; set; }
        [NotMapped]
        public List<TipoVaga> TiposVaga { get; set; }
        [NotMapped]
        public List<TipoPerfil> TiposPerfil { get; set; }
        public List<Empresa> Empresas { get; set; }
        public Guid EmpresaId { get; set; }
        public string NomeEmpresa { get; set; }
        [Display(Name = "Título")]
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "{0} deve ter tamanho entre {2} and {1}")]
        public string Titulo { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        [StringLength(150, MinimumLength = 1, ErrorMessage = "{0} deve ter tamanho entre {2} and {1}")]
        public string Descricao { get; set; }
        public bool Ativa { get; set; }
        [Display(Name = "Salário")]
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} deve ser entre R${1},00 a R${2},00")]
        public decimal Salario { get; set; }
        public bool ACombinarSalario { get; set; }

        public VagaFormViewModel()
        {
            TiposContrato = new List<TipoContrato>
            {
                TipoContrato.Estagio,
                TipoContrato.CLT,
                TipoContrato.PJ
            };

            TiposVaga = new List<TipoVaga>
            {
                TipoVaga.Estagio,
                TipoVaga.Treinee,
                TipoVaga.Junior,
                TipoVaga.Pleno,
                TipoVaga.Senior
            };

            TiposPerfil = new List<TipoPerfil>
            {
                TipoPerfil.Frontend,
                TipoPerfil.Backend,
                TipoPerfil.Fullstack,
                TipoPerfil.Mobile
            };
        }
    }
}
