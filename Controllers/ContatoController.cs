using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class ContatoController : Controller
{
    private readonly ILogger<ContatoController> _logger;

    public ContatoController (ILogger<ContatoController> logger)
    {
        _logger = logger;
    }

    public IActionResult exibir()
    {
        return View();
    }
   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}