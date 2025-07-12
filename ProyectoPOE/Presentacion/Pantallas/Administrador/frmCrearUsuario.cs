using System.Text;
using ProyectoPOE.Datos.Dtos;
using ProyectoPOE.Logica.Services;
using ProyectoPOE.Logica.Servicios;

namespace ProyectoPOE.Presentacion.Pantallas.Administrador
{
    public partial class frmCrearUsuario : Form
    {
        private bool _modoEdicion;
        public bool modoEdicion
        {
            get => _modoEdicion;
            set
            {
                if (value != _modoEdicion)
                {
                    _modoEdicion = value;
                    lAccion.Text = _modoEdicion ? "Editar usuario" : "Crear usuario";
                }
            }
        }

        private UsuarioService _usuarioService = new UsuarioService();

        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            estadoInicial();
            CargarUsuariosEnGrid();
        }

        private void CargarUsuariosEnGrid()
        {
            var usuarios = _usuarioService.ObtenerUsuarios();
            dgDatos.DataSource = usuarios;
           
            var dummy = usuarios.First();
            dgDatos.Columns[nameof(dummy.Id)].Visible = false;
            dgDatos.Columns[nameof(dummy.RolId)].Visible = false;

            dgDatos.ClearSelection();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string username = tUsername.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            bool habilitado = chHabilitado.Checked;
            int rolId = (int) cmbRol.SelectedValue;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(contrasena) || rolId == 0)
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }

            if (modoEdicion)
            {
                var usuarioSeleccionado = dgDatos.SelectedRows[0].DataBoundItem as UsuarioDto;
                _usuarioService.ActualizarUsuario(usuarioSeleccionado.Id, username, contrasena, habilitado, rolId);
                MessageBox.Show("Usuario actualizado correctamente.");
            }
            else
            {
                var nuevoUsuario = new UsuarioDto(0, username, contrasena, habilitado, rolId);
                _usuarioService.CrearUsuario(nuevoUsuario);
                MessageBox.Show("Usuario creado correctamente.");
            }

            estadoInicial();
            CargarUsuariosEnGrid();
        }

        private void dgDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgDatos.SelectedRows.Count > 0)
            {
                var usuario = dgDatos.SelectedRows[0].DataBoundItem as UsuarioDto;
                if (usuario != null)
                {
                    tUsername.Text = usuario.Username;
                    txtContrasena.Text = usuario.Contrasena;
                    cmbRol.SelectedValue = usuario.RolId;
                    chHabilitado.Checked = usuario.Habilitado;
                    modoEdicion = true;
                }
            }
        }

        private void estadoInicial()
        {
            tUsername.Text = string.Empty;
            txtContrasena.Text = string.Empty;
            cmbRol.SelectedIndex = -1;
            cmbRol.DataSource = _usuarioService.ObtenerRoles();
            cmbRol.DisplayMember = "Descripcion";
            cmbRol.ValueMember = "Id";
            chHabilitado.Checked = true;
            modoEdicion = false;
            dgDatos.ClearSelection();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoInicial();
        }

        private void btnGenerarContrasena_Click(object sender, EventArgs e)
        {
            txtContrasena.Text = AuthService.GenerarContrasena();
        }
    }
}
