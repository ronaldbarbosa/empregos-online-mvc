using System.Collections.ObjectModel;

namespace EmpregosOnLine.Models
{
    public class Habilidade
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public ICollection<Vaga> Vagas { get; set; } = new Collection<Vaga>();

        public Habilidade()
        {
        }

        public Habilidade(string titulo)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
        }
    }
}
