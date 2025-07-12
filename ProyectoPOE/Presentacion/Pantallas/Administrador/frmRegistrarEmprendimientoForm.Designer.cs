namespace ProyectoPOE.Presentacion.Pantallas
{
    partial class frmRegistrarEmprendimientoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lNombre = new Label();
            lFacultad = new Label();
            lRubro = new Label();
            lDescripcion = new Label();
            lFoto = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            cbFacultad = new ComboBox();
            cbRubro = new ComboBox();
            btnSubirFoto = new Button();
            pbFoto = new PictureBox();
            Dgv_VisualizarEmprendimiento = new DataGridView();
            btn_Eliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_VisualizarEmprendimiento).BeginInit();
            SuspendLayout();
            // 
            // lNombre
            // 
            lNombre.AutoSize = true;
            lNombre.Location = new Point(35, 62);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(51, 15);
            lNombre.TabIndex = 0;
            lNombre.Text = "Nombre";
            // 
            // lFacultad
            // 
            lFacultad.AutoSize = true;
            lFacultad.Location = new Point(34, 126);
            lFacultad.Name = "lFacultad";
            lFacultad.Size = new Size(52, 15);
            lFacultad.TabIndex = 1;
            lFacultad.Text = "Facultad";
            // 
            // lRubro
            // 
            lRubro.AutoSize = true;
            lRubro.Location = new Point(34, 186);
            lRubro.Name = "lRubro";
            lRubro.Size = new Size(39, 15);
            lRubro.TabIndex = 2;
            lRubro.Text = "Rubro";
            // 
            // lDescripcion
            // 
            lDescripcion.AutoSize = true;
            lDescripcion.Location = new Point(34, 246);
            lDescripcion.Name = "lDescripcion";
            lDescripcion.Size = new Size(69, 15);
            lDescripcion.TabIndex = 3;
            lDescripcion.Text = "Descripcion";
            // 
            // lFoto
            // 
            lFoto.AutoSize = true;
            lFoto.Location = new Point(34, 351);
            lFoto.Name = "lFoto";
            lFoto.Size = new Size(63, 15);
            lFoto.TabIndex = 4;
            lFoto.Text = "Elegir Foto";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(206, 497);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(35, 497);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(133, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(392, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(133, 238);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(392, 23);
            txtDescripcion.TabIndex = 8;
            // 
            // cbFacultad
            // 
            cbFacultad.FormattingEnabled = true;
            cbFacultad.Location = new Point(133, 118);
            cbFacultad.Name = "cbFacultad";
            cbFacultad.Size = new Size(392, 23);
            cbFacultad.TabIndex = 9;
            // 
            // cbRubro
            // 
            cbRubro.FormattingEnabled = true;
            cbRubro.Location = new Point(133, 178);
            cbRubro.Name = "cbRubro";
            cbRubro.Size = new Size(392, 23);
            cbRubro.TabIndex = 10;
            // 
            // btnSubirFoto
            // 
            btnSubirFoto.Location = new Point(119, 343);
            btnSubirFoto.Name = "btnSubirFoto";
            btnSubirFoto.Size = new Size(162, 23);
            btnSubirFoto.TabIndex = 11;
            btnSubirFoto.Text = "Subir Imagen";
            btnSubirFoto.UseVisualStyleBackColor = true;
            btnSubirFoto.Click += btnSubirFoto_Click;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(303, 292);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(209, 134);
            pbFoto.TabIndex = 12;
            pbFoto.TabStop = false;
            // 
            // Dgv_VisualizarEmprendimiento
            // 
            Dgv_VisualizarEmprendimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_VisualizarEmprendimiento.Location = new Point(570, 46);
            Dgv_VisualizarEmprendimiento.Name = "Dgv_VisualizarEmprendimiento";
            Dgv_VisualizarEmprendimiento.Size = new Size(452, 446);
            Dgv_VisualizarEmprendimiento.TabIndex = 13;
            Dgv_VisualizarEmprendimiento.CellClick += Dgv_VisualizarEmprendimiento_CellClick;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(363, 497);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(75, 23);
            btn_Eliminar.TabIndex = 14;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // frmRegistrarEmprendimientoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 589);
            Controls.Add(btn_Eliminar);
            Controls.Add(Dgv_VisualizarEmprendimiento);
            Controls.Add(pbFoto);
            Controls.Add(btnSubirFoto);
            Controls.Add(cbRubro);
            Controls.Add(cbFacultad);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(lFoto);
            Controls.Add(lDescripcion);
            Controls.Add(lRubro);
            Controls.Add(lFacultad);
            Controls.Add(lNombre);
            Name = "frmRegistrarEmprendimientoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Emprendimiento";
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_VisualizarEmprendimiento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lNombre;
        private Label lFacultad;
        private Label lRubro;
        private Label lDescripcion;
        private Label lFoto;
        private Button btnGuardar;
        private Button btnLimpiar;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private ComboBox cbFacultad;
        private ComboBox cbRubro;
        private Button btnSubirFoto;
        private PictureBox pbFoto;
        private DataGridView Dgv_VisualizarEmprendimiento;
        private Button btn_Eliminar;
    }
}