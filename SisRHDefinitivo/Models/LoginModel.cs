using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.Models
{
    public class LoginModel
    {
        public int? id_login { get; set; }
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Informe a Senha, Por Favor")]
        public string senha_login { get; set; }
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Informe o Login, Por Favor!")]
        public string nm_funcionario { get; set; }
        public bool trocar_senha { get; set; }


    }
}
