﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNOBRA_ASP.DB.Data.Entity
{
    public class Proyecto : EntityBase
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es obligatoria.")]
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "La fecha de fin es obligatoria.")]
        public DateTime FechaFin { get; set; }

        [Required(ErrorMessage = "El costo total es obligatorio.")]
        public decimal CostoTotal { get; set; }

        public List<Fase> Fases { get; set; }
    }
}
