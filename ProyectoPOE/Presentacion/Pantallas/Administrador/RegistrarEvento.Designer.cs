namespace ProyectoPOE.Presentacion.Pantallas.Administrador
{
    partial class RegistrarEvento
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
            tabPageEventos = new TabControl();
            tabControlEventos = new TabPage();
            dgvEventos = new DataGridView();
            btnEliminarEvento = new Button();
            btnLimpiarEvento = new Button();
            btnGuardarEvento = new Button();
            grpDatosEventos = new GroupBox();
            txtUbicacionEvento = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dtpFechaEvento = new DateTimePicker();
            txtNombreEvento = new TextBox();
            label1 = new Label();
            tabPagePresentaciones = new TabPage();
            dgvPresentaciones = new DataGridView();
            btnEliminarPresentacion = new Button();
            btnLimpiarPresentacion = new Button();
            btnGuardarPresentacion = new Button();
            grpDatosPresentacion = new GroupBox();
            cmbEmprendimientos = new ComboBox();
            label9 = new Label();
            nudDuracionMinutos = new NumericUpDown();
            label8 = new Label();
            dtpHoraInicioPresentacion = new DateTimePicker();
            label7 = new Label();
            txtTemaPresentacion = new TextBox();
            label6 = new Label();
            nudOrdenPresentacion = new NumericUpDown();
            label5 = new Label();
            lblEventoPresentacionInfo = new Label();
            cmbEventosParaPresentacion = new ComboBox();
            label4 = new Label();
            tabPageEventos.SuspendLayout();
            tabControlEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            grpDatosEventos.SuspendLayout();
            tabPagePresentaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPresentaciones).BeginInit();
            grpDatosPresentacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuracionMinutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudOrdenPresentacion).BeginInit();
            SuspendLayout();
            // 
            // tabPageEventos
            // 
            tabPageEventos.Controls.Add(tabControlEventos);
            tabPageEventos.Controls.Add(tabPagePresentaciones);
            tabPageEventos.Location = new Point(-3, -3);
            tabPageEventos.Name = "tabPageEventos";
            tabPageEventos.SelectedIndex = 0;
            tabPageEventos.Size = new Size(920, 493);
            tabPageEventos.TabIndex = 0;
            tabPageEventos.Tag = "";
            // 
            // tabControlEventos
            // 
            tabControlEventos.Controls.Add(dgvEventos);
            tabControlEventos.Controls.Add(btnEliminarEvento);
            tabControlEventos.Controls.Add(btnLimpiarEvento);
            tabControlEventos.Controls.Add(btnGuardarEvento);
            tabControlEventos.Controls.Add(grpDatosEventos);
            tabControlEventos.Location = new Point(4, 24);
            tabControlEventos.Name = "tabControlEventos";
            tabControlEventos.Padding = new Padding(3);
            tabControlEventos.Size = new Size(912, 465);
            tabControlEventos.TabIndex = 0;
            tabControlEventos.Text = "Gestion de eventos";
            tabControlEventos.UseVisualStyleBackColor = true;
            tabControlEventos.Click += tabControlEventos_Click;
            // 
            // dgvEventos
            // 
            dgvEventos.BackgroundColor = SystemColors.ButtonHighlight;
            dgvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventos.Location = new Point(477, 45);
            dgvEventos.Name = "dgvEventos";
            dgvEventos.Size = new Size(373, 361);
            dgvEventos.TabIndex = 4;
            dgvEventos.CellClick += dgvEventos_CellClick;
            // 
            // btnEliminarEvento
            // 
            btnEliminarEvento.Location = new Point(279, 385);
            btnEliminarEvento.Name = "btnEliminarEvento";
            btnEliminarEvento.Size = new Size(88, 32);
            btnEliminarEvento.TabIndex = 3;
            btnEliminarEvento.Text = "Eliminar";
            btnEliminarEvento.UseVisualStyleBackColor = true;
            btnEliminarEvento.Click += btnEliminarEvento_Click_1;
            // 
            // btnLimpiarEvento
            // 
            btnLimpiarEvento.Location = new Point(151, 385);
            btnLimpiarEvento.Name = "btnLimpiarEvento";
            btnLimpiarEvento.Size = new Size(88, 32);
            btnLimpiarEvento.TabIndex = 2;
            btnLimpiarEvento.Text = "Limpiar";
            btnLimpiarEvento.UseVisualStyleBackColor = true;
            btnLimpiarEvento.Click += btnLimpiarEvento_Click_1;
            // 
            // btnGuardarEvento
            // 
            btnGuardarEvento.Location = new Point(28, 385);
            btnGuardarEvento.Name = "btnGuardarEvento";
            btnGuardarEvento.Size = new Size(85, 32);
            btnGuardarEvento.TabIndex = 1;
            btnGuardarEvento.Text = "guardar";
            btnGuardarEvento.UseVisualStyleBackColor = true;
            btnGuardarEvento.Click += btnGuardarEvento_Click_1;
            // 
            // grpDatosEventos
            // 
            grpDatosEventos.Controls.Add(txtUbicacionEvento);
            grpDatosEventos.Controls.Add(label3);
            grpDatosEventos.Controls.Add(label2);
            grpDatosEventos.Controls.Add(dtpFechaEvento);
            grpDatosEventos.Controls.Add(txtNombreEvento);
            grpDatosEventos.Controls.Add(label1);
            grpDatosEventos.Location = new Point(11, 45);
            grpDatosEventos.Name = "grpDatosEventos";
            grpDatosEventos.Size = new Size(367, 282);
            grpDatosEventos.TabIndex = 0;
            grpDatosEventos.TabStop = false;
            grpDatosEventos.Text = "Datos del evento";
            // 
            // txtUbicacionEvento
            // 
            txtUbicacionEvento.Location = new Point(198, 198);
            txtUbicacionEvento.Name = "txtUbicacionEvento";
            txtUbicacionEvento.Size = new Size(100, 23);
            txtUbicacionEvento.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 201);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Ubicación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 133);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha:";
            // 
            // dtpFechaEvento
            // 
            dtpFechaEvento.Location = new Point(150, 127);
            dtpFechaEvento.Name = "dtpFechaEvento";
            dtpFechaEvento.Size = new Size(200, 23);
            dtpFechaEvento.TabIndex = 2;
            // 
            // txtNombreEvento
            // 
            txtNombreEvento.Location = new Point(166, 55);
            txtNombreEvento.Name = "txtNombreEvento";
            txtNombreEvento.Size = new Size(164, 23);
            txtNombreEvento.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 63);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del evento:";
            // 
            // tabPagePresentaciones
            // 
            tabPagePresentaciones.Controls.Add(dgvPresentaciones);
            tabPagePresentaciones.Controls.Add(btnEliminarPresentacion);
            tabPagePresentaciones.Controls.Add(btnLimpiarPresentacion);
            tabPagePresentaciones.Controls.Add(btnGuardarPresentacion);
            tabPagePresentaciones.Controls.Add(grpDatosPresentacion);
            tabPagePresentaciones.Controls.Add(lblEventoPresentacionInfo);
            tabPagePresentaciones.Controls.Add(cmbEventosParaPresentacion);
            tabPagePresentaciones.Controls.Add(label4);
            tabPagePresentaciones.Location = new Point(4, 24);
            tabPagePresentaciones.Name = "tabPagePresentaciones";
            tabPagePresentaciones.Padding = new Padding(3);
            tabPagePresentaciones.Size = new Size(912, 465);
            tabPagePresentaciones.TabIndex = 1;
            tabPagePresentaciones.Text = "Gestion de presentaciones";
            tabPagePresentaciones.UseVisualStyleBackColor = true;
            // 
            // dgvPresentaciones
            // 
            dgvPresentaciones.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPresentaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPresentaciones.Location = new Point(434, 32);
            dgvPresentaciones.Name = "dgvPresentaciones";
            dgvPresentaciones.Size = new Size(452, 402);
            dgvPresentaciones.TabIndex = 13;
            dgvPresentaciones.CellClick += dgvPresentaciones_CellClick;
            // 
            // btnEliminarPresentacion
            // 
            btnEliminarPresentacion.Location = new Point(288, 418);
            btnEliminarPresentacion.Name = "btnEliminarPresentacion";
            btnEliminarPresentacion.Size = new Size(95, 38);
            btnEliminarPresentacion.TabIndex = 12;
            btnEliminarPresentacion.Text = "Eliminar";
            btnEliminarPresentacion.UseVisualStyleBackColor = true;
            btnEliminarPresentacion.Click += btnEliminarPresentacion_Click_1;
            // 
            // btnLimpiarPresentacion
            // 
            btnLimpiarPresentacion.Location = new Point(162, 418);
            btnLimpiarPresentacion.Name = "btnLimpiarPresentacion";
            btnLimpiarPresentacion.Size = new Size(95, 38);
            btnLimpiarPresentacion.TabIndex = 11;
            btnLimpiarPresentacion.Text = "Limpiar";
            btnLimpiarPresentacion.UseVisualStyleBackColor = true;
            btnLimpiarPresentacion.Click += btnLimpiarPresentacion_Click_1;
            // 
            // btnGuardarPresentacion
            // 
            btnGuardarPresentacion.Location = new Point(36, 418);
            btnGuardarPresentacion.Name = "btnGuardarPresentacion";
            btnGuardarPresentacion.Size = new Size(95, 38);
            btnGuardarPresentacion.TabIndex = 10;
            btnGuardarPresentacion.Text = "Guardar";
            btnGuardarPresentacion.UseVisualStyleBackColor = true;
            btnGuardarPresentacion.Click += btnGuardarPresentacion_Click_1;
            // 
            // grpDatosPresentacion
            // 
            grpDatosPresentacion.Controls.Add(cmbEmprendimientos);
            grpDatosPresentacion.Controls.Add(label9);
            grpDatosPresentacion.Controls.Add(nudDuracionMinutos);
            grpDatosPresentacion.Controls.Add(label8);
            grpDatosPresentacion.Controls.Add(dtpHoraInicioPresentacion);
            grpDatosPresentacion.Controls.Add(label7);
            grpDatosPresentacion.Controls.Add(txtTemaPresentacion);
            grpDatosPresentacion.Controls.Add(label6);
            grpDatosPresentacion.Controls.Add(nudOrdenPresentacion);
            grpDatosPresentacion.Controls.Add(label5);
            grpDatosPresentacion.Enabled = false;
            grpDatosPresentacion.Location = new Point(25, 103);
            grpDatosPresentacion.Name = "grpDatosPresentacion";
            grpDatosPresentacion.Size = new Size(369, 288);
            grpDatosPresentacion.TabIndex = 3;
            grpDatosPresentacion.TabStop = false;
            grpDatosPresentacion.Text = "Datos de la presentacion";
            // 
            // cmbEmprendimientos
            // 
            cmbEmprendimientos.FormattingEnabled = true;
            cmbEmprendimientos.Location = new Point(224, 227);
            cmbEmprendimientos.Name = "cmbEmprendimientos";
            cmbEmprendimientos.Size = new Size(121, 23);
            cmbEmprendimientos.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 235);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 8;
            label9.Text = "Emprendimiento ";
            // 
            // nudDuracionMinutos
            // 
            nudDuracionMinutos.Location = new Point(242, 179);
            nudDuracionMinutos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDuracionMinutos.Name = "nudDuracionMinutos";
            nudDuracionMinutos.Size = new Size(89, 23);
            nudDuracionMinutos.TabIndex = 7;
            nudDuracionMinutos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 181);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 6;
            label8.Text = "Duracion (minutos)";
            // 
            // dtpHoraInicioPresentacion
            // 
            dtpHoraInicioPresentacion.Format = DateTimePickerFormat.Time;
            dtpHoraInicioPresentacion.Location = new Point(242, 126);
            dtpHoraInicioPresentacion.Name = "dtpHoraInicioPresentacion";
            dtpHoraInicioPresentacion.ShowUpDown = true;
            dtpHoraInicioPresentacion.Size = new Size(89, 23);
            dtpHoraInicioPresentacion.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 134);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 4;
            label7.Text = "Hora de inicio";
            // 
            // txtTemaPresentacion
            // 
            txtTemaPresentacion.Location = new Point(225, 78);
            txtTemaPresentacion.Name = "txtTemaPresentacion";
            txtTemaPresentacion.Size = new Size(120, 23);
            txtTemaPresentacion.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 86);
            label6.Name = "label6";
            label6.Size = new Size(134, 15);
            label6.TabIndex = 2;
            label6.Text = "Tema de la presentacion";
            // 
            // nudOrdenPresentacion
            // 
            nudOrdenPresentacion.Location = new Point(225, 33);
            nudOrdenPresentacion.Name = "nudOrdenPresentacion";
            nudOrdenPresentacion.Size = new Size(120, 23);
            nudOrdenPresentacion.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 41);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 0;
            label5.Text = "Orden";
            // 
            // lblEventoPresentacionInfo
            // 
            lblEventoPresentacionInfo.AutoSize = true;
            lblEventoPresentacionInfo.Location = new Point(25, 64);
            lblEventoPresentacionInfo.Name = "lblEventoPresentacionInfo";
            lblEventoPresentacionInfo.Size = new Size(299, 15);
            lblEventoPresentacionInfo.TabIndex = 2;
            lblEventoPresentacionInfo.Text = "Seleccione un evento para gestionar sus presentaciones";
            // 
            // cmbEventosParaPresentacion
            // 
            cmbEventosParaPresentacion.FormattingEnabled = true;
            cmbEventosParaPresentacion.Location = new Point(173, 17);
            cmbEventosParaPresentacion.Name = "cmbEventosParaPresentacion";
            cmbEventosParaPresentacion.Size = new Size(121, 23);
            cmbEventosParaPresentacion.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 25);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 0;
            label4.Text = "Seleccionar evento";
            // 
            // RegistrarEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 489);
            Controls.Add(tabPageEventos);
            Name = "RegistrarEvento";
            Text = "RegistrarEvento";
            tabPageEventos.ResumeLayout(false);
            tabControlEventos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            grpDatosEventos.ResumeLayout(false);
            grpDatosEventos.PerformLayout();
            tabPagePresentaciones.ResumeLayout(false);
            tabPagePresentaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPresentaciones).EndInit();
            grpDatosPresentacion.ResumeLayout(false);
            grpDatosPresentacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuracionMinutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudOrdenPresentacion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPageEventos;
        private TabPage tabControlEventos;
        private TabPage tabPagePresentaciones;
        private GroupBox grpDatosEventos;
        private Label label1;
        private TextBox txtUbicacionEvento;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpFechaEvento;
        private TextBox txtNombreEvento;
        private Button btnGuardarEvento;
        private Button btnEliminarEvento;
        private Button btnLimpiarEvento;
        private DataGridView dgvEventos;
        private ComboBox cmbEventosParaPresentacion;
        private Label label4;
        private GroupBox grpDatosPresentacion;
        private Label label6;
        private NumericUpDown nudOrdenPresentacion;
        private Label label5;
        private Label lblEventoPresentacionInfo;
        private Label label8;
        private DateTimePicker dtpHoraInicioPresentacion;
        private Label label7;
        private TextBox txtTemaPresentacion;
        private DataGridView dgvPresentaciones;
        private Button btnEliminarPresentacion;
        private Button btnLimpiarPresentacion;
        private Button btnGuardarPresentacion;
        private ComboBox cmbEmprendimientos;
        private Label label9;
        private NumericUpDown nudDuracionMinutos;
    }
}