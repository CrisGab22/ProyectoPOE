using System.Text;
using ProyectoPOE.Datos;
using ProyectoPOE.Datos.Entidades;
using ProyectoPOE.Datos.Dtos;

namespace ProyectoPOE.Logica.Services
{
    public class UsuarioService
    {
        public List<UsuarioDto> ObtenerUsuarios()
        {
            using (var context = new ProyectoPOEContext())
            {
                var usuarios = context.Usuarios
                    .Select(u => new
                    {
                        u.Id,
                        u.Username,
                        u.Password,
                        u.Habilitado,
                        u.RolId
                    })
                    .ToList();

                return usuarios.Select(u => new UsuarioDto(
                    u.Id,
                    u.Username,
                    DecodeBase64(u.Password),
                    u.Habilitado,
                    u.RolId
                )).ToList();
            }
        }

        public void CrearUsuario(UsuarioDto dto)
        {
            using (var context = new ProyectoPOEContext())
            {
                var usuario = new Usuario
                {
                    Username = dto.Username,
                    Password = EncodeBase64(dto.Contrasena),
                    Habilitado = dto.Habilitado,
                    RolId = dto.RolId
                };
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }

        public void ActualizarUsuario(int id, string username, string contrasena, bool habilitado, int rolId )
        {
            using (var context = new ProyectoPOEContext())
            {
                var usuario = context.Usuarios.FirstOrDefault(u => u.Id == id);
                if (usuario != null)
                {
                    usuario.Username = username;
                    usuario.Password = EncodeBase64(contrasena);
                    usuario.Habilitado = habilitado;
                    usuario.RolId = rolId;
                    context.SaveChanges();
                }
            }
        }

        private string DecodeBase64(string base64Encoded)
        {
            if (string.IsNullOrEmpty(base64Encoded)) return string.Empty;
            var bytes = Convert.FromBase64String(base64Encoded);
            return Encoding.UTF8.GetString(bytes);
        }

        private string EncodeBase64(string plainText)
        {
            if (string.IsNullOrEmpty(plainText)) return string.Empty;
            var bytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(bytes);
        }

        public List<Rol> ObtenerRoles()
        {
            using (var context = new ProyectoPOEContext())
            {
                return context.Roles.ToList();
            }
        }
    }
}
