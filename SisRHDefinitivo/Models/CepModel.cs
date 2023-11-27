using SisRHDefinitivo.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.Mvc.Adm.Models
{
    public class CepModel
    {
        [Display(Name = "Cod.Cep")]
        public int? ID_CEP { get; set; }

        [Display(Name = "Cep")]
        public string CEP { get; set; }

        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "UF")]
        public string UF { get; set; }


        public static implicit operator CepModel(
              Cep cep)
        {
            return new CepModel()
            {
                ID_CEP = cep.ID_CEP,
                CEP = cep.CEP,
                Logradouro = cep.Logradouro,
                Cidade = cep.Cidade,
                Bairro = cep.Bairro,
                UF = cep.UF
            };
        }
    }
}