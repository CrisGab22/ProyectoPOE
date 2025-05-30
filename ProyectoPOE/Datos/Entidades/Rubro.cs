using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProyectoPOE.Datos.Entidades
{
    public class Rubro
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("descripcion", TypeName = "varchar(100)")]
        public string Descripcion { get; set; } = "";

        public virtual ICollection<Emprendimiento>? Emprendimientos { get; set; }
    }

    public class RubroConfig : IEntityTypeConfiguration<Rubro>
    {
        public void Configure(EntityTypeBuilder<Rubro> builder)
        {
            builder.ToTable("rubro");

            builder.Property(rubro => rubro.Id)
                   .ValueGeneratedOnAdd();

            builder.HasMany(rubro => rubro.Emprendimientos)
                   .WithOne(emprendimiento => emprendimiento.Rubro)
                   .HasForeignKey(emprendimiento => emprendimiento.RubroId);

            // Seeder
            builder.HasData(
                new Rubro { Id = 1, Descripcion = "tecnología" },
                new Rubro { Id = 2, Descripcion = "gastronomía" },
                new Rubro { Id = 3, Descripcion = "textil" },
                new Rubro { Id = 4, Descripcion = "servicios" },
                new Rubro { Id = 5, Descripcion = "artesanía" }
            );
        }
    }
}
