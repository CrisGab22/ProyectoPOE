using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPOE.Datos.Entidades;

namespace ProyectoPOE.Logica.Helpers
{
    public static class Session
    {
        public static Usuario? UsuarioAutenticado { get; private set; } = null;

        public static void CerrarSesion()
        {
            UsuarioAutenticado = null;
        }
        public static bool EstaAutenticado()
        {
            return UsuarioAutenticado != null;
        }

        public static Usuario setUsuarioAutenticado(Usuario usuario)
        {
            UsuarioAutenticado = usuario;
            return UsuarioAutenticado;
        }

        public static int getIdUsuarioAutenticado()
        {
            if (UsuarioAutenticado == null)
            {
                throw new InvalidOperationException("No hay un usuario autenticado.");
            }
            return UsuarioAutenticado.Id;
        }
    }
}
