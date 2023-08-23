using System.ComponentModel.DataAnnotations;

namespace EmpregosOnLine.Models.ViewModels
{
    public class EmpresaEnderecoViewModel
    {
        public Guid Id { get; set; }
        public Empresa Empresa { get; set; }
        [Display(Name = "Endereço")]
        public Endereco Endereco { get; set; }

        public EmpresaEnderecoViewModel()
        {
            Id = Guid.NewGuid();
            Empresa = new Empresa();
            Empresa.Id = Guid.NewGuid();
            Endereco = new Endereco();
            Endereco.Id = Guid.NewGuid();
            Empresa.EnderecoId = Endereco.Id;
            Empresa.Endereco = Endereco;
        }
    }
}
