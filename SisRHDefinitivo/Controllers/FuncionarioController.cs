using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Protocol;
using SisRHDefinitivo.Core.Models;
using SisRHDefinitivo.Core.Models.Views;
using SisRHDefinitivo.Core.Repository;
using SisRHDefinitivo.Mvc.Adm.Models;
using SisRHDefinitivo.Mvc.Adm.ViewModels.Funcionario;
using System.Web.Razor.Tokenizer.Symbols;

namespace SisRHDefinitivo.Mvc.Adm.Controllers
{

    public class FuncionarioController : Controller
    {
        //private readonly IFuncionarioRepository _funcionarioRepository;

        //public FuncionarioController(
        //IFuncionarioRepository funcionarioRepository)

        //{
        //    _funcionarioRepository = funcionarioRepository;
        //}

        public IActionResult Index()
        {
            return View();
        }

        //public async Task<PartialViewResult> Search(
        //    ViewModels.Funcionario.IndexViewModel indexViewModel)
        //{
        //    var funcionarioView = new ConsultarFuncionariosView
        //    {
        //        id_func = indexViewModel.DadosFuncionario.id_func,
        //        primeiro_nm_func = indexViewModel.DadosFuncionario.primeiro_nm_func,
        //        sobre_nm_func = indexViewModel.DadosFuncionario.primeiro_nm_func,
        //        matricula_func = indexViewModel.DadosFuncionario.matricula_func,
        //        email_corp_func = indexViewModel.DadosFuncionario.email_corp_func,
        //        celular_func = indexViewModel.DadosFuncionario.celular_func,
        //        fk_cargo = indexViewModel.DadosFuncionario.fk_cargo
        //    };
        //    var funcionarioList = await _funcionarioRepository.ListarAsync(Convert.ToInt32(funcionarioView));
        //    return PartialView("_table", funcionarioList);
        //}

        [Route("new")]
        public IActionResult New()
        {

            return View();
        }

        //public async Task<IActionResult> adicionarFuncionario(
        //    ViewModels.Funcionario.NewViewModel newViewModel)
        //{
        //    var funcionario = new Funcionario
        //    {
        //        id_func = newViewModel.Funcionario.id_func,
        //        primeiro_nm_func = newViewModel.Funcionario.primeiro_nm_func,
        //        sobre_nm_func = newViewModel.Funcionario.sobre_nm_func,
        //        ultimo_nm_func = newViewModel.Funcionario.ultimo_nm_func,
        //        matricula_func = newViewModel.Funcionario.matricula_func,
        //        dt_nasc_func = newViewModel.Funcionario.dt_nasc_func,
        //        sexo_func = newViewModel.Funcionario.sexo_func,
        //        raca_func = newViewModel.Funcionario.raca_func,
        //        tipo_sanguineo_func = newViewModel.Funcionario.tipo_sanguineo_func,
        //        nm_mae_func = newViewModel.Funcionario.nm_mae_func,
        //        nm_pai_func = newViewModel.Funcionario.nm_pai_func,
        //        estado_civil_func = newViewModel.Funcionario.estado_civil_func,
        //        nm_conjugue_func = newViewModel.Funcionario.nm_conjugue_func,
        //        cidade_nasc = newViewModel.Funcionario.cidade_nasc,
        //        numero_resr_func = newViewModel.Funcionario.numero_resr_func,
        //        compl_func = newViewModel.Funcionario.compl_func,
        //        tipo_moradia_func = newViewModel.Funcionario.tipo_moradia_func,
        //        celular_func = newViewModel.Funcionario.celular_func,
        //        whatsapp_fun = newViewModel.Funcionario.whatsapp_fun,
        //        telefone_func = newViewModel.Funcionario.telefone_func,
        //        email_func = newViewModel.Funcionario.email_func,
        //        email_corp_func = newViewModel.Funcionario.email_corp_func,
        //        num_agen_func = newViewModel.Funcionario.num_agen_func,
        //        num_conta_func = newViewModel.Funcionario.num_conta_func,
        //        fk_cargo = newViewModel.Funcionario.fk_cargo,
        //        fk_banco = newViewModel.Funcionario.fk_banco,
        //        cpf_funk = newViewModel.Funcionario.cpf_funk,
        //        rg_func = newViewModel.Funcionario.rg_func,
        //        dt_emissao_func = newViewModel.Funcionario.dt_emissao_func,
        //        orgao_emissor_func = newViewModel.Funcionario.orgao_emissor_func,
        //        reservista_func = newViewModel.Funcionario.reservista_func,
        //        titulo_eleitor_func = newViewModel.Funcionario.titulo_eleitor_func,
        //        zona_eleitor_func = newViewModel.Funcionario.zona_eleitor_func,
        //        sessao_eleitor_func = newViewModel.Funcionario.sessao_eleitor_func,
        //        cidade_eleitor_func = newViewModel.Funcionario.cidade_eleitor_func,
        //        escolaridade_func = newViewModel.Funcionario.escolaridade_func,
        //        cns_func = newViewModel.Funcionario.cns_func,
        //        cert_nasc_func = newViewModel.Funcionario.cert_nasc_func,
        //        cert_casamento_func = newViewModel.Funcionario.cert_casamento_func,
        //        comprovante_res_func = newViewModel.Funcionario.comprovante_res_func,
        //        nacionalidade_func = newViewModel.Funcionario.nacionalidade_func,
        //        st_status_func = newViewModel.Funcionario.st_status_func,
        //        Fk_dep = newViewModel.Funcionario.Fk_dep,
        //    };
        //    var resultado = await _funcionarioRepository.AdicionarAsync(funcionario);
        //    return Json(resultado);
        //}

