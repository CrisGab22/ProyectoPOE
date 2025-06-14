using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProyectoPOE.Datos.Entidades
{
    public class ResultadoEvento
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("categoriaId", TypeName = "int")]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; } = null!;

        [Required]
        [Column("emprendimientoId", TypeName = "int")]
        public int EmprendimientoId { get; set; }
        public virtual Emprendimiento Emprendimiento { get; set; } = null!;
    }

    public class ResultadoEventoConfig : IEntityTypeConfiguration<ResultadoEvento>
    {
        public void Configure(EntityTypeBuilder<ResultadoEvento> builder)
        {
            builder.ToTable("resultadoevento");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Id)
                .ValueGeneratedOnAdd();

            builder.HasOne(r => r.Categoria)
                .WithMany()
                .HasForeignKey(r => r.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(r => r.Emprendimiento)
                .WithMany()
                .HasForeignKey(r => r.EmprendimientoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
