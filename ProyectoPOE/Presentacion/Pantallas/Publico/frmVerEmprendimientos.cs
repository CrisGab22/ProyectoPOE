using ProyectoPOE.Datos.Dtos;
using ProyectoPOE.Logica.Helpers;
using ProyectoPOE.Logica.Services;


namespace ProyectoPOE.Presentacion.Pantallas
{
    public partial class frmVerEmprendimientos : Form
    {
        private readonly EmprendimientoService service;
        private int idEmprendimientoSeleccionado = -1;

        public frmVerEmprendimientos()
        {
            InitializeComponent();
            this.service = new EmprendimientoService();
            EstadoInicial();
            CargarEmprendimientosEnDataGridView(); 
        }

        private void EstadoInicial()
        {
            try
            {
                txtNombre.Text = "";
                txtDescripcion.Text = "";
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
                
                var dummy = new EmprendimientoDto();
                Dgv_VisualizarEmprendimiento.Columns[nameof(dummy.Id)].Visible = false;
                Dgv_VisualizarEmprendimiento.Columns[nameof(dummy.FacultadId)].Visible = false;
                Dgv_VisualizarEmprendimiento.Columns[nameof(dummy.RubroId)].Visible = false;
                Dgv_VisualizarEmprendimiento.Columns[nameof(dummy.Foto)].Visible = false;
                
                Dgv_VisualizarEmprendimiento.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar emprendimientos: " + ex.Message);
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

            }
            else
            {
                idEmprendimientoSeleccionado = -1;
                pbFoto.Image = null;
                txtNombre.Text = "";
                txtDescripcion.Text = "";
                cbFacultad.SelectedIndex = -1;
                cbRubro.SelectedIndex = -1;
            }
        }

      
    }
}