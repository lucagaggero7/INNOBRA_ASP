using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNOBRA_ASP.DB.Data.Entity
{
    public class Material : EntityBase
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La unidad es obligatoria.")]
        public string Unidad { get; set; }

        [Required(ErrorMessage = "El costo de la unidad es obligatorio.")]
        public decimal CostoUnidad { get; set; }

        public List<ActividadMaterial> ActividadMateriales { get; set; }
    }
}
