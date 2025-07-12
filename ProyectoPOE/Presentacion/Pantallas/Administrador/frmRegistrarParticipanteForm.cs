using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ProyectoPOE.Datos.Entidades;
using ProyectoPOE.Logica.Helpers; // Necesario para ImageToBytes, aunque solo para ConvertirBytesAImagen si se carga desde DGV
using ProyectoPOE.Logica.Services;

namespace ProyectoPOE
{
    public partial class frmRegistrarParticipanteForm : Form
    {
        private string rutaImagenSeleccionada = string.Empty; 
        private ParticipanteService _miServicio;
        private int idParticipanteSeleccionado = -1;

        public frmRegistrarParticipanteForm()
        {
            InitializeComponent();
            _miServicio = new ParticipanteService();
            CargarItemsCargo();
            CargarParticipantesEnDataGridView();
            EstadoInicial();
        }

        private void CargarItemsCargo()
        {
            cmbCargo.Items.Add("Líder del Proyecto");
            cmbCargo.Items.Add("Diseñador/a Gráfico/a");
            cmbCargo.Items.Add("Desarrollador/a Software");
            cmbCargo.Items.Add("Expositor/a");
            cmbCargo.Items.Add("Encargado/a de Marketing");
            cmbCargo.Items.Add("Finanzas");
            cmbCargo.Items.Add("Otro");
            cmbCargo.SelectedIndex = -1;
        }

        private void EstadoInicial()
        {
            LimpiarCampos();
            idParticipanteSeleccionado = -1;
            Btn_Eliminar.Enabled = false;
            btnRegistrar.Text = "Registrar";
        }

        private void CargarParticipantesEnDataGridView()
        {
            try
            {
                Dgv_MostrarParticipante.DataSource = null;
                Dgv_MostrarParticipante.DataSource = _miServicio.ObtenerTodosLosParticipantes();
                if (Dgv_MostrarParticipante.Columns.Contains("FotoBytes"))
                {
                    Dgv_MostrarParticipante.Columns["FotoBytes"].Visible = false;
                }
                Dgv_MostrarParticipante.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar participantes: " + ex.Message, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            ofdCargarImagen.Title = "Seleccionar Foto del Participante";
            ofdCargarImagen.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
            ofdCargarImagen.FileName = string.Empty;

            if (ofdCargarImagen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(ofdCargarImagen.FileName, FileMode.Open, FileAccess.Read))
                    {
                        Image tempImg = Image.FromStream(fs);
                        picFoto.Image = new Bitmap(tempImg);
                    }
                    rutaImagenSeleccionada = ofdCargarImagen.FileName;
                    picFoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error de Imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rutaImagenSeleccionada = string.Empty;
                    picFoto.Image = null;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
            Dgv_MostrarParticipante.ClearSelection();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombres = txtNombresApellidos.Text.Trim();
                string? cargo = cmbCargo.SelectedItem?.ToString();

                if (idParticipanteSeleccionado != -1)
                {
                    _miServicio.ActualizarParticipante(idParticipanteSeleccionado, nombres, cargo);
                    MessageBox.Show("Participante actualizado exitosamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Participante participanteRegistrado = _miServicio.RegistrarNuevoParticipante(nombres, cargo);
                    MessageBox.Show("Participante registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                EstadoInicial();
                CargarParticipantesEnDataGridView();
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show(argEx.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNombresApellidos.Clear();
            cmbCargo.SelectedIndex = -1;
            picFoto.Image = null; // Limpia la imagen mostrada temporalmente
            rutaImagenSeleccionada = string.Empty;
            txtNombresApellidos.Focus();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (idParticipanteSeleccionado != -1)
            {
                DialogResult confirm = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este participante?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        _miServicio.EliminarParticipante(idParticipanteSeleccionado);
                        MessageBox.Show("Participante eliminado exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EstadoInicial();
                        CargarParticipantesEnDataGridView();
                    }
                    catch (ArgumentException argEx)
                    {
                        MessageBox.Show(argEx.Message, "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error inesperado al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un participante para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Dgv_MostrarParticipante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Dgv_MostrarParticipante.Rows[e.RowIndex];

                object idValue = row.Cells["Id"].Value;
                idParticipanteSeleccionado = (idValue != null && idValue != DBNull.Value) ? Convert.ToInt32(idValue) : -1;

                txtNombresApellidos.Text = row.Cells["NombresApellidos"].Value?.ToString() ?? string.Empty;

                string? cargoEnDGV = row.Cells["Cargo"].Value?.ToString();
                if (!string.IsNullOrEmpty(cargoEnDGV))
                {
                    int index = cmbCargo.Items.IndexOf(cargoEnDGV);
                    if (index != -1)
                    {
                        cmbCargo.SelectedIndex = index;
                    }
                    else
                    {
                        cmbCargo.SelectedIndex = -1;
                    }
                }
                else
                {
                    cmbCargo.SelectedIndex = -1;
                }
                Btn_Eliminar.Enabled = true;
                btnRegistrar.Text = "Actualizar";
            }
            else
            {
                EstadoInicial();
                Dgv_MostrarParticipante.ClearSelection();
            }
        }
    }
}