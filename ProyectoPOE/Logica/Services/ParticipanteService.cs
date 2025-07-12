using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPOE.Datos.Entidades;
using System.IO;
using ProyectoPOE.Datos;
using Microsoft.EntityFrameworkCore;

namespace ProyectoPOE.Logica.Services
{
    public class ValidacionException : Exception
    {
        public ValidacionException(string message) : base(message) { }
    }

    public class ParticipanteService
    {
        public Participante RegistrarNuevoParticipante(string nombresApellidos, string? cargo)
        {
            if (string.IsNullOrWhiteSpace(nombresApellidos))
            {
                throw new ArgumentException("Por favor, ingrese los Nombres y Apellidos.", nameof(nombresApellidos));
            }

            if (string.IsNullOrWhiteSpace(cargo))
            {
                throw new ArgumentException("Por favor, seleccione un Cargo o Función.", nameof(cargo));
            }

            Participante nuevoParticipante = new Participante
            {
                NombresApellidos = nombresApellidos,
                Cargo = cargo
            };

            using (var context = new ProyectoPOEContext())
            {
                context.Participantes.Add(nuevoParticipante);
                context.SaveChanges();
            }

            return nuevoParticipante;
        }

        public List<Participante> ObtenerTodosLosParticipantes()
        {
            using (var context = new ProyectoPOEContext())
            {
                return context.Participantes.ToList();
            }
        }

        public void EliminarParticipante(int idParticipante)
        {
            if (idParticipante <= 0)
            {
                throw new ArgumentException("ID de participante inválido.", nameof(idParticipante));
            }

            using (var context = new ProyectoPOEContext())
            {
                var participanteAEliminar = context.Participantes.Find(idParticipante);

                if (participanteAEliminar == null)
                {
                    throw new ArgumentException($"No se encontró ningún participante con ID: {idParticipante}.");
                }

                context.Participantes.Remove(participanteAEliminar);
                context.SaveChanges();
            }
        }

        public Participante ActualizarParticipante(int id, string nombresApellidos, string? cargo)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID de participante inválido para actualizar.", nameof(id));
            }
            if (string.IsNullOrWhiteSpace(nombresApellidos))
            {
                throw new ArgumentException("Por favor, ingrese los Nombres y Apellidos.", nameof(nombresApellidos));
            }
            if (string.IsNullOrWhiteSpace(cargo))
            {
                throw new ArgumentException("Por favor, seleccione un Cargo o Función.", nameof(cargo));
            }

            using (var context = new ProyectoPOEContext())
            {
                var participanteExistente = context.Participantes.Find(id);

                if (participanteExistente == null)
                {
                    throw new ArgumentException($"No se encontró ningún participante con ID: {id} para actualizar.");
                }

                participanteExistente.NombresApellidos = nombresApellidos;
                participanteExistente.Cargo = cargo;

                context.Entry(participanteExistente).State = EntityState.Modified;
                context.SaveChanges();
                return participanteExistente;
            }
        }
    }
}