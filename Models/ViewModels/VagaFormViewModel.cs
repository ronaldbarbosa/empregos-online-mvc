using EmpregosOnLine.Models.Enums;
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
        public List<Empresa> Empresas { get; set; }
        public Guid EmpresaId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

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
        }
    }
}
