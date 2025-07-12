namespace ProyectoPOE.Presentacion.Pantallas.Administrador
{
    partial class frmMenuPublico: Form
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
            btnVerEmprendimiento = new Button();
            SuspendLayout();
            // 
            // lTittle
            // 
            lTittle.AutoSize = true;
            lTittle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lTittle.Location = new Point(212, 41);
            lTittle.Name = "lTittle";
            lTittle.Size = new Size(54, 21);
            lTittle.TabIndex = 0;
            lTittle.Text = "Menu";
            // 
            // btnVerEmprendimiento
            // 
            btnVerEmprendimiento.Location = new Point(40, 100);
            btnVerEmprendimiento.Name = "btnVerEmprendimiento";
            btnVerEmprendimiento.Size = new Size(400, 28);
            btnVerEmprendimiento.TabIndex = 1;
            btnVerEmprendimiento.Text = "Ver emprendimientos";
            btnVerEmprendimiento.UseVisualStyleBackColor = true;
            btnVerEmprendimiento.Click += btnVerEmprendimiento_Click;
            // 
            // frmMenuPublico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 443);
            Controls.Add(btnVerEmprendimiento);
            Controls.Add(lTittle);
            Name = "frmMenuPublico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lTittle;
        private Button btnVerEmprendimiento;
    }
}
