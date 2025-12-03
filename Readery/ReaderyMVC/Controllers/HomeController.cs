using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ReaderyMVC.Models;

namespace ReaderyMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        if (HttpContext.Session.GetString("UsuarioNome") == null)
        {
            return RedirectToAction("Index", "Login");
        }

        ViewBag.Usuario = HttpContext.Session.GetString("UsuarioNome");
        return View();
    }
}