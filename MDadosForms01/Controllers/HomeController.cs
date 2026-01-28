using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MDadosForms01.Models;

namespace MDadosForms01.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }


    public IActionResult MostrarCadastro()
    {
        ViewBag.Pessoas = PessoasLista;

        return View();
    }


    public static List<Pessoa> PessoasLista = new List<Pessoa>();

    public IActionResult Processar(Pessoa input)
    {
        PessoasLista.Add(input);

        return RedirectToAction("MostrarCadastro");     // Se eu dasse return View("MostrarCadastro"); ia chamar o arquivo MostrarCadastro.cshtml e não a função MostrarCadastro(); no arquivo HomeController.cs , caso isso acontecesse, a função ia se tornar inutil, pois nunca seria chamada, alem disso, a ViewBag.Pessoas não seria populada.
    }

    // Return view sempre chama o arquivo .cshtml correspondente, nunca a função do controller.

    // Já RedirectToAction chama a função do controller, que por sua vez chama o arquivo .cshtml correspondente.

    // ----------------------------------------------------------------------------------

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
