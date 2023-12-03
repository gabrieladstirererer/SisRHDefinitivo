
using System.Data.Entity;
using SisRHDefinitivo.Core.Models;
using SisRHDefinitivo.Core.Models.Views;
using SisRHDefinitivo.Core.Repository.Data;

namespace SisRHDefinitivo.Core.Repository
{

    public class FuncionarioRepository :
        IFuncionarioRepository
    {
        private readonly BancoContext _funcionarioRepository;

        public FuncionarioRepository(
            BancoContext funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

       
        public async Task<Funcionario> AdicionarAsync(
            Funcionario funcionarioAdicionar)
        {
            await _funcionarioRepository.Funcionarios.AddAsync(
                funcionarioAdicionar);
            await _funcionarioRepository.SaveChangesAsync();

            return funcionarioAdicionar;
        }

        
        public async Task<List<Funcionario>> ListarAsync(int idListarFuncionario)
        {
            return await _funcionarioRepository.Funcionarios.ToListAsync();
        }


        public async Task<Funcionario> UpdateAsync(
             Funcionario funcionarioEdit)
        {
            Funcionario funcionarioAtualizar = await ListarFuncionarioId(
                funcionarioEdit.id_func);

            if (funcionarioAtualizar == null) throw new Exception("Houve um erro na Atualização do Funcionario");

            funcionarioAtualizar.primeiro_nm_func = funcionarioEdit.primeiro_nm_func;
            funcionarioAtualizar.sobre_nm_func = funcionarioEdit.sobre_nm_func;
            funcionarioAtualizar.ultimo_nm_func = funcionarioEdit.ultimo_nm_func;
            funcionarioAtualizar.matricula_func = funcionarioEdit.matricula_func;
            funcionarioAtualizar.dt_nasc_func = funcionarioEdit.dt_nasc_func;
            funcionarioAtualizar.sexo_func = funcionarioEdit.sexo_func;
            funcionarioAtualizar.raca_func = funcionarioEdit.raca_func;
            funcionarioAtualizar.tipo_sanguineo_func = funcionarioEdit.tipo_sanguineo_func;
            funcionarioAtualizar.nm_mae_func = funcionarioEdit.nm_mae_func;
            funcionarioAtualizar.nm_pai_func = funcionarioEdit.nm_pai_func;
            funcionarioAtualizar.estado_civil_func = funcionarioEdit.estado_civil_func;
            funcionarioAtualizar.nm_conjugue_func = funcionarioEdit.nm_conjugue_func;
            funcionarioAtualizar.cidade_nasc = funcionarioEdit.cidade_nasc;
            funcionarioAtualizar.numero_resr_func = funcionarioEdit.numero_resr_func;
            funcionarioAtualizar.compl_func = funcionarioEdit.compl_func;
            funcionarioAtualizar.tipo_moradia_func = funcionarioEdit.tipo_moradia_func;
            funcionarioAtualizar.celular_func = funcionarioEdit.celular_func;
            funcionarioAtualizar.whatsapp_fun = funcionarioEdit.whatsapp_fun;
            funcionarioAtualizar.telefone_func = funcionarioEdit.telefone_func;
            funcionarioAtualizar.telefone_func = funcionarioEdit.telefone_func;
            funcionarioAtualizar.email_corp_func = funcionarioEdit.email_corp_func;
            funcionarioAtualizar.num_agen_func = funcionarioEdit.num_agen_func;
            funcionarioAtualizar.num_conta_func = funcionarioEdit.num_conta_func;
            funcionarioAtualizar.fk_cargo = funcionarioEdit.fk_cargo;
            funcionarioAtualizar.fk_banco = funcionarioEdit.fk_banco;
            funcionarioAtualizar.cpf_funk = funcionarioEdit.cpf_funk;
            funcionarioAtualizar.rg_func = funcionarioEdit.rg_func;
            funcionarioAtualizar.dt_emissao_func = funcionarioEdit.dt_emissao_func;
            funcionarioAtualizar.orgao_emissor_func = funcionarioEdit.orgao_emissor_func;
            funcionarioAtualizar.reservista_func = funcionarioEdit.reservista_func;
            funcionarioAtualizar.titulo_eleitor_func = funcionarioEdit.titulo_eleitor_func;
            funcionarioAtualizar.zona_eleitor_func = funcionarioEdit.zona_eleitor_func;
            funcionarioAtualizar.sessao_eleitor_func = funcionarioEdit.sessao_eleitor_func;
            funcionarioAtualizar.cidade_eleitor_func = funcionarioEdit.cidade_eleitor_func;
            funcionarioAtualizar.escolaridade_func = funcionarioEdit.escolaridade_func;
            funcionarioAtualizar.cns_func = funcionarioEdit.cns_func;
            funcionarioAtualizar.cert_nasc_func = funcionarioEdit.cert_nasc_func;
            funcionarioAtualizar.cert_casamento_func = funcionarioEdit.cert_casamento_func;
            funcionarioAtualizar.comprovante_res_func = funcionarioEdit.comprovante_res_func;
            funcionarioAtualizar.nacionalidade_func = funcionarioEdit.nacionalidade_func;

            _funcionarioRepository.Funcionarios.Update(funcionarioAtualizar);
            await _funcionarioRepository.SaveChangesAsync();

            return await Task.FromResult(funcionarioAtualizar);
        }

        public async Task<bool> Remove(
            int idFuncionario)
        {
            Funcionario funcionarioRemove = await ListarFuncionarioId(idFuncionario);

            if (funcionarioRemove == null) throw new System.Exception("Houve um erro a Desabiliar o Funcionario");

            _funcionarioRepository.Funcionarios.Remove(funcionarioRemove);
            await _funcionarioRepository.SaveChangesAsync();

            return await Task.FromResult(true);
            
        }

        public async Task<Funcionario> ListarFuncionarioId(
            int idFuncionario)
        {
            Task<Funcionario> funcionarioList;

            try
            {
                funcionarioList = _funcionarioRepository.Funcionarios.FirstOrDefaultAsync(
                    x => x.id_func == idFuncionario);
            }
            catch (System.Exception e)
            {

                throw new Exception($"{e.Message} Houve um erro de Buscar Funcionario Desejado");
            }

            return await funcionarioList;
        }

        public async Task<List<ConsultarFuncionariosView>> ListarDados()
        {
            return await _funcionarioRepository.DadosFuncionarios.ToListAsync();
        }
      
    }


}

