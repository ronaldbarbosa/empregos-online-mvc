using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace EmpregosOnLine.Models
{
    public class Empresa
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        public string Nome { get; set; }
        [Display(Name = "Nome Fantasia")]
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        public string NomeFantasia { get; set; }
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        public string CNPJ { get; set; }
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        [Display(Name = "Endereço")]
        public Endereco Endereco { get; set; }
        public Guid EnderecoId { get; set; }
        public ICollection<Vaga> Vagas { get; set; } = new Collection<Vaga>();

        public Empresa(string nome, string nomeFantasia, string cnpj, Endereco endereco)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            NomeFantasia = nomeFantasia;
            CNPJ = cnpj;
            Endereco = endereco;
        }

        public Empresa()
        {
        }
    }
}
