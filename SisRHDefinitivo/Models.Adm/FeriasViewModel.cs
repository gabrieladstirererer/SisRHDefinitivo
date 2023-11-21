using SisRHDefinitivo.Models.Core;

using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.ViewModels
{
    public class FeriasViewModel
    {
        [Display(Name ="Cod.Férias")]
        public int? id_ferias { get; set; }

        [Display(Name = "Data Inicio Ferias")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? dt_inicioFerias { get; set; }

        [Display(Name = "Data Final Ferias")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? dt_fim_ferias { get; set; }

        [Display(Name = "Data Agendamento Ferias")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? dt_agendamentoFerias { get; set; }

        [Display(Name = "Valor Ferias")]
        public double? valor_receber_ferias { get; set; }

        /// <summary> 
        /// classe de dados de Funcionario
        /// </summary>
        public int? fk_func { get; set; }

        public static implicit operator FeriasViewModel(
            Ferias feriasModel)
        {
            return new FeriasViewModel()
            {   
                id_ferias = feriasModel. id_ferias,
                dt_inicioFerias = feriasModel.dt_inicioFerias,
                dt_fim_ferias = feriasModel. dt_fim_ferias,
                dt_agendamentoFerias = feriasModel.dt_agendamentoFerias,
                valor_receber_ferias = feriasModel.valor_receber_ferias,
                fk_func = feriasModel.fk_func,
            };
        }
    }
}
