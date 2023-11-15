using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Login")]
        public string Login { get; set; }

        [Display(Name = "Senha")]
        public string Password { get; set; }
    }
}
