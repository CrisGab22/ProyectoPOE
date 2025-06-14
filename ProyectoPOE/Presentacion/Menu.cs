using ProyectoPOE.Presentacion.Pantallas;

namespace ProyectoPOE
{
    public partial class Menu : Form
    {
        public Menu()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnRegistrarEmprendimiento_Click(object sender, EventArgs e)
        {
            var frm = new frmRegistrarEmprendimientoForm();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnRegistrarAplicante_Click(object sender, EventArgs e)
        {
            var frm = new frmRegistrarParticipanteForm();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            var frm = new frmResultadosEvento();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
    }
}
