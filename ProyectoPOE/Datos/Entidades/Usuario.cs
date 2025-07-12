using System.Buffers.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProyectoPOE.Datos.Entidades
{
    public class Usuario
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("username", TypeName = "varchar(50)")]
        public string Username { get; set; } = "";

        [Required]
        [Column("password", TypeName = "varchar(50)")]
        public string Password { get; set; } = "";

        [Required]
        [Column("habilitado", TypeName = "bit")]
        public bool Habilitado { get; set; }

        [Required]
        [Column("rolId", TypeName = "int")]
        public int RolId { get; set; }
        public virtual Rol? Rol { get; set; }
    }

    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");

            builder.Property(u => u.Id)
                .ValueGeneratedOnAdd();

            builder.HasOne(Usuario => Usuario.Rol)
                .WithMany(Rol => Rol.Usuarios)
                .HasForeignKey(Usuario => Usuario.RolId);

            builder.HasData(
                new Usuario
                {
                    Id = 1,
                    Username = "admin",
                    Password = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("admin")),
                    RolId = (int)RolEnum.Administrador,
                    Habilitado = true
                }
            );
        }
    }
}