        //public async Task<IActionResult> gravarEdit(
        //   ViewModels.Funcionario.EditViewModel editViewModel)
        //{
        //    var funcionario = new Funcionario
        //    {
        //        id_func = editViewModel.Funcionario.id_func,
        //        primeiro_nm_func = editViewModel.Funcionario.primeiro_nm_func,
        //        sobre_nm_func = editViewModel.Funcionario.sobre_nm_func,
        //        ultimo_nm_func = editViewModel.Funcionario.ultimo_nm_func,
        //        matricula_func = editViewModel.Funcionario.matricula_func,
        //        dt_nasc_func = editViewModel.Funcionario.dt_nasc_func,
        //        sexo_func = editViewModel.Funcionario.sexo_func,
        //        raca_func = editViewModel.Funcionario.raca_func,
        //        tipo_sanguineo_func = editViewModel.Funcionario.tipo_sanguineo_func,
        //        nm_mae_func = editViewModel.Funcionario.nm_mae_func,
        //        nm_pai_func = editViewModel.Funcionario.nm_pai_func,
        //        estado_civil_func = editViewModel.Funcionario.estado_civil_func,
        //        nm_conjugue_func = editViewModel.Funcionario.nm_conjugue_func,
        //        cidade_nasc = editViewModel.Funcionario.cidade_nasc,
        //        numero_resr_func = editViewModel.Funcionario.numero_resr_func,
        //        compl_func = editViewModel.Funcionario.compl_func,
        //        tipo_moradia_func = editViewModel.Funcionario.tipo_moradia_func,
        //        celular_func = editViewModel.Funcionario.celular_func,
        //        whatsapp_fun = editViewModel.Funcionario.whatsapp_fun,
        //        telefone_func = editViewModel.Funcionario.telefone_func,
        //        email_func = editViewModel.Funcionario.email_func,
        //        email_corp_func = editViewModel.Funcionario.email_corp_func,
        //        num_agen_func = editViewModel.Funcionario.num_agen_func,
        //        num_conta_func = editViewModel.Funcionario.num_conta_func,
        //        fk_cargo = editViewModel.Funcionario.fk_cargo,
        //        fk_banco = editViewModel.Funcionario.fk_banco,
        //        cpf_funk = editViewModel.Funcionario.cpf_funk,
        //        rg_func = editViewModel.Funcionario.rg_func,
        //        dt_emissao_func = editViewModel.Funcionario.dt_emissao_func,
        //        orgao_emissor_func = editViewModel.Funcionario.orgao_emissor_func,
        //        reservista_func = editViewModel.Funcionario.reservista_func,
        //        titulo_eleitor_func = editViewModel.Funcionario.titulo_eleitor_func,
        //        zona_eleitor_func = editViewModel.Funcionario.zona_eleitor_func,
        //        sessao_eleitor_func = editViewModel.Funcionario.sessao_eleitor_func,
        //        cidade_eleitor_func = editViewModel.Funcionario.cidade_eleitor_func,
        //        escolaridade_func = editViewModel.Funcionario.escolaridade_func,
        //        cns_func = editViewModel.Funcionario.cns_func,
        //        cert_nasc_func = editViewModel.Funcionario.cert_nasc_func,
        //        cert_casamento_func = editViewModel.Funcionario.cert_casamento_func,
        //        comprovante_res_func = editViewModel.Funcionario.comprovante_res_func,
        //        nacionalidade_func = editViewModel.Funcionario.nacionalidade_func,
        //        st_status_func = editViewModel.Funcionario.st_status_func,
        //        Fk_dep = editViewModel.Funcionario.Fk_dep,
        //    };
        //    //var resultado = await _funcionarioRepository.UpadateAsync(funcionario);
        //    //return Json(resultado);
        //}

        // Gravar a edição
        public IActionResult Edit()
        {

            return View();
        }
    }
}
