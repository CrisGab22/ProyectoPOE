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
            tabEventos = new TabPage();
            tabResultados = new TabPage();
            tabControl1.SuspendLayout();
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
            tabParticipantes.Location = new Point(4, 24);
            tabParticipantes.Name = "tabParticipantes";
            tabParticipantes.Padding = new Padding(3);
            tabParticipantes.Size = new Size(1093, 510);
            tabParticipantes.TabIndex = 1;
            tabParticipantes.Text = "Participantes";
            tabParticipantes.UseVisualStyleBackColor = true;
            tabParticipantes.UseWaitCursor = true;
            // 
            // tabEventos
            // 
            tabEventos.Location = new Point(4, 24);
            tabEventos.Name = "tabEventos";
            tabEventos.Size = new Size(1093, 510);
            tabEventos.TabIndex = 2;
            tabEventos.Text = "Eventos";
            tabEventos.UseVisualStyleBackColor = true;
            // 
            // tabResultados
            // 
            tabResultados.Location = new Point(4, 24);
            tabResultados.Name = "tabResultados";
            tabResultados.Size = new Size(1093, 510);
            tabResultados.TabIndex = 3;
            tabResultados.Text = "Resultados";
            tabResultados.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabEmprendimientos;
        private TabPage tabParticipantes;
        private TabPage tabEventos;
        private TabPage tabResultados;
    }
}
