using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
// ProyectoPOE - Formulario de Registro de Participantes


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
            // Cargar items en el ComboBox de Cargo/Funci�n
            cmbCargo.Items.Add("L�der del Proyecto");
            cmbCargo.Items.Add("Dise�ador/a Gr�fico/a");
            cmbCargo.Items.Add("Desarrollador/a Software");
            cmbCargo.Items.Add("Expositor/a");
            cmbCargo.Items.Add("Encargado/a de Marketing");
            cmbCargo.Items.Add("Finanzas");
            cmbCargo.Items.Add("Otro"); // Opci�n gen�rica

            // Seleccionar el primer �tem por defecto o dejarlo sin selecci�n
            // cmbCargo.SelectedIndex = 0; // Si quieres que uno est� preseleccionado
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
            // Validaciones b�sicas
            if (string.IsNullOrWhiteSpace(txtNombresApellidos.Text))
            {
                MessageBox.Show("Por favor, ingrese los Nombres y Apellidos.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombresApellidos.Focus();
                return;
            }

            if (cmbCargo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un Cargo o Funci�n.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCargo.Focus();
                return;
            }

            // Recopilar datos
            string nombres = txtNombresApellidos.Text;
            string cargo = cmbCargo.SelectedItem.ToString();
            string fotoInfo = string.IsNullOrEmpty(rutaImagenSeleccionada) ? "No se carg� foto" : $"Foto en: {Path.GetFileName(rutaImagenSeleccionada)}";

            // Mostrar los datos (en una aplicaci�n real, aqu� guardar�as en una base de datos, lista, etc.)
            string mensaje = $"Participante Registrado:\n\n" +
                             $"Nombres y Apellidos: {nombres}\n" +
                             $"Cargo/Funci�n: {cargo}\n" +
                             $"Foto: {fotoInfo}";

            MessageBox.Show(mensaje, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Opcional: Limpiar campos despu�s de registrar
            // LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombresApellidos.Clear();
            cmbCargo.SelectedIndex = -1; // Deselecciona cualquier �tem
            // cmbCargo.Text = ""; // Alternativa si quieres limpiar el texto visible tambi�n
            picFoto.Image = null;
            rutaImagenSeleccionada = string.Empty;
            txtNombresApellidos.Focus();
        }
    }
}
