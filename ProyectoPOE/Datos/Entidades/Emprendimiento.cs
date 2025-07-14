using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProyectoPOE.Datos.Entidades
{
    public class Emprendimiento
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("nombre", TypeName = "varchar(100)")]
        public string Nombre { get; set; } = "";

        [Required]
        [Column("facultadId", TypeName = "int")]
        public int FacultadId { get; set; }
        public virtual Facultad Facultad { get; set; } = null!;

        [Required]
        [Column("rubroId", TypeName = "int")]
        public int RubroId { get; set; }
        public virtual Rubro Rubro { get; set; } = null!;

        [Required]
        [Column("descripcion", TypeName = "varchar(500)")]
        public string Descripcion { get; set; } = "";

        [Column("foto", TypeName = "varbinary(max)")]
        public byte[] Foto { get; set; } = [];

        public virtual IEnumerable<Voto>? Votos { get; set; } = null!;
        public virtual IEnumerable<Comentario>? Comentarios { get; set; } = null!;

    }

    public class EmprendimientoConfig : IEntityTypeConfiguration<Emprendimiento>
    {
        public void Configure(EntityTypeBuilder<Emprendimiento> builder)
        {
            builder.ToTable("emprendimiento");

            builder.HasKey(emprendimiento => emprendimiento.Id);

            builder.Property(emprendimiento => emprendimiento.Id)
                .ValueGeneratedOnAdd();

            builder.HasOne(emprendimiento => emprendimiento.Facultad)
                .WithMany(facultad => facultad.Emprendimientos)
                .HasForeignKey(emprendimiento => emprendimiento.FacultadId);

            builder.HasOne(emprendimiento => emprendimiento.Rubro)
                .WithMany(rubro => rubro.Emprendimientos)
                .HasForeignKey(emprendimiento => emprendimiento.RubroId);
        }
    }
}
