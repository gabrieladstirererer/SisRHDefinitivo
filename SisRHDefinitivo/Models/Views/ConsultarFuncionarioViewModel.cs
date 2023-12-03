using SisRHDefinitivo.Core.Models.Views;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.Mvc.Adm.Models
{
    public class ConsultarFuncionarioViewModel
    {
        [Display(Name = "ID")]
        public int? id_func { get; set; }

        [Display(Name = "Nome")]
        public string primeiro_nm_func { get; set; }

        [Display(Name = "SobreNome")]
        public string sobre_nm_func { get; set; }

        [Display(Name = "Email Corporativo")]
        public string email_corp_func { get; set; }

        [Display(Name = "Celular")]
        public string celular_func { get; set; }

        [Display(Name = "Prontuario")]
        public int? matricula_func { get; set; }
        public int? fk_cargo { get; set; }


        public static implicit operator ConsultarFuncionarioViewModel(
            ConsultarFuncionariosView consultarfuncionario)
        {
            return new ConsultarFuncionarioViewModel()
            {
                id_func = consultarfuncionario.id_func,
                primeiro_nm_func = consultarfuncionario.primeiro_nm_func,
                sobre_nm_func = consultarfuncionario.sobre_nm_func,
                email_corp_func = consultarfuncionario.email_corp_func,
                matricula_func = consultarfuncionario.matricula_func,
                fk_cargo = consultarfuncionario.fk_cargo
            };


        }
    }

}


