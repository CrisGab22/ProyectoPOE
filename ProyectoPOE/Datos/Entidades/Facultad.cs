using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ProyectoPOE.Datos.Entidades
{
    public class Facultad
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("descripcion", TypeName = "varchar(100)")]
        public string Descripcion { get; set; } = "";

        public virtual ICollection<Emprendimiento>? Emprendimientos { get; set; }

    }

    public class FacultadConfig : IEntityTypeConfiguration<Facultad>
    {
        public void Configure(EntityTypeBuilder<Facultad> builder)
        {
            builder.ToTable("facultad");

            builder.HasKey(facultad => facultad.Id);
            
            builder.Property(facultad => facultad.Id)
                   .ValueGeneratedOnAdd();

            builder.HasMany(facultad => facultad.Emprendimientos)
                   .WithOne(emprendimiento => emprendimiento.Facultad)
                   .HasForeignKey(emprendimiento => emprendimiento.FacultadId);

            // Seeder
            builder.HasData(
                new Facultad { Id = 1, Descripcion = "Facultad de Ciencias Matemáticas y Físicas" },
                new Facultad { Id = 2, Descripcion = "Facultad de Ciencias Económicas" },
                new Facultad { Id = 3, Descripcion = "Facultad de Ciencias Sociales" },
                new Facultad { Id = 4, Descripcion = "Facultad de Derecho" }
            );
        }
    }
}
