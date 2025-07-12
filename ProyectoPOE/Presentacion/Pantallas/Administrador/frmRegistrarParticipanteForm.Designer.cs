namespace ProyectoPOE
{
    partial class frmRegistrarParticipanteForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ofdCargarImagen = new OpenFileDialog();
            picFoto = new PictureBox();
            cmbCargo = new ComboBox();
            txtNombresApellidos = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            btnCargarFoto = new Button();
            Btn_Eliminar = new Button();
            Dgv_MostrarParticipante = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_MostrarParticipante).BeginInit();
            SuspendLayout();
            // 
            // ofdCargarImagen
            // 
            ofdCargarImagen.FileName = "openFileDialog1";
            // 
            // picFoto
            // 
            picFoto.Location = new Point(198, 218);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(222, 208);
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picFoto.TabIndex = 17;
            picFoto.TabStop = false;
            picFoto.UseWaitCursor = true;
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "Diseñador", "Líder", "Expositor", "Etc.." });
            cmbCargo.Location = new Point(198, 149);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(222, 23);
            cmbCargo.TabIndex = 16;
            cmbCargo.UseWaitCursor = true;
            // 
            // txtNombresApellidos
            // 
            txtNombresApellidos.Location = new Point(198, 75);
            txtNombresApellidos.Name = "txtNombresApellidos";
            txtNombresApellidos.Size = new Size(222, 23);
            txtNombresApellidos.TabIndex = 15;
            txtNombresApellidos.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 299);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 14;
            label3.Text = "Foto Individual:";
            label3.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 157);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 13;
            label2.Text = "Cargo o Función:";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 83);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 12;
            label1.Text = "Nombres y Apellidos:";
            label1.UseWaitCursor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(198, 515);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(119, 48);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.UseWaitCursor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(41, 515);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(129, 48);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.UseWaitCursor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.Location = new Point(41, 348);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(107, 29);
            btnCargarFoto.TabIndex = 9;
            btnCargarFoto.Text = "Cargar";
            btnCargarFoto.UseVisualStyleBackColor = true;
            btnCargarFoto.UseWaitCursor = true;
            btnCargarFoto.Click += btnCargarFoto_Click;
            // 
            // Btn_Eliminar
            // 
            Btn_Eliminar.Location = new Point(352, 515);
            Btn_Eliminar.Name = "Btn_Eliminar";
            Btn_Eliminar.Size = new Size(122, 48);
            Btn_Eliminar.TabIndex = 20;
            Btn_Eliminar.Text = "Eliminar";
            Btn_Eliminar.UseVisualStyleBackColor = true;
            Btn_Eliminar.Click += Btn_Eliminar_Click;
            // 
            // Dgv_MostrarParticipante
            // 
            Dgv_MostrarParticipante.BackgroundColor = SystemColors.ButtonHighlight;
            Dgv_MostrarParticipante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_MostrarParticipante.Location = new Point(475, 50);
            Dgv_MostrarParticipante.Name = "Dgv_MostrarParticipante";
            Dgv_MostrarParticipante.Size = new Size(361, 376);
            Dgv_MostrarParticipante.TabIndex = 21;
            Dgv_MostrarParticipante.CellClick += Dgv_MostrarParticipante_CellClick;
            // 
            // frmRegistrarParticipanteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 586);
            Controls.Add(Dgv_MostrarParticipante);
            Controls.Add(Btn_Eliminar);
            Controls.Add(picFoto);
            Controls.Add(cmbCargo);
            Controls.Add(txtNombresApellidos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCargarFoto);
            Name = "frmRegistrarParticipanteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Participante";
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_MostrarParticipante).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog ofdCargarImagen;
        private PictureBox picFoto;
        private ComboBox cmbCargo;
        private TextBox txtNombresApellidos;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private Button btnCargarFoto;
        private Button Btn_Eliminar;
        private DataGridView Dgv_MostrarParticipante;
    }
}
