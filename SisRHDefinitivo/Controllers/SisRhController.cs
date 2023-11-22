using Microsoft.AspNetCore.Mvc;

namespace SisRHDefinitivo.Mvc.Adm.Controllers
{
    public class SisRhController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public SisRhController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
