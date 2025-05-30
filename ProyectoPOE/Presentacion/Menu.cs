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
            var frm = new RegistrarEmprendimientoForm();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnRegistrarAplicante_Click(object sender, EventArgs e)
        {
            var frm = new RegistrarParticipanteForm();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog(); 
        }
    }
}
