using SisRHDefinitivo.Models;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.ViewModels
{
    public class DeclaracaoViewModel
    {
        [Display(Name = "Cod.Declaração")]
        public int? id_dec { get; set; }

        [Display(Name = "Tipo Declaração")]
        public string tipo_dec { get; set; }

        // classe de passagem de dados arquivo
        public int fk_arq { get; set; }

        [Display(Name ="Data Inicial Declaração")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? dt_in_dec { get; set; }

        [Display(Name = "Data Final Declaração")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? dt_fm_dec { get; set; }

        [Display(Name = "Hora Inicial Declaração")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? hr_in_dec { get; set; }

        [Display(Name = "Hora Final Declaração")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? hr_fm_dec { get; set; }

        [Display(Name = "Descrição Declaração")]
        public string desc_dec { get; set; }

        [Display(Name = "Autor")]
        public int aut_desc { get; set; }

        public static implicit operator DeclaracaoViewModel(
            DeclaracaoModel declaracaoModel)
        {
            return new DeclaracaoViewModel()
            {
                id_dec = declaracaoModel.id_dec,
                tipo_dec = declaracaoModel.tipo_dec,
                fk_arq = declaracaoModel.fk_arq,
                dt_in_dec = declaracaoModel.dt_in_dec,
                dt_fm_dec = declaracaoModel.dt_fm_dec,
                hr_fm_dec = declaracaoModel.hr_fm_dec,
                desc_dec = declaracaoModel.desc_dec,
                aut_desc = declaracaoModel.aut_desc,
            };
        }
    }
}
