using System;
using System.Linq;
using ProyectoPOE.Datos;
using ProyectoPOE.Datos.Entidades;

namespace ProyectoPOE.Logica.Servicios
{
    public class AuthService
    {
        public Usuario? BuscarUsuario(string usuario, string password)
        {
            var passwordBase64 = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));

            using (var context = new ProyectoPOEContext())
            {
                return context.Usuarios.FirstOrDefault(u => u.Username == usuario && u.Password == passwordBase64);

            }
        }
        public static bool esAdministrador(Usuario usuario) 
        {
            return usuario.RolId == (int) RolEnum.Administrador;
        }
        public static string GenerarContrasena(int longitud = 10)
        {
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*";
            var random = new Random();
            return new string(Enumerable.Repeat(caracteres, longitud)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
