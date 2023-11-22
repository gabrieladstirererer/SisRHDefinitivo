using SisRHDefinitivo.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.Mvc.Adm.Models
{
    public class DepartamentoModel
    {
        [Display(Name = "Cod.Dep")]
        public int id_dep { get; set; }

        [Display(Name = "Nome Departamento")]
        public string nome_dep { get; set; }

        [Display(Name = "Chefe Departamento")]
        public int? fk_chefe_dep { get; set; }

        public static implicit operator DepartamentoModel(
            Departamento departamento)
        {
            return new DepartamentoModel()
            {
                id_dep = departamento.id_dep,
                nome_dep = departamento.nome_dep,
                fk_chefe_dep = departamento.fk_chefe_dep
            };
        }
    }
}
