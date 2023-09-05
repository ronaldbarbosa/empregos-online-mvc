using EmpregosOnLine.Models.Enums;

namespace EmpregosOnLine.Models
{
    public class UsuarioEmpresa : IUsuario
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoUsuario TipoUsuario { get; set; }

        public UsuarioEmpresa(string email, string senha)
        {
            Id = Guid.NewGuid();
            Email = email;
            Senha = senha;
            TipoUsuario = TipoUsuario.Empresa;
        }
    }
}
