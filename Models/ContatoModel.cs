using System.ComponentModel.DataAnnotations;

namespace CadastroContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Digite o nome do contato")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Digite o telefone do contato")]
        [Phone(ErrorMessage ="Por favor, insira um número válido")]
        public string Telefone { get; set; }
        
        [Required(ErrorMessage = "Digite o email do contato")]
        [EmailAddress(ErrorMessage ="Insira um email válido, por favor.")]
        public string Email { get; set; }
    }
}
