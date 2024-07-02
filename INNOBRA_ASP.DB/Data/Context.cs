using INNOBRA_ASP.DB.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNOBRA_ASP.DB.Data
{
    public class Context : DbContext
    {
        public  DbSet<Empleado> Empleados { get; set; }
        public DbSet<ActividadEmpleado> ActividadEmpleados { get; set; }
        public DbSet<Maquinaria> Maquinarias { get; set; }
        public DbSet<ActividadMaquinaria> ActividadMaquinarias { get; set; }
        public DbSet<Material> Materiales { get; set; }
        public DbSet<ActividadMaterial> ActividadMateriales { get; set; }
        public DbSet<Fase> Fases { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                                          .SelectMany(t => t.GetForeignKeys())
                                          .Where(fk => !fk.IsOwnership
                                          && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
