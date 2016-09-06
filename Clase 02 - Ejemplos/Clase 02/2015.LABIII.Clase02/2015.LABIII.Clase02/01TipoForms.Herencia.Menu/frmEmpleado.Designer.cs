namespace _01TipoForms.Herencia.Menu
{
    partial class frmEmpleado
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
            this.TxtLegajo = new System.Windows.Forms.TextBox();
            this.LblLegajo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtLegajo
            // 
            this.TxtLegajo.Location = new System.Drawing.Point(87, 100);
            this.TxtLegajo.Name = "TxtLegajo";
            this.TxtLegajo.Size = new System.Drawing.Size(100, 20);
            this.TxtLegajo.TabIndex = 12;
            // 
            // LblLegajo
            // 
            this.LblLegajo.AutoSize = true;
            this.LblLegajo.Location = new System.Drawing.Point(19, 100);
            this.LblLegajo.Name = "LblLegajo";
            this.LblLegajo.Size = new System.Drawing.Size(39, 13);
            this.LblLegajo.TabIndex = 13;
            this.LblLegajo.Text = "Legajo";
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 275);
            this.Controls.Add(this.TxtLegajo);
            this.Controls.Add(this.LblLegajo);
            this.Name = "frmEmpleado";
            this.Text = "frmHeredado";
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblApellido, 0);
            this.Controls.SetChildIndex(this.LblLegajo, 0);
            this.Controls.SetChildIndex(this.TxtLegajo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TxtLegajo;
        internal System.Windows.Forms.Label LblLegajo;
    }
}