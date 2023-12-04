using Microsoft.AspNetCore.Mvc;
using SisRHDefinitivo.Core.Repository;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using SisRHDefinitivo.Mvc.Adm.ViewModels;

namespace SisRHDefinitivo.Mvc.Adm.Controllers
{
    public class ApontamentoController : Controller
    {
        public IActionResult ConsultarFolhaPonto(string prof, string dia, string mes, string ano)
        {
            try
            {

                if (prof == null || (dia == null || mes == null || ano == null))
                {
                    var vm = new ConsultarFolhaPontoViewModel();
                    var folhapontorepo = new FolhaPontoRepository();

                    ModelState.Clear();
                    //int prof = -1;
                    //int dia = -1;
                    //int mes = -1;
                    //int ano = -1;   

                    //vm.Ponto = folhapontorepo.ConsultarFolhaPonto(prof, dia, mes, ano);            
                    vm.Ponto = folhapontorepo.ConsultarFolhaPonto(-1, -1, -1, -1);

                    return View(vm);
                }
                else
                {
                    var vm = new ConsultarFolhaPontoViewModel();
                    var folhapontorepo = new FolhaPontoRepository();
                    ModelState.Clear();


                    var diaP = -1;
                    var mesP = -1;
                    var anoP = -1;
                    var matricula = -1;

                    if (Convert.ToInt32(prof) > 0 && prof != null)
                    {
                        matricula = Convert.ToInt32(prof);
                    }

                    if ((Convert.ToInt32(dia) > 0 && Convert.ToInt32(dia) < 32) && (Convert.ToInt32(mes) > 0 && Convert.ToInt32(mes) < 13) && (Convert.ToInt32(ano) > 1900 && Convert.ToInt32(ano) <= DateTime.Now.Year))
                    {
                        diaP = Convert.ToInt32(dia);
                        mesP = Convert.ToInt32(mes);
                        anoP = Convert.ToInt32(ano);

                        vm.Ponto = folhapontorepo.ConsultarFolhaPonto(matricula, diaP, mesP, anoP);


                        return View(vm);
                    }
                    else
                    {
                        TempData["MensagemErro"] = $"Data não está válida!";

                        return View(vm);
                    }

                }
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = $"Erro em fazer a pesquisa! " + ex;
                return View("ConsultarFolhaPonto");
            }
        }

        //public IActionResult Pesquisar(string prof, string dia, string mes, string ano)
        //{
        //    try 
        //    {
        //        var diaP = -1;
        //        var mesP = -1;
        //        var anoP = -1;
        //        var matricula = -1;

        //        if (Convert.ToInt32(prof) > 0 && prof != null)
        //        {
        //            matricula = Convert.ToInt32(prof);
        //        }

        //        if ((Convert.ToInt32(dia) > 0 && Convert.ToInt32(dia) < 32) && (Convert.ToInt32(mes) > 0 && Convert.ToInt32(mes) < 13) && (Convert.ToInt32(ano) > 1900 && Convert.ToInt32(ano) <= DateTime.Now.Year))
        //        {
        //            diaP = Convert.ToInt32(dia);
        //            mesP = Convert.ToInt32(mes);
        //            anoP = Convert.ToInt32(ano);

        //            var folhapontorepo = new FolhaPontoRepository();
        //            ModelState.Clear();

        //            var vm = new ConsultarFolhaPontoViewModel();

        //            vm.Ponto = folhapontorepo.ConsultarFolhaPonto(matricula, diaP, mesP, anoP);

        //            return View(vm.Ponto);
        //        }
        //        else 
        //        {
        //            TempData["MensagemErro"] = $"Data não está válida!";

        //            return View("ConsultarFolhaPonto");
        //        }

        //    }
        //    catch (Exception ex) {
        //        TempData["MensagemErro"] = $"Erro em fazer a pesquisa! " + ex;
        //        return View("ConsultarFolhaPonto");
        //    }
        //}
    }
}
