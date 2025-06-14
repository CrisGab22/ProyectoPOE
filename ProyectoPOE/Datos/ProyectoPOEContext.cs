using Microsoft.EntityFrameworkCore;
using ProyectoPOE.Datos.Entidades;

namespace ProyectoPOE.Datos
{
    public class ProyectoPOEContext : DbContext
    {

        public DbSet<Emprendimiento> Emprendimientos { get; set; } = null!;
        public DbSet<Facultad> Facultades { get; set; } = null!;
        public DbSet<Rubro> Rubros { get; set; } = null!;

        public DbSet<Participante> Participantes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ResultadoEvento> ResultadosEventos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // todo: cambiar esto a una variable de entorno o configuración
            options.UseSqlServer("Server=.;Database=ProyectoPOE;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmprendimientoConfig());
            modelBuilder.ApplyConfiguration(new CategoriaConfig());
            modelBuilder.ApplyConfiguration(new FacultadConfig());
            modelBuilder.ApplyConfiguration(new RubroConfig());
            modelBuilder.ApplyConfiguration(new ResultadoEventoConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
