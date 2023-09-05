using EmpregosOnLine.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace EmpregosOnLine.Models
{
    public class UsuarioCandidato : IUsuario
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoUsuario TipoUsuario { get; set; }

        public UsuarioCandidato(string email, string senha)
        {
            Id = Guid.NewGuid();
            Email = email;
            Senha = senha;
            TipoUsuario = TipoUsuario.Empresa;
        }
    }
}
