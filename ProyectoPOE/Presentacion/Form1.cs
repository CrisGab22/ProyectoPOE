using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ProyectoPOE.Datos.Entidades;
using ProyectoPOE.Logica;


namespace ProyectoPOE
{
    public partial class Form1 : Form
    {

        private string rutaImagenSeleccionada = string.Empty;
        private Service _miServicio;
        public Form1()
        {
            InitializeComponent();
            _miServicio = new Service();
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
            // Configurar el OpenFileDialog
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
                // Recopilar datos del UI
                string nombres = txtNombresApellidos.Text;
                // Usamos el operador ?. para evitar NullReferenceException si no hay nada seleccionado
                // El servicio se encargará de validar si es null o vacío
                string? cargo = cmbCargo.SelectedItem?.ToString();

                // La variable rutaImagenSeleccionada ya contiene la ruta o está vacía.

                // Llamar al servicio para registrar
                Participante participanteRegistrado = _miServicio.RegistrarNuevoParticipante(nombres, cargo, rutaImagenSeleccionada);
                // Si llegamos aquí, el servicio no lanzó una excepción, así que la validación y creación fueron exitosas.
                // Mostrar los datos (en una aplicación real, la confirmación vendría después de guardar en BD)
                string fotoInfo = string.IsNullOrEmpty(participanteRegistrado.RutaFoto) ?
                                  "No se cargó foto" :
                                  $"Foto en: {Path.GetFileName(participanteRegistrado.RutaFoto)}"; // Usamos Path.GetFileName para mostrar solo el nombre

                string mensaje = $"Participante Registrado (a través del Servicio):\n\n" +
                                 $"Nombres y Apellidos: {participanteRegistrado.NombresApellidos}\n" +
                                 $"Cargo/Función: {participanteRegistrado.Cargo}\n" +
                                 $"Foto: {fotoInfo}";

                MessageBox.Show(mensaje, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidacionException vex) // Captura específica para errores de validación del servicio
            {
                MessageBox.Show(vex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) // Captura general para otros errores inesperados
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
