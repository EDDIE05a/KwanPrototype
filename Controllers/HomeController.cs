using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KwanPrototypeMVC.Models;

namespace KwanPrototypeMVC.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Servicios()
    {
        return View();
    }

    public IActionResult Cursos()
    {
        return View();
    }

    public IActionResult LogIn()
    {
        return View();
    }

    public IActionResult Contacto()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
