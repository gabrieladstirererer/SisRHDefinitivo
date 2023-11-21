namespace SisRHDefinitivo.Core.Models
{
    public class FuncionarioEstrangeiro
    {
        public int? id_funcEstrang { get; set; }
        public string visto_func { get; set; }
        public string passaporte_func { get; set; }
        public string auttrab_func { get; set; }
        public int? fk_func { get; set; }
    }
}
