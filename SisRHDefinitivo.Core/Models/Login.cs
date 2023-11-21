using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.Core.Models
{
    public class Login
    {
        public int? id_login { get; set; }
        public string senha_login { get; set; }
        public bool trocar_senha { get; set; }

    }
}
