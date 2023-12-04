using Microsoft.AspNetCore.Mvc;
using SisRHDefinitivo.Core.Models;
using SisRHDefinitivo.Core.Models.Views;
using SisRHDefinitivo.Core.Repository;



namespace SisRHDefinitivo.Mvc.Adm.Controllers
{
    
    public class FuncionarioController : Controller
    {
        
        public IActionResult Index()
        {
            // consultar funcionario
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
