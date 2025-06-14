using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoPOE.Datos.Entidades
{
    public class Participante
    {
        [Key]
        [Column("id_participante")]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        [Column("nombres_apellidos")]
        public string NombresApellidos { get; set; }

        [Required]
        [StringLength(100)]
        [Column("cargo_funcion")]
        public string Cargo { get; set; }

        [Column("foto_participante", TypeName = "varbinary(max)")]
        public byte[]? FotoBytes { get; set; }

        public Participante()
        {
            NombresApellidos = string.Empty;
            Cargo = string.Empty;
        }

        public Participante(string nombresApellidos, string cargo, byte[]? fotoBytes)
        {
            NombresApellidos = nombresApellidos;
            Cargo = cargo;
            FotoBytes = fotoBytes;
        }
    }
}
