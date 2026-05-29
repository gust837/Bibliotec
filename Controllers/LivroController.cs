using Bibliotec.Interfaces;
using Bibliotec.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bibliotec.Controllers
{
    public class LivroController : Controller
    {   

        private readonly ILivroService _livroService;

        public LivroController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        public async Task<IActionResult> Index()
        {
            string? adminSessao = HttpContext.Session.GetString("Admin");

            if (adminSessao == null)
            {
                return RedirectToAction("Index", "Login");
            }

            ViewBag.Admin = adminSessao == "True" || adminSessao == "true";
            
            var livros = await _livroService.BuscarLivrosComCat();

            return View(livros);
        }
    }
}