using SisRHDefinitivo.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.Adm.Models
{
    public class FuncionarioEstrangeiroModel
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

        public static implicit operator FuncionarioEstrangeiroModel(
           FuncionarioEstrangeiro funcionarioEstrangeiroModel)
        {
            return new FuncionarioEstrangeiroModel()
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
