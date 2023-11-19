namespace SisRHDefinitivo.Models
{
    public class FeriasModel
    {
        public int? id_ferias { get; set; }
        public DateTime? dt_inicioFerias { get; set; }
        public DateTime? dt_fim_ferias { get; set; }
        public DateTime? dt_agendamentoFerias { get; set; }
        public double? valor_receber_ferias { get; set; }
        public int? fk_func { get; set; }
    }
}
