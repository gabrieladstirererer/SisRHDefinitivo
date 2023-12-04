using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace SisRHDefinitivo.Core.Models
{
    public class Login
    {
        public int? id_login { get; set; }
        public int matricula { get; set; }
        public string senha { get; set; }
        public bool trocar_senha { get; set; }

    }

}
