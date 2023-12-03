
//using System.Data.Entity;
//using SisRHDefinitivo.Core.Models;

//namespace SisRHDefinitivo.Core.Repository
//{

//    public class FuncionarioRepository :
//        IFuncionarioRepository
//    {
//        private readonly DbContext _funcionarioRepository;
       
//        // Adicionando Construtor
//        public FuncionarioRepository(
//            DbContext funcionarioRepository)
//        {
//            _funcionarioRepository = funcionarioRepository;
//        }

//        public async Task<Funcionario> AdicionarAsync(Funcionario funcionarioAdicionar)
//        {
            
//            await _funcionarioRepository.Funcionarios.AdicionarAsync(Funcionario funcionarioAdicionar);
//        }

//        public Task<List<Funcionario>> ListarAsync()
//        {
          
           
//        }

//        public Task<Funcionario> Remove()
//        {
//            throw new NotImplementedException();
//        }
//    }


//}

