using SisRHDefinitivo.Models;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.ViewModels
{
    public class HoleriteViewModel
    {
        [Display(Name = "Cod.Holerite")]
        public int? id_hol { get; set; }

        /// <summary> 
        /// classe de dados de Folha de Ponto
        /// </summary>
        public int? fk_fp { get; set; }

        [Display(Name = "Beneficios")]
        public double beneficios_hol { get; set; }

        /// <summary> 
        /// classe de dados de Funcionario
        /// </summary>
        public int? fk_func { get; set; }

        /// <summary> 
        /// classe de dados de Ferias
        /// </summary>
        public int? fk_ferias { get; set; }

        public static implicit operator HoleriteViewModel(
            HoleriteModel holeriteModel)
        {
            return new HoleriteViewModel()
            {
                id_hol = holeriteModel.id_hol,
                fk_fp = holeriteModel.fk_fp,
                beneficios_hol = holeriteModel.beneficios_hol,
                fk_func = holeriteModel.fk_func,
                fk_ferias = holeriteModel.fk_ferias
            };
        }
    }
}
