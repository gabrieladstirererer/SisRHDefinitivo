using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.Mvc.Adm.ViewModels
{
    public class ConsultarFolhaPontoViewModel
    {
        public IEnumerable<SisRHDefinitivo.Core.Models.FolhaPonto> Ponto { get; set; }
        public int? matricula { get; set; }
        public int dia { get; set; }
        public int mes { get; set; }
        public int ano { get; set; }
        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public string Dt_apont_fp { get; set; }
        [Display(Name = "Entrada 1")]
        public TimeSpan? Hr_apont_fp_E1 { get; set; }
        public byte? Atraso_fp { get; set; }
        public byte? Adv_fp { get; set; }
        [Display(Name = "Observação")]
        public string? Desc_adv_fp { get; set; }
        public string? Lat_fp { get; set; }
        public string? Long_fp { get; set; }
        public int? Fk_arq { get; set; }
        public int? AlterarFolha1 { get; set; }
        [Display(Name = "Entrada 2")]
        public TimeSpan? Hr_apont_fp_E2 { get; set; }
        [Display(Name = "Saída 1")]
        public TimeSpan? Hr_apont_fp_S1 { get; set; }
        [Display(Name = "Saída 2")]
        public TimeSpan? Hr_apont_fp_S2 { get; set; }
        [Display(Name = "Entrada 3")]
        public TimeSpan? Hr_apont_fp_E3 { get; set; }
        [Display(Name = "Saída 3")]
        public TimeSpan? Hr_apont_fp_S3 { get; set; }
        public int Mes_fp1 { get; set; }
        public int Ano_fp1 { get; set; }
        public int Dia_fp1 { get; set; }
        [Display(Name = "Nome")]
        public string Nome_Func { get; set; }
        [Display(Name = "Horas")]
        public string Horas_trabalhadas { get; set; }
        [Display(Name = "Extra")]
        public string Horas_extras { get; set; }
    }
}
