using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Datos.Dtos
{
    public class ResultadoDto
    {
        public int Id { get; set; }
        public string Emprendimiento { get; set; } = String.Empty;
        public string Categoria { get; set; } = String.Empty;
        public string EmprendimientoDescripcion { get; set; } = String.Empty;
    }

}
