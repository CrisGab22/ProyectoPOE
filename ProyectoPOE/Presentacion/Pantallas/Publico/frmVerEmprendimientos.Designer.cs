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
            label1 = new Label();
            label2 = new Label();
            btnVotar = new Button();
            tComentario = new TextBox();
            lVoto = new Label();
            btnEnviarComentario = new Button();
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
            lFacultad.Location = new Point(34, 101);
            lFacultad.Name = "lFacultad";
            lFacultad.Size = new Size(52, 15);
            lFacultad.TabIndex = 1;
            lFacultad.Text = "Facultad";
            // 
            // lRubro
            // 
            lRubro.AutoSize = true;
            lRubro.Location = new Point(34, 139);
            lRubro.Name = "lRubro";
            lRubro.Size = new Size(39, 15);
            lRubro.TabIndex = 2;
            lRubro.Text = "Rubro";
            // 
            // lDescripcion
            // 
            lDescripcion.AutoSize = true;
            lDescripcion.Location = new Point(34, 183);
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
            txtDescripcion.Location = new Point(133, 175);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(392, 23);
            txtDescripcion.TabIndex = 8;
            // 
            // cbFacultad
            // 
            cbFacultad.Enabled = false;
            cbFacultad.FormattingEnabled = true;
            cbFacultad.Location = new Point(133, 93);
            cbFacultad.Name = "cbFacultad";
            cbFacultad.Size = new Size(392, 23);
            cbFacultad.TabIndex = 9;
            // 
            // cbRubro
            // 
            cbRubro.Enabled = false;
            cbRubro.FormattingEnabled = true;
            cbRubro.Location = new Point(133, 131);
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
            pbFoto.BorderStyle = BorderStyle.FixedSingle;
            pbFoto.Location = new Point(133, 220);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(287, 166);
            pbFoto.TabIndex = 14;
            pbFoto.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 220);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 15;
            label1.Text = "Foto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 437);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 16;
            label2.Text = "Ingresar comentario";
            // 
            // btnVotar
            // 
            btnVotar.Location = new Point(35, 554);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(75, 23);
            btnVotar.TabIndex = 18;
            btnVotar.Text = "Votar";
            btnVotar.UseVisualStyleBackColor = true;
            btnVotar.Click += btnVotar_click;
            // 
            // tComentario
            // 
            tComentario.Location = new Point(164, 429);
            tComentario.Multiline = true;
            tComentario.Name = "tComentario";
            tComentario.Size = new Size(284, 53);
            tComentario.TabIndex = 19;
            // 
            // lVoto
            // 
            lVoto.AutoSize = true;
            lVoto.Location = new Point(138, 559);
            lVoto.Name = "lVoto";
            lVoto.Size = new Size(0, 15);
            lVoto.TabIndex = 20;
            // 
            // btnEnviarComentario
            // 
            btnEnviarComentario.Location = new Point(164, 488);
            btnEnviarComentario.Name = "btnEnviarComentario";
            btnEnviarComentario.Size = new Size(75, 23);
            btnEnviarComentario.TabIndex = 21;
            btnEnviarComentario.Text = "Enviar";
            btnEnviarComentario.UseVisualStyleBackColor = true;
            btnEnviarComentario.Click += btnEnviarComentario_Click;
            // 
            // frmVerEmprendimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 589);
            Controls.Add(btnEnviarComentario);
            Controls.Add(lVoto);
            Controls.Add(tComentario);
            Controls.Add(btnVotar);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Button btnVotar;
        private TextBox tComentario;
        private Label lVoto;
        private Button btnEnviarComentario;
    }
}