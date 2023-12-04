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
        public int? matricula { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Digite a senha")]
        public string senha { get; set; }

        [Display(Name = "Trocar Senha")]
        public bool trocar_senha { get; set; }

        public static implicit operator LoginModel(
           Login loginModel)
        {
            return new LoginModel
            {
                id_login = loginModel.id_login,
                matricula = loginModel.matricula,
                senha = loginModel.senha,
                trocar_senha = loginModel.trocar_senha
            };


        }
    }
}


