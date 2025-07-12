namespace ProyectoPOE.Presentacion.Pantallas.Administrador
{
    partial class frmCrearUsuario
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
            lUsuario = new Label();
            dgDatos = new DataGridView();
            lContraseña = new Label();
            btnGenerarContrasena = new Button();
            tUsername = new TextBox();
            txtContrasena = new TextBox();
            cmbRol = new ComboBox();
            lRol = new Label();
            btnGuardar = new Button();
            chHabilitado = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            lAccion = new Label();
            tNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            SuspendLayout();
            // 
            // lUsuario
            // 
            lUsuario.AutoSize = true;
            lUsuario.Location = new Point(66, 110);
            lUsuario.Name = "lUsuario";
            lUsuario.Size = new Size(47, 15);
            lUsuario.TabIndex = 0;
            lUsuario.Text = "Usuario";
            // 
            // dgDatos
            // 
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Location = new Point(405, 59);
            dgDatos.Name = "dgDatos";
            dgDatos.Size = new Size(417, 319);
            dgDatos.TabIndex = 1;
            dgDatos.SelectionChanged += dgDatos_SelectionChanged;
            // 
            // lContraseña
            // 
            lContraseña.AutoSize = true;
            lContraseña.Location = new Point(46, 145);
            lContraseña.Name = "lContraseña";
            lContraseña.Size = new Size(67, 15);
            lContraseña.TabIndex = 2;
            lContraseña.Text = "Contraseña";
            // 
            // btnGenerarContrasena
            // 
            btnGenerarContrasena.Location = new Point(124, 177);
            btnGenerarContrasena.Name = "btnGenerarContrasena";
            btnGenerarContrasena.Size = new Size(203, 23);
            btnGenerarContrasena.TabIndex = 3;
            btnGenerarContrasena.Text = "Generar Contraseña";
            btnGenerarContrasena.UseVisualStyleBackColor = true;
            btnGenerarContrasena.Click += btnGenerarContrasena_Click;
            // 
            // tUsername
            // 
            tUsername.Location = new Point(124, 104);
            tUsername.Name = "tUsername";
            tUsername.Size = new Size(203, 23);
            tUsername.TabIndex = 4;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(124, 137);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(203, 23);
            txtContrasena.TabIndex = 5;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(124, 221);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(203, 23);
            cmbRol.TabIndex = 6;
            // 
            // lRol
            // 
            lRol.AutoSize = true;
            lRol.Location = new Point(89, 224);
            lRol.Name = "lRol";
            lRol.Size = new Size(24, 15);
            lRol.TabIndex = 7;
            lRol.Text = "Rol";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(726, 396);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(96, 25);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // chHabilitado
            // 
            chHabilitado.AutoSize = true;
            chHabilitado.Location = new Point(124, 266);
            chHabilitado.Name = "chHabilitado";
            chHabilitado.Size = new Size(15, 14);
            chHabilitado.TabIndex = 9;
            chHabilitado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 265);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 10;
            label1.Text = "Habilitado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(555, 27);
            label2.Name = "label2";
            label2.Size = new Size(127, 17);
            label2.TabIndex = 11;
            label2.Text = "Usuarios existentes";
            // 
            // lAccion
            // 
            lAccion.AutoSize = true;
            lAccion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lAccion.Location = new Point(149, 40);
            lAccion.Name = "lAccion";
            lAccion.Size = new Size(91, 17);
            lAccion.TabIndex = 13;
            lAccion.Text = "Crear Usuario";
            // 
            // tNuevo
            // 
            tNuevo.Location = new Point(621, 396);
            tNuevo.Name = "tNuevo";
            tNuevo.Size = new Size(90, 24);
            tNuevo.TabIndex = 14;
            tNuevo.Text = "Nuevo";
            tNuevo.UseVisualStyleBackColor = true;
            tNuevo.Click += btnNuevo_Click;
            // 
            // frmCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 433);
            Controls.Add(tNuevo);
            Controls.Add(lAccion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chHabilitado);
            Controls.Add(btnGuardar);
            Controls.Add(lRol);
            Controls.Add(cmbRol);
            Controls.Add(txtContrasena);
            Controls.Add(tUsername);
            Controls.Add(btnGenerarContrasena);
            Controls.Add(lContraseña);
            Controls.Add(dgDatos);
            Controls.Add(lUsuario);
            Name = "frmCrearUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCrearUsuario";
            Load += frmCrearUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lUsuario;
        private DataGridView dgDatos;
        private Label lContraseña;
        private Button btnGenerarContrasena;
        private TextBox tUsername;
        private TextBox txtContrasena;
        private ComboBox cmbRol;
        private Label lRol;
        private Button btnGuardar;
        private CheckBox chHabilitado;
        private Label label1;
        private Label label2;
        private Label lAccion;
        private Button tNuevo;
    }
}