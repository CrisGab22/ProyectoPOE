using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ProyectoPOE.Datos.Entidades;
using ProyectoPOE.Logica.Helpers;
using ProyectoPOE.Logica.Services;

namespace ProyectoPOE
{
    public partial class frmRegistrarParticipanteForm : Form
    {

        private string rutaImagenSeleccionada = string.Empty;
        private ParticipanteService _miServicio;
        public frmRegistrarParticipanteForm()
        {
            InitializeComponent();
            _miServicio = new ParticipanteService();
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            // Cargar items en el ComboBox de Cargo/Función
            cmbCargo.Items.Add("Líder del Proyecto");
            cmbCargo.Items.Add("Diseñador/a Gráfico/a");
            cmbCargo.Items.Add("Desarrollador/a Software");
            cmbCargo.Items.Add("Expositor/a");
            cmbCargo.Items.Add("Encargado/a de Marketing");
            cmbCargo.Items.Add("Finanzas");
            cmbCargo.Items.Add("Otro");
        }


        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            ofdCargarImagen.Title = "Seleccionar Foto del Participante";
            ofdCargarImagen.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
            ofdCargarImagen.FileName = string.Empty; // Limpiar nombre de archivo previo

            if (ofdCargarImagen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rutaImagenSeleccionada = ofdCargarImagen.FileName;
                    picFoto.Image = Image.FromFile(rutaImagenSeleccionada);
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
            LimpiarCampos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombres = txtNombresApellidos.Text; // Asegúrate que este control exista en tu form
                string? cargo = cmbCargo.SelectedItem?.ToString();

                byte[]? imagenBytes = null;
                if (picFoto.Image != null)
                {
                    try
                    {
                        // Usar el helper para convertir la imagen del PictureBox a byte[]
                        imagenBytes = ImageToBytes.ConvertirImagenABytes(picFoto.Image);
                    }
                    catch (ArgumentNullException anex)
                    {
                        MessageBox.Show(anex.Message, "Error de Conversión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // No continuar si hay error de conversión
                    }
                    catch (Exception conversionEx)
                    {
                        MessageBox.Show("Error al procesar la imagen para guardarla: " + conversionEx.Message, "Error de Imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // No continuar si hay error de conversión
                    }
                }

                // Llamar al servicio con los bytes de la imagen
                Participante participanteRegistrado = _miServicio.RegistrarNuevoParticipante(nombres, cargo, imagenBytes);

                string fotoInfo = (participanteRegistrado.FotoBytes != null && participanteRegistrado.FotoBytes.Length > 0) ?
                                  "Foto guardada" :
                                  "No se cargó foto";

                string mensaje = $"Participante Registrado:\n\n" +
                                 $"Nombres y Apellidos: {participanteRegistrado.NombresApellidos}\n" +
                                 $"Cargo/Función: {participanteRegistrado.Cargo}\n" +
                                 $"Foto: {fotoInfo}";

                MessageBox.Show(mensaje, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentException argEx) // Para capturar las de ParticipanteService
            {
                MessageBox.Show(argEx.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado durante el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtNombresApellidos.Clear();
            cmbCargo.SelectedIndex = -1;
            picFoto.Image = null;
            rutaImagenSeleccionada = string.Empty;
            txtNombresApellidos.Focus();
        }
    }
}
