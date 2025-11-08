using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Projeto02_Rotas.Controllers
{
    public class PaginasController : Controller
    {
        // Rota: /sobre
        public IActionResult Sobre()
        {
            return View();
        }

        // Rota: /contato
        public IActionResult Contato()
        {
            return View();
        }
    }
}
