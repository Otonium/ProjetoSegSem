using Microsoft.AspNetCore.Mvc;
using ReaderyMVC.Data;
using ReaderyMVC.Models;

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
                GeneroUsuario = usuario.GeneroUsuario,
                DescricaoUsuario = usuario.DescricaoUsuario,
                FotoURL = usuario.FotoURL
            };

            return Json(viewModel);
        }

        //* POST – MODAL
        [HttpPost]
        public IActionResult AtualizarPerfil(PerfilViewModel model)
        {
            int? usuarioId = HttpContext.Session.GetInt32("UsuarioId");

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

            usuario.Nome = model.Nome;
            usuario.GeneroUsuario = model.GeneroUsuario;
            usuario.DescricaoUsuario = model.DescricaoUsuario;

            if (model.Foto != null && model.Foto.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    model.Foto.CopyTo(ms);
                    usuario.FotoURL = Convert.ToBase64String(ms.ToArray());
                }
            }

            _context.SaveChanges();

            TempData["Sucesso"] = "Perfil atualizado com sucesso!";
            return RedirectToAction("Index");
        }
    }
}