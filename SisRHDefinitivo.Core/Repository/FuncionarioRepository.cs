using SisRHDefinitivo.Core.Repository.Data;
using System.Data.Entity;
using SisRHDefinitivo.Core.Models;
using SisRHDefinitivo.Core.Models.Views;

namespace SisRHDefinitivo.Core.Repository
{


    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly DbContext _context;

        public FuncionarioRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<Funcionario> AdicionarAsync
            (Funcionario FuncionarioModel)
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

        public async Task<List<Funcionario>> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Task<Funcionario> ListarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Funcionario> UpadateAsync(Funcionario FuncionarioModel)
        {
            throw new NotImplementedException();
        }
    }



}

