using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace SisRHDefinitivo.Core.Models
{
    public class Login
    {
        public int matricula_func { get; set; }
        public bool TrocaSenha { get; set; }
        public int? id_login { get; set; }
        public string senha_login { get; set; }
        public bool trocar_senha { get; set; }

    }

}
