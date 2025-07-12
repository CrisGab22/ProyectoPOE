using ProyectoPOE.Datos.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoPOE.Datos.Dtos
{
    public class EmprendimientoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = String.Empty;
        public int FacultadId { get; set; }
        public string Facultad { get; set; } = String.Empty;
        public int RubroId { get; set; }
        public string Rubro { get; set; } = String.Empty;
        public string Descripcion { get; set; } = String.Empty;
        public byte[] Foto { get; set; } = [];
    }
}
