using ProyectoPOE.Datos.Entidades;
using ProyectoPOE.Logica.Helpers;
using ProyectoPOE.Logica.Services;
using System.Windows.Forms;

namespace ProyectoPOE.Presentacion.Pantallas
{
    public partial class frmRegistrarEmprendimientoForm : Form
    {
        private readonly EmprendimientoService service;
        private int idEmprendimientoSeleccionado = -1;
        public frmRegistrarEmprendimientoForm()
        {
            InitializeComponent();
            this.service = new EmprendimientoService();
            EstadoInicial();
            CargarEmprendimientosEnDataGridView();
            Dgv_VisualizarEmprendimiento.AutoGenerateColumns = false;
        }

        private void EstadoInicial()
        {
            try
            {
                txtNombre.Text = String.Empty;
                txtDescripcion.Text = String.Empty;
                pbFoto.Image = null;
                pbFoto.SizeMode = PictureBoxSizeMode.Zoom;

                cbFacultad.DataSource = service.getFacultades();
                cbFacultad.DisplayMember = "Descripcion";
                cbFacultad.ValueMember = "Id";
                cbFacultad.SelectedIndex = -1;

                cbRubro.DataSource = service.getRubros();
                cbRubro.DisplayMember = "Descripcion";
                cbRubro.ValueMember = "Id";
                cbRubro.SelectedIndex = -1;

                idEmprendimientoSeleccionado = -1;
                btn_Eliminar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estado inicial: " + ex.Message);
            }
        }

        private void CargarEmprendimientosEnDataGridView()
        {
            try
            {
                Dgv_VisualizarEmprendimiento.DataSource = null;
                Dgv_VisualizarEmprendimiento.DataSource = service.getEmprendimientos();
                if (Dgv_VisualizarEmprendimiento.Columns.Contains("Foto"))
                {
                    Dgv_VisualizarEmprendimiento.Columns["Foto"].Visible = false;
                }
                Dgv_VisualizarEmprendimiento.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar emprendimientos: " + ex.Message);
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
                service.guardar(nombre, descripcion, facultadId, rubroId, foto);
                MessageBox.Show("Emprendimiento creado exitosamente.");
                EstadoInicial();
                CargarEmprendimientosEnDataGridView();
                MessageBox.Show("Emprendimiento creado exitosamente");
                EstadoInicial();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            Dgv_VisualizarEmprendimiento.ClearSelection();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (idEmprendimientoSeleccionado != -1)
            {
                DialogResult dialogResult = MessageBox.Show(
                    "¿Está seguro de que quiere eliminar este emprendimiento?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        service.eliminar(idEmprendimientoSeleccionado);
                        MessageBox.Show("Emprendimiento eliminado exitosamente.");
                        EstadoInicial();
                        CargarEmprendimientosEnDataGridView();
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error inesperado al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un emprendimiento de la lista para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Dgv_VisualizarEmprendimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Dgv_VisualizarEmprendimiento.Rows[e.RowIndex];
                object idValue = row.Cells["Id"].Value;

                idEmprendimientoSeleccionado = (idValue != null && idValue != DBNull.Value) ? Convert.ToInt32(idValue) : -1;

                txtNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? string.Empty;

                txtDescripcion.Text = row.Cells["Descripcion"].Value?.ToString() ?? string.Empty;

                object facultadIdValue = row.Cells["FacultadId"].Value;
                int selectedFacultadId = (facultadIdValue != null && facultadIdValue != DBNull.Value) ? Convert.ToInt32(facultadIdValue) : 0;
                cbFacultad.SelectedValue = selectedFacultadId;

                object rubroIdValue = row.Cells["RubroId"].Value;
                int selectedRubroId = (rubroIdValue != null && rubroIdValue != DBNull.Value) ? Convert.ToInt32(rubroIdValue) : 0;
                cbRubro.SelectedValue = selectedRubroId;

                object fotoValue = row.Cells["Foto"].Value;
                byte[] fotoBytes = fotoValue as byte[];

                if (fotoBytes != null && fotoBytes.Length > 0)
                {
                    pbFoto.Image = ImageToBytes.ConvertirBytesAImagen(fotoBytes);
                    pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pbFoto.Image = null;
                }

                btn_Eliminar.Enabled = true;
            }
            else
            {
                idEmprendimientoSeleccionado = -1;
                pbFoto.Image = null;
                txtNombre.Text = "";
                txtDescripcion.Text = "";
                cbFacultad.SelectedIndex = -1;
                cbRubro.SelectedIndex = -1;
                btn_Eliminar.Enabled = false;
            }
        }
    }
}
