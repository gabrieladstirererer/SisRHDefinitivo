using SisRHDefinitivo.Models.Core;

namespace SisRHDefinitivo.Repository
{
    public interface IFuncionarioRepository
    {
        Task<List<Funcionario>> BuscarTodos();
        Task<Funcionario> AdicionarAsync(Funcionario FuncionarioModel);
        Task<Funcionario> ListarAsync(int id);
        Task<Funcionario> UpadateAsync(Funcionario FuncionarioModel);
        Task<bool> AtivarDesativarAsync(int id);
        Task<bool> RemoveAsync(int id);
    }
}