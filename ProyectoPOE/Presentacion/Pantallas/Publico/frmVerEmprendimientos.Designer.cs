namespace ProyectoPOE.Presentacion.Pantallas
{
    partial class frmVerEmprendimientos
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
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            cbFacultad = new ComboBox();
            cbRubro = new ComboBox();
            Dgv_VisualizarEmprendimiento = new DataGridView();
            pbFoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Dgv_VisualizarEmprendimiento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
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
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(133, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(392, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(133, 238);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(392, 23);
            txtDescripcion.TabIndex = 8;
            // 
            // cbFacultad
            // 
            cbFacultad.Enabled = false;
            cbFacultad.FormattingEnabled = true;
            cbFacultad.Location = new Point(133, 118);
            cbFacultad.Name = "cbFacultad";
            cbFacultad.Size = new Size(392, 23);
            cbFacultad.TabIndex = 9;
            // 
            // cbRubro
            // 
            cbRubro.Enabled = false;
            cbRubro.FormattingEnabled = true;
            cbRubro.Location = new Point(133, 178);
            cbRubro.Name = "cbRubro";
            cbRubro.Size = new Size(392, 23);
            cbRubro.TabIndex = 10;
            // 
            // Dgv_VisualizarEmprendimiento
            // 
            Dgv_VisualizarEmprendimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_VisualizarEmprendimiento.Location = new Point(543, 46);
            Dgv_VisualizarEmprendimiento.Name = "Dgv_VisualizarEmprendimiento";
            Dgv_VisualizarEmprendimiento.Size = new Size(485, 506);
            Dgv_VisualizarEmprendimiento.TabIndex = 13;
            Dgv_VisualizarEmprendimiento.CellClick += Dgv_VisualizarEmprendimiento_CellClick;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(94, 291);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(369, 261);
            pbFoto.TabIndex = 14;
            pbFoto.TabStop = false;
            // 
            // frmVerEmprendimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 589);
            Controls.Add(pbFoto);
            Controls.Add(Dgv_VisualizarEmprendimiento);
            Controls.Add(cbRubro);
            Controls.Add(cbFacultad);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lDescripcion);
            Controls.Add(lRubro);
            Controls.Add(lFacultad);
            Controls.Add(lNombre);
            Name = "frmVerEmprendimientos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ver Emprendimientos";
            ((System.ComponentModel.ISupportInitialize)Dgv_VisualizarEmprendimiento).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lNombre;
        private Label lFacultad;
        private Label lRubro;
        private Label lDescripcion;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private ComboBox cbFacultad;
        private ComboBox cbRubro;
        private DataGridView Dgv_VisualizarEmprendimiento;
        private PictureBox pbFoto;
    }
}