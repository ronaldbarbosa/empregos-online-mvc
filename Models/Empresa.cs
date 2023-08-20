using System.Collections.ObjectModel;

namespace EmpregosOnLine.Models
{
    public class Empresa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
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
