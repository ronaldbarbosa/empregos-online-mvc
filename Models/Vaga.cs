using EmpregosOnLine.Models.Enums;
using System.Collections.ObjectModel;

namespace EmpregosOnLine.Models
{
    public class Vaga
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public TipoVaga TipoVaga { get; set; }
        public TipoContrato TipoContrato { get; set; }
        public Empresa Empresa { get; set; }
        public Guid EmpresaId { get; set; }
        public bool Ativa { get; set; } = true;
        public ICollection<Beneficio> Beneficios { get; set; } = new Collection<Beneficio>();
        public ICollection<Habilidade> Habilidades { get; set; } = new Collection<Habilidade>();

        public Vaga(string titulo, string descricao, TipoVaga tipoVaga, Empresa empresa)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            Descricao = descricao;
            TipoVaga = tipoVaga;
            Empresa = empresa;
        }

        public Vaga()
        {
        }
    }
}
