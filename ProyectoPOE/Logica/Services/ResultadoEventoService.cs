using ProyectoPOE.Datos;
using ProyectoPOE.Datos.Entidades;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ProyectoPOE.Logica.Services
{
    public class ResultadoEventoService
    {
        public List<Categoria> ObtenerCategorias()
        {
            using var context = new ProyectoPOEContext();
            return context.Categorias.ToList();
        }

        public List<Emprendimiento> ObtenerEmprendimientos()
        {
            using var context = new ProyectoPOEContext();
            return context.Emprendimientos.ToList();
        }

        public void AgregarResultado(int categoriaId, int emprendimientoId)
        {
            var resultado = new ResultadoEvento
            {
                CategoriaId = categoriaId,
                EmprendimientoId = emprendimientoId
            };

            using var context = new ProyectoPOEContext();
            context.ResultadosEventos.Add(resultado);
            context.SaveChanges();
        }

        public List<ResultadoEvento> ListarResultados()
        {
            using var context = new ProyectoPOEContext();
            return context.ResultadosEventos
                .Include(r => r.Categoria)
                .Include(r => r.Emprendimiento)
                .OrderByDescending(r => r.Id)
                .ToList();
        }
    }
}
