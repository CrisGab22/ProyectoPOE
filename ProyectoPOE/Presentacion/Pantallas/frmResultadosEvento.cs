using ProyectoPOE.Datos.Dtos;
using ProyectoPOE.Datos.Entidades;
using ProyectoPOE.Logica.Helpers;
using ProyectoPOE.Logica.Services;

namespace ProyectoPOE.Presentacion.Pantallas
{
    public partial class frmResultadosEvento : Form
    {
        private readonly ResultadoEventoService _service;
        private List<ResultadoDto> _resultados;
        public frmResultadosEvento()
        {
            InitializeComponent();
            _service = new ResultadoEventoService();
        }
        private void FrmResultadosEvento_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarResultados();
        }
        private void CargarCombos()
        {
            // Categorías
            var categorias = _service.ObtenerCategorias();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.SelectedIndex = -1;

            // Emprendimientos
            var emprendimientos = _service.ObtenerEmprendimientos();
            cmbEmprendimiento.DataSource = emprendimientos;
            cmbEmprendimiento.DisplayMember = "Nombre";
            cmbEmprendimiento.ValueMember = "Id";
            cmbEmprendimiento.SelectedIndex = -1;
        }
        private void CargarResultados()
        {
            _resultados = _service.ListarResultados();
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = _resultados;
            // Aquí puedes ajustar columnas visibles o nombres en dgvResultados
        }
        private void btnAgregarResultado_Click(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedIndex == -1 || cmbEmprendimiento.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona categoría y emprendimiento.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int categoriaId = (int)cmbCategoria.SelectedValue;
            int emprendimientoId = (int)cmbEmprendimiento.SelectedValue;

            try
            {
                _service.AgregarResultado(categoriaId, emprendimientoId);
                MessageBox.Show("Resultado agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarResultados();
                cmbCategoria.SelectedIndex = -1;
                cmbEmprendimiento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar resultado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            if (_resultados == null || _resultados.Count == 0)
            {
                MessageBox.Show("No hay resultados para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                PdfExporter.ExportarResultados(_resultados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
