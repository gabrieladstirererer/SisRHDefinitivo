using SisRHDefinitivo.Models.Core;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.ViewModels
{
    public class CargoViewModel
    {
        [Display(Name = "Cod. Cargo")]
        public int id_cargo { get; set; }

        [Display(Name = "Cargo")]
        public string desc_cargo { get; set; }

        [Display(Name = "Salario")]
        public decimal? salario_cargo { get; set; }

        public static implicit operator CargoViewModel(
            Cargo cargoModel)
        {
            return new CargoViewModel
            {
                id_cargo = cargoModel.id_cargo,
                desc_cargo = cargoModel.desc_cargo,
                salario_cargo = cargoModel.salario_cargo
            };
        }
    } 
}
