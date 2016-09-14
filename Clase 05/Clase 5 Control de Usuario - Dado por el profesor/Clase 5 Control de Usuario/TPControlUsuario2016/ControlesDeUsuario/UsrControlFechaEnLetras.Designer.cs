namespace ControlesDeUsuario
{
    partial class UsrControlFechaEnLetras
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtDia = new ControlesDeUsuario.txtSoloNumeros();
            this.txtMes = new ControlesDeUsuario.txtSoloNumeros();
            this.txtAño = new ControlesDeUsuario.txtSoloNumeros();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(3, 3);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(52, 20);
            this.txtDia.TabIndex = 0;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(3, 42);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(52, 20);
            this.txtMes.TabIndex = 1;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(3, 81);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(52, 20);
            this.txtAño.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UsrControlFechaEnLetras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtAño);
            this.Name = "UsrControlFechaEnLetras";
            this.Size = new System.Drawing.Size(96, 106);
            this.Load += new System.EventHandler(this.UsrControlFechaEnLetras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private txtSoloNumeros txtAño;
        private txtSoloNumeros txtMes;
        private txtSoloNumeros txtDia;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}
