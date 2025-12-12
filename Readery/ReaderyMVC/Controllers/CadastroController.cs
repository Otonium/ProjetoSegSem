using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;
using teste_mvc.Data;
using teste_mvc.Models;
using teste_mvc.Services;

namespace teste_mvc.Controllers
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
            if (string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(nome))
            {
                ViewBag.Erro = "Preencha todos os campos";
                return View("Index");
            }

            if (senha.Length < 8)
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

            EmailService emailService = new EmailService(email);

            var user = _context.Usuarios.FirstOrDefault(u => u.Email == email);
            if(user == null)
            {
                return View("Index");
            }
            emailService.EnviarEmail();
        
            return RedirectToAction("Index", "Home");
        }





        public IActionResult LoginGoogle()
        {
            var propriedades = new AuthenticationProperties
            {
                RedirectUri = Url.Action("GoogleCallback")
            };

            return Challenge(propriedades, GoogleDefaults.AuthenticationScheme);
        }

        public async Task<IActionResult> GoogleCallback()
        {
            var resultado = await HttpContext.AuthenticateAsync(GoogleDefaults.AuthenticationScheme);

            if(!resultado.Succeeded)
            {
                return RedirectToAction("Index");
            }

            var claims = resultado.Principal.Identities.First().Claims.ToList();

            string email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            string nome = claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value ?? "Usuario Google";

            if(email == null)
            return RedirectToAction("Index");

            var usuario = _context.Usuario.FirstOrDefault(u => u.Email == email);

            if(usuario == null)
            {
                usuario = new Usuario
                {
                    Email = email,
                    Nome = nome,
                    SenhaHash = ""
                }

                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
            }

            var identity = new ClaimsIdentity(resultado.Principal.identity, resultado.Principal.Claims);

            await HttpContext.SignInAsync(
                CookieAuthentificationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(identity)
            );

            HttpContext.Session.SetString("Nome", usuario.Nome);
            HttpContext.Session.SetInt32("UsuarioId", usuario.UsuarioId);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Sair()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}