using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using ProyectoPOE.Datos.Entidades;

namespace ProyectoPOE.Datos
{
    public class ProyectoPOEContext : DbContext
    {
        public DbSet<Emprendimiento> Emprendimientos { get; set; } = null!;
        public DbSet<Facultad> Facultades { get; set; } = null!;
        public DbSet<Rubro> Rubros { get; set; } = null!;
        public DbSet<Participante> Participantes { get; set; } = null!;
        public DbSet<Categoria> Categorias { get; set; } = null!;
        public DbSet<ResultadoEvento> ResultadosEventos { get; set; } = null!;
        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<Rol> Roles { get; set; } = null!;
        public DbSet<Voto> Votos { get; set; } = null!;
        public DbSet<Comentario> Comentarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("config.json")  
                .Build();

            var connectionString = configuration.GetConnectionString("Main");
            options.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmprendimientoConfig());
            modelBuilder.ApplyConfiguration(new CategoriaConfig());
            modelBuilder.ApplyConfiguration(new FacultadConfig());
            modelBuilder.ApplyConfiguration(new RubroConfig());
            modelBuilder.ApplyConfiguration(new ResultadoEventoConfig());
            modelBuilder.ApplyConfiguration(new UsuarioConfig());
            modelBuilder.ApplyConfiguration(new RolConfig());
            modelBuilder.ApplyConfiguration(new VotoConfig());
            modelBuilder.ApplyConfiguration(new ComentarioConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
