using ProyectoPOE.Logica.Services;

namespace ProyectoPOE.Presentacion.Pantallas
{
    public partial class frmRegistrarEmprendimientoForm : Form
    {
        private readonly EmprendimientoService service;
        public frmRegistrarEmprendimientoForm()
        {
            InitializeComponent();
            this.service = new EmprendimientoService();
            EstadoInicial();
        }

        private void EstadoInicial()
        {
            try
            {
                txtNombre.Text = "";
                txtDescripcion.Text = "";
                pbFoto.Image = null;

                cbFacultad.DataSource = service.getFacultades();
                cbFacultad.DisplayMember = "Descripcion";
                cbFacultad.ValueMember = "Id";
                cbFacultad.SelectedIndex = -1;

                cbRubro.DataSource = service.getRubros();
                cbRubro.DisplayMember = "Descripcion";
                cbRubro.ValueMember = "Id";
                cbRubro.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                pbFoto.Image = img;
                pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = txtNombre.Text.Trim();
                var descripcion = txtDescripcion.Text.Trim();
                var facultadId = (int)(cbFacultad.SelectedValue ?? 0);
                var rubroId = (int)(cbRubro.SelectedValue ?? 0);
                var foto = pbFoto.Image;

                service.guardar(
                    nombre,
                    descripcion,
                    facultadId,
                    rubroId,
                    foto
                );

                MessageBox.Show("Emprendimiento creado exitosamente");
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }
    }
}
