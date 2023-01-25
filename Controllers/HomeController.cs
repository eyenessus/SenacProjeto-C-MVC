using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EnounSenac.Models;

namespace EnounSenac.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Sobre(){
        return View();
    }
    public IActionResult Trabalhe(){
         return View();
    }

    public IActionResult Contato(){
         return View();
    }

    [HttpPost]
    public IActionResult ContatoIn() { 

        Console.WriteLine("Standard DateTime Format Specifiers");
        return View();
    }

    public IActionResult Produtos(){
         return View();
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
