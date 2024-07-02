using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNOBRA_ASP.DB.Data.Entity
{
    public class Actividad : EntityBase
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Las horas hombre son obligatorias.")]
        public decimal HorasHombre { get; set; }

        [Required(ErrorMessage = "Las horas maquina son obligatorias.")]
        public decimal HorasMaquina { get; set; }

        [Required(ErrorMessage = "Los costo de las horas hombre son obligatorios.")]
        public decimal CostoHorasHombre { get; set; }

        public List<ActividadEmpleado> ActividadEmpleados { get; set; }

        [Required(ErrorMessage = "Los costos de las horas maquina son obligatorios.")]
        public decimal CostoHorasMaquina { get; set; }
        public List<ActividadMaquinaria> ActividadMaquinarias { get; set; }

        [Required(ErrorMessage = "Los costos totales de los materiales son obligatorios.")]
        public decimal CostoTotalMateriales { get; set; }

        public List<ActividadMaterial> ActividadMateriales { get; set; }

        [Required(ErrorMessage = "El Id es obligatorio.")]
        public int FaseId { get; set; }

        public Fase Fase { get; set; }

        [Required(ErrorMessage = "El Id es obligatorio.")]
        public int ActividadEmpleadoId { get; set; }

        [Required(ErrorMessage = "El Id es obligatorio.")]
        public int ActividadMaquinariaId { get; set; }

        [Required(ErrorMessage = "El Id es obligatorio.")]
        public int ActividadMaterialId { get; set; }

    }
}
