using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;        // Para [Key], [Required], [StringLength]
using System.ComponentModel.DataAnnotations.Schema; // Para [Column]

namespace ProyectoPOE.Datos.Entidades
{
    public class Participante
    {
        [Key] // Indica que esta propiedad es la Clave Primaria (Primary Key)
        [Column("id_participante")] // Opcional: Especifica el nombre exacto de la columna en la BD.
                                    // Si se omite, EF Core usará el nombre de la propiedad ("Id").
        public int Id { get; set; }

        [Required] // Indica que este campo no puede ser nulo en la base de datos.
                   // Para strings, también implica que no puede ser una cadena vacía si se usa con validación del lado del cliente.
        [StringLength(150)] // Especifica la longitud máxima para el string.
                            // Esto se traduce a nvarchar(150) en SQL Server, por ejemplo.
        [Column("nombres_apellidos")] // Nombre de columna personalizado
        public string NombresApellidos { get; set; }

        [Required]
        [StringLength(100)]
        [Column("cargo_funcion")]
        public string Cargo { get; set; }

        // Para FotoBytes, que es byte[] y puede ser nulo (byte[]?),
        // no necesitamos [Required] a menos que siempre deba haber una foto.
        // Podemos especificar el tipo de columna si queremos ser explícitos.
        [Column("foto_participante", TypeName = "varbinary(max)")] // Especifica el tipo de dato SQL
                                                                   // varbinary(max) es común para imágenes.
        public byte[]? FotoBytes { get; set; }

        // Constructor vacío es útil para Entity Framework Core
        public Participante()
        {
            // Es buena práctica inicializar strings no nulos para evitar NullReferenceExceptions
            // si no se asignan explícitamente y no son nullables en el modelo.
            NombresApellidos = string.Empty;
            Cargo = string.Empty;
        }

        // Constructor para facilitar la creación (actualizado)
        public Participante(string nombresApellidos, string cargo, byte[]? fotoBytes)
        {
            NombresApellidos = nombresApellidos;
            Cargo = cargo;
            FotoBytes = fotoBytes;
        }
    }
}
