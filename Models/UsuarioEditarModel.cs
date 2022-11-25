using CadastroContatos.Enums;
using System.ComponentModel.DataAnnotations;

namespace CadastroContatos.Models
{
    public class UsuarioEditarModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Informe o nome do usuário.")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Defina um Login para o usuário")]
        public string Login { get; set; }
        [Required(ErrorMessage ="Informe o email")]
        [EmailAddress(ErrorMessage = "Insira um email válido")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Defina o perfil do usuário")]
        public PerfilEnum? Perfil { get; set; }
    }
}
