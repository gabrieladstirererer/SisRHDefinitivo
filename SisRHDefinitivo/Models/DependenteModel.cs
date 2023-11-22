using Microsoft.AspNetCore.Mvc.ModelBinding;
using SisRHDefinitivo.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.Mvc.Adm.Models
{
    public class DependenteModel
    {
        [Display(Name = "Cod. Dependente")]
        public int? id_dep { get; set; }

        [Display(Name = "Nome Dependente")]
        public string nome_dep { get; set; }

        [Display(Name = "CPF Dependente")]
        public string Cpf_dep { get; set; }

        [Display(Name = "Data Nascimento Dependente")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Dt_nasc_dep { get; set; }

        [Display(Name = "Grau Parentesco")]
        public string Grau_Parent_dep { get; set; }

        [Display(Name = "Desconto Salario")]
        public bool Desconto_salario_dep { get; set; }

        [Display(Name ="Gerar Salario")]
        public bool Gera_salario_dep { get; set; }

        /// <summary> 
        /// classe de dados de Funcionario
        /// </summary>
        public int? Fk_func { get; set; }

        [Display(Name = "Pensão Funcionario")]
        public decimal? Pensao_dep { get; set; }

        public static implicit operator DependenteModel(
           Dependente dependenteModel)
        {
            return new DependenteModel()
            {
                id_dep = dependenteModel.id_dep,
                nome_dep = dependenteModel.nome_dep,
                Cpf_dep = dependenteModel.Cpf_dep,
                Dt_nasc_dep = dependenteModel.Dt_nasc_dep,
                Grau_Parent_dep = dependenteModel.Grau_Parent_dep,
                Desconto_salario_dep = dependenteModel.Desconto_salario_dep,
                Gera_salario_dep = dependenteModel.Gera_salario_dep,
                Fk_func = dependenteModel.Fk_func,
                Pensao_dep = dependenteModel.Pensao_dep
            };
        }
    }
}
