
using System.Data.Entity;
using SisRHDefinitivo.Models;

namespace SisRHDefinitivo.Repository
{


    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly DbContext _context;

        public FuncionarioRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<FuncionarioModel> AdicionarAsync
            (FuncionarioModel FuncionarioModel)
        {

            //DbContext _context1 = _context;
            //await _context1.AddAsync(FuncionarioModel);
            //await _context1.SaveChangesAsync();

            return FuncionarioModel;
        }

        public Task<bool> AtivarDesativarAsync
           (int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FuncionarioModel>> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Task<FuncionarioModel> ListarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<FuncionarioModel> UpadateAsync(FuncionarioModel FuncionarioModel)
        {
            throw new NotImplementedException();
        }
    }



}

