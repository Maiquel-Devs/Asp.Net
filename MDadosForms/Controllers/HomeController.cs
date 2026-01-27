using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MDadosForms.Models;

namespace MDadosForms.Controllers;

public class HomeController : Controller
{   
    // Pagina Inicial
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult MostrarCadastro()
    {
        // Passa a lista direto como Modelo
        ViewBag.Pessoas = listaPessoas;     // Usando ViewBag (variável local) para passar a lista (variável global) para a View
        return View();
    }

    private static List<Pessoa> listaPessoas = new List<Pessoa>();  // Variável global para armazenar os cadastros

    [HttpPost]
    public IActionResult Processar(Pessoa input)
    {
        listaPessoas.Add(input);    // Adcionando a variável global

        return View("Index");
    }



    // --------------------------------------------------------------------------

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
