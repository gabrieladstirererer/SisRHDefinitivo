using SisRHDefinitivo.Mvc.Adm.Models;
using System.Web.Mvc;

namespace SisRHDefinitivo.Mvc.Adm.ViewsModel.Funcionario
{
    public class NewViewModel : FuncionarioModel
    {
        public Mvc.Adm.Models.FuncionarioModel Funcionario { get; set; }
        public IEnumerable<SelectListItem> TipoEnderecoList { get; set; }
    }
}
