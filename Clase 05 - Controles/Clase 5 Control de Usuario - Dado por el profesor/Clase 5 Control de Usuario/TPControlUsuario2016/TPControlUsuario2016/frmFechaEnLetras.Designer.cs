namespace TPControlUsuario2016
{
    partial class frmFechaEnLetras
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
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.grbFecha = new System.Windows.Forms.GroupBox();
            this.txtDia = new ControlesDeUsuario.txtSoloNumeros();
            this.txtMes = new ControlesDeUsuario.txtSoloNumeros();
            this.txtAño = new ControlesDeUsuario.txtSoloNumeros();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grbEnLetras = new System.Windows.Forms.GroupBox();
            this.lblFechaLetras = new System.Windows.Forms.Label();
            this.grbFecha.SuspendLayout();
            this.grbEnLetras.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(14, 53);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(28, 13);
            this.lblDia.TabIndex = 8;
            this.lblDia.Text = "Día:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(14, 92);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 9;
            this.lblMes.Text = "Mes:";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(14, 131);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 13);
            this.lblAño.TabIndex = 10;
            this.lblAño.Text = "Año:";
            // 
            // grbFecha
            // 
            this.grbFecha.Controls.Add(this.txtDia);
            this.grbFecha.Controls.Add(this.txtMes);
            this.grbFecha.Controls.Add(this.txtAño);
            this.grbFecha.Location = new System.Drawing.Point(50, 30);
            this.grbFecha.Name = "grbFecha";
            this.grbFecha.Size = new System.Drawing.Size(104, 143);
            this.grbFecha.TabIndex = 11;
            this.grbFecha.TabStop = false;
            this.grbFecha.Text = "En Números";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(16, 20);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(52, 20);
            this.txtDia.TabIndex = 0;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(16, 59);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(52, 20);
            this.txtMes.TabIndex = 1;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(16, 98);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(52, 20);
            this.txtAño.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(188, 63);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(188, 106);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // grbEnLetras
            // 
            this.grbEnLetras.Controls.Add(this.lblFechaLetras);
            this.grbEnLetras.Location = new System.Drawing.Point(17, 190);
            this.grbEnLetras.Name = "grbEnLetras";
            this.grbEnLetras.Size = new System.Drawing.Size(246, 61);
            this.grbEnLetras.TabIndex = 12;
            this.grbEnLetras.TabStop = false;
            this.grbEnLetras.Text = "En Letras";
            // 
            // lblFechaLetras
            // 
            this.lblFechaLetras.AutoSize = true;
            this.lblFechaLetras.Location = new System.Drawing.Point(54, 31);
            this.lblFechaLetras.Name = "lblFechaLetras";
            this.lblFechaLetras.Size = new System.Drawing.Size(35, 13);
            this.lblFechaLetras.TabIndex = 0;
            this.lblFechaLetras.Text = "label1";
            // 
            // frmFechaEnLetras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 263);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.grbFecha);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grbEnLetras);
            this.Name = "frmFechaEnLetras";
            this.Text = "frmFechaEnLetras";
            this.grbFecha.ResumeLayout(false);
            this.grbFecha.PerformLayout();
            this.grbEnLetras.ResumeLayout(false);
            this.grbEnLetras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.GroupBox grbFecha;
        private ControlesDeUsuario.txtSoloNumeros txtDia;
        private ControlesDeUsuario.txtSoloNumeros txtMes;
        private ControlesDeUsuario.txtSoloNumeros txtAño;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox grbEnLetras;
        private System.Windows.Forms.Label lblFechaLetras;
    }
}