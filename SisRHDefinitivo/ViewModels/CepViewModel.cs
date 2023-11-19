using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.ViewModels
{
    public class CepViewModel
    {
        [Display(Name = "Cod.Cep")]
        public int? ID_CEP { get; set; }

        [Display(Name = "Cep")]
        public string CEP { get; set; }

        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Display(Name ="Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "UF")]
        public string UF { get; set; }
    }
}
