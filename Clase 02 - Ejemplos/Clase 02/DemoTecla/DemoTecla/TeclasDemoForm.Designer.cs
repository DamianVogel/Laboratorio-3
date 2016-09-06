namespace DemoTecla
{
    partial class TeclasDemoForm
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
            this.caracterLabel = new System.Windows.Forms.Label();
            this.infoTeclaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // caracterLabel
            // 
            this.caracterLabel.AutoSize = true;
            this.caracterLabel.Location = new System.Drawing.Point(13, 57);
            this.caracterLabel.Name = "caracterLabel";
            this.caracterLabel.Size = new System.Drawing.Size(10, 13);
            this.caracterLabel.TabIndex = 0;
            this.caracterLabel.Text = "-";
            // 
            // infoTeclaLabel
            // 
            this.infoTeclaLabel.AutoSize = true;
            this.infoTeclaLabel.Location = new System.Drawing.Point(13, 148);
            this.infoTeclaLabel.Name = "infoTeclaLabel";
            this.infoTeclaLabel.Size = new System.Drawing.Size(10, 13);
            this.infoTeclaLabel.TabIndex = 1;
            this.infoTeclaLabel.Text = "-";
            // 
            // TeclasDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 380);
            this.Controls.Add(this.infoTeclaLabel);
            this.Controls.Add(this.caracterLabel);
            this.Name = "TeclasDemoForm";
            this.Text = "Demo Tecla";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclasDemoForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclasDemoForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TeclasDemoForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label caracterLabel;
        private System.Windows.Forms.Label infoTeclaLabel;
    }
}

