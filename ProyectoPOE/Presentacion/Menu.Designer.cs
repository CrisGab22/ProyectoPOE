namespace ProyectoPOE
{
    partial class Menu: Form
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
            lTittle = new Label();
            btnRegistrarAplicante = new Button();
            btnRegistrarEmprendimiento = new Button();
            btnRegistrarEvento = new Button();
            btnResultados = new Button();
            btnRegistrarUsuarios = new Button();
            SuspendLayout();
            // 
            // lTittle
            // 
            lTittle.AutoSize = true;
            lTittle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lTittle.Location = new Point(159, 43);
            lTittle.Name = "lTittle";
            lTittle.Size = new Size(166, 21);
            lTittle.TabIndex = 0;
            lTittle.Text = "Menu administrador";
            // 
            // btnRegistrarAplicante
            // 
            btnRegistrarAplicante.Location = new Point(40, 149);
            btnRegistrarAplicante.Name = "btnRegistrarAplicante";
            btnRegistrarAplicante.Size = new Size(400, 28);
            btnRegistrarAplicante.TabIndex = 2;
            btnRegistrarAplicante.Text = "Registrar participante";
            btnRegistrarAplicante.UseVisualStyleBackColor = true;
            btnRegistrarAplicante.Click += btnRegistrarAplicante_Click;
            // 
            // btnRegistrarEmprendimiento
            // 
            btnRegistrarEmprendimiento.Location = new Point(40, 100);
            btnRegistrarEmprendimiento.Name = "btnRegistrarEmprendimiento";
            btnRegistrarEmprendimiento.Size = new Size(400, 28);
            btnRegistrarEmprendimiento.TabIndex = 1;
            btnRegistrarEmprendimiento.Text = "Registrar emprendimiento";
            btnRegistrarEmprendimiento.UseVisualStyleBackColor = true;
            btnRegistrarEmprendimiento.Click += btnRegistrarEmprendimiento_Click;
            // 
            // btnRegistrarEvento
            // 
            btnRegistrarEvento.Location = new Point(40, 198);
            btnRegistrarEvento.Name = "btnRegistrarEvento";
            btnRegistrarEvento.Size = new Size(400, 28);
            btnRegistrarEvento.TabIndex = 3;
            btnRegistrarEvento.Text = "Registrar Evento";
            btnRegistrarEvento.UseVisualStyleBackColor = true;
            // 
            // btnResultados
            // 
            btnResultados.Location = new Point(40, 246);
            btnResultados.Name = "btnResultados";
            btnResultados.Size = new Size(400, 28);
            btnResultados.TabIndex = 4;
            btnResultados.Text = "Resultados";
            btnResultados.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarUsuarios
            // 
            btnRegistrarUsuarios.Location = new Point(40, 295);
            btnRegistrarUsuarios.Name = "btnRegistrarUsuarios";
            btnRegistrarUsuarios.Size = new Size(400, 28);
            btnRegistrarUsuarios.TabIndex = 5;
            btnRegistrarUsuarios.Text = "Registrar Usuarios";
            btnRegistrarUsuarios.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 443);
            Controls.Add(btnRegistrarUsuarios);
            Controls.Add(btnResultados);
            Controls.Add(btnRegistrarEvento);
            Controls.Add(btnRegistrarEmprendimiento);
            Controls.Add(btnRegistrarAplicante);
            Controls.Add(lTittle);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lTittle;
        private Button btnRegistrarAplicante;
        private Button btnRegistrarEmprendimiento;
        private Button btnRegistrarEvento;
        private Button btnResultados;
        private Button btnRegistrarUsuarios;
    }
}
