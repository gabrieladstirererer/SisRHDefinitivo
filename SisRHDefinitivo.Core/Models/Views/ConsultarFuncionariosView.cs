using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisRHDefinitivo.Core.Models.Views
{
    public class ConsultarFuncionariosView
    {
        public int? id_func { get; set; }
        public string primeiro_nm_func { get; set; }
        public string sobre_nm_func { get; set; }
        public string email_corp_func { get; set; }
        public int? fk_cargo { get; set; }
        public string celular_func { get; set; }
        public int? matricula_func { get; set; }
    }
}
