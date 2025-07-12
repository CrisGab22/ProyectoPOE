namespace ProyectoPOE.Presentacion.Pantallas
{
    partial class frmLogin
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
            label1 = new Label();
            lUsuario = new Label();
            lPassword = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 51);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // lUsuario
            // 
            lUsuario.AutoSize = true;
            lUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lUsuario.Location = new Point(91, 111);
            lUsuario.Name = "lUsuario";
            lUsuario.Size = new Size(56, 17);
            lUsuario.TabIndex = 1;
            lUsuario.Text = "Usuario:";
            // 
            // lPassword
            // 
            lPassword.AutoSize = true;
            lPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lPassword.Location = new Point(70, 142);
            lPassword.Name = "lPassword";
            lPassword.Size = new Size(77, 17);
            lPassword.TabIndex = 2;
            lPassword.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(153, 105);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(186, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(153, 136);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(186, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyUp += txtPassword_KeyUp;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(172, 197);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 284);
            Controls.Add(btnEntrar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(lPassword);
            Controls.Add(lUsuario);
            Controls.Add(label1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lUsuario;
        private Label lPassword;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnEntrar;
    }
}