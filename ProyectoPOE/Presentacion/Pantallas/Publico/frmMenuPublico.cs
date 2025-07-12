using ProyectoPOE.Presentacion.Pantallas;

namespace ProyectoPOE.Presentacion.Pantallas.Administrador
{
    public partial class frmMenuPublico : Form
    {
        public frmMenuPublico()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnVerEmprendimiento_Click(object sender, EventArgs e)
        {
            var frm = new frmVerEmprendimientos();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
    }
}
