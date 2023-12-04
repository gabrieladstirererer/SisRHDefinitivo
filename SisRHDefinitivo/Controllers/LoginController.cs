using Microsoft.AspNetCore.Mvc;
using SisRHDefinitivo.Core.Models;
using SisRHDefinitivo.Core.Repository;
using SisRHDefinitivo.Mvc.Adm.Models;

namespace SisRHDefinitivo.Mvc.Adm.Controllers
{
    public class LoginController : Controller
    {

        private LoginRepository _loginRepository;

        public LoginController()
        {
            _loginRepository = new LoginRepository();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Entrar(Login login) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var usuarioAutenticado = _loginRepository.BuscarPorLogin(login.matricula, login.senha);

                    if (usuarioAutenticado != false)
                    {
                        return RedirectToAction("Index", "SisRH");
                    }

                    TempData["MensagemErro"] = $"Matrícula e/ou senha inválido(s). Por favor, tente novamente.";
                }
                return View("Index");    
            }  
            catch (Exception Erro) 
            {
                throw;
            }
        }
    }
}
