using ProyectoPOE.Datos.Entidades;

namespace ProyectoPOE.Datos.Dtos
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Contrasena { get; set; }
        public bool Habilitado { get; set; }
        public string Rol { get; set; }
        public int RolId { get; set; }


        public UsuarioDto(int id, string username, string contrasena, bool habilitado, int rolId)
        {
            Id = id;
            Username = username;
            Contrasena = contrasena;
            Habilitado = habilitado;
            RolId = rolId;
            if(rolId == (int) RolEnum.Administrador)
            {
                Rol = "Administrador";
            }
            else if (rolId == (int)RolEnum.General)
            {
                Rol = "General";
            }
        }
    }
}
