namespace EmpregosOnLine.Models
{
    public class Habilidade
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }

        public Habilidade(string titulo)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
        }
    }
}
