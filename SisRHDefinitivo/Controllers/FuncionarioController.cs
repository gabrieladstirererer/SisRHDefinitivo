using Microsoft.AspNetCore.Mvc;
using SisRHDefinitivo.Core.Models;
using SisRHDefinitivo.Core.Models.Views;
using SisRHDefinitivo.Core.Repository;
using SisRHDefinitivo.Mvc.Adm.Models;

namespace SisRHDefinitivo.Mvc.Adm.Controllers
{
    
    public class FuncionarioController : Controller
    {
        
        public IActionResult Index(ConsultarFuncionarioViewModel cv)
        {
            var selectFunc = new SelectFuncionarioRepository();
            ModelState.Clear();

            var nome = "-1";
            var matricula = -1;

            if (cv.primeiro_nm_func != null || cv.matricula_func > 0)
            {
                nome = cv.primeiro_nm_func != "" ? cv.primeiro_nm_func : nome;
                matricula = cv.matricula_func > 0 ? cv.matricula_func : matricula;

                cv.funcionarios = selectFunc.ConsultarFunc(nome, matricula);
                return View(cv);
            }
            else 
            {
                cv.funcionarios = selectFunc.ConsultarFunc("-1", -1);
                return View(cv);
            }          
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
