using EmpregosOnLine.Models.Enums;

namespace EmpregosOnLine.Models.ViewModels
{
    public class VagasListViewModel
    {
        public IEnumerable<TipoPerfil> TiposPerfil { get; set; }
        public IEnumerable<TipoVaga> TiposVaga { get; set; }

        public VagasListViewModel()
        {
            TiposPerfil = new List<TipoPerfil>
            {
                TipoPerfil.Frontend,
                TipoPerfil.Backend,
                TipoPerfil.Fullstack,
                TipoPerfil.Mobile
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
