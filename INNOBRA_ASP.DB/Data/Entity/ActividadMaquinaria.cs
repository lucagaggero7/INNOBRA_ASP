using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNOBRA_ASP.DB.Data.Entity
{
    public class ActividadMaquinaria : EntityBase
    {
        [Required(ErrorMessage = "Las horas utilizadas son obligatorias.")]
        public decimal HorasUtilizadas { get; set; }

        [Required(ErrorMessage = "El costo de la hora de la hora es obligatorio.")]
        public decimal CostoHora { get; set; }

        [Required(ErrorMessage = "El Id es obligatorio.")]
        public int MaquinariaId { get; set; }

        public Maquinaria Maquinaria { get; set; }

    }
}
