using SisRHDefinitivo.Core.Models;
using SisRHDefinitivo.Core.Models.Views;

namespace SisRHDefinitivo.Core.Repository
{
    public interface IFuncionarioRepository
    {
        Task<List<Funcionario>> ListarAsync(int idListarFuncionario);

        Task<Funcionario> AdicionarAsync(Funcionario funcionarioAdicionar);

        Task<Funcionario> UpdateAsync(Funcionario funcionarioEdit);

        Task<Funcionario> ListarFuncionarioId(int idFuncionario);

        Task<List<ConsultarFuncionariosView>> ListarDados();
       
    }
}