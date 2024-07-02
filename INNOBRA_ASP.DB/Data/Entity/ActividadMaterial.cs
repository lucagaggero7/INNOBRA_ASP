using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNOBRA_ASP.DB.Data.Entity
{
    public class ActividadMaterial : EntityBase
    {
        [Required(ErrorMessage = "Las cantidades son obligatorias.")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El costo total es obligatorio.")]
        public decimal CostoTotal { get; set; }

        [Required(ErrorMessage = "El Id es obligatorio.")]
        public int MaterialId { get; set; }

        public Material Material { get; set; }

    }
}
