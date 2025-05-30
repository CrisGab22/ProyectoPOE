using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoPOE
{
    public partial class Form1 : Form
    {

        private string rutaImagenSeleccionada = string.Empty;
        public Form1()
        {
            InitializeComponent();
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
            cmbCargo.Items.Add("Otro"); // Opción genérica

            // Seleccionar el primer ítem por defecto o dejarlo sin selección
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
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtNombresApellidos.Text))
            {
                MessageBox.Show("Por favor, ingrese los Nombres y Apellidos.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombresApellidos.Focus();
                return;
            }

            if (cmbCargo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un Cargo o Función.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCargo.Focus();
                return;
            }

            // Recopilar datos
            string nombres = txtNombresApellidos.Text;
            string cargo = cmbCargo.SelectedItem.ToString();
            string fotoInfo = string.IsNullOrEmpty(rutaImagenSeleccionada) ? "No se cargó foto" : $"Foto en: {Path.GetFileName(rutaImagenSeleccionada)}";

            // Mostrar los datos (en una aplicación real, aquí guardarías en una base de datos, lista, etc.)
            string mensaje = $"Participante Registrado:\n\n" +
                             $"Nombres y Apellidos: {nombres}\n" +
                             $"Cargo/Función: {cargo}\n" +
                             $"Foto: {fotoInfo}";

            MessageBox.Show(mensaje, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimpiarCampos()
        {
            txtNombresApellidos.Clear();
            cmbCargo.SelectedIndex = -1; // Deselecciona cualquier íte
            picFoto.Image = null;
            rutaImagenSeleccionada = string.Empty;
            txtNombresApellidos.Focus();
        }
    }
}
