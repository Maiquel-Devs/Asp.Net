using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MRota.Models;

namespace MRota.Controllers;

public class HomeController : Controller
{
    // Página Inicial
    public IActionResult Index()
    {
        return View();
    }

    // Página Casa
    public IActionResult Casa()
    {
        return View();
    }

    // Página Vaso
    public IActionResult Vaso()
    {
        return View();
    }

    // Página Barco
    [Route("Barco")]
    public IActionResult Barco()
    {
        return View();
    }



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
