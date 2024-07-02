using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNOBRA_ASP.DB.Data.Entity
{
    public class Empleado : EntityBase
    {
        [Required(ErrorMessage = "La categoria es obligatoria.")]
        public string Categoria { get; set; }

        public List<ActividadEmpleado> ActividadEmpleados { get; set; }
    }
}
