using Microsoft.AspNetCore.Mvc;

namespace Bibliotec.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
