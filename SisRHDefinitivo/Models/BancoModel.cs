using SisRHDefinitivo.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.Mvc.Adm.Models
{
    public class BancoModel
    {
        [Display(Name = "Cod.Banco")]
        public int id_banco { get; set; }

        [Display(Name = "Banco")]
        public string banco { get; set; }

        public static implicit operator BancoModel(Banco bancoModel)
        {
            if (bancoModel == null)
            {
                return null;
            }

            return new BancoModel()
            {
                id_banco = bancoModel.id_banco,
                banco = bancoModel.banco
            };
        }
    }
}
