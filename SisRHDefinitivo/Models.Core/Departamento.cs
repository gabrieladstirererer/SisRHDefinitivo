namespace SisRHDefinitivo.Models.Core
{
    public class Departamento
    {
        public int id_dep { get; set; }
        public string nome_dep { get; set; }
        public int? fk_chefe_dep { get; set; }
    }
}
