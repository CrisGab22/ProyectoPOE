using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ProyectoPOE.Datos.Entidades
{
    public class Rol
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("descripción", TypeName = "varchar(50)")]
        public string Descripcion { get; set; } = "";

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }

    public class RolConfig : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.ToTable("rol");

            builder.HasKey(r => r.Id);

            builder.Property(u => u.Id)
                .ValueGeneratedOnAdd();

            builder.HasMany(Rol => Rol.Usuarios)
                .WithOne(Usuario => Usuario.Rol)
                .HasForeignKey(Usuario => Usuario.RolId);

            builder.HasData(
                new Rol
                {
                    Id = (int) RolEnum.Administrador,
                    Descripcion = "Administrador",
                    
                },
                new Rol
                {
                    Id = (int) RolEnum.General,
                    Descripcion = "General"
                }
            );
        }
    }

    public enum RolEnum
    {
        Administrador = 1,
        General = 2
    }
}