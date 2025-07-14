using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProyectoPOE.Datos;
using ProyectoPOE.Datos.Entidades;

namespace ProyectoPOE.Logica.Services
{
    public class EventoService
    {

        public Evento RegistrarEvento(string nombre, DateTime fecha, string ubicacion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre del evento no puede estar vacío.");
            }
            if (fecha == DateTime.MinValue)
            {
                throw new ArgumentException("Debe especificar una fecha válida para el evento.");
            }
            if (string.IsNullOrWhiteSpace(ubicacion))
            {
                throw new ArgumentException("La ubicación del evento no puede estar vacía.");
            }

            var nuevoEvento = new Evento
            {
                Nombre = nombre,
                Fecha = fecha,
                Ubicacion = ubicacion
            };

            using (var context = new ProyectoPOEContext())
            {
                context.Eventos.Add(nuevoEvento);
                context.SaveChanges();
            }
            return nuevoEvento;
        }

        public List<Evento> ObtenerTodosLosEventos()
        {
            using (var context = new ProyectoPOEContext())
            {
                return context.Eventos
                              .Include(e => e.Presentaciones)
                                .ThenInclude(p => p.Emprendimiento)
                              .ToList();
            }
        }

        public void EliminarEvento(int idEvento)
        {
            if (idEvento <= 0)
            {
                throw new ArgumentException("ID de evento inválido.");
            }

            using (var context = new ProyectoPOEContext())
            {
                var eventoAEliminar = context.Eventos.Find(idEvento);
                if (eventoAEliminar == null)
                {
                    throw new ArgumentException($"No se encontró ningún evento con ID: {idEvento}.");
                }
                context.Eventos.Remove(eventoAEliminar);
                context.SaveChanges();
            }
        }

        public Evento ActualizarEvento(int id, string nombre, DateTime fecha, string ubicacion)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID de evento inválido para actualizar.");
            }
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre del evento no puede estar vacío.");
            }
            if (fecha == DateTime.MinValue)
            {
                throw new ArgumentException("Debe especificar una fecha válida para el evento.");
            }
            if (string.IsNullOrWhiteSpace(ubicacion))
            {
                throw new ArgumentException("La ubicación del evento no puede estar vacía.");
            }

            using (var context = new ProyectoPOEContext())
            {
                var eventoExistente = context.Eventos.Find(id);
                if (eventoExistente == null)
                {
                    throw new ArgumentException($"No se encontró ningún evento con ID: {id} para actualizar.");
                }

                eventoExistente.Nombre = nombre;
                eventoExistente.Fecha = fecha;
                eventoExistente.Ubicacion = ubicacion;

                context.Entry(eventoExistente).State = EntityState.Modified;
                context.SaveChanges();
                return eventoExistente;
            }
        }

        // --- Métodos para Presentaciones ---

        public PresentacionE RegistrarPresentacion(int eventoId, int orden, string tema, TimeSpan horaInicio, int duracionMinutos, int emprendimientoId)
        {
            if (eventoId <= 0) throw new ArgumentException("Debe asociar la presentación a un evento válido.");
            if (orden <= 0) throw new ArgumentException("El orden de la presentación debe ser mayor a 0.");
            if (string.IsNullOrWhiteSpace(tema)) throw new ArgumentException("El tema de la presentación no puede estar vacío.");
            if (duracionMinutos <= 0) throw new ArgumentException("La duración de la presentación debe ser mayor a 0 minutos.");
            if (emprendimientoId <= 0) throw new ArgumentException("Debe seleccionar un emprendimiento para la presentación.");

            using (var context = new ProyectoPOEContext())
            {
                var eventoExiste = context.Eventos.Any(e => e.Id == eventoId);
                if (!eventoExiste) throw new ArgumentException($"El evento con ID {eventoId} no existe.");

                var emprendimientoExiste = context.Emprendimientos.Any(e => e.Id == emprendimientoId);
                if (!emprendimientoExiste) throw new ArgumentException($"El emprendimiento con ID {emprendimientoId} no existe.");

                var nuevaPresentacion = new PresentacionE
                {
                    EventoId = eventoId,
                    Orden = orden,
                    Tema = tema,
                    HoraInicio = horaInicio,
                    DuracionMinutos = duracionMinutos,
                    EmprendimientoId = emprendimientoId
                };
                context.Presentacion.Add(nuevaPresentacion);
                context.SaveChanges();
                return nuevaPresentacion;
            }
        }

        public List<PresentacionE> ObtenerPresentacionesPorEvento(int eventoId)
        {
            using (var context = new ProyectoPOEContext())
            {
                return context.Presentacion
                              .Where(p => p.EventoId == eventoId)
                              .Include(p => p.Emprendimiento)
                              .OrderBy(p => p.Orden)
                              .ToList();
            }
        }

        public void EliminarPresentacion(int idPresentacion)
        {
            if (idPresentacion <= 0)
            {
                throw new ArgumentException("ID de presentación inválido.");
            }

            using (var context = new ProyectoPOEContext())
            {
                var presentacionAEliminar = context.Presentacion.Find(idPresentacion);
                if (presentacionAEliminar == null)
                {
                    throw new ArgumentException($"No se encontró ninguna presentación con ID: {idPresentacion}.");
                }
                context.Presentacion.Remove(presentacionAEliminar);
                context.SaveChanges();
            }
        }

        public PresentacionE ActualizarPresentacion(int id, int eventoId, int orden, string tema, TimeSpan horaInicio, int duracionMinutos, int emprendimientoId)
        {
            if (id <= 0) throw new ArgumentException("ID de presentación inválido para actualizar.");
            if (eventoId <= 0) throw new ArgumentException("Debe asociar la presentación a un evento válido.");
            if (orden <= 0) throw new ArgumentException("El orden de la presentación debe ser mayor a 0.");
            if (string.IsNullOrWhiteSpace(tema)) throw new ArgumentException("El tema de la presentación no puede estar vacío.");
            if (duracionMinutos <= 0) throw new ArgumentException("La duración de la presentación debe ser mayor a 0 minutos.");
            if (emprendimientoId <= 0) throw new ArgumentException("Debe seleccionar un emprendimiento para la presentación.");

            using (var context = new ProyectoPOEContext())
            {
                var presentacionExistente = context.Presentacion.Find(id);
                if (presentacionExistente == null)
                {
                    throw new ArgumentException($"No se encontró ninguna presentación con ID: {id} para actualizar.");
                }

                var eventoExiste = context.Eventos.Any(e => e.Id == eventoId);
                if (!eventoExiste) throw new ArgumentException($"El evento con ID {eventoId} no existe.");

                var emprendimientoExiste = context.Emprendimientos.Any(e => e.Id == emprendimientoId);
                if (!emprendimientoExiste) throw new ArgumentException($"El emprendimiento con ID {emprendimientoId} no existe.");

                presentacionExistente.EventoId = eventoId;
                presentacionExistente.Orden = orden;
                presentacionExistente.Tema = tema;
                presentacionExistente.HoraInicio = horaInicio;
                presentacionExistente.DuracionMinutos = duracionMinutos;
                presentacionExistente.EmprendimientoId = emprendimientoId;

                context.Entry(presentacionExistente).State = EntityState.Modified;
                context.SaveChanges();
                return presentacionExistente;
            }
        }

        public List<Emprendimiento> ObtenerEmprendimientosParaCombo()
        {
            using (var context = new ProyectoPOEContext())
            {
                return context.Emprendimientos.Select(e => new Emprendimiento { Id = e.Id, Nombre = e.Nombre }).ToList();
            }
        }
    }
}