using SisRHDefinitivo.Core.Repository.Data;
using System.Data.Entity;
using SisRHDefinitivo.Core.Models;

namespace SisRHDefinitivo.Core.Repository
{

    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly BancoContext _funcionarioRepository;

        // Adicionando Construtor
        public FuncionarioRepository(
            BancoContext funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public async Task<Funcionario> AdicionarAsync(Funcionario funcionarioAdicionar)
        {
            _funcionarioRepository.Funcionario.AddAsync(funcionarioAdicionar);
            _funcionarioRepository.SaveChangesAsync();
            return funcionarioAdicionar;

        }

        public async Task<List<Funcionario>> ListarAsync()
        {
            return await _funcionarioRepository.Funcionario.ToListAsync();

        }

        public Task<Funcionario> Remove()
        {
            throw new NotImplementedException();
        }
    }


}

