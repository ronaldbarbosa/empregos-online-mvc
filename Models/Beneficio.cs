using System.Collections.ObjectModel;

namespace EmpregosOnLine.Models
{
    public class Beneficio
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public ICollection<Vaga> Vagas { get; set; } = new Collection<Vaga>();

        public Beneficio()
        {
        }

        public Beneficio(string titulo)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
        }
    }
}
