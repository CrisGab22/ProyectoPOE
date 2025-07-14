using ProyectoPOE.Logica.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProyectoPOE.Presentacion.Pantallas.Administrador
{
    public partial class RegistrarEvento : Form

    {
        private EventoService _eventoService;
        public RegistrarEvento()

        {
            InitializeComponent();
            _eventoService = new EventoService();
            InicializarFormulario();
        }
        private int idEventoSeleccionado = -1;
        private int idPresentacionSeleccionada = -1;
        private int idEventoPadreSeleccionado = -1;

        private void InicializarFormulario()
        {
            CargarEventosEnDGV();

            EstadoInicialEventos();

            CargarComboBoxEventos();

            CargarComboBoxEmprendimientos();

            EstadoInicialPresentaciones();

            cmbEventosParaPresentacion.SelectedIndexChanged += CmbEventosParaPresentacion_SelectedIndexChanged;
        }



        private void EstadoInicialEventos()
        {
            txtNombreEvento.Text = string.Empty;
            dtpFechaEvento.Value = DateTime.Now;
            txtUbicacionEvento.Text = string.Empty;
            idEventoSeleccionado = -1;
            btnEliminarEvento.Enabled = false;
            btnGuardarEvento.Text = "Guardar Evento";
            dgvEventos.ClearSelection();
        }

        private void CargarEventosEnDGV()
        {
            try
            {
                dgvEventos.DataSource = null;
                dgvEventos.DataSource = _eventoService.ObtenerTodosLosEventos();
                dgvEventos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                if (dgvEventos.Columns.Contains("Presentaciones"))
                {
                    dgvEventos.Columns["Presentaciones"].Visible = false;
                }
            }

            catch (Exception ex)

            {
                MessageBox.Show("Error al cargar eventos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void EstadoInicialPresentaciones()

        {
            nudOrdenPresentacion.Value = 1;
            txtTemaPresentacion.Text = string.Empty;
            dtpHoraInicioPresentacion.Value = DateTime.Today.AddHours(9);
            nudDuracionMinutos.Value = 15;
            cmbEmprendimientos.SelectedIndex = -1;
            idPresentacionSeleccionada = -1;
            btnEliminarPresentacion.Enabled = false;
            btnGuardarPresentacion.Text = "Guardar Presentación";
            dgvPresentaciones.ClearSelection();

            grpDatosPresentacion.Enabled = (idEventoPadreSeleccionado != -1);
            lblEventoPresentacionInfo.Text = (idEventoPadreSeleccionado != -1) ?
            $"Presentaciones para: {_eventoService.ObtenerTodosLosEventos().FirstOrDefault(e => e.Id == idEventoPadreSeleccionado)?.Nombre}" :
            "Seleccione un evento para gestionar sus presentaciones.";

        }


        private void CargarComboBoxEventos()
        {
            try
            {
                var eventos = _eventoService.ObtenerTodosLosEventos();
                cmbEventosParaPresentacion.DataSource = null;
                cmbEventosParaPresentacion.DisplayMember = "Nombre";
                cmbEventosParaPresentacion.ValueMember = "Id";
                cmbEventosParaPresentacion.DataSource = eventos;
                cmbEventosParaPresentacion.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar eventos para ComboBox: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void CargarComboBoxEmprendimientos()
        {
            try
            {
                var emprendimientos = _eventoService.ObtenerEmprendimientosParaCombo();
                cmbEmprendimientos.DataSource = null;
                cmbEmprendimientos.DisplayMember = "Nombre";
                cmbEmprendimientos.ValueMember = "Id";
                cmbEmprendimientos.DataSource = emprendimientos;
                cmbEmprendimientos.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar emprendimientos para ComboBox: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CargarPresentacionesEnDGV(int eventoId)
        {
            try
            {
                dgvPresentaciones.DataSource = null;
                if (eventoId > 0)
                {
                    dgvPresentaciones.DataSource = _eventoService.ObtenerPresentacionesPorEvento(eventoId);
                }
                dgvPresentaciones.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                if (dgvPresentaciones.Columns.Contains("Evento")) dgvPresentaciones.Columns["Evento"].Visible = false;
                if (dgvPresentaciones.Columns.Contains("Emprendimiento")) dgvPresentaciones.Columns["Emprendimiento"].Visible = false;
                if (dgvPresentaciones.Columns.Contains("EventoId")) dgvPresentaciones.Columns["EventoId"].Visible = false;
                if (dgvPresentaciones.Columns.Contains("EmprendimientoId")) dgvPresentaciones.Columns["EmprendimientoId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar presentaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CmbEventosParaPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEventosParaPresentacion.SelectedValue is int selectedId && selectedId > 0)
            {
                idEventoPadreSeleccionado = selectedId;
                CargarPresentacionesEnDGV(idEventoPadreSeleccionado);
                EstadoInicialPresentaciones();
                lblEventoPresentacionInfo.Text = $"Presentaciones para: {cmbEventosParaPresentacion.Text}";
                grpDatosPresentacion.Enabled = true;
            }
            else
            {
                idEventoPadreSeleccionado = -1;
                CargarPresentacionesEnDGV(-1);
                EstadoInicialPresentaciones();
            }
        }
        private void tabControlEventos_Click(object sender, EventArgs e)
        {
        }

        private void btnLimpiarEvento_Click_1(object sender, EventArgs e)
        {
            EstadoInicialEventos();
        }



        private void btnGuardarEvento_Click_1(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreEvento.Text.Trim();
                DateTime fecha = dtpFechaEvento.Value.Date;
                string ubicacion = txtUbicacionEvento.Text.Trim();

                if (idEventoSeleccionado != -1)
                {
                    _eventoService.ActualizarEvento(idEventoSeleccionado, nombre, fecha, ubicacion);
                    MessageBox.Show("Evento actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _eventoService.RegistrarEvento(nombre, fecha, ubicacion);
                    MessageBox.Show("Evento registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                EstadoInicialEventos();
                CargarEventosEnDGV();
                CargarComboBoxEventos();
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show(argEx.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar/actualizar evento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminarEvento_Click_1(object sender, EventArgs e)
        {
            if (idEventoSeleccionado != -1)
            {
                DialogResult confirm = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este evento y todas sus presentaciones asociadas?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        _eventoService.EliminarEvento(idEventoSeleccionado);
                        MessageBox.Show("Evento eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EstadoInicialEventos();
                        CargarEventosEnDGV();
                        CargarComboBoxEventos();
                        CargarPresentacionesEnDGV(-1);
                        EstadoInicialPresentaciones();
                    }
                    catch (ArgumentException argEx)
                    {
                        MessageBox.Show(argEx.Message, "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error inesperado al eliminar el evento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un evento para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEventos.Rows[e.RowIndex];
                object idValue = row.Cells["Id"].Value;

                idEventoSeleccionado = (idValue != null && idValue != DBNull.Value) ? Convert.ToInt32(idValue) : -1;

                if (idEventoSeleccionado != -1)
                {
                    txtNombreEvento.Text = row.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                    dtpFechaEvento.Value = (row.Cells["Fecha"].Value is DateTime dt) ? dt : DateTime.Now;
                    txtUbicacionEvento.Text = row.Cells["Ubicacion"].Value?.ToString() ?? string.Empty;

                    btnEliminarEvento.Enabled = true;
                    btnGuardarEvento.Text = "Actualizar Evento";

                    idEventoPadreSeleccionado = idEventoSeleccionado;
                    CargarPresentacionesEnDGV(idEventoPadreSeleccionado);
                    cmbEventosParaPresentacion.SelectedValue = idEventoPadreSeleccionado;
                    lblEventoPresentacionInfo.Text = $"Presentaciones para: {txtNombreEvento.Text}";
                    grpDatosPresentacion.Enabled = true;
                }
                else
                {
                    EstadoInicialEventos();
                }
            }
            else
            {
                EstadoInicialEventos();
            }
        }

        private void btnGuardarPresentacion_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (idEventoPadreSeleccionado == -1)
                {
                    MessageBox.Show("Debe seleccionar un evento antes de guardar una presentación.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int orden = (int)nudOrdenPresentacion.Value;
                string tema = txtTemaPresentacion.Text.Trim();
                TimeSpan horaInicio = dtpHoraInicioPresentacion.Value.TimeOfDay;
                int duracionMinutos = (int)nudDuracionMinutos.Value;
                int emprendimientoId = (int)(cmbEmprendimientos.SelectedValue ?? 0);

                if (emprendimientoId <= 0)
                {
                    MessageBox.Show("Debe seleccionar un emprendimiento para la presentación.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (idPresentacionSeleccionada != -1)
                {
                    _eventoService.ActualizarPresentacion(idPresentacionSeleccionada, idEventoPadreSeleccionado, orden, tema, horaInicio, duracionMinutos, emprendimientoId);
                    MessageBox.Show("Presentación actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _eventoService.RegistrarPresentacion(idEventoPadreSeleccionado, orden, tema, horaInicio, duracionMinutos, emprendimientoId);
                    MessageBox.Show("Presentación registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                EstadoInicialPresentaciones();
                CargarPresentacionesEnDGV(idEventoPadreSeleccionado);
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show(argEx.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar/actualizar presentación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarPresentacion_Click_1(object sender, EventArgs e)
        {
            EstadoInicialPresentaciones();
        }

        private void btnEliminarPresentacion_Click_1(object sender, EventArgs e)
        {
            if (idPresentacionSeleccionada != -1)
            {
                DialogResult confirm = MessageBox.Show(
                  "¿Está seguro de que desea eliminar esta presentación?",
                  "Confirmar Eliminación",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning
                );
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        _eventoService.EliminarPresentacion(idPresentacionSeleccionada);
                        MessageBox.Show("Presentación eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EstadoInicialPresentaciones();
                        CargarPresentacionesEnDGV(idEventoPadreSeleccionado);

                    }
                    catch (ArgumentException argEx)
                    {

                        MessageBox.Show(argEx.Message, "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error inesperado al eliminar la presentación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una presentación para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvPresentaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPresentaciones.Rows[e.RowIndex];
                object idValue = row.Cells["Id"].Value;
                idPresentacionSeleccionada = (idValue != null && idValue != DBNull.Value) ? Convert.ToInt32(idValue) : -1;

                if (idPresentacionSeleccionada != -1)
                {
                    nudOrdenPresentacion.Value = (row.Cells["Orden"].Value is int orden) ? orden : 1;
                    txtTemaPresentacion.Text = row.Cells["Tema"].Value?.ToString() ?? string.Empty;
                    if (row.Cells["HoraInicio"].Value is TimeSpan horaSpan)
                    {
                        dtpHoraInicioPresentacion.Value = DateTime.Today.Add(horaSpan);
                    }
                    else
                    {
                        dtpHoraInicioPresentacion.Value = DateTime.Today.AddHours(9);
                    }
                    nudDuracionMinutos.Value = (row.Cells["DuracionMinutos"].Value is int duracion) ? duracion : 15;

                    object emprendimientoIdValue = row.Cells["EmprendimientoId"].Value;
                    int selectedEmprendimientoId = (emprendimientoIdValue != null && emprendimientoIdValue != DBNull.Value) ? Convert.ToInt32(emprendimientoIdValue) : -1;
                    cmbEmprendimientos.SelectedValue = selectedEmprendimientoId;

                    btnEliminarPresentacion.Enabled = true;
                    btnGuardarPresentacion.Text = "Actualizar Presentación";
                }
                else
                {
                    EstadoInicialPresentaciones();
                }
            }
            else
            {
                EstadoInicialPresentaciones();
            }
        }
    }
}
