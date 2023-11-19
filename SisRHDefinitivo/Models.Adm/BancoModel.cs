using SisRHDefinitivo.Models.Core;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.ViewModels
{
    public class BancoViewModel
    {
        [Display(Name = "Cod.Banco")]
        public int id_banco { get; set; }

        [Display(Name = "Banco")]
        public string banco { get; set; }

        public static implicit operator BancoViewModel(
            BancoModel bancoModel)
        {
            return new BancoViewModel()
            {
                id_banco = bancoModel.id_banco,
                banco = bancoModel.banco
            };
        }
    }
}
