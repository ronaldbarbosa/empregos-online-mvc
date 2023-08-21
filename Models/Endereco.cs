namespace EmpregosOnLine.Models
{
    public class Endereco
    {
        public Guid Id { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
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
