using Microsoft.AspNetCore.Mvc;

namespace SisRHDefinitivo.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search()
        {
            return View();
        }

        public IActionResult New()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
