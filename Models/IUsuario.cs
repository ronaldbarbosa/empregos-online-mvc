using EmpregosOnLine.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace EmpregosOnLine.Models
{
    public interface IUsuario
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório")]
        [EmailAddress(ErrorMessage = "Entre com um email válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "{0} é obrigatória")]
        [EmailAddress(ErrorMessage = "Entre com um senha válida")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public TipoUsuario TipoUsuario { get; set; }

    }
}
