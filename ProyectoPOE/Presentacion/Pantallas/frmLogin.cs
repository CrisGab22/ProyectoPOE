using ProyectoPOE.Datos.Entidades;
using ProyectoPOE.Logica.Helpers;
using ProyectoPOE.Logica.Servicios;
using ProyectoPOE.Presentacion.Pantallas.Administrador;
using ProyectoPOE.Presentacion.Pantallas.Publico;

namespace ProyectoPOE.Presentacion.Pantallas
{
    public partial class frmLogin : Form
    {
        private readonly AuthService _service;
        public frmLogin()
        {
            InitializeComponent();
            this._service = new AuthService();
        }

        private void onCloseChildWindows(object? sender, FormClosedEventArgs args)
        {
            Session.CerrarSesion();
            this.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var username = txtUsuario.Text.Trim();
            var password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var Usuario = _service.BuscarUsuario(username, password);
            if (Usuario == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Usuario.Habilitado)
            {
                MessageBox.Show("El usuario no está habilitado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form frmMenu = AuthService.esAdministrador(Usuario) ?
                new frmMenuAdministrador()
                : new frmMenuPublico();

            Session.setUsuarioAutenticado(Usuario);

            this.Hide();

            try
            {
                frmMenu.StartPosition = FormStartPosition.CenterScreen;
                frmMenu.FormClosed += onCloseChildWindows;

                frmMenu.Show();
            }
            catch (Exception ex)
            {
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick();
            }
        }
    }
}
