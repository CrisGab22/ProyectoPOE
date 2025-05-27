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
        [Column("nombre", TypeName = "varchar(100)")]
        public string Nombre { get; set; } = "";

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
        }
    }
}
