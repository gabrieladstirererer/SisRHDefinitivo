namespace SisRHDefinitivo.Models
{
    public class ArquivoModel
    {
        public int? id_arq { get; set; }
        public string caminho_arq { get; set; }
        public string tipo_arq { get; set; }
        public string tipo_doc_arq { get; set; }
        public int? st_ativo_arq { get; set; }
        public int? fk_func { get; set; }
    }
}
