using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReaderyMVC.Data;
using ReaderyMVC.Models;
using ReaderyMVC.Services;

namespace ReaderyMVC.Controllers
{
    public class CadastroController : Controller
    {
        private readonly AppDbContext _context;

        public CadastroController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(string nome, string email, string senha)
        {

            if(senha.Length < 8)
            {
                return View("Index");
            }

            byte[] Hash = HashService.GerarHashBytes(senha);

             Usuario usuario = new Usuario
             {
                Nome = nome,
                Email = email,
                SenhaHash = Hash,
                FotoURL = null,
             };

             _context.Usuarios.Add(usuario);
             _context.SaveChanges();

             return RedirectToAction("Index", "Home");
        }
    }
}