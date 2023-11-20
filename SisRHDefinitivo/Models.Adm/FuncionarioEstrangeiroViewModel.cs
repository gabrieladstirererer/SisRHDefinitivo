using SisRHDefinitivo.Models.Core;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.ViewModels
{
    public class FuncionarioEstrangeiroViewModel
    {
        [Display(Name = "Cod.Funcionario")]
        public int? id_funcEstrang { get; set; }

        [Display(Name = "Visto")]
        public string visto_func { get; set; }

        [Display(Name = "Passaporte")]
        public string passaporte_func { get; set; }

        [Display(Name = "AUTTRAB")]
        public string auttrab_func { get; set; }

        /// <summary> 
        /// classe de dados de Funcionario
        /// </summary>
        public int? fk_func { get; set; }

        public static implicit operator FuncionarioEstrangeiroViewModel(
           FuncionarioEstrangeiro funcionarioEstrangeiroModel)
        {
            return new FuncionarioEstrangeiroViewModel()
            {
                id_funcEstrang = funcionarioEstrangeiroModel.id_funcEstrang,
                visto_func = funcionarioEstrangeiroModel.visto_func,
                passaporte_func = funcionarioEstrangeiroModel.passaporte_func,
                auttrab_func = funcionarioEstrangeiroModel.auttrab_func,
                fk_func = funcionarioEstrangeiroModel.fk_func,
            };
        }
    }
}
