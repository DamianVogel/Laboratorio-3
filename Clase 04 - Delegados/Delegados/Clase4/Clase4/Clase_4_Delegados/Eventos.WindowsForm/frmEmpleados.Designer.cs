namespace Eventos.WindowsForm
{
    partial class frmEmpleados
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblManejador = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.cmbManejador = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(73, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(77, 144);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.TabIndex = 1;
            this.lblSueldo.Text = "Sueldo";
            // 
            // lblManejador
            // 
            this.lblManejador.AutoSize = true;
            this.lblManejador.Location = new System.Drawing.Point(60, 239);
            this.lblManejador.Name = "lblManejador";
            this.lblManejador.Size = new System.Drawing.Size(57, 13);
            this.lblManejador.TabIndex = 2;
            this.lblManejador.Text = "Manejador";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(128, 141);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(80, 20);
            this.txtSueldo.TabIndex = 4;
            // 
            // cmbManejador
            // 
            this.cmbManejador.FormattingEnabled = true;
            this.cmbManejador.Location = new System.Drawing.Point(128, 236);
            this.cmbManejador.Name = "cmbManejador";
            this.cmbManejador.Size = new System.Drawing.Size(179, 21);
            this.cmbManejador.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(146, 301);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 367);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblManejador);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.cmbManejador);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmEmpleados";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblManejador;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.ComboBox cmbManejador;
        private System.Windows.Forms.Button btnAceptar;
    }
}

