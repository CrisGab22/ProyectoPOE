namespace ProyectoPOE.Presentacion.Pantallas
{
    partial class frmResultadosEvento
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
            lblCategoria = new Label();
            lblEmprendimiento = new Label();
            cmbCategoria = new ComboBox();
            cmbEmprendimiento = new ComboBox();
            btnAgregarResultado = new Button();
            btnExportarPDF = new Button();
            dgvResultados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(142, 93);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 21);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Categoria";
            // 
            // lblEmprendimiento
            // 
            lblEmprendimiento.AutoSize = true;
            lblEmprendimiento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmprendimiento.Location = new Point(142, 172);
            lblEmprendimiento.Name = "lblEmprendimiento";
            lblEmprendimiento.Size = new Size(188, 21);
            lblEmprendimiento.TabIndex = 1;
            lblEmprendimiento.Text = "Emprendimiento ganador";
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(385, 85);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 29);
            cmbCategoria.TabIndex = 2;
            // 
            // cmbEmprendimiento
            // 
            cmbEmprendimiento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEmprendimiento.FormattingEnabled = true;
            cmbEmprendimiento.Location = new Point(385, 164);
            cmbEmprendimiento.Name = "cmbEmprendimiento";
            cmbEmprendimiento.Size = new Size(121, 29);
            cmbEmprendimiento.TabIndex = 3;
            // 
            // btnAgregarResultado
            // 
            btnAgregarResultado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarResultado.Location = new Point(152, 261);
            btnAgregarResultado.Name = "btnAgregarResultado";
            btnAgregarResultado.Size = new Size(162, 32);
            btnAgregarResultado.TabIndex = 4;
            btnAgregarResultado.Text = "Registrar resultado";
            btnAgregarResultado.UseVisualStyleBackColor = true;
            btnAgregarResultado.Click += btnAgregarResultado_Click;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportarPDF.Location = new Point(385, 261);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(128, 32);
            btnExportarPDF.TabIndex = 5;
            btnExportarPDF.Text = "Exportar PDF";
            btnExportarPDF.UseVisualStyleBackColor = true;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.BackgroundColor = SystemColors.ButtonHighlight;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(110, 353);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(469, 165);
            dgvResultados.TabIndex = 6;
            // 
            // FmrResultadosEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(702, 552);
            Controls.Add(dgvResultados);
            Controls.Add(btnExportarPDF);
            Controls.Add(btnAgregarResultado);
            Controls.Add(cmbEmprendimiento);
            Controls.Add(cmbCategoria);
            Controls.Add(lblEmprendimiento);
            Controls.Add(lblCategoria);
            Name = "FmrResultadosEvento";
            Text = "FmrResultadosEvento";
            Load += FrmResultadosEvento_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoria;
        private Label lblEmprendimiento;
        private ComboBox cmbCategoria;
        private ComboBox cmbEmprendimiento;
        private Button btnAgregarResultado;
        private Button btnExportarPDF;
        private DataGridView dgvResultados;
    }
}