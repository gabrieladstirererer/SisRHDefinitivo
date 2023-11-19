using SisRHDefinitivo.Models;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.ViewModels
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
            ArquivoModel arquivoModel)
        {
            return new ArquivoViewModel()
            {
                id_arq = arquivoModel.id_arq,
                caminho_arq = arquivoModel.caminho_arq,
                tipo_arq = arquivoModel.tipo_arq,
                tipo_doc_arq = arquivoModel.tipo_doc_arq,
                st_ativo_arq = arquivoModel.st_ativo_arq,
                fk_func = arquivoModel.fk_func
            };
        }
    }
}
