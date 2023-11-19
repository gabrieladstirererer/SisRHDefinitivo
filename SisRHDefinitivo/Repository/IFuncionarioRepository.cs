using SisRHDefinitivo.Models;

namespace SisRHDefinitivo.Repository
{
    public interface IFuncionarioRepository
    {
        Task<List<FuncionarioModel>> BuscarTodos();
        Task<FuncionarioModel> AdicionarAsync(FuncionarioModel FuncionarioModel);
        Task<FuncionarioModel> ListarAsync(int id);
        Task<FuncionarioModel> UpadateAsync(FuncionarioModel FuncionarioModel);
        Task<bool> AtivarDesativarAsync(int id);
        Task<bool> RemoveAsync(int id);
    }
}