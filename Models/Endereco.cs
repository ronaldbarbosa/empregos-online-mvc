using System.ComponentModel.DataAnnotations;

namespace EmpregosOnLine.Models
{
    public class Endereco
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        [StringLength(10, MinimumLength = 8, ErrorMessage = "{0} deve ter tamanho entre {2} and {1}")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "{0} deve ter tamanho entre {2} and {1}")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        public int Numero { get; set; }
        [StringLength(100, MinimumLength = 1, ErrorMessage = "{0} deve ter tamanho entre {2} and {1}")]
        public string? Complemento { get; set; }
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "{0} deve ter tamanho entre {2} and {1}")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "{0} deve ter tamanho entre {2} and {1}")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "{0} é um campo obrigatório")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "{0} deve ter tamanho entre {2} and {1}")]
        public string Estado { get; set; }

        public Endereco(string cep, string logradouro, int numero, string? complemento, string bairro, string cidade, string estado)
        {
            Id = Guid.NewGuid();
            CEP = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public Endereco()
        {
        }

        public override string ToString()
        {
            return $"{Logradouro}, {Numero} - {Cidade}";
        }
    }
}
