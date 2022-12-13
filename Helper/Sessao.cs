using CadastroContatos.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace CadastroContatos.Helper
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _httpContextoSessao;

        public Sessao(IHttpContextAccessor httpContext)
        {
            _httpContextoSessao = httpContext;
        }
        public UsuarioModel BuscarSessaoUsuario()
        {
            string sessaoUsr = _httpContextoSessao.HttpContext.Session.GetString("SessaoUsrLogado");

            if (string.IsNullOrEmpty(sessaoUsr)) return null;

            return JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsr);
        }

        public void CriarSessaoUsuario(UsuarioModel usuario)
        {
            string valor = JsonConvert.SerializeObject(usuario);
            _httpContextoSessao.HttpContext.Session.SetString("SessaoUsrLogado", valor);
        }
        public void RemoverSessaoUsuario()
        {
            _httpContextoSessao.HttpContext.Session.Remove("SessaoUsrLogado");
        }


    }
}
