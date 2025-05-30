using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPOE.Datos.Entidades;
using System.IO;

namespace ProyectoPOE.Logica
{
    //Excepción para manejar errores de validación en el registro de participantes
    public class ValidacionException : Exception
    {
        public ValidacionException(string message) : base(message) { }
    }
    public class Service
    {
        public Participante RegistrarNuevoParticipante(string nombresApellidos, string? cargo, string? rutaFotoOriginal)
        {
            // 1. Hacer las validaciones de los parámetros recibidos
            if (string.IsNullOrWhiteSpace(nombresApellidos))
            {
                throw new ValidacionException("Por favor, ingrese los Nombres y Apellidos.");
            }

            if (string.IsNullOrWhiteSpace(cargo))
            {
                throw new ValidacionException("Por favor, seleccione un Cargo o Función.");
            }

            // 2. Construir un objeto de la entidad (Modelo)
            string? nombreArchivoFoto = null;
            if (!string.IsNullOrEmpty(rutaFotoOriginal))
            {
                nombreArchivoFoto = rutaFotoOriginal;
            }

            Participante nuevoParticipante = new Participante
            {
                NombresApellidos = nombresApellidos,
                Cargo = cargo,
                RutaFoto = nombreArchivoFoto
            };
            return nuevoParticipante;
        }
    }
}
