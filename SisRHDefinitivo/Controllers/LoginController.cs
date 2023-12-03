using Microsoft.AspNetCore.Mvc;
using SisRHDefinitivo.Core.Repository;
using SisRHDefinitivo.Mvc.Adm.Models;

namespace SisRHDefinitivo.Mvc.Adm.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginRepository _loginRepository;   
        public LoginController(ILoginRepository loginRepository) 
        {
            _loginRepository = loginRepository;
        }    
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Entrar(LoginModel loginModel) 
        {
            try
            {
                if (ModelState.IsValid) 
                {
                    if(loginModel.matricula_func == 32 && loginModel.senha_login == "123") 
                    {
                        return RedirectToAction("Index", "SisRH");
                    }

                    TempData["MensagemErro"] = $"Matrícula e/ou senha inválido(s). Por favor, tente novamente.";
                }
                return View("Index");    
            }  
            catch (Exception Erro) 
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login, tente novamente, detalhe do erro: {Erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
