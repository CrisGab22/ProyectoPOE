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
            // Cargar items en el ComboBox de Cargo/Funci�n
            cmbCargo.Items.Add("L�der del Proyecto");
            cmbCargo.Items.Add("Dise�ador/a Gr�fico/a");
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
                // El servicio se encargar� de validar si es null o vac�o
                string? cargo = cmbCargo.SelectedItem?.ToString();

                // La variable rutaImagenSeleccionada ya contiene la ruta o est� vac�a.

                // Llamar al servicio para registrar
                Participante participanteRegistrado = _miServicio.RegistrarNuevoParticipante(nombres, cargo, rutaImagenSeleccionada);
                // Si llegamos aqu�, el servicio no lanz� una excepci�n, as� que la validaci�n y creaci�n fueron exitosas.
                // Mostrar los datos (en una aplicaci�n real, la confirmaci�n vendr�a despu�s de guardar en BD)
                string fotoInfo = string.IsNullOrEmpty(participanteRegistrado.RutaFoto) ?
                                  "No se carg� foto" :
                                  $"Foto en: {Path.GetFileName(participanteRegistrado.RutaFoto)}"; // Usamos Path.GetFileName para mostrar solo el nombre

                string mensaje = $"Participante Registrado (a trav�s del Servicio):\n\n" +
                                 $"Nombres y Apellidos: {participanteRegistrado.NombresApellidos}\n" +
                                 $"Cargo/Funci�n: {participanteRegistrado.Cargo}\n" +
                                 $"Foto: {fotoInfo}";

                MessageBox.Show(mensaje, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidacionException vex) // Captura espec�fica para errores de validaci�n del servicio
            {
                MessageBox.Show(vex.Message, "Error de Validaci�n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) // Captura general para otros errores inesperados
            {
                MessageBox.Show("Ocurri� un error inesperado durante el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
