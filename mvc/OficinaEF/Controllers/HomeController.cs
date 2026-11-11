using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OficinaEF.Models;

namespace OficinaEF.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [Authorize(Roles = "Admin")]
    public IActionResult Admin()
    {
        return View();
    }

    [Authorize(Roles = "Admin,Atendente")]
    public IActionResult Atendente()
    {
        return View();
    }
    [Authorize(Roles = "Admin,Atendente,Cliente")]
    public IActionResult Cliente()
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
