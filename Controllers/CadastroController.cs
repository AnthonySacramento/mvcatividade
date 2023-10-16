using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class CadastroController : Controller
{
    private readonly ILogger<CadastroController> _logger;

    public CadastroController (ILogger<CadastroController> logger)
    {
        _logger = logger;
    }

    public IActionResult Criar()
    {
        Cadastro cadastro = new Cadastro(0212121,"24/06/2023","20.000L",25.000);
        return View(cadastro);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}