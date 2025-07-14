using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProyectoPOE.Datos.Entidades
{
    public class Voto
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("idEmprendimiento", TypeName = "int")]
        public int IdEmprendimiento{ get; set; }
        public virtual Emprendimiento Emprendimiento { get; set; } = null!;

        [Required]
        [Column("idUsuario", TypeName = "int")]
        public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; } = null!;
    }
    public class VotoConfig : IEntityTypeConfiguration<Voto>
    {
        public void Configure(EntityTypeBuilder<Voto> builder)
        {
            builder.ToTable("Voto");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.HasOne(v => v.Usuario)
                .WithMany(u => u.Votos)
                .HasForeignKey(v => v.IdUsuario);

            builder.HasOne(v => v.Emprendimiento)
              .WithMany(emp => emp.Votos)
              .HasForeignKey(v => v.IdEmprendimiento);
        }
    }
}
