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
            if(string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(nome))
            {
                ViewBag.Erro = "Preencha todos os campos";
                return View("Index");
            }

            if(senha.Length < 8)
            {
                ViewBag.Erro = "A senha deve conter pelo menos 8 caracteres";
                return View("Index");
            }

            Console.WriteLine(senha);
            Console.WriteLine(email);
            Console.WriteLine(nome);

            byte[] hash = HashService.GerarHashBytes(senha);
            Console.WriteLine(hash);

            var data = DateTime.Now;
            //data.AddHours(-3);

             Usuario usuario = new Usuario
             {
                Nome = nome,
                Email = email,
                SenhaHash = hash,
                FotoURL = null,
                DataCadastro = data
             };

             _context.Usuarios.Add(usuario);
             _context.SaveChanges();

             return RedirectToAction("Index", "Home");
        }
    }
}