using SisRHDefinitivo.Core.Models.Views;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.Mvc.Adm.Models
{
    public class ConsultarFuncionarioViewModel
    {
        [Display(Name = "ID")]
        public int? id_func { get; set; }

        [Display(Name = "Nome")]
        public string primeiro_nm_func { get; set; }

        [Display(Name = "SobreNome")]
        public string sobre_nm_func { get; set; }

        [Display(Name = "Email Corporativo")]
        public string email_corp_func { get; set; }

        [Display(Name = "Prontuario")]
        public int matricula_func { get; set; }
        public int? fk_cargo { get; set; }
        [Display(Name = "Nome")]
        public string nome_func { get;set; }
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        public string telefone { get; set; }
        public string sexo { get; set; }
        public string cargo { get; set; }
        public string departamento { get; set; }
        [Display(Name = "Data de Emissão")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime dataEmissao {  get; set; }
        [Display(Name = "Matrícula")]
        public int matricula { get; set; }
        public IEnumerable<SisRHDefinitivo.Core.Models.Funcionario> funcionarios { get; set; }

    }

}


