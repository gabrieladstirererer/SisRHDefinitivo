using SisRHDefinitivo.Core.Models;

namespace SisRHDefinitivo.Core.Repository
{
    public interface IFuncionarioRepository
    {
        Task<List<Funcionario>> ListarAsync();
        Task<Funcionario> AdicionarAsync(Funcionario funcionarioAdicionar);
        Task<Funcionario> Remove();
    }
}