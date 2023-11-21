using SisRHDefinitivo.Models.Core;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Login")]
        public int? id_login { get; set; }

        [Display(Name = "Senha")]
        public string senha_login { get; set; }

        [Display(Name = "Trocar Senha")]
        public bool trocar_senha { get; set; }

        public static implicit operator LoginViewModel(
           Login loginModel)
        {
            return new LoginViewModel
            {
                id_login = loginModel.id_login,
                senha_login = loginModel.senha_login,
                trocar_senha = loginModel.trocar_senha
            };


        }
    }
}


