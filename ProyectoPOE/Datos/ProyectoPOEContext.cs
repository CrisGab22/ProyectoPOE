using Microsoft.EntityFrameworkCore;
using ProyectoPOE.Datos.Entidades;

namespace ProyectoPOE.Datos
{
    public class ProyectoPOEContext : DbContext
    {

        public DbSet<Emprendimiento> Emprendimientos { get; set; } = null!;
        public DbSet<Facultad> Facultades { get; set; } = null!;
        public DbSet<Rubro> Rubros { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // todo: cambiar esto a una variable de entorno o configuración
            options.UseSqlServer("Server=.;Database=ProyectoPOE;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmprendimientoConfig());
            modelBuilder.ApplyConfiguration(new FacultadConfig());
            modelBuilder.ApplyConfiguration(new RubroConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
