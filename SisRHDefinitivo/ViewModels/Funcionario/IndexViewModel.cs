using SisRHDefinitivo.Core.Models.Views;

namespace SisRHDefinitivo.Mvc.Adm.ViewModels.Funcionario
{
    public class IndexViewModel : ConsultarFuncionariosView
    {
        public Mvc.Adm.Models.FuncionarioModel DadosFuncionario { get; set; }
    }
}
