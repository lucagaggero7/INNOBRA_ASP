using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNOBRA_ASP.DB.Data.Entity
{
    public class Maquinaria : EntityBase
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El costo de hora es obligatorio.")]
        public decimal CostoHora { get; set; }

        public List<ActividadMaquinaria> ActividadMaquinarias { get; set; }
    }
}
