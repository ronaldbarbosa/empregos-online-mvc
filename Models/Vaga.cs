using EmpregosOnLine.Models.Enums;

namespace EmpregosOnLine.Models
{
    public class Vaga
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public TipoVaga TipoVaga { get; set; }
        public Empresa Empresa { get; set; }
        public Guid EmpresaId { get; set; }
        public bool Ativa { get; set; } = true;

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
