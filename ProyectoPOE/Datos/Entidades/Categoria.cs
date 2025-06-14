using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProyectoPOE.Datos.Entidades
{
    public class Categoria
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("descripcion", TypeName = "varchar(100)")]
        public string Descripcion { get; set; } = "";
    }

    public class CategoriaConfig : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categoria");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Descripcion)
                .IsRequired()
                .HasMaxLength(100);

            // Seeder
            builder.HasData(
                new Categoria { Id = 1, Descripcion = "tecnología" },
                new Categoria { Id = 2, Descripcion = "gastronomía" },
                new Categoria { Id = 3, Descripcion = "textil" },
                new Categoria { Id = 4, Descripcion = "servicios" },
                new Categoria { Id = 5, Descripcion = "artesanía" }
            );
        }
    }
}
