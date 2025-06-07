using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPOE.Datos.Entidades;
using System.IO;

namespace ProyectoPOE.Logica.Services
{
    //Excepción para manejar errores de validación en el registro de participantes
    public class ValidacionException : Exception
    {
        public ValidacionException(string message) : base(message) { }
    }
    public class ParticipanteService
    {
        public Participante RegistrarNuevoParticipante(string nombresApellidos, string? cargo, byte[]? fotoBytes)
        {
            if (string.IsNullOrWhiteSpace(nombresApellidos))
            {
                // throw new ValidacionException("Por favor, ingrese los Nombres y Apellidos.");
                throw new ArgumentException("Por favor, ingrese los Nombres y Apellidos.", nameof(nombresApellidos));
            }

            if (string.IsNullOrWhiteSpace(cargo))
            {
                // throw new ValidacionException("Por favor, seleccione un Cargo o Función.");
                throw new ArgumentException("Por favor, seleccione un Cargo o Función.", nameof(cargo));
            }

            Participante nuevoParticipante = new Participante
            {
                NombresApellidos = nombresApellidos,
                Cargo = cargo,
                FotoBytes = fotoBytes // Asignar los bytes de la imagen
            };

            return nuevoParticipante;
        }
    }
}
