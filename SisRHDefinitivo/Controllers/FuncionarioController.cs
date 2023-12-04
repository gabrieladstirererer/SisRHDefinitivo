using Microsoft.AspNetCore.Mvc;
using SisRHDefinitivo.Core.Models;
using SisRHDefinitivo.Core.Models.Views;
using SisRHDefinitivo.Core.Repository;
using SisRHDefinitivo.Mvc.Adm.Models;
using SisRHDefinitivo.Mvc.Adm.ViewsModel.Funcionario;

namespace SisRHDefinitivo.Mvc.Adm.Controllers
{

    public class FuncionarioController : Controller
    {

        public IActionResult Index(ConsultarFuncionarioViewModel cv)
        {
            var selectFunc = new SelectFuncionarioRepository();
            ModelState.Clear();

            var nome = "-1";
            var matricula = -1;

            if (cv.primeiro_nm_func != null || cv.matricula_func > 0)
            {
                nome = cv.primeiro_nm_func != "" ? cv.primeiro_nm_func : nome;
                matricula = cv.matricula_func > 0 ? cv.matricula_func : matricula;

                cv.funcionarios = selectFunc.ConsultarFunc(nome, matricula);
                return View(cv);
            }
            else
            {
                cv.funcionarios = selectFunc.ConsultarFunc("-1", -1);
                return View(cv);
            }
        }
        public IActionResult New(NewViewModel nvw)
        {

            if (nvw.primeiro_nm_func != null)
            {
                var gravarFunc = new CadastrarFuncionarioRepository();

                var nCadModel = new CadastrarFuncModel
                {
                    primeiro_nm_func = nvw.primeiro_nm_func,
                    sobre_nm_func = nvw.sobre_nm_func,
                    ultimo_nm_func = nvw.ultimo_nm_func,
                    matricula_func = nvw.matricula,
                    dt_nasc_func = nvw.dt_nasc_func,
                    sexo_func = nvw.sexo_func,
                    raca_func = nvw.raca_func,
                    tipo_sanguineo_func = nvw.tipo_sanguineo_func,
                    nm_mae_func = nvw.nm_mae_func,
                    nm_pai_func = nvw.nm_pai_func,
                    estado_civil_func = nvw.estado_civil_func,
                    nome_conjunge_func = nvw.nome_conjugue_func,
                    cidade_nasc = nvw.cidade_nasc,
                    numero_res_func = nvw.numero_resr_func,
                    compl_func = nvw.compl_func,
                    tipo_moradia_func = nvw.tipo_moradia,
                    celular_func = nvw.celular_func,
                    whatsapp_func = nvw.whatsapp_fun,
                    telefone_func = nvw.telefone_func,
                    email_func = nvw.email_func,
                    email_corp_func = nvw.email_corp_func,
                    num_agen_func = nvw.num_agen_func,
                    num_conta_func = nvw.num_conta_func,
                    fk_cargo = nvw.fk_cargo,
                    fk_banco = nvw.fk_banco,
                    cpf_func = nvw.cpf_funk,
                    rg_func = nvw.rg_func,
                    dt_emissao_func = nvw.dt_emissao_func,
                    orgao_emissor_func = nvw.orgao_emissor_func,
                    reservista_func = nvw.reservista_func,
                    titulo_eleitor_func = nvw.titulo_eleitor_func,
                    zona_eleitor_func = nvw.zona_eleitor_func,
                    sessao_eleitor_func = nvw.sessao_eleitor_func,
                    cidade_eleitor_func = nvw.cidade_eleitor_func,
                    escolaridade_func = nvw.escolaridade_func,
                    cns_func = nvw.cns_func,
                    cert_nasc_func = nvw.cert_nasc_func,
                    cert_casamento_func = nvw.cert_casamento_func,
                    comprovante_res_func = nvw.comprovante_res_func,
                    nacionalidade_func = nvw.nacionalidade_func,
                    st_status_func = 1,
                    Fk_dep = 2,
                    fk_cep = 1,
                    Jornada_func = "",
                    ST_Ativo = true,
                };


                if (gravarFunc.CadastrarFunc(nCadModel))
                {
                    TempData["MensagemCerto"] = $"Funcionario cadastrado.";

                    return RedirectToAction("New");
                }
                else
                {
                    TempData["MensagemErro"] = $"Erro em cadastrar o funcionario.";

                    return View("New");
                }
            }
            return View("New");
        }

        public IActionResult Search()
        {

            return View();
        }




        public IActionResult Edit()
        {
            return View();
        }
    }
}
