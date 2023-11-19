namespace SisRHDefinitivo.Models.Core
{
    public class Dependente
    {
        public int? id_dep { get; set; }
        public string nome_dep { get; set; }
        public string Cpf_dep { get; set; }
        public DateTime? Dt_nasc_dep { get; set; }
        public string Grau_Parent_dep { get; set; }
        public bool Desconto_salario_dep { get; set; }
        public bool Gera_salario_dep { get; set; }
        public int? Fk_func { get; set; }
        public decimal? Pensao_dep { get; set; }
    }
}
