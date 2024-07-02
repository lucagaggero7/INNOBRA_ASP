using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace INNOBRA_ASP.DB.Data.Entity
{
    public class ActividadEmpleado : EntityBase
    {
        [Required(ErrorMessage = "Las horas trabajadas son obligatorias.")]
        public decimal  HorasTrabajadas { get; set; }

        [Required(ErrorMessage = "El costo de la hora de la hora es obligatorio.")]
        public decimal CostoHora { get; set; }

        [Required(ErrorMessage = "El Id es obligatorio.")]
        public int EmpleadoId { get; set; }

        public Empleado Empleado { get; set; }

    }
}
