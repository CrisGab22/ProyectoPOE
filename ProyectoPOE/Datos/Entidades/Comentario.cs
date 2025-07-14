using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProyectoPOE.Datos.Entidades
{
    public class Comentario
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("mensaje", TypeName = "varchar(100)")]
        public string Mensaje { get; set; } = String.Empty;

        [Required]
        [Column("idEmprendimiento", TypeName = "int")]
        public int IdEmprendimiento{ get; set; }
        public virtual Emprendimiento Emprendimiento { get; set; } = null!;

        [Required]
        [Column("idUsuario", TypeName = "int")]
        public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; } = null!;

    }
    public class ComentarioConfig : IEntityTypeConfiguration<Comentario>
    {
        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
            builder.ToTable("Comentario");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.HasOne(c => c.Usuario)
                .WithMany(u => u.Comentarios)
                .HasForeignKey(c => c.IdUsuario);

            builder.HasOne(c => c.Emprendimiento)
              .WithMany(emp => emp.Comentarios)
              .HasForeignKey(c => c.IdEmprendimiento);
        }
    }
}
