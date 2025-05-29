namespace ProyectoPOE
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabEmprendimientos = new TabPage();
            tabParticipantes = new TabPage();
            cmbCargo = new ComboBox();
            txtNombresApellidos = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            btnCargarFoto = new Button();
            tabEventos = new TabPage();
            tabResultados = new TabPage();
            ofdCargarImagen = new OpenFileDialog();
            picFoto = new PictureBox();
            tabControl1.SuspendLayout();
            tabParticipantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabEmprendimientos);
            tabControl1.Controls.Add(tabParticipantes);
            tabControl1.Controls.Add(tabEventos);
            tabControl1.Controls.Add(tabResultados);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1101, 538);
            tabControl1.TabIndex = 0;
            tabControl1.UseWaitCursor = true;
            // 
            // tabEmprendimientos
            // 
            tabEmprendimientos.Location = new Point(4, 24);
            tabEmprendimientos.Name = "tabEmprendimientos";
            tabEmprendimientos.Padding = new Padding(3);
            tabEmprendimientos.Size = new Size(1093, 510);
            tabEmprendimientos.TabIndex = 0;
            tabEmprendimientos.Text = "Emprendimientos";
            tabEmprendimientos.UseVisualStyleBackColor = true;
            tabEmprendimientos.UseWaitCursor = true;
            // 
            // tabParticipantes
            // 
            tabParticipantes.Controls.Add(picFoto);
            tabParticipantes.Controls.Add(cmbCargo);
            tabParticipantes.Controls.Add(txtNombresApellidos);
            tabParticipantes.Controls.Add(label3);
            tabParticipantes.Controls.Add(label2);
            tabParticipantes.Controls.Add(label1);
            tabParticipantes.Controls.Add(btnLimpiar);
            tabParticipantes.Controls.Add(btnRegistrar);
            tabParticipantes.Controls.Add(btnCargarFoto);
            tabParticipantes.Location = new Point(4, 24);
            tabParticipantes.Name = "tabParticipantes";
            tabParticipantes.Padding = new Padding(3);
            tabParticipantes.Size = new Size(1093, 510);
            tabParticipantes.TabIndex = 1;
            tabParticipantes.Text = "Participantes";
            tabParticipantes.UseVisualStyleBackColor = true;
            tabParticipantes.UseWaitCursor = true;
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "Diseñador", "Líder", "Expositor", "Etc.." });
            cmbCargo.Location = new Point(366, 242);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(222, 23);
            cmbCargo.TabIndex = 7;
            cmbCargo.UseWaitCursor = true;
            // 
            // txtNombresApellidos
            // 
            txtNombresApellidos.Location = new Point(366, 143);
            txtNombresApellidos.Name = "txtNombresApellidos";
            txtNombresApellidos.Size = new Size(222, 23);
            txtNombresApellidos.TabIndex = 6;
            txtNombresApellidos.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 342);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 5;
            label3.Text = "Foto Individual:";
            label3.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 245);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 4;
            label2.Text = "Cargo o Función:";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 146);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombres y Apellidos:";
            label1.UseWaitCursor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(735, 321);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(137, 56);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.UseWaitCursor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(735, 129);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(137, 48);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.UseWaitCursor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.Location = new Point(361, 328);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(222, 49);
            btnCargarFoto.TabIndex = 0;
            btnCargarFoto.Text = "Cargar";
            btnCargarFoto.UseVisualStyleBackColor = true;
            btnCargarFoto.UseWaitCursor = true;
            btnCargarFoto.Click += btnCargarFoto_Click;
            // 
            // tabEventos
            // 
            tabEventos.Location = new Point(4, 24);
            tabEventos.Name = "tabEventos";
            tabEventos.Size = new Size(1093, 510);
            tabEventos.TabIndex = 2;
            tabEventos.Text = "Eventos";
            tabEventos.UseVisualStyleBackColor = true;
            tabEventos.UseWaitCursor = true;
            // 
            // tabResultados
            // 
            tabResultados.Location = new Point(4, 24);
            tabResultados.Name = "tabResultados";
            tabResultados.Size = new Size(1093, 510);
            tabResultados.TabIndex = 3;
            tabResultados.Text = "Resultados";
            tabResultados.UseVisualStyleBackColor = true;
            tabResultados.UseWaitCursor = true;
            // 
            // ofdCargarImagen
            // 
            ofdCargarImagen.FileName = "openFileDialog1";
            // 
            // picFoto
            // 
            picFoto.Location = new Point(361, 409);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(222, 55);
            picFoto.TabIndex = 8;
            picFoto.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 554);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabParticipantes.ResumeLayout(false);
            tabParticipantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabEmprendimientos;
        private TabPage tabParticipantes;
        private TabPage tabEventos;
        private TabPage tabResultados;
        private Label label2;
        private Label label1;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private Button btnCargarFoto;
        private ComboBox cmbCargo;
        private TextBox txtNombresApellidos;
        private Label label3;
        private OpenFileDialog ofdCargarImagen;
        private PictureBox picFoto;
    }
}
