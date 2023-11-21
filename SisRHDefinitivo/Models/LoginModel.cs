using SisRHDefinitivo.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.Adm.Models
{
    public class LoginModel
    {
        [Display(Name = "Login")]
        public int? id_login { get; set; }

        [Display(Name = "Senha")]
        public string senha_login { get; set; }

        [Display(Name = "Trocar Senha")]
        public bool trocar_senha { get; set; }

        public static implicit operator LoginModel(
           Login loginModel)
        {
            return new LoginModel
            {
                id_login = loginModel.id_login,
                senha_login = loginModel.senha_login,
                trocar_senha = loginModel.trocar_senha
            };


        }
    }
}


