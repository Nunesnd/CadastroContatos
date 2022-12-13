using CadastroContatos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace CadastroContatos.ViewsComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string sessaoUsr = HttpContext.Session.GetString("SessaoUsrLogado");

            if (string.IsNullOrEmpty(sessaoUsr)) return null;

            UsuarioModel usuario = JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsr);

            return View(usuario);
        }
    }
}
