using CadastroContatos.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroContatos.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Informe o nome do usuário.")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Defina um Login para o usuário")]
        public string Login { get; set; }
        [Required(ErrorMessage ="Informe o email")]
        [EmailAddress(ErrorMessage = "Insira um email válido")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Selecione um perfil")]
        public PerfilEnum? Perfil { get; set; }
        [Required(ErrorMessage ="Defina uma senha")]
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao{ get; set; }

        public  bool SenhaValida(string senha)
        {
            return Senha == senha;
        }
    }
}
