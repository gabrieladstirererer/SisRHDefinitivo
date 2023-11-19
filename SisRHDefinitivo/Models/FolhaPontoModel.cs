using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NuGet.Common;

namespace SisRHDefinitivo.Models
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

        



    }
}
