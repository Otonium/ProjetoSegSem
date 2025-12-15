using Microsoft.AspNetCore.Mvc;
using ReaderyMVC.Data;
using ReaderyMVC.Models;
using System.IO; // Necessario para MemoryStream

namespace ReaderyMVC.Controllers
{
    public class LivroController : Controller
    {
        private readonly AppDbContext _context;

        public LivroController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //* GET – MODAL
        [HttpGet]
        public IActionResult BuscarPerfil()
        {
            int? usuarioId = HttpContext.Session.GetInt32("UsuarioId");

            // Se nao estiver logado, retorna nulo (depende da sessao real)
            if (usuarioId == null)
            {
                return Json(null);
            }

            var usuario = _context.Usuarios.FirstOrDefault
                (u => u.IdUsuario == usuarioId);

            if (usuario == null)
            {
                return Json(null);
            }

            var viewModel = new PerfilViewModel
            {
                Nome = usuario.Nome,
                Genero = usuario.Genero, // OK: Sincronizado com DB
                Descricao = usuario.Descricao, // OK: Sincronizado com DB
                FotoURL = usuario.FotoURL
            };

            return Json(viewModel);
        }

        //* POST – MODAL
        [HttpPost]
        public IActionResult AtualizarPerfil(PerfilViewModel model)
        {
            // Pega o ID da sessao
            int? usuarioId = HttpContext.Session.GetInt32("UsuarioId");

            // Se nao tiver ID (sem mock), manda pra tela de login
            if (usuarioId == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var usuario = _context.Usuarios.FirstOrDefault
                (u => u.IdUsuario == usuarioId);

            if (usuario == null)
            {
                return RedirectToAction("Index", "Login");
            }

            // --- APLICACAO DAS ALTERACOES ---
            usuario.Nome = model.Nome;
            usuario.Genero = model.Genero; // OK: Sincronizado com DB
            usuario.Descricao = model.Descricao; // OK: Sincronizado com DB

            // Logica de foto
            if (model.Foto != null && model.Foto.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    model.Foto.CopyTo(ms);
                    usuario.FotoURL = Convert.ToBase64String(ms.ToArray());
                }
            }

            // --- SAVE LIMPO ---
            _context.SaveChanges();

            TempData["Sucesso"] = "Perfil atualizado com sucesso!";
            return RedirectToAction("Index");
        }
    }
}