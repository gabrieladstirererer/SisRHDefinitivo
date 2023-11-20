using SisRHDefinitivo.Models.Adm;
using SisRHDefinitivo.Models.Core;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.Models.Adm
{
    public class ArquivoViewModel
    {
        [Display(Name ="Cod. Arquivo")]
        public int? id_arq { get; set; }

        [Display(Name = "Caminho Arquivo")]
        public string caminho_arq { get; set; }

        [Display(Name = "Tipo do Arquivo")]
        public string tipo_arq { get; set; }

        [Display(Name ="Tipo Documento")]
        public string tipo_doc_arq { get; set; }

        [Display(Name = "Ativo")]
        public int? st_ativo_arq { get; set; }

        // classe passagem dados Funcionario
        public int? fk_func { get; set; }

        public static implicit operator ArquivoViewModel(
            Arquivo arquivo)
        {
            return new ArquivoViewModel()
            {
                id_arq = arquivo.id_arq,
                caminho_arq = arquivo.caminho_arq,
                tipo_arq = arquivo.tipo_arq,
                tipo_doc_arq = arquivo.tipo_doc_arq,
                st_ativo_arq = arquivo.st_ativo_arq,
                fk_func = arquivo.fk_func
            };
        }
    }
}
