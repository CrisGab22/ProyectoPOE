using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Datos.Entidades
{
    public class Participante
    {
        public int Id { get; set; } // Clave primaria, útil para la base de datos
        public string NombresApellidos { get; set; }
        public string Cargo { get; set; }
        public string? RutaFoto { get; set; } // Puede ser null si no se carga foto

        // Constructor vacío es útil para Entity Framework Core
        public Participante() { }

        // Constructor para facilitar la creación
        public Participante(string nombresApellidos, string cargo, string? rutaFoto)
        {
            NombresApellidos = nombresApellidos;
            Cargo = cargo;
            RutaFoto = rutaFoto;
        }
    }
}
