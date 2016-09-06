namespace _01TipoForms.Herencia.Menu
{
    partial class frmInicio
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
            this.grpSeleccion = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboEjemplos = new System.Windows.Forms.ComboBox();
            this.grpSeleccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSeleccion
            // 
            this.grpSeleccion.Controls.Add(this.lblTitulo);
            this.grpSeleccion.Controls.Add(this.cboEjemplos);
            this.grpSeleccion.Location = new System.Drawing.Point(23, 11);
            this.grpSeleccion.Name = "grpSeleccion";
            this.grpSeleccion.Size = new System.Drawing.Size(351, 120);
            this.grpSeleccion.TabIndex = 1;
            this.grpSeleccion.TabStop = false;
            this.grpSeleccion.Text = "Seleccionar Ejemplo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(34, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(47, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Ejemplo:";
            // 
            // cboEjemplos
            // 
            this.cboEjemplos.FormattingEnabled = true;
            this.cboEjemplos.Location = new System.Drawing.Point(87, 46);
            this.cboEjemplos.Name = "cboEjemplos";
            this.cboEjemplos.Size = new System.Drawing.Size(199, 21);
            this.cboEjemplos.TabIndex = 0;
            this.cboEjemplos.SelectedIndexChanged += new System.EventHandler(this.cboEjemplos_SelectedIndexChanged);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 143);
            this.Controls.Add(this.grpSeleccion);
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.grpSeleccion.ResumeLayout(false);
            this.grpSeleccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpSeleccion;
        internal System.Windows.Forms.Label lblTitulo;
        internal System.Windows.Forms.ComboBox cboEjemplos;
    }
}