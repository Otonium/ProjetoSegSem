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
        //* Cadastro do Usuario
        public IActionResult Criar(string nome, string email, string senha)
        {
            if (string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(nome))
            {
                ViewBag.Erro = "Preencha todos os campos";
                return View("Index");
            }

            var emailUsuario = _context.Usuarios.FirstOrDefault(e => email == e.Email);

            if (emailUsuario == null)
            {
                ViewBag.Erro = "Email inexistente";
                return View("Index");
            }

            if (senha.Length < 8)
            {
                ViewBag.Erro = "A senha deve conter pelo menos 8 caracteres";
                return View("Index");
            }

            //*Criacao de uma senha Hash para mandar ao banco
            byte[] hash = HashService.GerarHashBytes(senha);

            var data = DateTime.Now;
            //? -3 por conta do fuso horário da nuvem
            data.AddHours(-3);

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

            //* Envio do email
            EmailService emailService = new EmailService(email);

            var user = _context.Usuarios.FirstOrDefault(u => u.Email == email);
            if (user == null)
            {
                return View("Index");
            }
            emailService.EnviarEmail();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Voltar()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}