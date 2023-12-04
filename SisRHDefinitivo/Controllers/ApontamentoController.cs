using Microsoft.AspNetCore.Mvc;
using SisRHDefinitivo.Core.Repository;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using SisRHDefinitivo.Mvc.Adm.ViewModels;

namespace SisRHDefinitivo.Mvc.Adm.Controllers
{
    public class ApontamentoController : Controller
    {
        public IActionResult ConsultarFolhaPonto(ConsultarFolhaPontoViewModel vm)
        {
            try
            {

                if (vm.matricula == null && (vm.dia == 0 || vm.mes == 0 || vm.ano == 0))
                {
                   // var vm = new ConsultarFolhaPontoViewModel();
                    var folhapontorepo = new FolhaPontoRepository();

                    ModelState.Clear();                             

                    var Ldia = DateTime.Now.Day - 1;
                    var Lmes = Ldia == 0 ? DateTime.Now.Month - 1 : DateTime.Now.Month;
                    var Lano = Lmes == 0 ? DateTime.Now.Year - 1 : DateTime.Now.Year;

                    vm.dia = Ldia != 0 ? Ldia : DateTime.DaysInMonth(Lano, Lmes);
                    vm.mes = Lmes;
                    vm.ano = Lano;
                    vm.Ponto = folhapontorepo.ConsultarFolhaPonto(-1, -1, -1, -1);

                    return View(vm);
                }
                else
                {
                   // var vm = new ConsultarFolhaPontoViewModel();
                    var folhapontorepo = new FolhaPontoRepository();
                    ModelState.Clear();


                    var diaP = -1;
                    var mesP = -1;
                    var anoP = -1;
                    var matricula = -1;

                    if (Convert.ToInt32(vm.matricula) > 0 && vm.matricula != null)
                    {
                        matricula = Convert.ToInt32(vm.matricula);
                    }

                    if ((Convert.ToInt32(vm.dia) > 0 && Convert.ToInt32(vm.dia) < 32) && (Convert.ToInt32(vm.mes) > 0 && Convert.ToInt32(vm.mes) < 13) && (Convert.ToInt32(vm.ano) > 1900 && Convert.ToInt32(vm.ano) <= DateTime.Now.Year))
                    {
                        diaP = Convert.ToInt32(vm.dia);
                        mesP = Convert.ToInt32(vm.mes);
                        anoP = Convert.ToInt32(vm.ano);

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
