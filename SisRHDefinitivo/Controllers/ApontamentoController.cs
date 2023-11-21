using Microsoft.AspNetCore.Mvc;
using SisRHDefinitivo.Repository;


namespace SisRHDefinitivo.Controllers
{
    public class ApontamentoController : Controller
    {
        public IActionResult ConsultarFolhaPonto()
        {
            var folhapontorepo = new FolhaPontoRepository();
            ModelState.Clear();
            int prof = -1;
            int dia = -1;
            int mes = -1;
            int ano = -1;
            return View(folhapontorepo.ConsultarFolhaPonto(prof, dia, mes, ano));
        }
    }
}
