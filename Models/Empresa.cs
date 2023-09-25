using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace EmpregosOnLine.Models
{
    public class Empresa
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "{0} deve ter tamanho entre {2} and {1}")]
        public string Nome { get; set; }
        [Display(Name = "Nome Fantasia")]
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "{0} deve ter tamanho entre {2} and {1}")]
        public string NomeFantasia { get; set; }
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        [StringLength(18, MinimumLength = 14, ErrorMessage = "{0} deve ter tamanho entre {2} and {1}")]
        public string CNPJ { get; set; }
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        [Display(Name = "Endereço")]
        public Endereco Endereco { get; set; }
        public Guid EnderecoId { get; set; }
        public ICollection<Vaga> Vagas { get; set; } = new Collection<Vaga>();
        [Display(Name = "Imagem")]
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        public string? UrlImagem { get; set; }

        public Empresa(string nome, string nomeFantasia, string cnpj, Endereco endereco, string urlImagem)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            NomeFantasia = nomeFantasia;
            CNPJ = cnpj;
            Endereco = endereco;
            UrlImagem = urlImagem;
        }

        public Empresa()
        {
        }
    }
}
