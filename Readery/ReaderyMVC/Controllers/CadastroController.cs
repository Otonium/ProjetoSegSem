using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;
using ReaderyMVC.Data;
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

            byte[] senhaBytes = HashService.GerarHashBytes(senha);
            string senhaHash = Convert.ToBase64String(senhaBytes);

            var data = DateTime.Now;
            //data.AddHours(-3);

            Usuario usuario = new Usuario
            {
                Nome = nome,
                Email = email,
                SenhaHash = senhaHash,
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

            //* Abre a tela do login do Google
            return Challenge(propriedades, GoogleDefaults.AuthenticationScheme);
        }

        public async Task<IActionResult> GoogleCallback()
        {
            //* Pega as Autentificacoes do Google
            var resultado = await HttpContext.AuthenticateAsync(GoogleDefaults.AuthenticationScheme);

            if(!resultado.Succeeded)
            {
                return RedirectToAction("Index");
            }

            //* Sao os valores pega do Google
            var claims = resultado.Principal.Identities.First().Claims.ToList();

            string email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            string nome = claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value ?? "Usuario Google";

            if(email == null)
            return RedirectToAction("Index");

            
            var usuario = new Usuario
                {
                    Email = email,
                    Nome = nome,
                    SenhaHash = ""
                };

                _context.Usuarios.Add(usuario);
                _context.SaveChanges();

            //* Vai pegar os valores das Claims vinda da google
            var identity = new ClaimsIdentity(resultado.Principal.Identity, resultado.Principal.Claims);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(identity)
            );

            //* Vai armazenar a sessao usado no site
            HttpContext.Session.SetString("Nome", usuario.Nome);
            HttpContext.Session.SetInt32("UsuarioId", usuario.IdUsuario);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Sair()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}