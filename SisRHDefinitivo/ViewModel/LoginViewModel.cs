using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.ViewModel
{
    public class LoginViewModel
    {
        [Display(Name = "LOGIN")]
        public string Login { get; set; }

        [Display(Name = "SENHA")]
        public string Password { get; set; }
    }
}
