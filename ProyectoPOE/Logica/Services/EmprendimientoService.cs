using ProyectoPOE.Datos;
using Microsoft.EntityFrameworkCore;
using ProyectoPOE.Datos.Dtos;
using ProyectoPOE.Datos.Entidades;
using ProyectoPOE.Logica.Helpers;

namespace ProyectoPOE.Logica.Services
{
    public class EmprendimientoService
    {
        public List<Facultad> getFacultades()
        {
            return new ProyectoPOEContext().Facultades.ToList();
        }

        public List<Rubro> getRubros()
        {
            return new ProyectoPOEContext().Rubros.ToList();
        }
        public List<EmprendimientoDto> getEmprendimientos()
        {
            using (var context = new ProyectoPOEContext())
            {
                return context.Emprendimientos
                              .Include(e => e.Facultad)
                              .Include(e => e.Rubro)
                              .Select(e => new EmprendimientoDto
                              {
                                  Id = e.Id,
                                  Nombre = e.Nombre,
                                  FacultadId = e.FacultadId,
                                  Facultad = e.Facultad.Descripcion,
                                  RubroId = e.RubroId,
                                  Rubro = e.Rubro.Descripcion,
                                  Descripcion = e.Descripcion,
                                  Foto = e.Foto
                              })
                              .ToList();
            }
        }
        public Emprendimiento guardar(
            string nombre,
            string descripcion,
            int facultadId,
            int rubroId,
            Image foto
        ) {
            var emprendimiento = new Emprendimiento() {
                Descripcion = descripcion,
                Nombre = nombre,
                FacultadId = facultadId,
                RubroId = rubroId,
                Foto = ImageToBytes.ConvertirImagenABytes(foto)
            };

            validarEmprendimiento(emprendimiento);
            {
                using (var context = new ProyectoPOEContext())
                {
                    context.Emprendimientos.Add(emprendimiento);
                    context.SaveChanges();
                }
                return emprendimiento;
            }
        }
        public void eliminar(int idEmprendimiento)
        {
            using (var context = new ProyectoPOEContext())
            {
                var emprendimientoAEliminar = context.Emprendimientos.Find(idEmprendimiento);
                if (emprendimientoAEliminar == null)
                {
                    throw new ArgumentException("El emprendimiento no existe.");
                }

                var tieneResultadosAtados = context.ResultadosEventos.FirstOrDefault(r => r.EmprendimientoId == idEmprendimiento) != null;
                if (tieneResultadosAtados)
                {
                    throw new InvalidOperationException("No se puede eliminar el emprendimiento porque tiene resultados asociados.");
                }

                context.Emprendimientos.Remove(emprendimientoAEliminar);
                context.SaveChanges();
            }
        }
        private static void validarEmprendimiento(Emprendimiento emp) {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(emp.Nombre))
            {
                errors.Add("El nombre del emprendimiento no puede estar vacío.");
            }

            if (string.IsNullOrWhiteSpace(emp.Descripcion))
            {
                errors.Add("La descripción del emprendimiento no puede estar vacía.");
            }

            if (!(emp.FacultadId > 0))
            {
                errors.Add("Debe seleccionar una Facultad");
            }

            if (!(emp.RubroId > 0))
            {
                errors.Add("Debe seleccionar un Rubro");
            }

            if (emp.Foto == null || emp.Foto.Length == 0)
            {
                errors.Add("Debe proporcionar una foto del emprendimiento.");
            }

            if (errors.Count > 0)
                throw new ArgumentException(string.Join(", ", errors));
        }
    
        public bool AgregarComentario(int idEmprendimiento, string comentario, int idUsuario)
        {
            using (var context = new ProyectoPOEContext())
            {
                if(string.IsNullOrWhiteSpace(comentario))
                {
                    throw new ArgumentException("El comentario no puede estar vacío.");
                }
                if(idEmprendimiento <= 0)
                {
                    throw new ArgumentException("El emprendimiento no es válido");
                }
                var emprendimiento = context.Emprendimientos.FirstOrDefault(emp => emp.Id == idEmprendimiento);
                if (emprendimiento == null)
                {
                    throw new ArgumentException("El emprendimiento no existe.");
                }
                var nuevoComentario = new Comentario
                {
                    IdEmprendimiento = idEmprendimiento,
                    Mensaje = comentario,
                    IdUsuario = idUsuario
                };
                context.Comentarios.Add(nuevoComentario);
                context.SaveChanges();
                return true;
            }
        }

        public bool AgregarVoto(int idEmprendimiento, int idUsuario)
        {
            using (var context = new ProyectoPOEContext())
            {
                var emprendimiento = context.Emprendimientos.FirstOrDefault(emp => emp.Id == idEmprendimiento);
                if (emprendimiento == null)
                {
                    throw new ArgumentException("El emprendimiento no existe.");
                }
                var votoExistente = context.Votos
                    .FirstOrDefault(v => v.IdEmprendimiento == idEmprendimiento && v.IdUsuario == idUsuario);
                if (votoExistente != null)
                {
                    throw new InvalidOperationException("Ya has votado por este emprendimiento.");
                }
                var nuevoVoto = new Voto
                {
                    IdEmprendimiento = idEmprendimiento,
                    IdUsuario = idUsuario
                };
                context.Votos.Add(nuevoVoto);
                context.SaveChanges();
                return true;
            }
        }

        public string getComentario(int idEmprendimiento)
        {
            using (var context = new ProyectoPOEContext())
            {
                var comentario = context.Comentarios
                    .Where(c => c.IdEmprendimiento == idEmprendimiento)
                    .Select(c => c.Mensaje)
                    .FirstOrDefault();
                return comentario ?? string.Empty;
            }
        }
    }
}
