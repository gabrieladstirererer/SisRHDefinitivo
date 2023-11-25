using Microsoft.AspNetCore.Mvc;
using SisRHDefinitivo.Core.Repository;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using SisRHDefinitivo.Mvc.Adm.ViewModels;

namespace SisRHDefinitivo.Mvc.Adm.Controllers
{
    public class ApontamentoController : Controller
    {
        public IActionResult ConsultarFolhaPonto()
        {
            var vm = new ConsultarFolhaPontoViewModel();
            var folhapontorepo = new FolhaPontoRepository();
           
            ModelState.Clear();
            int prof = -1;
            int dia = -1;
            int mes = -1;
            int ano = -1;

            
            var Ldia = DateTime.Now.Day - 1;
            var Lmes = Ldia == 0 ? DateTime.Now.Month - 1 : DateTime.Now.Month;
            var Lano = Lmes == 0 ? DateTime.Now.Year - 1 : DateTime.Now.Year;


            vm.Ponto = folhapontorepo.ConsultarFolhaPonto(prof, dia, mes, ano);
            vm.dia = Ldia != 0 ? Ldia : DateTime.DaysInMonth(Lano, Lmes);            
            vm.mes = Lmes;
            vm.ano = Lano;

            return View(vm);
        }

        public IActionResult btnPesquisar(ConsultarFolhaPontoViewModel vm)
        {
            var folhapontorepo = new FolhaPontoRepository();
            ModelState.Clear();

            var prof = -1;
            var dia = -1;
            var mes = -1;
            var ano = -1;

            if (vm.matricula != 0 && vm.matricula != null)
            {
                prof = Convert.ToInt16(vm.matricula);
            }

            if ((vm.dia > 0 && vm.dia < 32) && (vm.mes > 0 && vm.mes < 13) && (vm.ano > 1900 && vm.ano <= DateTime.Now.Year))
            {
                dia = vm.dia;
                mes = vm.mes;
                ano = vm.ano;
            }

            vm.Ponto = folhapontorepo.ConsultarFolhaPonto(prof, dia, mes, ano);           

            return View(vm);
        }
    }
}
