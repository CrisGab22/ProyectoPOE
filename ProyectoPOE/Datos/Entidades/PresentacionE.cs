using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore.Metadata.Builders; 
using System; 

namespace ProyectoPOE.Datos.Entidades
{
    public class PresentacionE
    {
        [Key]
        [Column("id_presentacion")]
        public int Id { get; set; }

        [Required]
        [Column("orden")]
        public int Orden { get; set; }

        [Required]
        [StringLength(200)]
        [Column("tema_presentacion")]
        public string Tema { get; set; } = string.Empty;

        [Required]
        [Column("hora_inicio", TypeName = "time")]
        public TimeSpan HoraInicio { get; set; }

        [Required]
        [Column("duracion_minutos")]
        public int DuracionMinutos { get; set; }


        [Required]
        [Column("id_evento")]
        public int EventoId { get; set; }
        public virtual Evento Evento { get; set; } = null!;

 
        [Required]
        [Column("id_emprendimiento")]
        public int EmprendimientoId { get; set; }
        public virtual Emprendimiento Emprendimiento { get; set; } = null!;
    }

    public class PresentacionConfig : IEntityTypeConfiguration<PresentacionE>
    {
        public void Configure(EntityTypeBuilder<PresentacionE> builder)
        {
            builder.ToTable("Presentacion"); 

            builder.HasKey(p => p.Id); 

            builder.Property(p => p.Id)
                   .HasColumnName("id_presentacion") 
                   .ValueGeneratedOnAdd(); 

            builder.Property(p => p.Orden)
                   .HasColumnName("orden")
                   .IsRequired();

            builder.Property(p => p.Tema)
                   .HasColumnName("tema_presentacion") 
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(p => p.HoraInicio)
                   .HasColumnName("hora_inicio") 
                   .IsRequired()
                   .HasColumnType("time"); 

            builder.Property(p => p.DuracionMinutos)
                   .HasColumnName("duracion_minutos") 
                   .IsRequired();

            builder.HasOne(p => p.Evento)
                   .WithMany(e => e.Presentaciones)
                   .HasForeignKey(p => p.EventoId)
                   .IsRequired();


            builder.HasOne(p => p.Emprendimiento) 
                   .WithMany() 
                   .HasForeignKey(p => p.EmprendimientoId) 
                   .IsRequired() 
                   .OnDelete(DeleteBehavior.Restrict); 
        }
    }
}