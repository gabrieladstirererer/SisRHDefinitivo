using SisRHDefinitivo.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.Mvc.Adm.Models
{
    public class LoginModel
    {
        [Display(Name = "Login")]
        public int? id_login { get; set; }

        [Display(Name = "Matrícula")]
        [Required(ErrorMessage = "Digite a matrícula")]
        public int? matricula_func { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Digite a senha")]
        public string senha_login { get; set; }

        [Display(Name = "Trocar Senha")]
        public bool trocar_senha { get; set; }

        public static implicit operator LoginModel(
           Login loginModel)
        {
            return new LoginModel
            {
                id_login = loginModel.id_login,
                matricula_func = loginModel.matricula_func,
                senha_login = loginModel.senha_login,
                trocar_senha = loginModel.trocar_senha
            };


        }
    }
}


