﻿namespace SisRHDefinitivo.Models
{
    public class DeclaracaoModel
    {
        public int? id_dec { get; set; }
        public string tipo_dec { get; set; }
        public int fk_arq { get; set; }
        public DateTime? dt_in_dec { get; set; }
        public DateTime? dt_fm_dec { get; set; }
        public DateTime? hr_in_dec { get; set; }
        public DateTime? hr_fm_dec { get; set; }
        public string desc_dec { get; set; }
        public int aut_desc { get; set; }
    }
}
