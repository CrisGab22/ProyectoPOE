using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore.Metadata.Builders; 
using System; 

namespace ProyectoPOE.Datos.Entidades
{
     public class Evento
    {
        [Key]
        [Column("id_evento")]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("nombre_evento")]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [Column("fecha_evento", TypeName = "datetime2")]
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(200)]
        [Column("ubicacion_evento")]
        public string Ubicacion { get; set; } = string.Empty;

        public virtual ICollection<PresentacionE>? Presentaciones { get; set; }
    }

    public class EventoConfig : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.ToTable("Evento");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                   .HasColumnName("id_evento") 
                   .ValueGeneratedOnAdd(); 

            builder.Property(e => e.Nombre)
                   .HasColumnName("nombre_evento") 
                   .IsRequired() 
                   .HasMaxLength(100);

            builder.Property(e => e.Fecha)
                   .HasColumnName("fecha_evento") 
                   .IsRequired() 
                   .HasColumnType("datetime2"); 

            builder.Property(e => e.Ubicacion)
                   .HasColumnName("ubicacion_evento") 
                   .IsRequired() 
                   .HasMaxLength(200); 

            builder.HasMany(e => e.Presentaciones) 
                   .WithOne(p => p.Evento) 
                   .HasForeignKey(p => p.EventoId) 
                   .OnDelete(DeleteBehavior.Cascade); 

            builder.HasData(
                new Evento { Id = 1, Nombre = "Feria de Innovación 2025", Fecha = new DateTime(2025, 10, 26), Ubicacion = "Centro de Convenciones" },
                new Evento { Id = 2, Nombre = "Expo Emprendedores Juveniles", Fecha = new DateTime(2025, 11, 15), Ubicacion = "Auditorio Principal" }
            );
        }
    }
}