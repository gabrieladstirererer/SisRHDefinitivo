using SisRHDefinitivo.Core.Models;
using System.ComponentModel.DataAnnotations;


namespace SisRHDefinitivo.Mvc.Adm.Models
{
    public class FolhaPontoModel
    {
        public int Id_fp { get; set; }

        public int? Fk_func { get; set; }
        [Display(Name = "Data")]
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

        public static implicit operator FolhaPontoModel(
           FolhaPonto folhaPonto)
        {
            return new FolhaPonto()
            {
                Id_fp = folhaPonto.Id_fp,
                Fk_func = folhaPonto.Fk_func,
                Dt_apont_fp = folhaPonto.Dt_apont_fp,
                Hr_apont_fp_E1 = folhaPonto.Hr_apont_fp_E1,
                Atraso_fp = folhaPonto.Atraso_fp,
                Adv_fp = folhaPonto.Adv_fp,
                Desc_adv_fp = folhaPonto.Desc_adv_fp,
                Lat_fp = folhaPonto.Lat_fp,
                Long_fp = folhaPonto.Long_fp,
                Fk_arq = folhaPonto.Fk_arq,
                AlterarFolha1 = folhaPonto.AlterarFolha1,
                Hr_apont_fp_E2 = folhaPonto.Hr_apont_fp_E2,
                Hr_apont_fp_S1 = folhaPonto.Hr_apont_fp_S1,
                Hr_apont_fp_S2 = folhaPonto.Hr_apont_fp_S2,
                Hr_apont_fp_E3 = folhaPonto.Hr_apont_fp_E3,
                Hr_apont_fp_S3 = folhaPonto.Hr_apont_fp_S3,
                Mes_fp1 = folhaPonto.Mes_fp1,
                Ano_fp1 = folhaPonto.Ano_fp1,
                Dia_fp1 = folhaPonto.Dia_fp1,
                Nome_Func = folhaPonto.Nome_Func,
                Horas_extras = folhaPonto.Horas_extras,
                Horas_trabalhadas = folhaPonto.Horas_trabalhadas,

            };
        }
    }
}
